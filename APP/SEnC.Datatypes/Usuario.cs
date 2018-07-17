using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblUsuario")]
    public class Usuario : IDatatype
    {
        //[Key]
        //[Column("IdUsuario", TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Nome")]
        public string NomeUsuario { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [MaxLength(150)]
        [Display(Name = "E-Mail")]
        public string EmailUsuario { get; set; }

        //[Required]
        [Display(Name = "Senha")]
        //[StringLength(255, ErrorMessage = "A {0} deve ter ao menos {2} caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string PassUsuario { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data do cadastro")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCadastro { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data de validade da conta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataVigencia { get; set; }

        [Display(Name = "Plano selecionado")]
        public int PlanoId { get; set; }
        //[ForeignKey("idPlanos")]
        public virtual Plano Plano { get; set; }

        public int AfiliadoId { get; set; }
        //[ForeignKey("idAfiliado")]
        public virtual Afiliado Afiliado { get; set; }

        public int PagamentoId { get; set; }
        public virtual ICollection<Pagamento> Pagamentos { get; set; }

        public int AlertaId { get; set; }
        public virtual ICollection<Alerta> Alertas { get; set; }

        public int GrupoId { get; set; }
        public virtual ICollection<Grupo> Grupos { get; set; }

        public int FornecedorId { get; set; }
        public virtual ICollection<Fornecedor> Fornecedores { get; set; }

        public int ContaId { get; set; }
        public virtual ICollection<Conta> Contas { get; set; }
    }

    public class RegisterExternalLoginModel
    {
        [Required]
        [MaxLength(150)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public string ExternalLoginData { get; set; }
    }

    public class LocalPasswordModel
    {
        [Required]
        [Display(Name = "Senha atual")]
        [StringLength(255, ErrorMessage = "A {0} deve ter ao menos {2} caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string OldPwd { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "A {0} Deve ter ao menos {2} caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        public string NewPwd { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação da nova senha")]
        [Compare("NewPwd", ErrorMessage = "A nova senha e a confirmação estão diferentes.")]
        public string ConfirmPwd { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Pwd { get; set; }

        [Display(Name = "Lembrar de mim?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [MaxLength(150)]
        [Display(Name = "Nome")]
        public string NomeUsuario { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string EmailUsuario { get; set; }

        [Required]
        [Display(Name = "Senha")]
        [StringLength(255, ErrorMessage = "A {0} deve ter ao menos {2} caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string PassUsuario { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação da senha")]
        [Compare("PassUsuario", ErrorMessage = "A senha e a confirmação estão diferentes.")]
        public string ConfirmPassword { get; set; }
    }

    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
}
