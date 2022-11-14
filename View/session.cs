using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
     public static class session
    {
        public  static string userid;
        public static string username;
        /*public static string UserId
        {
            get { return this.userid; }
            set { this.userid = value; }
        }
        public string UserName
        {
            get { return this.username; }
            set { this.username = value; }
        }*/

        public static void destroy()
        {
            session.userid = "";
            session.username = "";
        }

    }
}
