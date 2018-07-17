using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblLancamento")]
    public class Lancamento : IDatatype
    {
        //[Key]
        //[Column("IdLancamento", TypeName = "bigint")]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Descrição do lançamento")]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name="Data do gasto")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataLancamento { get; set; }

        //[Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data do pagamento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataContabil { get; set; }

        //[Required]
        [Display(Name = "Tipo de lançamento")]
        public string TipoLancamento { get; set; }

        [Required]
        [Display(Name = "Valor do lançamento")]
        [RegularExpression(@"\d+(.\d{1,2})?", ErrorMessage = "Valor inválido")]
        public decimal ValorLancamento { get; set; }

        //[Display(Name = "Valor da multa")]
        //[RegularExpression(@"\d+(.\d{1,2})?", ErrorMessage = "Valor inválido")]
        //public decimal ValorMulta { get; set; }

        //[Display(Name = "Valor de juros")]
        //[RegularExpression(@"\d+(.\d{1,2})?", ErrorMessage = "Valor inválido")]
        //public decimal ValorJuros { get; set; }

        //[Display(Name = "Valor de desconto")]
        //[RegularExpression(@"\d+(.\d{1,2})?", ErrorMessage = "Valor inválido")]
        //public decimal ValorDesconto { get; set; }

        //[Display(Name = "Total do lançamento")]
        //[RegularExpression(@"\d+(.\d{1,2})?", ErrorMessage = "Valor inválido")]
        //public decimal TotalLancamento { get; set; }

        //[Display(Name = "Observação")]
        //public string Observacao { get; set; }

        //[Display(Name = "Status")]
        //public int StatusId { get; set; }
        ////[ForeignKey("TblStatus_IdStatus")]
        //public virtual Status Status { get; set; }

        //[Display(Name = "Cliente/Fornecedor")]
        //public int FornecedorId { get; set; }
        ////[ForeignKey("TblFornecedor_IdFornecedor")]
        //public virtual Fornecedor Fornecedor { get; set; }

        //[Display(Name = "Conta")]
        //public int ContaId { get; set; }
        ////public int TblConta_TblUsuario_IdUsuario { get; set; }
        ////[ForeignKey("TblConta_IdConta,TblConta_TblUsuario_IdUsuario")]
        //public virtual Conta Conta { get; set; }

        [Display(Name = "Grupo de lançamentos")]
        public int GrupoId { get; set; }
        //public int TblGrupo_TblUsuario_IdUsuario { get; set; }
        //[ForeignKey("TblGrupo_IdGrupo,TblGrupo_TblUsuario_IdUsuario")]
        //public virtual Grupo Grupo { get; set; }
    }
}
