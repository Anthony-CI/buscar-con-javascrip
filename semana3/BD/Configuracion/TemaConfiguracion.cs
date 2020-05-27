using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using semana3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3.BD.Configuracion
{
    public class TemaConfiguracion : IEntityTypeConfiguration<Tema>
    {
        public void Configure(EntityTypeBuilder<Tema> builder)
        {
            builder.ToTable("Tema");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Categoria)
                .WithMany(o => o.Temas)
                .HasForeignKey(o=>o.CategoriaId);

            

        }
    }
}
