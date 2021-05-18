using System.ComponentModel.DataAnnotations;

namespace empresasAPi.Models
{
    // criando uma classe chamada User, para o EFCore representa uma tabela;
    public class User
    {
        // criando a propriedade Id, para o EFCore representa uma coluna da tabela User;
        // e colocando o Atributo/Annotation [Key];
        // pois para o EFCore ela representa uma chave, ela é única;
        [Key]
        public int Id { get; set; }

        // Required é um atributo que significa obrigatório
        // Se caso não for preenchido irá dar uma Mensagem de Erro(Este campo é obrigatório);
        [Required(ErrorMessage = "Este campo é obrigatório")]

        // MaxLength é um atributo que significa comprimento máximo,
        // Deixamos especificado que o máximo de caracteres que podem ser colocados é de até 75,
        // Caso ao contrário será exibida a Mesagem de Erro (Este campo deve conter entre 5 e 75 caracteres).
        [MaxLength(75, ErrorMessage = "Este campo deve ter entre 5 e 75 caracteres")]

        // MinLength é um atributo que significa comprimento mínimo,
        // Deixamos especificado que o mínimo de caracteres que podem ser inseridos é a partir de 5,
        // Caso ao contrário será exibida a Mensagem de Erro (Este campo deve conter entre 5 e 75 caracteres).
        [MinLength(5, ErrorMessage = "Este campo deve ter entre 5 e 75 caracteres")]

        // criando uma propriedade Name, para o EFCore representa uma coluna da tabela User;
        public string Name { get; set; }
        
        // Required é um atributo que significa obrigatório
        // Se caso não for preenchido irá dar uma Mensagem de Erro(Este campo é obrigatório);
        [Required(ErrorMessage = "Este campo é obrigatório")]

        // MaxLength é um atributo que significa comprimento máximo,
        // Deixamos especificado que o máximo de caracteres que podem ser colocados é de até 75,
        // Caso ao contrário será exibida a Mesagem de Erro (Este campo deve conter entre 5 e 75 caracteres).
        [MaxLength(75, ErrorMessage = "Este campo deve ter entre 5 e 75 caracteres")]

        // MinLength é um atributo que significa comprimento mínimo,
        // Deixamos especificado que o mínimo de caracteres que podem ser inseridos é a partir de 5,
        // Caso ao contrário será exibida a Mensagem de Erro (Este campo deve conter entre 5 e 75 caracteres).
        [MinLength(5, ErrorMessage = "Este campo deve ter entre 5 e 75 caracteres")]
        
        // criando uma propriedade Surname, para o EFCore representa uma coluna da tabela User;
        public string Surname { get; set; }

        // Required é um atributo que significa obrigatório
        // Se caso não for preenchido irá dar uma Mensagem de Erro(Este campo é obrigatório);
        [Required(ErrorMessage = "Este campo é obrigatório")]

        // MaxLength é um atributo que significa comprimento máximo,
        // Deixamos especificado que o máximo de caracteres que podem ser colocados é de até 75,
        // Caso ao contrário será exibida a Mesagem de Erro (Este campo deve conter entre 5 e 75 caracteres).
        [MaxLength(75, ErrorMessage = "Este campo deve ter entre 5 e 75 caracteres")]

        // MinLength é um atributo que significa comprimento mínimo,
        // Deixamos especificado que o mínimo de caracteres que podem ser inseridos é a partir de 5,
        // Caso ao contrário será exibida a Mensagem de Erro (Este campo deve conter entre 5 e 75 caracteres).
        [MinLength(5, ErrorMessage = "Este campo deve ter entre 5 e 75 caracteres")]

        // criando uma propriedade Age, para o EFCore representa uma coluna da tabela User;
        public int Age { get; set; }
        
    }
}