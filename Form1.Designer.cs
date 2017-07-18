namespace AliyunRDS
{
    partial class Form1
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
            this.btnDatabaseList = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnAccountList = new System.Windows.Forms.Button();
            this.tbRegionID = new System.Windows.Forms.TextBox();
            this.tbAccessKeyID = new System.Windows.Forms.TextBox();
            this.tbAccessKeySecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDBInstanceID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDatabaseList
            // 
            this.btnDatabaseList.Location = new System.Drawing.Point(41, 526);
            this.btnDatabaseList.Name = "btnDatabaseList";
            this.btnDatabaseList.Size = new System.Drawing.Size(75, 23);
            this.btnDatabaseList.TabIndex = 0;
            this.btnDatabaseList.Text = "数据库列表";
            this.btnDatabaseList.UseVisualStyleBackColor = true;
            this.btnDatabaseList.Click += new System.EventHandler(this.btnDatabaseList_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(671, 358);
            this.textBox1.TabIndex = 1;
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Location = new System.Drawing.Point(126, 526);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDatabase.TabIndex = 2;
            this.btnCreateDatabase.Text = "创建数据库";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // tbDatabase
            // 
            this.tbDatabase.Location = new System.Drawing.Point(66, 497);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(151, 20);
            this.tbDatabase.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(386, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "pass";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(386, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(423, 526);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(122, 20);
            this.tbPassword.TabIndex = 10;
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(423, 497);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(122, 20);
            this.tbAccount.TabIndex = 9;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(550, 524);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "创建账号";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnAccountList
            // 
            this.btnAccountList.Location = new System.Drawing.Point(550, 495);
            this.btnAccountList.Name = "btnAccountList";
            this.btnAccountList.Size = new System.Drawing.Size(75, 23);
            this.btnAccountList.TabIndex = 7;
            this.btnAccountList.Text = "账号列表";
            this.btnAccountList.UseVisualStyleBackColor = true;
            this.btnAccountList.Click += new System.EventHandler(this.btnAccountList_Click);
            // 
            // tbRegionID
            // 
            this.tbRegionID.Location = new System.Drawing.Point(149, 364);
            this.tbRegionID.Name = "tbRegionID";
            this.tbRegionID.Size = new System.Drawing.Size(122, 20);
            this.tbRegionID.TabIndex = 13;
            // 
            // tbAccessKeyID
            // 
            this.tbAccessKeyID.Location = new System.Drawing.Point(149, 390);
            this.tbAccessKeyID.Name = "tbAccessKeyID";
            this.tbAccessKeyID.Size = new System.Drawing.Size(147, 20);
            this.tbAccessKeyID.TabIndex = 14;
            // 
            // tbAccessKeySecret
            // 
            this.tbAccessKeySecret.Location = new System.Drawing.Point(149, 416);
            this.tbAccessKeySecret.Name = "tbAccessKeySecret";
            this.tbAccessKeySecret.Size = new System.Drawing.Size(339, 20);
            this.tbAccessKeySecret.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(76, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "Region ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(64, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "AccessKeyID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(40, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "AccessKeySecret:";
            // 
            // tbDBInstanceID
            // 
            this.tbDBInstanceID.Location = new System.Drawing.Point(149, 442);
            this.tbDBInstanceID.Name = "tbDBInstanceID";
            this.tbDBInstanceID.Size = new System.Drawing.Size(177, 20);
            this.tbDBInstanceID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(58, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "DBInstanceID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 580);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDBInstanceID);
            this.Controls.Add(this.tbAccessKeySecret);
            this.Controls.Add(this.tbAccessKeyID);
            this.Controls.Add(this.tbRegionID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnAccountList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.btnCreateDatabase);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDatabaseList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDatabaseList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnAccountList;
        private System.Windows.Forms.TextBox tbRegionID;
        private System.Windows.Forms.TextBox tbAccessKeyID;
        private System.Windows.Forms.TextBox tbAccessKeySecret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDBInstanceID;
        private System.Windows.Forms.Label label8;
    }
}

