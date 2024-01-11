using Dapper;
using System.Data;

namespace TableBackend.Repositories
{
    public class TableDataSql: ITableRepository
    {
        private readonly DapperDBContext _context;

        public TableDataSql(DapperDBContext context)
        {
            _context = context;
        }

        public async Task<List<TableObj>> GetAll()
        {
            string query = "select * from tbl_Users";
            using (var connectin = _context.CreateConnection())
            {
                var users = await connectin.QueryAsync<TableObj>(query);
                return users.ToList();
            }
        }

        public async Task<bool> DeleteUser(int id)
        {
            string query = "delete from tbl_Users where Id=@id";

            using (var connectin = _context.CreateConnection())
            {
                await connectin.ExecuteAsync(query, new { id });
                return true;
            }
        }

        public async Task<TableObj> AddUser(TableObj data)
        {
            string query = "insert into tbl_Users(UserID,Name,Email,Birthday,Gender,Phone) OUTPUT INSERTED.[Id] " +
                "values (@userId,@name,@email,@birthday,@gender,@phone)";

            var parameters = new DynamicParameters();
            parameters.Add("userId", data.UserId, DbType.String);
            parameters.Add("name", data.Name, DbType.String);
            parameters.Add("email", data.Email, DbType.String);
            parameters.Add("birthday", data.Birthday, DbType.DateTime);
            parameters.Add("gender", data.Gender, DbType.String);
            parameters.Add("Phone", data.Phone, DbType.String);

            using (var connectin = _context.CreateConnection())
            {
                int newUserId = await connectin.QuerySingleAsync<int>(query, parameters);
                data.Id = newUserId;
                return data;
            }
        }

        public async Task<TableObj> UpdateUser(int id, TableObj data)
        {
            string query = "update tbl_Users set " +
                "UserID=@userId,Name=@name,Email=@email,Birthday=@birthday,Gender=@gender,Phone=@phone " +
                "where Id=@id";

            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            parameters.Add("userId", data.UserId, DbType.String);
            parameters.Add("name", data.Name, DbType.String);
            parameters.Add("email", data.Email, DbType.String);
            parameters.Add("birthday", data.Birthday, DbType.DateTime);
            parameters.Add("gender", data.Gender, DbType.String);
            parameters.Add("Phone", data.Phone, DbType.String);

            using (var connectin = _context.CreateConnection())
            {
                await connectin.ExecuteAsync(query, parameters);
                data.Id = id;
                return data;
            }
        }
    }
}
