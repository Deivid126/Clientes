using AutoMapper;
using Clientes.Application.DTOs;
using Clientes.Domain.Entities;

namespace Clientes.Application.Mappings
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteResponseDto>();
            CreateMap<ClienteResponseDto, Cliente>();
            CreateMap<ClienteRequestDto, Cliente>();
        }
    }
}