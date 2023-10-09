using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[Route("api/filmes")]
[ApiController]
public class FilmesController : ControllerBase
{
private static List<Filme> filmes = new List<Filme> {
    new Filme { Id = 1, Titulo = "Filme 1", Diretor = "Direitor 1", Atores = "Ator 1, Atriz 1", Ano = 2020 }
};

[HttpGet]
public ActionResult<IEnumerable<Filme>> Get(){
    return Ok(filmes);
}

[HttpGet("{id}")]
public ActionResult<Filme> Get(int id){
    var filme = filmes.FirstOrDefault(f => f.Id == id);
    if (filme == null) {
        return NotFound();
    }
    return Ok(filme);
    } 
}
