using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEnC.Datatypes
{
    //[Table("TblStatus")]
    public class Status : IDatatype
    {
        //[Key]
        //[Column("IdStatus", TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        [Display(Name = "Descrição do status")]
        public string Descricao { get; set; }
    }
}
