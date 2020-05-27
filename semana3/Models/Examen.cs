using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3.Models
{
    public class Examen
    {
        public int Id { get; set; }
        
        public DateTime FechaRegistro { get; set; }


        //realcion con temas
        public int TemaId { get; set; }
        public Tema Tema { get; set; }

        //relacion con usuario
        public int UsuarioId { get; set; }
    }
}
