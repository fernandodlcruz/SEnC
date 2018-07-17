using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblFornecedor")]
    public class Fornecedor : IDatatype
    {
        //[Key]
        //[Column("IdFornecedor", TypeName = "int", Order = 1)]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        //[Key]
        //[Column("TblUsuario_IdUsuario", TypeName = "int", Order = 2)]
        public int UsuarioId { get; set; }
        //[ForeignKey("TblUsuario_IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        //public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}
