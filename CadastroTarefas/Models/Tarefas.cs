namespace CadastroTarefas.Models
{
    public class Tarefas
    {
        public int IdTarefa { get; set; }
        public string NomeTarefa { get; set; }
        public string Descricao { get; set; }
        public DateTime DataTarefa { get; set; }
        public int Prioridade { get; set; }
        public string Responsavel { get; set; }
    }


}
