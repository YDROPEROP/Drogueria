using DrogueriaUI.DataContext;
using DrogueriaUI.Models;
using Microsoft.EntityFrameworkCore;

namespace DrogueriaUI.Repository
{
    public class ClienteRepository : IGenericRepository<Cliente>
    {
        private readonly DrogueriaContext _dbContext;

        public ClienteRepository(DrogueriaContext drogueriaContext)
        {
            this._dbContext = drogueriaContext;
        }
        public async Task<bool> Actualizar(Cliente usuario)
        {
            var user = new Cliente()
            {
                Id = usuario.Id,
                Identificacion = usuario.Identificacion,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                IdCiudad = usuario.IdCiudad
            };

            this._dbContext.Clientes.Update(user);
            await this._dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            var user = this._dbContext.Clientes.Where(cliente => cliente.Id == id).FirstOrDefault();

            this._dbContext.Clientes.Remove(user);
            await this._dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Cliente> Insertar(Cliente usuario)
        {

            this._dbContext.Clientes.Add(usuario);

            await this._dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<Cliente> Obtener(int id)
        {
            return await this._dbContext.Clientes.FirstOrDefaultAsync(cliente => cliente.Id == id);
        }

        public async Task<List<Cliente>> ObtenerTodos()
        {
            var clientes = await this._dbContext.Clientes.ToListAsync();

            return clientes;
        }
    }
}
