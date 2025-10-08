using Clinica.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Data
{
    public class ApplicationDbContextClinica : DbContext
    {
        public ApplicationDbContextClinica(DbContextOptions<ApplicationDbContextClinica> options) : base (options) { }

        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Procedimento> Procedimentos { get; set; }
        public DbSet<RelatorioConsulta> RelatoriosConsultas { get; set; }
        public DbSet<Status> Status { get; set; }

    }
}
