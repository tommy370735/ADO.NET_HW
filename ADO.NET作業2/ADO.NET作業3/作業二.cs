using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET作業3
{
    public partial class 作業二 : Form
    {
        public 作業二()
        {
            InitializeComponent();
            con_起始方法();
        }

        //enum CategoryName : int
        //{
        //    Beverages = 0,
        //    Condiments = 1,
        //    Confections = 2,
        //    DairyProducts = 3,
        //    GrainsCereals = 4,
        //    MeatPoultry = 5,
        //    Produce = 6,
        //    Seafood = 7,
        //}

        private void con_起始方法()
        {
            SqlConnection conn_起始設定 = null;
            try
            {
                conn_起始設定 = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn_起始設定.Open();
                SqlCommand command_起始指令 = new SqlCommand("select CategoryName from Categories", conn_起始設定);
                SqlDataReader data_起始讀取 = command_起始指令.ExecuteReader();
                while (data_起始讀取.Read())
                {
                    string a = data_起始讀取["CategoryName"].ToString();
                    comboBox1.Items.Add(a);
                }
            }
            catch (Exception ex_異常)
            {
                MessageBox.Show(ex_異常.Message);
            }
            finally
            {
                if (conn_起始設定 != null)
                {
                    conn_起始設定.Close();
                }
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string X = comboBox1.SelectedItem.ToString();
                   
            SqlConnection conn_資料庫 = null;
            try
            {
                conn_資料庫 = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn_資料庫.Open();

                //string sqlstring = "select [ProductID],[ProductName],[UnitPrice] from [Products] p" +
                //    "join[dbo].[Categories] c on p.CategoryID = c.CategoryID where CategoryName ='" + X + "'";

                SqlCommand command_指令 = new SqlCommand("select [ProductID],[ProductName],[UnitPrice]" +
                    " from [Products] p join[dbo].[Categories] c on p.CategoryID = c.CategoryID where CategoryName ='" + X + "'", conn_資料庫);

                SqlDataReader data_讀取 = command_指令.ExecuteReader();

                this.listBox1.Items.Clear();
                while (data_讀取.Read())
                {
                    string s = $"{data_讀取["ProductID"],-3} - {data_讀取["ProductName"],-40} - {data_讀取["UnitPrice"]:c2}";
                    listBox1.Items.Add(s);
                } 
            }
            catch (Exception ex_異常)
            {
                MessageBox.Show(ex_異常.Message);
            }
            finally
            {
                if( conn_資料庫 != null)
                {
                    conn_資料庫.Close();
                }
            }


            

        }
    }
}
