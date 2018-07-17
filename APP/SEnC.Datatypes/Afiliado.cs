using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblAfiliado")]
    public class Afiliado : IDatatype
    {
        //[Key]
        //[Column("AfiliadoId", TypeName = "int")]
        public int Id { get; set; }

        //(AllowEmptyStrings=false,ErrorMessage="O campo nome é obrigatório.")
        [Required]
        [MaxLength(150)]
        [Display(Name="Nome")]
        public string Nome { get; set; }

        //[Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [MaxLength(150)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Display(Name = "Código de afiliado")]
        public string Codigo { get; set; }
        
        //public virtual ICollection<UsuarioVo> Usuarios { get; set; }
    }
}
