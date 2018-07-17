using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblPagamento")]
    public class Pagamento : IDatatype
    {
        //[Key]
        //[Column("IdPagamento", TypeName = "int")]
        public int Id { get; set; }
        public string Chave { get; set; }
        public DateTime DataPagamento { get; set; }
        public string FormaPagamento { get; set; }
        public decimal Valor { get; set; }
        public string FlagPagamento { get; set; }

        public int UsuarioId { get; set; }
        //[ForeignKey("TblUsuario_IdUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
