using System.ComponentModel.DataAnnotations;

namespace AkumaNoMi.Data.Dtos
{
    public class UpdateFrutaDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O campo Tipo é obrigatório")]
        public string Tipo { get; set; }


        [StringLength(100, ErrorMessage = "O campo Usuário não pode passar de 30 caracteres")]
        public string Usuário { get; set; }


        [Required(ErrorMessage = "O campo Detalhes é obrigatório")]
        public string Detalhes { get; set; }
    }
}
