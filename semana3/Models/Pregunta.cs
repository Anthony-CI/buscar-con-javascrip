using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3.Models
{
    public class Pregunta
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        //relacion
        public int TemaId { get; set; }
        public Tema Tema { get; set; }
        //relacion con alternativa
        public List<Alternativa> Alternativas { get; set; }


    }
}
