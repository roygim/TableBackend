namespace TableBackend.Interfaces
{
    public interface ITableService
    {
        Task<List<TableObj>> GetAll();
        Task<bool> DeleteUser(int id);
        Task<TableObj> AddUser(TableObj data);
    }
}
