using Microsoft.EntityFrameworkCore;

namespace Clinica.Data
{
    public class ApplicationDbContextClinica : DbContext
    {
        public ApplicationDbContextClinica(DbContextOptions<ApplicationDbContextClinica> options) : base (options) { }
    }
}
