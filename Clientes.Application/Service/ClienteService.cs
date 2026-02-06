using AutoMapper;
using Clientes.Application.DTOs;
using Clientes.Application.Interfaces;
using Clientes.Domain.Entities;

namespace Clientes.Application.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ClienteResponseDto>> GetAll()
        {
            var clientes = await _repository.GetAllAsync();
            return _mapper.Map<List<ClienteResponseDto>>(clientes);
        }

        public async Task<ClienteResponseDto> Salvar(ClienteRequestDto dto)
        {
            if (await _repository.ExisteEmailAsync(dto.Email))
                throw new Exception("Email já cadastrado.");

            var cliente = _mapper.Map<Cliente>(dto);

            cliente.Id = Guid.NewGuid();

            await _repository.AddAsync(cliente);

            return _mapper.Map<ClienteResponseDto>(cliente);
        }
    }
}