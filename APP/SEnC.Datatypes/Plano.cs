using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblPlanos")]
    public class Plano : IDatatype
    {
        //[Key]
        //[Column("IdPlanos", TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Descrição do plano")]
        public string Descricao { get; set; }

        [Display(Name = "Valor do plano")]
        [RegularExpression(@"\d+(.\d{1,2})?", ErrorMessage = "Valor inválido")]
        public decimal Valor { get; set; }

        [Display(Name = "Periodicidade")]
        public int PeriodicidadeId { get; set; }
        //[ForeignKey("TblPeriodicidade_IdPeriodicidade")]
        public virtual Periodicidade Periodicidade { get; set; }

        //public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
