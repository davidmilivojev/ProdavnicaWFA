using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdavnicaPica.DataAccess.Entities
{


    [Table("Operater")]
    public class Operater
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Ime { get; set; }
        
        public virtual ICollection<Prodaja> Prodajas { get; set; }
    }
}
