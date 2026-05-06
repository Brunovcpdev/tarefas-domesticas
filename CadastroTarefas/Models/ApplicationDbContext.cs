using Microsoft.EntityFrameworkCore;

namespace CadastroTarefas.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Tarefas> Tarefas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefas>()
                .ToTable("Tarefas")
                .HasKey(t => t.IdTarefa);
        }
    }

    public class TarefasRepository
    {
        private readonly ApplicationDbContext _context;

        public TarefasRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Tarefas> Listar()
        {
            return _context.Tarefas.ToList();
        }

        public bool Excluir(int IdTarefa)
        {
            var tarefa = _context.Tarefas.Find(IdTarefa);

            if (tarefa == null)
                return false;

            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();
            return true;
        }

        public bool Alterar(Tarefas tarefa)
        {
            var tarefaExist = _context.Tarefas.Find(tarefa.IdTarefa);

            if(tarefaExist == null)
                return false;

            _context.Entry(tarefaExist).CurrentValues.SetValues(tarefa);
            _context.SaveChanges();
            return true;
 
        }
    }
}