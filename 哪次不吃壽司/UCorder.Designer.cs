namespace 哪次不吃壽司
{
    partial class UCorder
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCorder));
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.labelMenu = new System.Windows.Forms.Label();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.butSubmit = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butCheckout = new System.Windows.Forms.Button();
            this.listViewOrderList = new System.Windows.Forms.ListView();
            this.but重新載入 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxbot = new System.Windows.Forms.PictureBox();
            this.label軍艦 = new System.Windows.Forms.Label();
            this.label握壽司 = new System.Windows.Forms.Label();
            this.label全部 = new System.Windows.Forms.Label();
            this.label甜點飲料 = new System.Windows.Forms.Label();
            this.label新商品 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbot)).BeginInit();
            this.SuspendLayout();
            // 
            // listView商品展示
            // 
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(20, 118);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(532, 484);
            this.listView商品展示.TabIndex = 9;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labelMenu.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMenu.Location = new System.Drawing.Point(358, 29);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(84, 42);
            this.labelMenu.TabIndex = 10;
            this.labelMenu.Text = "菜單";
            // 
            // imageListMenu
            // 
            this.imageListMenu.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListMenu.ImageSize = new System.Drawing.Size(256, 256);
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(718, 463);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(119, 60);
            this.butSubmit.TabIndex = 12;
            this.butSubmit.Text = "送出訂單";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(579, 463);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(119, 60);
            this.butClear.TabIndex = 13;
            this.butClear.Text = "清除訂單";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butCheckout
            // 
            this.butCheckout.Location = new System.Drawing.Point(718, 542);
            this.butCheckout.Name = "butCheckout";
            this.butCheckout.Size = new System.Drawing.Size(119, 60);
            this.butCheckout.TabIndex = 14;
            this.butCheckout.Text = "結帳";
            this.butCheckout.UseVisualStyleBackColor = true;
            this.butCheckout.Click += new System.EventHandler(this.butCheckout_Click);
            // 
            // listViewOrderList
            // 
            this.listViewOrderList.HideSelection = false;
            this.listViewOrderList.Location = new System.Drawing.Point(575, 95);
            this.listViewOrderList.Name = "listViewOrderList";
            this.listViewOrderList.Size = new System.Drawing.Size(262, 347);
            this.listViewOrderList.TabIndex = 18;
            this.listViewOrderList.UseCompatibleStateImageBehavior = false;
            // 
            // but重新載入
            // 
            this.but重新載入.Location = new System.Drawing.Point(579, 542);
            this.but重新載入.Name = "but重新載入";
            this.but重新載入.Size = new System.Drawing.Size(119, 60);
            this.but重新載入.TabIndex = 19;
            this.but重新載入.Text = "重新載入";
            this.but重新載入.UseVisualStyleBackColor = true;
            this.but重新載入.Visible = false;
            this.but重新載入.Click += new System.EventHandler(this.but重新載入_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(699, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxbot
            // 
            this.pictureBoxbot.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxbot.Image")));
            this.pictureBoxbot.Location = new System.Drawing.Point(561, 529);
            this.pictureBoxbot.Name = "pictureBoxbot";
            this.pictureBoxbot.Size = new System.Drawing.Size(151, 102);
            this.pictureBoxbot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxbot.TabIndex = 50;
            this.pictureBoxbot.TabStop = false;
            // 
            // label軍艦
            // 
            this.label軍艦.AutoSize = true;
            this.label軍艦.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label軍艦.Location = new System.Drawing.Point(219, 90);
            this.label軍艦.Name = "label軍艦";
            this.label軍艦.Size = new System.Drawing.Size(92, 25);
            this.label軍艦.TabIndex = 51;
            this.label軍艦.Text = "軍艦壽司";
            this.label軍艦.Click += new System.EventHandler(this.label軍艦_Click);
            // 
            // label握壽司
            // 
            this.label握壽司.AutoSize = true;
            this.label握壽司.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label握壽司.Location = new System.Drawing.Point(109, 90);
            this.label握壽司.Name = "label握壽司";
            this.label握壽司.Size = new System.Drawing.Size(72, 25);
            this.label握壽司.TabIndex = 52;
            this.label握壽司.Text = "握壽司";
            this.label握壽司.Click += new System.EventHandler(this.label握壽司_Click);
            // 
            // label全部
            // 
            this.label全部.AutoSize = true;
            this.label全部.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label全部.Location = new System.Drawing.Point(19, 90);
            this.label全部.Name = "label全部";
            this.label全部.Size = new System.Drawing.Size(52, 25);
            this.label全部.TabIndex = 53;
            this.label全部.Text = "全部";
            this.label全部.Click += new System.EventHandler(this.label全部_Click);
            // 
            // label甜點飲料
            // 
            this.label甜點飲料.AutoSize = true;
            this.label甜點飲料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label甜點飲料.Location = new System.Drawing.Point(349, 90);
            this.label甜點飲料.Name = "label甜點飲料";
            this.label甜點飲料.Size = new System.Drawing.Size(92, 25);
            this.label甜點飲料.TabIndex = 54;
            this.label甜點飲料.Text = "甜點飲料";
            this.label甜點飲料.Click += new System.EventHandler(this.label甜點飲料_Click);
            // 
            // label新商品
            // 
            this.label新商品.AutoSize = true;
            this.label新商品.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label新商品.Location = new System.Drawing.Point(479, 90);
            this.label新商品.Name = "label新商品";
            this.label新商品.Size = new System.Drawing.Size(72, 25);
            this.label新商品.TabIndex = 55;
            this.label新商品.Text = "新商品";
            this.label新商品.Click += new System.EventHandler(this.label新商品_Click);
            // 
            // UCorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.label新商品);
            this.Controls.Add(this.label甜點飲料);
            this.Controls.Add(this.label全部);
            this.Controls.Add(this.label握壽司);
            this.Controls.Add(this.label軍艦);
            this.Controls.Add(this.pictureBoxbot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but重新載入);
            this.Controls.Add(this.listViewOrderList);
            this.Controls.Add(this.butCheckout);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.listView商品展示);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCorder";
            this.Size = new System.Drawing.Size(850, 634);
            this.Load += new System.EventHandler(this.UCorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.ImageList imageListMenu;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butCheckout;
        private System.Windows.Forms.ListView listViewOrderList;
        private System.Windows.Forms.Button but重新載入;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxbot;
        private System.Windows.Forms.Label label軍艦;
        private System.Windows.Forms.Label label握壽司;
        private System.Windows.Forms.Label label全部;
        private System.Windows.Forms.Label label甜點飲料;
        private System.Windows.Forms.Label label新商品;
    }
}
