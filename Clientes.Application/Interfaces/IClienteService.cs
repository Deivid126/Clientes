using Clientes.Application.DTOs;

namespace Clientes.Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteResponseDto> Salvar(ClienteRequestDto cliente);
        Task<List<ClienteResponseDto>> GetAll();
    }
}