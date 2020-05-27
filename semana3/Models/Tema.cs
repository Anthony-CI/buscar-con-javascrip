using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace semana3.Models
{
    public class Tema
    {
        
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }


        //crear la relacion con categoria
        [Required]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        //crear la relacion con Pregunta
        public List<Pregunta> Preguntas { get; set; }

        //relacion cn usuario

        public int UsuarioId { get; set; }

        //relacion con examen
        public List<Examen> Examenes { get; set; }


    }
}
