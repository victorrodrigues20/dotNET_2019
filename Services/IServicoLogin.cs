using dotNET_2019.Models;

namespace dotNET_2019.Services
{
    public interface IServicoLogin
    {
        Usuario RecuperarUsuario();

        bool UsuarioLogado();
    }
}
