using Microsoft.EntityFrameworkCore;
using TarefasApi.Models;

namespace TarefasApi.Context
{
    public class OrganizadorContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }
    }
}
