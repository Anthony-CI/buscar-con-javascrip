using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace semana3.Models
{
    public class Alternativa
    {
        public int Id { get; set; }
        [Required]
        public string Resumen { get; set; }
        [Required]
        public bool EsCorrecto { get; set; }
        //Realcion entre tablas
        public int PreguntaId { get; set; }
        public Pregunta Pregunta { get; set; }
    }
}
