using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BaseEntity
    {

        public BaseEntity()
        {
            CreatedAt = DateTime.Now;
            IsActived = true;
        }

        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }


        [Column(TypeName = "datetime2")]
        public DateTime CreatedAt { get; set; }


        public bool IsActived { get; set; }
    }
}
