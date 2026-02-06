using Clientes.Domain.Entities;

namespace Clientes.Application.Interfaces
{
    public interface IClienteRepository
    {
        Task AddAsync(Cliente cliente);
        Task<List<Cliente>> GetAllAsync();
        Task<bool> ExisteEmailAsync(string email);
    }
}