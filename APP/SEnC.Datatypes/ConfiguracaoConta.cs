using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblConfiguracaoConta")]
    public class ConfiguracaoConta : IDatatype
    {
        //[Key]
        //[Column("IdConfiguracaoConta", TypeName = "int", Order = 1)]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Imagem { get; set; }

        [Display(Name = "Dia de fechamento da fatura")]
        public int DiaFechamento { get; set; }

        [Display(Name = "Dia de vencimento da fatura")]
        public int DiaVencimento { get; set; }

        //public int TblConta_IdConta { get; set; }
        //public int TblConta_TblUsuario_IdUsuario { get; set; }
        //[ForeignKey("TblConta_IdConta,TblConta_TblUsuario_IdUsuario")]
        //public virtual ContaVo Conta { get; set; }

        //[InverseProperty("ConfiguracaoConta")] // <- Navigation property name in EntityA
        //public virtual ICollection<ContaVo> Contas { get; set; }
    }
}
