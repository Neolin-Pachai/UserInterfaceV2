using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceV2
{
    class User
    {
        private string userName;
        private string password;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}", userName, password);
        }
    }
}
