namespace TableBackend.Interfaces
{
    public interface ITableRepository
    {
        Task<List<TableObj>> GetAll();
    }
}
