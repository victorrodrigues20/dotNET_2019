using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotNET_2019.Models
{
    public class Autor
    {
        [Key]
        public int AutorID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O campo Nome pode ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        public ICollection<LivroAutor> LivAutor { get; set; }
    }
}