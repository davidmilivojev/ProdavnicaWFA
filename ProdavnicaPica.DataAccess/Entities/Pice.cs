using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdavnicaPica.DataAccess.Entities
{
    [Table("Pice")]
    public class Pice
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Naziv { get; set; }

        public int Kolicina { get; set; }

        public decimal Cena { get; set; }

        public virtual ICollection<Prodaja> Prodajas { get; set; }
    }
}
