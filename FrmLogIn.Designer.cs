namespace prjMovieBackSys
{
    partial class FrmLogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelPsw = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDemo1 = new System.Windows.Forms.Button();
            this.btnDemo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(27, 57);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(41, 20);
            this.labelAccount.TabIndex = 0;
            this.labelAccount.Text = "帳號";
            // 
            // labelPsw
            // 
            this.labelPsw.AutoSize = true;
            this.labelPsw.Location = new System.Drawing.Point(27, 126);
            this.labelPsw.Name = "labelPsw";
            this.labelPsw.Size = new System.Drawing.Size(41, 20);
            this.labelPsw.TabIndex = 1;
            this.labelPsw.Text = "密碼";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(91, 54);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(162, 29);
            this.txtAcc.TabIndex = 2;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(91, 123);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(162, 29);
            this.txtPsw.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(40, 180);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDemo1
            // 
            this.btnDemo1.Location = new System.Drawing.Point(40, 231);
            this.btnDemo1.Name = "btnDemo1";
            this.btnDemo1.Size = new System.Drawing.Size(87, 34);
            this.btnDemo1.TabIndex = 6;
            this.btnDemo1.Text = "Demo1";
            this.btnDemo1.UseVisualStyleBackColor = true;
            this.btnDemo1.Click += new System.EventHandler(this.btnDemo1_Click);
            // 
            // btnDemo2
            // 
            this.btnDemo2.Location = new System.Drawing.Point(166, 231);
            this.btnDemo2.Name = "btnDemo2";
            this.btnDemo2.Size = new System.Drawing.Size(87, 34);
            this.btnDemo2.TabIndex = 7;
            this.btnDemo2.Text = "Demo2";
            this.btnDemo2.UseVisualStyleBackColor = true;
            this.btnDemo2.Click += new System.EventHandler(this.btnDemo2_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 298);
            this.Controls.Add(this.btnDemo2);
            this.Controls.Add(this.btnDemo1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.labelPsw);
            this.Controls.Add(this.labelAccount);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelPsw;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDemo1;
        private System.Windows.Forms.Button btnDemo2;
    }
}