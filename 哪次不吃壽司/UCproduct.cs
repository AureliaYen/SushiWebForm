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



namespace 哪次不吃壽司
{
    public partial class UCproduct : UserControl
    {
        string strMyDBconnectionString = "";
        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPID = new List<int>();
        //商品描述到商品詳細資訊再做

        public UCproduct()
        {
            InitializeComponent();
        }

        private void UCproduct_Load(object sender, EventArgs e)
        {

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Sushi";
            scsb.IntegratedSecurity = true;
            strMyDBconnectionString = scsb.ToString();
            讀取資料庫();
            listview圖片模式();

            //labelLogImfor.Text = $"ID:{GlobalVar.memberID} {GlobalVar.str登入姓名} 權限:{GlobalVar.int權限}";
        }
        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(strMyDBconnectionString);
            con.Open();
            string strSQL = "select *from Products";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"全部壽司\"; //圖檔目錄，相對路徑
            //string image_dir = @"c:\mydata\images\"; //絕對路徑，但更改電腦會比較麻煩
            string image_name = ""; //圖檔名稱
            int i = 0;
            while (reader.Read())
            {
                listPID.Add((int)reader["pid"]); //在listPID加入sql的pid定轉換成int(物件轉換不需要用tryparse)
                listPname.Add(reader["pname"].ToString());
                listPrice.Add((int)reader["price"]);

                image_name = reader["pimage"].ToString(); //取得檔名
                Image myProductImage = Image.FromFile(image_dir + image_name);  //取的圖片需路徑家檔名
                imageList產品圖檔.Images.Add(myProductImage);
                i++;
            }
            Console.WriteLine($"讀取{i}筆資料");
            reader.Close();
            con.Close();
        }

        private void but圖片模式_Click(object sender, EventArgs e)
        {
            listview圖片模式();
        }
        void listview圖片模式()
        {
            listView商品展示.Clear(); //先清除前面的資料
            listView商品展示.View = View.LargeIcon;  //大圖檔模式
            imageList產品圖檔.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageList產品圖檔;

            for (int i = 0; i < imageList產品圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listPname[i] + "" + listPrice[i] + "元"; //物品展現內容，對應順序i
                item.Tag = listPID[i];
                listView商品展示.Items.Add(item);
            }
        }

        private void but列表模式_Click(object sender, EventArgs e)
        {
            listview列表模式();
        }
        void listview列表模式()
        {
            listView商品展示.Clear(); //先清除前面的資料
            listView商品展示.LargeImageList = null;
            listView商品展示.View = View.Details;  //列表模式
            listView商品展示.Columns.Add("PID", 100);  //(欄位名稱,欄位寬度)
            listView商品展示.Columns.Add("商品名稱", 200);
            listView商品展示.Columns.Add("商品價格", 80);
            listView商品展示.FullRowSelect = true;  //全列選擇
            listView商品展示.GridLines = true;  //格線

            for (int i = 0; i < listPID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                listView商品展示.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listPID[i].ToString();
                item.SubItems.Add(listPname[i]);  //第2個欄位
                item.SubItems.Add(listPrice[i].ToString()); //第3個欄位
                item.Tag = listPID[i];

                listView商品展示.Items.Add(item);

            }
        }

        private void but新增商品_Click(object sender, EventArgs e)
        {
            FormDetail myFormFetail = new FormDetail();  //連接另一個表單
            myFormFetail.ShowDialog();  //ShowDialog獨佔開起
        }

        private void but重新載入_Click(object sender, EventArgs e)
        {
            listPID.Clear();
            listPname.Clear();
            listPrice.Clear();
            imageList產品圖檔.Images.Clear();
            讀取資料庫();

            if (listView商品展示.View == View.Details) //View.Details 列表模式
            {
                listview列表模式();
            }
            else  //View.LargeIcon 圖片模式
            {
                listview圖片模式();
            }
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        //ItemActivate 發生於啟動項目時
        {
            FormDetail myFormDetail = new FormDetail();
            myFormDetail.PID = (int)listView商品展示.SelectedItems[0].Tag;
            //將FormDetail內的公開變數PID借用，並利用隱藏的tag
            myFormDetail.ShowDialog(); //叫出FormDetail
        }
    }

}

