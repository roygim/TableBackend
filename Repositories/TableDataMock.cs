namespace TableBackend.Repositories
{
    public class TableDataMock: ITableRepository
    {
        private List<TableObj> _table= new List<TableObj>
        {
            new TableObj { Id = 1, Name = "Test1" },
            new TableObj { Id = 2, Name = "Test2" },
            new TableObj { Id = 3, Name = "Test3" },
        };

        public async Task<List<TableObj>> GetAll()
        {
            return _table;
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
