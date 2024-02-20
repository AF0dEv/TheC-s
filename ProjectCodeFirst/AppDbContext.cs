using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCodeFirst
{
    internal class AppDbContext : DbContext
    { 
        public DbSet<Formando>? Nomes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Trust Server Certificate -> Para conectar precisa de Certificado, como não tenho, cria e define como trusted 
            optionsBuilder.UseSqlServer(@"data source = 62.28.39.135,62444;Initial Catalog=KAfonso;User ID=EFAafonso;Password=Abc.123##; trust server certificate = true;");
        }
    }
}

// Comandos Package Manager Console
// View -> Other Windows -> Package Manager Console

// 1º COMANDO
// add-migration -> Pega na Classe Modelo e na Classe Context e Gera Codigo CSharp que Gera Base de Dados
// antes de fazer migration, clean rebuild e rebuild solution

// 2º COMANDO
// update -> Pega na Migração Gerada e Propraga para a Base de Dados, se a BD NÃO Existe cria, se Existe faz Atualização 
