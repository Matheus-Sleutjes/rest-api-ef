using Microsoft.AspNetCore.Mvc;
using RestApi.Entities;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivrosController(ILivroService _livrosService) : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Find(int id)
        {
            var model = _livrosService.Find(id);
            return model != null ? Ok(model) : BadRequest("Não existe entidade com esse id");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Livro model)
        {
            _livrosService.Add(model);
            _livrosService.SaveChanges();
            return Ok(model.Id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var model = _livrosService.Find(id);

            if (model == null)
                return NotFound("Não foi encontrado nenhuma entidade com esse id");

            _livrosService.Delete(model);
            _livrosService.SaveChanges();
            return Ok("Removido com sucesso!");
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Livro request, int id)
        {
            var model = _livrosService.Find(id);

            if (model == null)
                return NotFound("Não foi encontrado nenhuma entidade com esse id");

            model.Descricao = request.Descricao;

            _livrosService.Update(model);
            _livrosService.SaveChanges();
            return Ok(model);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var lista = _livrosService.GetAll();
            return Ok(lista);
        }
    }
}
