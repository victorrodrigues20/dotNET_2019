namespace dotNET_2019.Models
{
    public class SistemaUsuario
    {
        public int SistemaID { get; set; }
        public Sistema Sistemas { get; set; }

        public int UsuarioID { get; set; }
        public Usuario Usuarios { get; set; }
    }

}