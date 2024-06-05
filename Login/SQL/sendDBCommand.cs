using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;

using Login.Objects;

namespace Login.SQL
{
    internal class sendDBCommand
    {
        private SqlConnectionStringBuilder builder;
        private string sqlCommand;
        
        public sendDBCommand()
        {
            builder = new SqlConnectionStringBuilder();
        }

        private void connectToSQL()
        {
            //SQL Server Name
            builder.DataSource = "FDEU-131\\SQLEXPRESS";
            //SQL User Name
            builder.UserID = "sa";
            //SQL User Password
            builder.Password = "applesauce/2";
            //SQL Datebase
            builder.InitialCatalog = "Test";
        }

        public sqlInfo sendCommand()
        {
            return null;
        }

        private void sendToDB()
        {

        }
    }
}
