using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblPeriodicidade")]
    public class Periodicidade : IDatatype
    {
        //[Key]
        //[Column("IdPeriodicidade", TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        [Display(Name = "Descrição da periodicidade")]
        public string Descricao { get; set; }

        [Display(Name = "Percentual de desconto")]
        [Range(0.01, 100.00, ErrorMessage = "Percentual de desconto não ultrapassa 100%")]
        [RegularExpression(@"\d+(.\d{1,2})?", ErrorMessage = "Valor inválido")]
        public decimal PercentualDesconto { get; set; }

        //[Display(Name = "Planos de pagamentos")]
        //public virtual ICollection<Plano> Planos { get; set; }
    }
}
