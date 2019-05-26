using System;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace MCL
{
    public class DB
    {
        public Micro micro;
        public string t;
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
            var data = new Micro
            {
                IDMicro = IDMicro,
                NameMicro = nomeMicro,
                StatusMicro = statusMicro,
                CommandMicro = commandMicro,
                ComplementMicro = complementMicro
            };
            SetResponse response = await client.SetTaskAsync("Micro/" + IDMicro, data);
            Micro result = response.ResultAs<Micro>();
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
    }
}
