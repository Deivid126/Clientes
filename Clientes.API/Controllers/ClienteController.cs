using Clientes.Application.DTOs;
using Clientes.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Clientes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(IClienteService service, ILogger<ClienteController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] ClienteRequestDto cliente)
        {
            try
            {
                await _service.Salvar(cliente);
                return Created();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex,"Erro ao cadastrar cliente: {cliente} ", cliente);
                return BadRequest(new
                {
                    error = ex.Message
                });
            }
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodos()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar os clientes");
                return BadRequest(new
                {
                    error = ex.Message
                });
            }
        }
    }
}