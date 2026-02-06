using Clientes.Application.Interfaces;
using Clientes.Domain.Entities;

namespace Clientes.Infra.Repositories
{
    public class ClienteInMemoryRepository : IClienteRepository
    {
        private static readonly List<Cliente> _clientes = new();

        public Task AddAsync(Cliente cliente)
        {
            _clientes.Add(cliente);
            return Task.CompletedTask;
        }

        public Task<List<Cliente>> GetAllAsync()
        {
            return Task.FromResult(_clientes.ToList());
        }

        public Task<bool> ExisteEmailAsync(string email)
        {
            var existe = _clientes.Any(c =>
                c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            return Task.FromResult(existe);
        }
    }
}