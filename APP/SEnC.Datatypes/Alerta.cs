using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblAlerta")]
    public class Alerta : IDatatype
    {
        //[Key]
        //[Column("IdAlerta", TypeName = "int", Order = 1)]
        public int Id { get; set; }

        public string TipoAlerta { get; set; }

        //[Key]
        //[Column("TblUsuario_IdUsuario", TypeName = "int", Order = 2)]
        public int UsuarioId { get; set; }
        //[ForeignKey("TblUsuario_IdUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
