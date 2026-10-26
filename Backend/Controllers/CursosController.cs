using Microsoft.AspNetCore.Mvc;
using Backend.Models; 

namespace Backend.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCursos(
            [FromQuery] string? nome, 
            [FromQuery] string? categoria, 
            [FromQuery] string? modalidade, 
            [FromQuery] string? status)
        {
            var cursos = new List<Curso>
            {
                new Curso {
                    Id = 1, NomeCompleto = "Estratégias Avançadas para o Metagame de Pokémon TCG", NomeBreve = "Estratégias em Pokémon TCG",
                    Descricao = "Aprenda a montar decks competitivos, ler o meta e dominar as mecânicas.", Categoria = "ESTRATÉGIA",
                    Modalidade = "Online", CargaHoraria = 40, PublicoAlvo = "Jogadores intermediários", Status = "Inscrições Abertas",
                    ImagemUrl = "/assets/pokemon.jpg", DataDisponibilizacao = "2024-01-15"
                },
                new Curso {
                    Id = 2, NomeCompleto = "Construção de Deck e Combos no Yu-Gi-Oh!", NomeBreve = "Deck e Combos em Yu-Gi-Oh!",
                    Descricao = "Domine as cadeias de invocação, side deck e as principais cartas.", Categoria = "ESTRATÉGIA",
                    Modalidade = "Presencial", CargaHoraria = 30, PublicoAlvo = "Fãs de card games", Status = "Em Breve",
                    ImagemUrl = "/assets/yugioh.jpg", DataDisponibilizacao = "2024-03-10"
                },
                new Curso {
                    Id = 3, NomeCompleto = "Introdução ao Commander e Formatos Casuais de Magic", NomeBreve = "Formatos Casuais de Magic",
                    Descricao = "Aprenda as regras do Commander (EDH) e construção de deck.", Categoria = "COLECIONISMO",
                    Modalidade = "Online", CargaHoraria = 25, PublicoAlvo = "Iniciantes no Magic", Status = "Inscrições Abertas",
                    ImagemUrl = "/assets/magic.jpg", DataDisponibilizacao = "2024-02-20"
                },
                new Curso {
                    Id = 4, NomeCompleto = "Avaliação e Mercado de Cartas Colecionáveis (TCG)", NomeBreve = "Mercado de Cartas",
                    Descricao = "Como identificar raridades, conservação (grading) e precificação.", Categoria = "MERCADO",
                    Modalidade = "Online", CargaHoraria = 15, PublicoAlvo = "Colecionadores", Status = "Inscrições Abertas",
                    ImagemUrl = "/assets/mercado.jpg", DataDisponibilizacao = "2024-04-05"
                },
                new Curso {
                    Id = 5, NomeCompleto = "Arte e Ilustração para Card Games", NomeBreve = "Arte para Card Games",
                    Descricao = "Técnicas de ilustração digital voltadas para a criação de artes.", Categoria = "ARTE",
                    Modalidade = "Presencial", CargaHoraria = 60, PublicoAlvo = "Artistas", Status = "Encerrado",
                    ImagemUrl = "/assets/arte.jpg", DataDisponibilizacao = "2023-11-10"
                },
                new Curso {
                    Id = 6, NomeCompleto = "Organização de Torneios e Arbitragem em TCG", NomeBreve = "Arbitragem em TCG",
                    Descricao = "Regras oficiais, resolução de conflitos e softwares de pareamento.", Categoria = "ORGANIZAÇÃO",
                    Modalidade = "Online", CargaHoraria = 20, PublicoAlvo = "Organizadores", Status = "Em Breve",
                    ImagemUrl = "/assets/torneio.jpg", DataDisponibilizacao = "2024-05-01"
                }
            };

            

            if (!string.IsNullOrEmpty(nome))
            {
                cursos = cursos.Where(c => c.NomeCompleto.Contains(nome, StringComparison.OrdinalIgnoreCase) || 
                                           c.NomeBreve.Contains(nome, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(categoria))
            {
                cursos = cursos.Where(c => c.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(modalidade))
            {
                cursos = cursos.Where(c => c.Modalidade.Equals(modalidade, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(status))
            {
                cursos = cursos.Where(c => c.Status.Equals(status, StringComparison.OrdinalIgnoreCase)).ToList();
            }

        

            return Ok(cursos);
        }
    }
}