namespace Clinica.Models
{
    public class RelatorioConsulta
    {
        public int Id { get; set; }

        //chave estrangeira
        //public int? ProcedimentoId { get; set; }
        public int? AgendamentoId { get; set; }

        //public Procedimento Procedimento { get; set; }
        public Agendamento Agendamento { get; set; }
        //public double Preco { get; set; }

        public DateTime DataAgendada { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
    }
}
