using AutoMapper;
using ComexApiT2.Data;
using ComexApiT2.Dtos;
using ComexApiT2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComexApiT2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ComexContext _context;
        private IMapper _mapper;

        public ClienteController(ComexContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarCliente([FromBody] CreateClienteDto clienteDto)
        {
            Cliente cliente = _mapper.Map<Cliente>(clienteDto);

            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Ok("Cliente Adicionado com sucesso!");
        }

        [HttpGet]
        public IActionResult ListarClientes()
        {
            var clientes = _context.Clientes.ToList();
            return Ok(_mapper.Map<List<ReadClienteDto>>(clientes));
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaClientePorId(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound("Cliente Não Encontrado!");
            }
            ReadClienteDto clienteDto = _mapper.Map<ReadClienteDto>(cliente);
            return Ok(clienteDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCliente(int id, [FromBody] UpdateClienteDto clienteDto)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);

            if (cliente == null)
            {
                return NotFound("Cliente Não Encontrado!");
            }

            _mapper.Map(clienteDto, cliente);
            _context.SaveChanges();
            return Ok("Cliente Atualizado com Sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult ApagarCliente(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);

            if (cliente == null)
            {
                return NotFound("Cliente Não Encontrado!");
            }

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            return Ok("Cliente apagado com Sucesso!");
        }
    }
}
