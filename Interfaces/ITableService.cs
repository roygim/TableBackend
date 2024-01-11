namespace TableBackend.Interfaces
{
    public interface ITableService
    {
        Task<List<TableObj>> GetAll();
        Task<bool> DeleteUser(int id);
    }
}
