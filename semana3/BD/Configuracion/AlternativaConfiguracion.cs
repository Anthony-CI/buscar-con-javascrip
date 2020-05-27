using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using semana3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3.BD.Configuracion
{
    public class AlternativaConfiguracion : IEntityTypeConfiguration<Alternativa>
    {
        public void Configure(EntityTypeBuilder<Alternativa> builder)
        {
            builder.ToTable("Alternativa");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Pregunta)
                .WithMany(o => o.Alternativas)
                .HasForeignKey(o => o.PreguntaId);
        }
    }
}
