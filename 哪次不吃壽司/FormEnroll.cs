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

namespace 哪次不吃壽司
{

    public partial class FormEnroll : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";
        public FormEnroll()
        {
            InitializeComponent();
        }

        private void FormEnroll_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";  //伺服器名稱, @字串忽略特殊符號
            scsb.InitialCatalog = "Sushi";   //資料庫名稱
            scsb.IntegratedSecurity = true;  //windows驗證
            strDBConnectString = scsb.ToString();

           
        }

        private void butEnroll_Click(object sender, EventArgs e)
        {
            if ((textName.Text != "") && (textPhone.Text != "") && (textEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "insert into Member values (@NewName,@NewPhone,@NewEmail,@NewBirthday,100,'一般會員')";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@NewName", textName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", textPhone.Text);
                cmd.Parameters.AddWithValue("@NewEmail", textEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtpBirthday.Value);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("註冊成功");
                this.Close();

            }
            else
            {
                MessageBox.Show("請將資料輸入完整");
            }
        }
    }
}
