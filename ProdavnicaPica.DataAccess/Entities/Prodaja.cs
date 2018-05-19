using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdavnicaPica.DataAccess.Entities
{

    [Table("Prodaja")]
    public partial class Prodaja
    {
        public int ID { get; set; }

        public int OperaterId { get; set; }

        public int PiceId { get; set; }

        public DateTime Vreme { get; set; }

        public virtual Operater Operater { get; set; }

        public virtual Pice Pice { get; set; }
    }
}
