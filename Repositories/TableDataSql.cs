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
            string query = "Insert into tbl_Users(UserID,Name,Email,Birthday,Gender,Phone) OUTPUT INSERTED.[Id] " +
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

        //public async Task<TaskObj> GetTask(int id)
        //{
        //    return _tasks.SingleOrDefault(t => t.Id == id);
        //}

        //public async Task<List<TaskObj>> GetCompletedTasks()
        //{
        //    return _tasks.Where(t => t.IsComplete).ToList();
        //}

        //public async Task<TaskObj> AddTask(TaskObj task)
        //{
        //    _tasks.Add(task);
        //    return task;
        //}

        //public async Task<bool> DeleteTask(int id)
        //{
        //    var task = _tasks.SingleOrDefault(t => t.Id == id);
        //    if (task != null)
        //    {
        //        return _tasks.Remove(task);
        //    }
        //    return false;
        //}

        //public async Task<int> DeleteTasks(string ids)
        //{
        //    string[] idsArray = ids.Split(',');
        //    int num = _tasks.RemoveAll(t => idsArray.Contains(t.Id.ToString()));
        //    return num;
        //}
    }
}
