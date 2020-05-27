using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using semana3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3.BD.Configuracion
{
    public class ProductoConfiguracion : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");
            builder.HasKey(o=>o.Id);
            builder.Property(o => o.Nombre).HasColumnName("Nombre") ;
            builder.Property(o => o.Categoria).HasColumnName("Categoria");
            builder.Property(o => o.FechaCreacion).HasColumnName("FechaCreacion");
        }
    }
}
