using Microsoft.AspNetCore.Mvc;
using Projeto1.Repositorio;

namespace Projeto1.Controllers
{
    public class UsuarioController : Controller
    {
        /* DECLARANDO UMA VARIAVEL PRIVADA SOMENTE PARA LEITURA DO 
         * TIPO UsuarioRepositorio CHAMADA _usuarioRepositorio */
        private readonly UsuarioRepositorio _usuarioRepositorio; 

        /* DEFININDO O CONSTRUTOR DA CLASSE UsuarioController QUE 
         * VAI RECEBER UMA INSTÂNICA DE UsuarioReposiorio */
        public UsuarioController(UsuarioRepositorio usuarioRepositorio) 
        {
            _usuarioRepositorio = usuarioRepositorio;
        } 
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }

    }
}
