using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblGrupo")]
    public class Grupo : IDatatype
    {
        //[Key]
        //[Column("IdGrupo", TypeName = "int", Order = 1)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Nome do grupo")]
        public string Nome { get; set; }

        //[Key]
        //[Column("TblUsuario_IdUsuario", TypeName = "int", Order = 2)]
        public int UsuarioId { get; set; }
        //[ForeignKey("TblUsuario_IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        [Display(Name = "Grupo superior")]
        public int IdPai { get; set; }
        //[ForeignKey("IdGrupoPai")]
        //public virtual Grupo GrupoPai { get; set; }

        //public virtual ICollection<Grupo> Grupos { get; set; }

        public virtual ICollection<Lancamento> Lancamentos { get; set; }

        public int LancamentosCount { get; set; }
        
    }
}
