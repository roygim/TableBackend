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

        public async Task<bool> DeleteUser(int id)
        {
            return await _tableRepository.DeleteUser(id);
        }

        public async Task<TableObj> AddUser(TableObj data)
        {
            return await _tableRepository.AddUser(data);
        }

        public async Task<TableObj> UpdateUser(int id, TableObj data)
        {
            return await _tableRepository.UpdateUser(id, data);
        }
    }
}
