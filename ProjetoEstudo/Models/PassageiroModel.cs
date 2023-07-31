using System.ComponentModel.DataAnnotations;

namespace ProjetoEstudo.Models
{
    public class PassageiroModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        [EmailAddress(ErrorMessage = "Digite o e-mail corretamente")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o Cpf")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe o Numero da Poltrona")]
        public string NumeroPoltrona { get; set; }

        [Required(ErrorMessage = "Informe a Compania")]
        public string Compania { get; set; }

        [Required(ErrorMessage = "Informe a Origem")]
        public string Origem { get; set; }

        [Required(ErrorMessage = "Informe o Destino")]
        public string Destino { get; set; }
    }
}
