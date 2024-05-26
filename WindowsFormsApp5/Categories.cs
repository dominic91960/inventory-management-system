using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    internal class Categories
    {
        private string name;
        private string newName;
        private string description;
        private string[] nameList = new string[10];
        private int index;

        private string query;
        private string con_string;

        MySqlCommand cmd;
        MySqlConnection con;
        MySqlDataAdapter da;
        public DataTable dt;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string NewName
        {
            set { newName = value; }
            get { return newName; }
        }

        public string Description
        {
            set { description = value; }
            get { return description; }
        }

        public string[] NameList
        {
            get { return nameList; }
        }

        public void accessDatabase()
        {   //1.Create connection string
            con_string = "server=localhost; database=bravo_six; user=root; password=;";
            //2.Establishing a connection
            con = new MySqlConnection(con_string);
        }

        public void insert()
        {   //1.Create a query
            query = "insert into categories values('" + name + "','" + description + "');";
            //2.Create a command
            cmd = new MySqlCommand(query,con);
        }

        public void update()
        {   //1.Create a query
            query = "update categories set" +
                " name='" + newName + "'," +
                " description='" + description +"'" +
                " where name='"+name+"';";
            //2.Create a command
            cmd = new MySqlCommand(query, con);
        }

        public void delete()
        {   //1.Create a query
            query = "delete from categories where name='" + name + "';";
            //2.Create a command
            cmd = new MySqlCommand(query, con);
        }

        public void execute()
        {
            //1.Open connection and execute command
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("done");
        }

        public void search()
        {
            //1.Create a query
            query = "select * from categories where name='" + name + "';";
            //2.Create a command
            cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString("name");
                description = reader.GetString("description");
            }
            reader.Close();
            con.Close();
        }

        public void fillComboBox()
        {
            //1.Create a query
            query = "select name from categories;";
            //2.Create a command
            cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            //3.Reset the array
            for (index = 0; index < nameList.Length; index++)
            {
                nameList[index] = null;
            }
            index = 0;
            //4.Load values into the array
            while (reader.Read())
            {
                nameList[index] = reader.GetString("name");
                index++;
            }
            reader.Close();
            con.Close();
        }

        public void fillDataGridView()
        {
            query = "select * from categories";
            con.Open();
            da = new MySqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
        }
    }
}
