namespace ApiServico
{
    public class Tarefa
    {
        public int Id { get; set; }
        public required string Descricao { get; set; }
        public DateOnly DataAbertura { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly Fechamento { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public string Status { get; set; } = "Aberto";
    }
}

