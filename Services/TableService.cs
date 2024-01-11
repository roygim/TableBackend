using System.Threading.Tasks;

namespace TableBackend.Services
{
    public class TableService : ITableService
    {
        private readonly ITableRepository _tableRepository;

        public TableService(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public async Task<List<TableObj>> GetAll()
        {
            return await _tableRepository.GetAll();
        }

        //public async Task<TaskObj> AddTask(TaskObj task)
        //{
        //    return await _taskRepository.AddTask(task);
        //}

        //public async Task<bool> DeleteTask(int id)
        //{
        //    return await _taskRepository.DeleteTask(id);
        //}

        //public async Task<int> DeleteTasks(string ids)
        //{
        //    return await _taskRepository.DeleteTasks(ids);
        //}
    }
}
