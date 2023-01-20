using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPortal.Models
{
    [Table("usuario")]

    public class Usuario
    {
        [Key]
        public int usuarioId { get; set; }

        [Required(ErrorMessage = "Nome deve ser informado!")]
        [StringLength(50, ErrorMessage = "Nome deve ter no maximo 50 caracteres!")]
        [Display(Name = "Nome")]
        public string usuarioNome { get; set; }

        [Required(ErrorMessage = "Nome deve ser informado!")]
        [StringLength(50, ErrorMessage = "Nome deve ter no maximo 50 caracteres!")]
        [Display(Name = "Sobrenome")]
        public string usuarioSobrenome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Telefone deve ser informado!")]
        [RegularExpression(@"^(?:(?:+|00)?(55)\s?)?(?:(?([1-9][0-9]))?\s?)(?:((?:9\d|[2-9])\d{3})-?(\d{4}))$", ErrorMessage = "Telefone do E-mail Inválido")]
        public int usuarioTelefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "E-mail deve ser informado!")]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Formato do E-mail Inválido")]
        [Remote("EmailUnico", "Cadastrousuario", ErrorMessage = "e-mail já cadastrado")]
        [StringLength(50, ErrorMessage = "Senha deve ter no maximo maximo 50 caracteres!")]
        public string usuarioEmail { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Senha deve ser preenchida!")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "Senha deve ter entre 4 e 25 caracteres")]
        public string usuarioSenha { get; set; }

        [Display(Name = "Confirmar Senha")]
        [Required(ErrorMessage = "Confirmar Senha deve ser preenchida!")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "Senha deve ter entre 4 e 25 caracteres")]
        [Compare("Senha", ErrorMessage = "Senhas informadas não conferem")]
        public string usuarioConfirmarSenha { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória!")]
        public DateTime usuarioDataNascimento { get; set; }

    }
}
