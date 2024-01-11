namespace TableBackend.Interfaces
{
    public interface ITableRepository
    {
        Task<List<TableObj>> GetAll();
        Task<bool> DeleteUser(int id);
        Task<TableObj> AddUser(TableObj data);
        Task<TableObj> UpdateUser(int id, TableObj data);
    }
}
