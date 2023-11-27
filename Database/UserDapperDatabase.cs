using System.Data;
using System.Data.SqlClient;
using Dapper;
using orm_json_benchmarking.Interfaces;
using orm_json_benchmarking.Models;

namespace orm_json_benchmarking.Database
{
    internal class UserDapperDatabase : IUserDatabase
    {
        private readonly string _connectionString = "[connectionstring]";

        public long? Insert(UserModel user)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                return connection.QuerySingle<int>(
                    "INSERT INTO [dbo].[Users] ([Username], [Password], [Role], [CreationDate]) VALUES (@Username, @Password, @Role, @CreationDate); SELECT CAST(SCOPE_IDENTITY() as int)",
                    user);
            }
        }

        public UserModel Get(long? id)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                return connection.QuerySingle<UserModel>("SELECT * FROM [dbo].[Users] WHERE [Id] = @Id", new {Id = id});
            }
        }

        public void Delete(long? id)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                connection.Execute("DELETE FROM [dbo].[Users] WHERE [Id] = @Id", new {Id = id});
            }
        }
    }
}