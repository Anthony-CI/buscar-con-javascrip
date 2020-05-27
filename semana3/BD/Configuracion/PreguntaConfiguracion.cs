using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using semana3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3.BD.Configuracion
{
    public class PreguntaConfiguracion : IEntityTypeConfiguration<Pregunta>
    {
        public void Configure(EntityTypeBuilder<Pregunta> builder)
        {
            builder.ToTable("Pregunta");
            builder.HasKey(o=>o.Id);

            builder.HasOne(o => o.Tema)
                .WithMany(o => o.Preguntas)
                .HasForeignKey(o => o.TemaId);
        }
    }
}
