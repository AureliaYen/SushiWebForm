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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Headers;

namespace 哪次不吃壽司
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";

        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPID = new List<int>();

        //商品描述到商品詳細資訊再做

        public UCorder Forder;
        public UCorderModify ForderModify;
        public UCproduct Fproduct;
        public UCcustomer Fcustomer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (GlobalVar.isVertified==true)
            {
                SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
                scsb.DataSource = @".";
                scsb.InitialCatalog = "Sushi";
                scsb.IntegratedSecurity = true;
                strDBConnectionString = scsb.ToString();

                Forder = new UCorder();
                ForderModify = new UCorderModify();
                Fproduct = new UCproduct();
                Fcustomer = new UCcustomer();

                Forder.Show();
                panel1.Controls.Clear();
                panel1.Controls.Add(Forder);

                labelLogin.Text = ($"ID:{GlobalVar.memberID}\n姓名:{GlobalVar.str登入姓名} \n類別:{GlobalVar.str類別}");

                if (GlobalVar.str類別!="一般會員")
                {
                    butMenu.Visible = true;
                    butOrder.Visible = true;
                    butProduct.Visible = true;
                    butCustomer.Visible = true;
                    pictureBoxBot.Visible = false;
                }
            }

        }


        public void butMenu_Click(object sender, EventArgs e)
        {
            Forder.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(Forder);
        }

        public void butOrder_Click(object sender, EventArgs e)
        {
            ForderModify.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(ForderModify);
        }

        public void butProduct_Click(object sender, EventArgs e)
        {
            Fproduct.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(Fproduct);
        }

        public void butCustomer_Click(object sender, EventArgs e)
        {
            Fcustomer.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(Fcustomer);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
