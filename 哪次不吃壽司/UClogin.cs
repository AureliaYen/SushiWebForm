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
using System.Drawing.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Principal;

namespace 哪次不吃壽司
{
    public partial class UClogin : UserControl
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        public static bool isVertified = false;


        public UClogin()
        {
            InitializeComponent();
        }

        private void UClogin_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Mydb";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

        }
        private void butLogin_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != "") && (textBoxPassword.Text != ""))
            {
             
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from Member where Email= @strAccount and 電話 = @strPassword";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@strAccount", textBoxName.Text);
                cmd.Parameters.AddWithValue("@strPassword", textBoxPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();


                if(reader.Read()==true)
                {
                    textBoxName.Text = reader["Email"].ToString();
                    textBoxPassword.Text = reader["電話"].ToString();
                    isVertified= true;
                    MessageBox.Show("登入成功");
                }

                else
                {
                    MessageBox.Show("帳號輸入錯誤");
                }

                reader.Close();
                con.Close();
                
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼");
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
