using System;
using System.Data;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace MCL
{
    public class DB
    {
        DataTable dataTable;
        public Micro micro;
        public DBInfo dbInfo;
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0vHkKXJUSytcCXiHTBmPTBO49HWCxKcNqkVlXE6t",
            BasePath = "https://fir-csharp-f4422.firebaseio.com/"
        };

        public DB()
        {
            ConnectServer();
        }

        public bool ConnectServer()
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                return true;
            }
            else{
                return false;
            }
        }
        public async void InsertMicro(Micro micro)
        {
            var newMicro = new Micro
            {
                IDMicro = dbInfo.count+1,
                SerialLogin = micro.SerialLogin,
                NameMicro = micro.NameMicro,
                StatusMicro = micro.StatusMicro,
                CommandMicro = micro.CommandMicro,
                ComplementMicro = micro.ComplementMicro
            };

            SetResponse response = await client.SetTaskAsync("Micro/" + newMicro.IDMicro, newMicro);
            Micro result = response.ResultAs<Micro>();

            var obj = new DBInfo
            {
                count = newMicro.IDMicro
            };

            SetResponse response1 = await client.SetTaskAsync("Admin/db_info", obj);
        }
        public async Task<Micro> GetMicroServer(int IDMicro)
        {
            FirebaseResponse response = await client.GetTaskAsync("Micro/" + IDMicro);
            micro = response.ResultAs<Micro>();
            return micro;
        }
        public async Task<DBInfo> GetIDServer()
        {
            FirebaseResponse response = await client.GetTaskAsync("Admin/db_info");
            dbInfo = response.ResultAs<DBInfo>();
            return dbInfo;
        }
        public async void UpdateMicro(Micro micro)
        {
            micro.CommandMicro = 0;
            micro.StatusMicro = 1;
            FirebaseResponse response = await client.UpdateTaskAsync("Micro/" + micro.IDMicro, micro);
        }
        public async void UpdateMicroInfo(Micro micro)
        {
            FirebaseResponse response = await client.UpdateTaskAsync("Micro/" + micro.IDMicro, micro);
        }
        public async void SendCommand(Micro micro)
        {
            FirebaseResponse response = await client.UpdateTaskAsync("Micro/" + micro.IDMicro, micro);
        }
        public DataTable GetAllMicro(DataTable dt)
        {
            this.dataTable = dt;
            LoadAllMicro();
            return dt;
        }
        private async void LoadAllMicro()
        {
            int i = 0;
            FirebaseResponse resp1 = await client.GetTaskAsync("Admin/db_info");
            DBInfo db_info = resp1.ResultAs<DBInfo>();
            int cnt = Convert.ToInt32(db_info.count);

            while (true)
            {
                if (i == cnt)
                {
                    break;
                }
                i++;
                try
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("Micro/" + i);
                    Micro micro = resp2.ResultAs<Micro>();

                    if (micro.StatusMicro == 1)
                    {
                        DataRow row = dataTable.NewRow();
                        row["ID"] = micro.IDMicro;
                        row["Serial"] = micro.SerialLogin;
                        row["Micro"] = micro.NameMicro;
                        row["Status"] = "Online";
                        row["Command"] = micro.CommandMicro;
                        row["Complement"] = micro.ComplementMicro;
                        dataTable.Rows.Add(row);
                        micro.StatusMicro = 0;
                        UpdateMicro(micro);
                    }
                    
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public async Task<DBInfo> GetDBInfo(DBInfo dbInfo)
        {
            FirebaseResponse resp = await client.GetTaskAsync("Admin/db_info");
            var db_info = resp.ResultAs<DBInfo>();
            dbInfo = db_info;
            return dbInfo;
        }

        public async void DeleteAll()
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Micro");
            var obj = new DBInfo
            {
                count = 0
            };

            SetResponse response1 = await client.SetTaskAsync("Admin/db_info", obj);
        }
    }
}
