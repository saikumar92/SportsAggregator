namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MANAGERS")]
    public partial class MANAGER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MANAGER()
        {
            AGENTS = new HashSet<AGENT>();
            AGENTS1 = new HashSet<AGENT>();
            SPORTS = new HashSet<SPORT>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FIRST_NAME { get; set; }

        [StringLength(100)]
        public string MIDDLE_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string LAST_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string CONTACT { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENT> AGENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENT> AGENTS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPORT> SPORTS { get; set; }
    }
}
