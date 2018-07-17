using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblConta")]
    public class Conta : IDatatype
    {
        //[Key]
        //[Column("IdConta", TypeName = "int", Order = 1)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Nome da conta")]
        public string Descricao { get; set; }

        //[Key]
        //[Column("TblUsuario_IdUsuario", TypeName = "int", Order = 2)]
        public int IdUsuarioId { get; set; }
        //[ForeignKey("TblUsuario_IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public int ConfiguracaoContaId { get; set; }
        public virtual ConfiguracaoConta ConfiguracaoConta { get; set; }

        //public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}
