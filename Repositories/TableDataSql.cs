using Dapper;

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
