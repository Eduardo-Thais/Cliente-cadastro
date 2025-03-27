using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDSimples.Model
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente")]
        public String Nome { get; set; }
        [Required(ErrorMessage = "Informe o endereço do cliente")]
        public String Endereco { get; set; }
        [Required(ErrorMessage = "Informe o Telefone do cliente")]
        public String Telefone { get; set; }

    }
}
