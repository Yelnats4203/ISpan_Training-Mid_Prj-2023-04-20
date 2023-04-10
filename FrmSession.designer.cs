namespace prjMovieBackSys
{
    partial class FrmSession
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.dataGridSession = new System.Windows.Forms.DataGridView();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelHasOrder = new System.Windows.Forms.Label();
            this.comboMovie = new System.Windows.Forms.ComboBox();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelMovie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureMovie = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(17, 377);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 27);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "新增場次";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(10, 32);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(73, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "選擇日期";
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(17, 419);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(106, 27);
            this.btnAlter.TabIndex = 3;
            this.btnAlter.Text = "修改場次";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // dataGridSession
            // 
            this.dataGridSession.AllowUserToAddRows = false;
            this.dataGridSession.AllowUserToDeleteRows = false;
            this.dataGridSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSession.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSession.Location = new System.Drawing.Point(0, 0);
            this.dataGridSession.Name = "dataGridSession";
            this.dataGridSession.ReadOnly = true;
            this.dataGridSession.RowHeadersVisible = false;
            this.dataGridSession.RowHeadersWidth = 62;
            this.dataGridSession.RowTemplate.Height = 24;
            this.dataGridSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridSession.Size = new System.Drawing.Size(771, 509);
            this.dataGridSession.TabIndex = 5;
            this.dataGridSession.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSession_CellClick);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(318, 32);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(105, 20);
            this.labelClass.TabIndex = 6;
            this.labelClass.Text = "篩選影廳等級";
            // 
            // comboClass
            // 
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "(All)"});
            this.comboClass.Location = new System.Drawing.Point(431, 29);
            this.comboClass.Margin = new System.Windows.Forms.Padding(5);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(163, 28);
            this.comboClass.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(89, 26);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(201, 29);
            this.dateTimePicker.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.comboClass);
            this.splitContainer1.Panel1.Controls.Add(this.labelDate);
            this.splitContainer1.Panel1.Controls.Add(this.labelClass);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 595);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridSession);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelHasOrder);
            this.splitContainer2.Panel2.Controls.Add(this.comboMovie);
            this.splitContainer2.Panel2.Controls.Add(this.labelEnd);
            this.splitContainer2.Panel2.Controls.Add(this.labelStart);
            this.splitContainer2.Panel2.Controls.Add(this.labelMovie);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.pictureMovie);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer2.Panel2.Controls.Add(this.btnCreate);
            this.splitContainer2.Panel2.Controls.Add(this.btnAlter);
            this.splitContainer2.Size = new System.Drawing.Size(1083, 509);
            this.splitContainer2.SplitterDistance = 771;
            this.splitContainer2.TabIndex = 6;
            // 
            // labelHasOrder
            // 
            this.labelHasOrder.Location = new System.Drawing.Point(129, 431);
            this.labelHasOrder.Name = "labelHasOrder";
            this.labelHasOrder.Size = new System.Drawing.Size(165, 67);
            this.labelHasOrder.TabIndex = 13;
            this.labelHasOrder.Text = "1";
            // 
            // comboMovie
            // 
            this.comboMovie.FormattingEnabled = true;
            this.comboMovie.Location = new System.Drawing.Point(129, 377);
            this.comboMovie.Name = "comboMovie";
            this.comboMovie.Size = new System.Drawing.Size(165, 28);
            this.comboMovie.TabIndex = 12;
            this.comboMovie.SelectedIndexChanged += new System.EventHandler(this.comboMovie_SelectedIndexChanged);
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(101, 316);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(73, 20);
            this.labelEnd.TabIndex = 11;
            this.labelEnd.Text = "電影名稱";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(101, 271);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(73, 20);
            this.labelStart.TabIndex = 10;
            this.labelStart.Text = "電影名稱";
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.Location = new System.Drawing.Point(101, 226);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(73, 20);
            this.labelMovie.TabIndex = 9;
            this.labelMovie.Text = "電影名稱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "下檔時間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "上映時間";
            // 
            // pictureMovie
            // 
            this.pictureMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureMovie.Location = new System.Drawing.Point(17, 17);
            this.pictureMovie.Name = "pictureMovie";
            this.pictureMovie.Size = new System.Drawing.Size(243, 192);
            this.pictureMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMovie.TabIndex = 6;
            this.pictureMovie.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "電影名稱";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(17, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "刪除場次";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 595);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSession";
            this.Text = "Session";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.DataGridView dataGridSession;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMovie;
        private System.Windows.Forms.Label labelHasOrder;
    }
}

