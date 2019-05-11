using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotNET_2019.Models
{
    public class Sistema
    {
        [Key]
        public int SistemaID { get; set; }
        public string Nome { get; set; }

        public ICollection<SistemaUsuario> SistUsuarios { get; set; }
    }

}