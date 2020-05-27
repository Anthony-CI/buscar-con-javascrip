using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using semana3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3.BD.Configuracion
{
    public class ExamenConfiguracion : IEntityTypeConfiguration<Examen>
    {
        public void Configure(EntityTypeBuilder<Examen> builder)
        {
            builder.ToTable("Examen");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Tema)
                .WithMany(o => o.Examenes)
                .HasForeignKey(o => o.TemaId);
        }
    }
}
