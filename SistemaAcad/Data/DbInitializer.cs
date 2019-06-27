using SistemaAcad.Models;
using SistemaAcad.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcad.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaAcadContext context)
        {
            context.Database.EnsureCreated();
            if (context.Categoria.Any())
            {
                return;
            }

            var categorias = new Categoria[]
            {
                new Categoria{ Nombre="Programación",Descripcion="Curso de programación ASP",Estado=true,Carrera="Sistemas"},
                new Categoria{ Nombre="Diseño Gráfico",Descripcion="Curso de diseño gráfico",Estado=true,Carrera="Mercadotecnia"},
                new Categoria{ Nombre="Matemáticas",Descripcion="Introducción al Álgebra Lineal",Estado=true,Carrera="Matemáticas"},
            };

            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
        }
    }
}
