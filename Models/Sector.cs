using System.ComponentModel.DataAnnotations;

namespace empresasAPi.Models
{
    // criando uma classe chamada Sector, para o EFCore representa um a tabela;
    public class Sector
    {
        // criando a propriedade Id, para o EFCore representa uma coluna da tabela Sector;
        // e colocando o Atributo/Annotation [Key];
        // pois para o EFCORE ela representa uma chave, ela é única;
        [Key]
        public int Id { get; set;  }

        // Required é um atributo que significa obrigatório
        // Se caso não for preenchido irá dar uma Mensagem de Erro(Este campo é obrigatório);
        [Required(ErrorMessage = "Este campo é obrigatório")]

        // MaxLength é um atributo que significa comprimento máximo,
        // Deixamos especificado que o máximo de caracteres que podem ser colocados é de até 80 ,
        // Caso ao contrário será exibida a Mesagem de Erro (Este campo deve conter entre 5 e 80 caracteres).
        [MaxLength(80, ErrorMessage = "Este campo deve ter entre 5 e 80 caracteres")]

        // MinLength é um atributo que significa comprimento mínimo,
        // Deixamos especificado que o mínimo de caracteres que podem ser inseridos é a partir de 5,
        // Caso ao contrário será exibida a Mensagem de Erro (Este campo deve conter entre 5 e 80 caracteres).
        [MinLength(5, ErrorMessage = "Este campo deve ter entrer 5 e 80 caracteres")]

        // criando a propriedade Administrative, para o EFCore representa uma coluna da tabela Sector;
        public string Administrative { get; set; }
        
        // Required é um atributo que significa obrigatório
        // Se caso não for preenchido irá dar uma Mensagem de Erro(Este campo é obrigatório);
        [Required(ErrorMessage = "Este campo é obrigatório")]

        // MaxLength é um atributo que significa comprimento máximo,
        // Deixamos especificado que o máximo de caracteres que podem ser colocados é de até 80 ,
        // Caso ao contrário será exibida a Mesagem de Erro (Este campo deve conter entre 5 e 80 caracteres).
        [MaxLength(80, ErrorMessage = "Este campo deve ter entre 5 e 80 caracteres")]

        // MinLength é um atributo que significa comprimento mínimo,
        // Deixamos especificado que o mínimo de caracteres que podem ser inseridos é a partir de 5,
        // Caso ao contrário será exibida a Mensagem de Erro (Este campo deve conter entre 5 e 80 caracteres).
        [MinLength(5, ErrorMessage = "Este campo deve ter entrer 5 e 80 caracteres")]

        // criando a propriedade Financial, para o EFCore representa uma coluna da tabela Sector;
        public string Financial { get; set; }

        // Required é um atributo que significa obrigatório
        // Se caso não for preenchido irá dar uma Mensagem de Erro(Este campo é obrigatório);
        [Required(ErrorMessage = "Este campo é obrigatório")]

        // MaxLength é um atributo que significa comprimento máximo,
        // Deixamos especificado que o máximo de caracteres que podem ser colocados é de até 80 ,
        // Caso ao contrário será exibida a Mesagem de Erro (Este campo deve conter entre 5 e 80 caracteres).
        [MaxLength(80, ErrorMessage = "Este campo deve ter entre 5 e 80 caracteres")]

        // MinLength é um atributo que significa comprimento mínimo,
        // Deixamos especificado que o mínimo de caracteres que podem ser inseridos é a partir de 5,
        // Caso ao contrário será exibida a Mensagem de Erro (Este campo deve conter entre 5 e 80 caracteres).
        [MinLength(5, ErrorMessage = "Este campo deve ter entrer 5 e 80 caracteres")]

        // criando a propriedade HumanResources, para o EFCore representa uma coluna da tabela Sector;
        public string HumanResources { get; set; }

        // Required é um Atributo/Annotation que significa obrigatório
        // Se caso nao for preenchido irá dar uma Mensagem de Erro(Este campo é obrigatório);
        // Range de 1 a 5: 1, 2, 3, 4 ou 5 - ou seja digitar 6, está fora  da range.
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Usuário inválido")]

        // Criando a propriedade UserId, para o EFCore representa uma coluna da tabela Sector;
        public int UserId { get; set;}

        // Criando a propriedade User, do tipo User, para o EFCore representa uma coluna da tabela Sector;
        public User User { get; set; }
    }
}