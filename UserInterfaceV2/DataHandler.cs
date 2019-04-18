using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UserInterfaceV2
{
    class DataHandler
    {
        public string connection = "Data Source=NEOLIN-MAC;Initial Catalog=dbUni;Integrated Security=True";

        public List<User> UserRead() //reading user table in db
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            SqlCommand cmd = null;
            List<User> temp = new List<User>();
            try
            {
                conn = new SqlConnection(connection);
                conn.Open();
                string select = "SELECT * FROM tblUser";
                cmd = new SqlCommand(select, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    temp.Add(new User(reader[1].ToString(), reader[2].ToString()));
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("List<User>UserRead()" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return temp;
        }
        
    }
}
