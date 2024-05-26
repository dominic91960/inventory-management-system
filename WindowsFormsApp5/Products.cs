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
    internal class Products
    {
        private int id;
        private string name;
        private string category;
        private double price;
        private string quantity;
        private string description;

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

        public string Category
        {
            set { category = value; }
            get { return category; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        public string Quantity
        {
            set { quantity = value; }
            get { return quantity; }
        }

        public string Description
        {
            set { description = value; }
            get { return description; }
        }

        public void accessDatabase()
        {   //1.Create connection string
            con_string = "server=localhost; database=bravo_six; user=root; password=;";
            //2.Establishing a connection
            con = new MySqlConnection(con_string);
        }

        public void insert()
        {   //1.Create a query
            query = "insert into items(name, category, price, quantity, description) " +
                "VALUES ('"+ name+"','"+category+"','"+price+"','"+quantity+"','"+description+"')";
            //2.Create a command
            cmd = new MySqlCommand(query, con);
        }

        public void update()
        {   //1.Create a query
            query = "update items set" +
                " name='" + name + "'," +
                " category='" + category + "',"+
                " price='" + price + "',"+
                " quantity='" + quantity + "',"+
                " description='" + description + "'"+
                " where id='" + id + "';";
            //2.Create a command
            cmd = new MySqlCommand(query, con);
        }

        public void delete()
        {   //1.Create a query
            query = "delete from items where id='" + id + "';";
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
            query = "select * from items where id='" + id + "';";
            //2.Create a command
            cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32("id");
                name = reader.GetString("name");
                category = reader.GetString("category");
                price = reader.GetDouble("price");
                quantity = reader.GetString("quantity");
                description = reader.GetString("description");
            }
            reader.Close();
            con.Close();
        }

        public void fillDataGridView()
        {
            query = "select * from items";
            con.Open();
            da = new MySqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
        }
    }
}
