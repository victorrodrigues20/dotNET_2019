using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotNET_2019.Models
{
    public class Livro
    {
        [Key]
        public int LivroID { get; set; }

        public string Titulo { get; set; }
    }
}