﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using aplicacionraiz2022postgress.Models;

namespace aplicacionraiz2022postgress.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<aplicacionraiz2022postgress.Models.Contacto> DataContactos { get; set; }

    public DbSet<aplicacionraiz2022postgress.Models.Producto> DataProductos { get; set; }

    public DbSet<aplicacionraiz2022postgress.Models.Proforma> DataProforma { get; set; }
}