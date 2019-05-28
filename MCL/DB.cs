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
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0vHkKXJUSytcCXiHTBmPTBO49HWCxKcNqkVlXE6t",
            BasePath = "https://fir-csharp-f4422.firebaseio.com/"
        };

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
        public void GetAdminBase(string pass)
        {
            AdminBase adminBase = new AdminBase
            {
                SuperPass = pass
            };
        }
        public async void InsertMicro(string IDMicro, string nomeMicro, int statusMicro, int commandMicro, string complementMicro)
        {
            ConnectServer();
            FirebaseResponse resp = await client.GetTaskAsync("Admin/db_info");
            var db_info = resp.ResultAs<DBInfo>();

            var micro = new Micro
            {
                IDMicro = (int.Parse(db_info.count.ToString())+1).ToString(),
                NameMicro = nomeMicro,
                StatusMicro = statusMicro,
                CommandMicro = commandMicro,
                ComplementMicro = complementMicro
            };

            SetResponse response = await client.SetTaskAsync("Micro/" + micro.IDMicro, micro);
            Micro result = response.ResultAs<Micro>();

            var obj = new DBInfo
            {
                count = micro.IDMicro
            };

            SetResponse response1 = await client.SetTaskAsync("Admin/db_info", obj);

            //var data = new Micro
            //{
            //    IDMicro = IDMicro,
            //    NameMicro = nomeMicro,
            //    StatusMicro = statusMicro,
            //    CommandMicro = commandMicro,
            //    ComplementMicro = complementMicro
            //};
            //SetResponse response = await client.SetTaskAsync("Micro/" + IDMicro, data);
            //Micro result = response.ResultAs<Micro>();
        }
        public async Task<Micro> GetMicroServer(string microName)
        {
            FirebaseResponse response = await client.GetTaskAsync("Micro/" + microName);
            micro = response.ResultAs<Micro>();
            return micro;
        }
        public async void UpdateMicro(string ID, Micro micro)
        {
            micro.CommandMicro = 0;
            FirebaseResponse response = await client.UpdateTaskAsync("Micro/" + ID, micro);
        }
        public async void SendCommand(string ID, Micro micro)
        {
            FirebaseResponse response = await client.UpdateTaskAsync("Micro/" + ID, micro);
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

                    DataRow row = dataTable.NewRow();
                    row["ID"] = micro.IDMicro;
                    row["Micro"] = micro.NameMicro;
                    row["Status"] = micro.StatusMicro;

                    dataTable.Rows.Add(row);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
