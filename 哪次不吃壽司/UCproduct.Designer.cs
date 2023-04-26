namespace 哪次不吃壽司
{
    partial class UCproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCproduct));
            this.but重新載入 = new System.Windows.Forms.Button();
            this.but新增商品 = new System.Windows.Forms.Button();
            this.but列表模式 = new System.Windows.Forms.Button();
            this.but圖片模式 = new System.Windows.Forms.Button();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // but重新載入
            // 
            this.but重新載入.BackColor = System.Drawing.Color.White;
            this.but重新載入.Location = new System.Drawing.Point(665, 511);
            this.but重新載入.Name = "but重新載入";
            this.but重新載入.Size = new System.Drawing.Size(135, 49);
            this.but重新載入.TabIndex = 12;
            this.but重新載入.Text = "重新載入";
            this.but重新載入.UseVisualStyleBackColor = false;
            this.but重新載入.Click += new System.EventHandler(this.but重新載入_Click);
            // 
            // but新增商品
            // 
            this.but新增商品.BackColor = System.Drawing.Color.White;
            this.but新增商品.Location = new System.Drawing.Point(665, 437);
            this.but新增商品.Name = "but新增商品";
            this.but新增商品.Size = new System.Drawing.Size(135, 49);
            this.but新增商品.TabIndex = 11;
            this.but新增商品.Text = "新增商品";
            this.but新增商品.UseVisualStyleBackColor = false;
            this.but新增商品.Click += new System.EventHandler(this.but新增商品_Click);
            // 
            // but列表模式
            // 
            this.but列表模式.BackColor = System.Drawing.Color.White;
            this.but列表模式.Location = new System.Drawing.Point(665, 363);
            this.but列表模式.Name = "but列表模式";
            this.but列表模式.Size = new System.Drawing.Size(135, 49);
            this.but列表模式.TabIndex = 10;
            this.but列表模式.Text = "列表模式";
            this.but列表模式.UseVisualStyleBackColor = false;
            this.but列表模式.Click += new System.EventHandler(this.but列表模式_Click);
            // 
            // but圖片模式
            // 
            this.but圖片模式.BackColor = System.Drawing.Color.White;
            this.but圖片模式.Location = new System.Drawing.Point(665, 289);
            this.but圖片模式.Name = "but圖片模式";
            this.but圖片模式.Size = new System.Drawing.Size(135, 49);
            this.but圖片模式.TabIndex = 9;
            this.but圖片模式.Text = "圖片模式";
            this.but圖片模式.UseVisualStyleBackColor = false;
            this.but圖片模式.Click += new System.EventHandler(this.but圖片模式_Click);
            // 
            // listView商品展示
            // 
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(41, 124);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(560, 436);
            this.listView商品展示.TabIndex = 8;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(255, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "商品維護";
            // 
            // imageList產品圖檔
            // 
            this.imageList產品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList產品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(675, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(653, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // UCproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but重新載入);
            this.Controls.Add(this.but新增商品);
            this.Controls.Add(this.but列表模式);
            this.Controls.Add(this.but圖片模式);
            this.Controls.Add(this.listView商品展示);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCproduct";
            this.Size = new System.Drawing.Size(850, 634);
            this.Load += new System.EventHandler(this.UCproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but重新載入;
        private System.Windows.Forms.Button but新增商品;
        private System.Windows.Forms.Button but列表模式;
        private System.Windows.Forms.Button but圖片模式;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList產品圖檔;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
