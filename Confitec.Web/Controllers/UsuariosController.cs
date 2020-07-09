using Confitec.Dominio.BaseRepositorio;
using Confitec.Dominio.Entidade;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Confitec.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuariosController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio  = usuarioRepositorio;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Json(_usuarioRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("Deletar")]
        public IActionResult Deletar([FromBody] Usuarios usuario)
        {
            try
            {
                _usuarioRepositorio.Remover(usuario);
                return Json(_usuarioRepositorio.ObterTodos()); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuarios usuario)
        {
            try
            {
                //var _usuarioCadastro = _usuarioRepositorio.Obter(usuario.Email);
               
                if (usuario.Id > 0)
                {
                    _usuarioRepositorio.Atualizar(usuario);
                }
                else
                {
                _usuarioRepositorio.Adicionar(usuario);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
