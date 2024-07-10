using AutoMapper;
using ComexApiT2.Data;
using ComexApiT2.Dtos;
using ComexApiT2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComexApiT2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private ComexContext _context;
        private IMapper _mapper;

        public EnderecoController(ComexContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarEndereco([FromBody] CreateEnderecoDto enderecoDto)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDto);

            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return Ok("Endereco Adicionado com sucesso!");
        }

        [HttpGet]
        public IActionResult ListarEnderecos()
        {
            var enderecos = _context.Enderecos.ToList();
            return Ok(_mapper.Map<List<ReadEnderecoDto>>(enderecos));
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEnderecoPorId(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(en => en.Id == id);
            if(endereco == null)
            {
                return NotFound("Endereço Não Encontrado!");
            }
            ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
            return Ok(enderecoDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
        {
            var endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);

            if (endereco == null)
            {
                return NotFound("Endereço Não Encontrado!");
            }

            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();
            return Ok("Endereço Atualizado com Sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult ApagarEndereco(int id)
        {
            var endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);

            if (endereco == null)
            {
                return NotFound("Endereço Não Encontrado!");
            }

            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();
            return Ok("Endereço apagado com Sucesso!");
        }
    }
}
