namespace TableBackend.Repositories
{
    public class TableDataMock: ITableRepository
    {
        private List<TableObj> _table= new List<TableObj>
        {
            new TableObj { Id = 1, UserId="11111111", Name = "Test1", Email="test1@gmail.com", Birthday="01/16/1996", Gender= "Male", Phone= "0545555555" },
            new TableObj { Id = 2, UserId="22222222", Name = "Test2", Email="test2@gmail.com", Birthday="02/17/1998", Gender= "Female", Phone= "0545555555" },
            new TableObj { Id = 3, UserId="33333333", Name = "Test3", Email="test3@gmail.com", Birthday="03/18/1999", Phone= "0545555555" },
        };

        public Task<TableObj> AddUser(TableObj data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TableObj>> GetAll()
        {
            return _table;
        }

        public Task<TableObj> UpdateUser(int id, TableObj data)
        {
            throw new NotImplementedException();
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
