using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class UpdateEnderecoDto
{
    [Required(ErrorMessage = "O logradouro do endereço é obrigatório")]
    [MaxLength(80, ErrorMessage = "O tamanho do logradouro não pode exceder 80 caracteres")]
    public string Logradouro { get; set; }

    [Required(ErrorMessage = "O numero do endereço é obrigatório")]
    public int Numero { get; set; }
}
