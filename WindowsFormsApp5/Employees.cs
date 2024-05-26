using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    internal class Employees
    {
        private int id;
        private string name;
        private string address;
        private int age;
        private string position;
        private double salary;

        private string query;
        private string con_string;

        MySqlCommand cmd;
        MySqlConnection con;
        MySqlDataAdapter da;
        public DataTable dt;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Address
        {
            set { address = value; }
            get { return address; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public string Position
        {
            set { position = value; }
            get { return position; }
        }

        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        public void accessDatabase()
        {   //1.Create connection string
            con_string = "server=localhost; database=bravo_six; user=root; password=;";
            //2.Establishing a connection
            con = new MySqlConnection(con_string);
        }

        public void insert()
        {   //1.Create a query
            query = "INSERT INTO " +
                "employees(name, address, age, position, salary) " +
                "VALUES " +
                "('"+name+"','"+address+"','"+age+"','"+position+"','"+salary+"');";
            //2.Create a command
            cmd = new MySqlCommand(query, con);
        }

        public void update()
        {   //1.Create a query
            query = "update employees set name='"+name+"'," +
                " address='"+address+"'," +
                " age='"+age+"'," +
                " position='"+position+"'," +
                " salary='"+salary+"'" +
                " where id='"+id+"';";
            //2.Create a command
            cmd = new MySqlCommand(query, con);
        }

        public void delete()
        {   //1.Create a query
            query = "delete from employees where id='" + id + "';";
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
            query = "select * from employees where id='" + id + "';";
            //2.Create a command
            cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString("name");
                address = reader.GetString("address");
                age = reader.GetInt32("age");
                position = reader.GetString("position");
                salary = reader.GetDouble("salary");
            }
            reader.Close();
            con.Close();
        }

        public void fillDataGridView()
        {
            query = "select * from employees";
            con.Open();
            da = new MySqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
        }
    }
}
