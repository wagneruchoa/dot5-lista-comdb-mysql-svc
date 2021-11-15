using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace mvc1.Models
{
    public static class PopulaDb
    {
        public static void IncluiDadosDb(IApplicationBuilder app)
        {
            IncluiDadosDb(app.ApplicationServices.GetRequiredService<AppDbContext>());
        }
        public static void IncluiDadosDb(AppDbContext context)
        {
            System.Console.WriteLine("Aplicando Migrations...");
            context.Database.Migrate();
            if (!context.Produtos.Any())
            {
                System.Console.WriteLine("Criando dados...");
                context.Produtos.AddRange(
                    new Produto("Luvas de goleiro", "Futebol", 25),
                    new Produto("Bola de basquete", "Basquete", 48.95m),
                    new Produto("Bola de Futebol", "Futebol", 50),
                    new Produto("Meias Grandes", "Futebol", 50),
                    new Produto("Cesta para quadra", "Basquete", 29.95m)
                );
                context.SaveChanges();
            }
        }
    }
}