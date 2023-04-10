namespace prjMovieBackSys
{
    partial class FrmMovieBackSys
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCoupon = new System.Windows.Forms.Button();
            this.btnSaleProducts = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCMT = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnStatics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnStatics);
            this.splitContainer1.Panel1.Controls.Add(this.btnLogOut);
            this.splitContainer1.Panel1.Controls.Add(this.btnCoupon);
            this.splitContainer1.Panel1.Controls.Add(this.btnSaleProducts);
            this.splitContainer1.Panel1.Controls.Add(this.btnSales);
            this.splitContainer1.Panel1.Controls.Add(this.btnCMT);
            this.splitContainer1.Panel1.Controls.Add(this.btnMember);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnMovie);
            this.splitContainer1.Panel1.Controls.Add(this.btnSession);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Size = new System.Drawing.Size(1490, 768);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.Location = new System.Drawing.Point(34, 700);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(190, 38);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "登出";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCoupon
            // 
            this.btnCoupon.Location = new System.Drawing.Point(34, 432);
            this.btnCoupon.Name = "btnCoupon";
            this.btnCoupon.Size = new System.Drawing.Size(190, 38);
            this.btnCoupon.TabIndex = 7;
            this.btnCoupon.Text = "優惠券系統管理";
            this.btnCoupon.UseVisualStyleBackColor = true;
            this.btnCoupon.Click += new System.EventHandler(this.btnCoup_Click);
            // 
            // btnSaleProducts
            // 
            this.btnSaleProducts.Location = new System.Drawing.Point(34, 377);
            this.btnSaleProducts.Name = "btnSaleProducts";
            this.btnSaleProducts.Size = new System.Drawing.Size(190, 38);
            this.btnSaleProducts.TabIndex = 6;
            this.btnSaleProducts.Text = "小賣部商品管理";
            this.btnSaleProducts.UseVisualStyleBackColor = true;
            this.btnSaleProducts.Click += new System.EventHandler(this.btnSaleProducts_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(34, 322);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(190, 38);
            this.btnSales.TabIndex = 5;
            this.btnSales.Text = "小賣部訂單管理";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnCMT
            // 
            this.btnCMT.Location = new System.Drawing.Point(34, 267);
            this.btnCMT.Name = "btnCMT";
            this.btnCMT.Size = new System.Drawing.Size(190, 38);
            this.btnCMT.TabIndex = 4;
            this.btnCMT.Text = "會員評論客訴管理";
            this.btnCMT.UseVisualStyleBackColor = true;
            this.btnCMT.Click += new System.EventHandler(this.btnCMT_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(34, 212);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(190, 38);
            this.btnMember.TabIndex = 3;
            this.btnMember.Text = "會員資料管理";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(34, 157);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(190, 38);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "電影訂單資料管理";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnMovie
            // 
            this.btnMovie.Location = new System.Drawing.Point(34, 47);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(190, 38);
            this.btnMovie.TabIndex = 1;
            this.btnMovie.Text = "電影資料管理";
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // btnSession
            // 
            this.btnSession.Location = new System.Drawing.Point(34, 102);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(190, 38);
            this.btnSession.TabIndex = 0;
            this.btnSession.Text = "場次資料管理";
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // btnStatics
            // 
            this.btnStatics.Location = new System.Drawing.Point(34, 566);
            this.btnStatics.Name = "btnStatics";
            this.btnStatics.Size = new System.Drawing.Size(190, 38);
            this.btnStatics.TabIndex = 9;
            this.btnStatics.Text = "統計報表";
            this.btnStatics.UseVisualStyleBackColor = true;
            this.btnStatics.Click += new System.EventHandler(this.btnStatics_Click);
            // 
            // FrmMovieBackSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 768);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMovieBackSys";
            this.Text = "MovieBackSys";
            this.Load += new System.EventHandler(this.FrmMovieBackSys_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnCMT;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnSaleProducts;
        private System.Windows.Forms.Button btnCoupon;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnStatics;
    }
}

