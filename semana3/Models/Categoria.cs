using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        //crear la relacion con tema
        public List<Tema> Temas { get; set; }

    }
}
