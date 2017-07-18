using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliyunRDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDatabaseList_Click(object sender, EventArgs e)
        {
            RdsHelper rds = new RdsHelper(
                tbRegionID.Text.Trim(),
                tbAccessKeyID.Text.Trim(),
                tbAccessKeySecret.Text.Trim(),
                tbDBInstanceID.Text.Trim());

            try
            {
                var databases = rds.DescribeDatabases();
                textBox1.AppendText("查询成功，数据库信息如下：" + Environment.NewLine);
                foreach (var db in databases)
                {
                    textBox1.AppendText(db.DBName + Environment.NewLine);
                    textBox1.AppendText(db.DBInstanceId + Environment.NewLine);
                    textBox1.AppendText(db.DBStatus + Environment.NewLine);
                    textBox1.AppendText(db.Engine + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            RdsHelper rds = new RdsHelper(
                tbRegionID.Text.Trim(),
                tbAccessKeyID.Text.Trim(),
                tbAccessKeySecret.Text.Trim(),
                tbDBInstanceID.Text.Trim());

            try
            {
                rds.CreateDatabase(tbDatabase.Text.Trim());
                textBox1.AppendText("数据库创建成功" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        private void btnAccountList_Click(object sender, EventArgs e)
        {
            RdsHelper rds = new RdsHelper(
                tbRegionID.Text.Trim(),
                tbAccessKeyID.Text.Trim(),
                tbAccessKeySecret.Text.Trim(),
                tbDBInstanceID.Text.Trim());

            try
            {
                var accounts = rds.DescribeAccounts();
                textBox1.AppendText("请求成功，账号信息如下：" + Environment.NewLine);
                foreach (var ac in accounts)
                {
                    textBox1.AppendText(ac.AccountName + Environment.NewLine);
                    textBox1.AppendText(ac.AccountType + Environment.NewLine);
                    textBox1.AppendText(ac.AccountStatus + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            RdsHelper rds = new RdsHelper(
                tbRegionID.Text.Trim(),
                tbAccessKeyID.Text.Trim(),
                tbAccessKeySecret.Text.Trim(),
                tbDBInstanceID.Text.Trim());

            try
            {
                rds.CreateAccount(tbAccount.Text.Trim(), tbPassword.Text.Trim());
                textBox1.AppendText("账号创建成功" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "程序错误");
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            RdsHelper rds = new RdsHelper(
                tbRegionID.Text.Trim(),
                tbAccessKeyID.Text.Trim(),
                tbAccessKeySecret.Text.Trim(),
                tbDBInstanceID.Text.Trim());

            try
            {
                rds.ResetAccountPassword(tbAccount.Text.Trim(), tbPassword.Text.Trim());
                textBox1.AppendText("账号密码修改成功" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "程序错误");
            }
        }
    }
}
