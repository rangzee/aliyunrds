using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Rds.Model.V20140815;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace AliyunRDS
{
    public class RdsHelper
    {
        private string regionId;
        private string accessKeyId;
        private string accessKeySecret;
        private string dbInstanceId;
        private IAcsClient client;

        public RdsHelper(string regionId, string accessKeyId, string accessKeySecret, string dbInstanceId)
        {
            this.regionId = regionId;
            this.accessKeyId = accessKeyId;
            this.accessKeySecret = accessKeySecret;
            this.dbInstanceId = dbInstanceId;

            IClientProfile profile = DefaultProfile.GetProfile(regionId, accessKeyId, accessKeySecret);
            client = new DefaultAcsClient(profile);
        }

        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="charset"></param>
        public void CreateDatabase(string dbName, string charset = "utf8mb4")
        {
            CreateDatabaseRequest request = new CreateDatabaseRequest();
            request.DBInstanceId = dbInstanceId;
            request.DBName = dbName;
            request.CharacterSetName = charset;

            client.GetAcsResponse(request);
        }

        /// <summary>
        /// 列出数据库
        /// </summary>
        /// <param name="name"></param>
        /// <param name="status">数据库状态，取值范围：Creating（创建中），Running（使用中），Deleting（删除中）</param>
        /// <returns></returns>
        public List<DescribeDatabasesResponse.Database> DescribeDatabases(string name = "", string status = "")
        {
            DescribeDatabasesRequest request = new DescribeDatabasesRequest();
            request.DBInstanceId = dbInstanceId;
            if (!string.IsNullOrWhiteSpace(name))
            {
                request.DBName = name;
            }
            if (!string.IsNullOrWhiteSpace(status))
            {
                request.DBStatus = status;
            }

            DescribeDatabasesResponse response = client.GetAcsResponse(request);

            return response.Databases;
        }

        /// <summary>
        /// 授权数据库
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="accountName"></param>
        /// <param name="privilege"></param>
        public void GrantPrivilege(string dbName, string accountName, string privilege = "ReadWrite")
        {
            GrantAccountPrivilegeRequest request = new GrantAccountPrivilegeRequest();
            request.DBInstanceId = dbInstanceId;
            request.DBName = dbName;
            request.AccountPrivilege = privilege;
            request.AccountName = accountName;

            client.GetAcsResponse(request);
        }

        /// <summary>
        /// 删除数据库
        /// </summary>
        /// <param name="dbName"></param>
        public void DeleteDatabase(string dbName)
        {
            DeleteDatabaseRequest request = new DeleteDatabaseRequest();
            request.DBInstanceId = dbInstanceId;
            request.DBName = dbName;

            client.GetAcsResponse(request);
        }



        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="type">【！！！注意！！！Super用户谨慎创建！请参阅：https://help.aliyun.com/document_detail/26130.html】 用户类型，取值为：Normal（普通账号），Super（超级账号），默认为Normal。该参数仅对 MySQL5.5/5.6、SQL Server 2008R2 有效，MySQL5.7/SQL Server 2012/PostgreSQL/PPAS 有且仅有一个初始账号，其他账号由初始账号连接数据库后创建。</param>
        public void CreateAccount(string name, string password, string type = "Normal")
        {
            CreateAccountRequest request = new CreateAccountRequest();
            request.DBInstanceId = dbInstanceId;
            request.AccountName = name;
            request.AccountPassword = password;
            request.AccountType = type;

            client.GetAcsResponse(request);
        }
        /// <summary>
        /// 列出账号
        /// </summary>
        /// <param name="accountName"></param>
        /// <returns></returns>
        public List<DescribeAccountsResponse.DBInstanceAccount> DescribeAccounts(string accountName = "")
        {
            DescribeAccountsRequest request = new DescribeAccountsRequest();
            request.DBInstanceId = dbInstanceId;
            if (!string.IsNullOrWhiteSpace(accountName))
            {
                request.AccountName = accountName;
            }

            DescribeAccountsResponse response = client.GetAcsResponse(request);

            return response.Accounts;
        }

        /// <summary>
        /// 删除账号
        /// </summary>
        /// <param name="name"></param>
        public void DeleteAccount(string name)
        {
            DeleteAccountRequest request = new DeleteAccountRequest();
            request.DBInstanceId = dbInstanceId;
            request.AccountName = name;

            client.GetAcsResponse(request);
        }


    }
}
