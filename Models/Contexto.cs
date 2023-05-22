using Microsoft.EntityFrameworkCore;

namespace AgendaTarefas.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Tarefa> TAREFAS { get; set; }

    }
}
