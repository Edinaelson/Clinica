using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public DateTime? DataAgendamento { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFim { get; set; }

        // Foreign Keys
        public int? ProcedimentoId { get; set; }

        //public int TituloId { get; set; }
        public int ClienteId { get; set; }
        public int StatusId { get; set; }

        // Navegação
        //public Titulo Titulo { get; set; } = null!;

        public Procedimento? Procedimento { get; set; } = null;
        public Cliente Cliente { get; set; } = null!;
        public Status Status { get; set; } = null!;

        // Propriedades de uso no RadzenScheduler (não mapeadas no banco)
        [NotMapped]
        public DateTime Start => DataAgendamento.HasValue && HoraInicio.HasValue
            ? DataAgendamento.Value.Date.Add(HoraInicio.Value)
            : DateTime.MinValue;

        [NotMapped]
        public DateTime End => DataAgendamento.HasValue && HoraFim.HasValue
            ? DataAgendamento.Value.Date.Add(HoraFim.Value)
            : DateTime.MinValue;

        //Texto que aparece em agenda
        [NotMapped]
        public string Text => $"{Cliente?.Nome ?? ""}{(Procedimento != null ? " - " + Procedimento.Nome : "")}";
    }
}
