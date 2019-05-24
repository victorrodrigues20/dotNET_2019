using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using dotNET_2019.Dados;
using dotNET_2019.Models;

namespace dotNET_2019.Services
{
    // Classe herdando da IServicoLogin
    public class ServicoLogin : IServicoLogin
    {
        // Variável de contexto que também é injetável
        private BibliotecaDbContext _context;
	  // UserManager também é injetável e recupera informações do usuário no banco app.db
        private UserManager<IdentityUser> _userManager;

	  // HttpContext também é injetável e recupera informações do usuário logado no sistema
        private HttpContext _httpContext;

	  // Construtor da classe com as variáveis que serão injetadas pelo próprio sistema
        public ServicoLogin(BibliotecaDbContext context,
            UserManager<IdentityUser> userManager,
            IHttpContextAccessor httpContext)
        {
            _context = context;
            _userManager = userManager;
            _httpContext = httpContext.HttpContext;
        }
        
	    // Implementação do método RecuperarUsuario
        public Usuario RecuperarUsuario()
        {
	      // Recupera ID do usuário logado
            var userID = _userManager.GetUserId(_httpContext.User);
		// Recupera nome/email do usuário logado
            var userName = _userManager.GetUserName(_httpContext.User);

		// Linq que recupera instância do usuário no banco biblioteca.db
            Usuario usuario = _context.Usuario.FirstOrDefault(u => u.ApplicationUserId == userID);

	      // Se não existir um usuário com o ID, cadastra um novo
            if (usuario == null)
            {
		    // Cria novo usuário
            usuario = new Usuario
            {
                Nome = userName,
                ApplicationUserId = userID
            };

            // Insere novo usuário na tabela                                     
            _context.Usuario.Add(usuario);

		    // Salva alterações
                _context.SaveChanges();
            }

		// Retorna usuário recuperado ou o novo que foi cadastrado
            return usuario;
        }

	  // Implementação do método UsuarioLogado
        public bool UsuarioLogado()
        {
		// Se estiver autenticado, significa que usuário está logado
            return _httpContext.User.Identity.IsAuthenticated;
        }   
    }
}
