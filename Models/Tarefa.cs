using System.ComponentModel.DataAnnotations;

namespace AgendaTarefas.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "Campo {0} não deve ultreapassar os 50 caracteres")]
        public string Nome { get; set; }

        public string Data { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [DataType(DataType.Time)]
        public string Horario { get; set; }
    }
}
