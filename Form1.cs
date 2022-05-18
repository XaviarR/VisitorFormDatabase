using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {  
        //connection string to connect to database
        string connString = @"Data Source=LAPTOP-IQ43ERVJ\SQLEXPRESS;Initial Catalog=VisitorInfo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(connString);

            string sql_Query = "Select Visitor.VisitorID, Visitor.FirstName, Visitor.LastName, Visitor.Mobile, Visitor.Email, Visitor.MeetingWith From Visitor, Staff where Visitor.MeetingWith = Staff.StaffID";

            SqlCommand cmd = new SqlCommand(sql_Query, Conn);
            cmd.Parameters.Clear();
            Conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //populate data in Listbox from Reader
                listBox.Items.Add(reader["VisitorID"] + " " + reader["FirstName"] + " " + reader["LastName"] + " " + reader["Mobile"] + " " + reader["Email"] + " " + reader["MeetingWith"]);
            }



            //Close Database reader
            reader.Close();
            Conn.Close();
        }
    }
}
