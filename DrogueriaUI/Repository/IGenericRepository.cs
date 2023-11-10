namespace DrogueriaUI.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Insertar(T usuario);
        Task<bool> Actualizar(T usuario);
        Task<bool> Eliminar(int id);
        Task<T> Obtener(int id);
        Task<List<T>> ObtenerTodos();
    }
}
