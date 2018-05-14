namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROLES")]
    public partial class ROLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROLE()
        {
            LOGIN_PROFILE = new HashSet<LOGIN_PROFILE>();
        }

        public int ID { get; set; }

        [Column("ROLE")]
        [Required]
        [StringLength(20)]
        public string ROLE1 { get; set; }

        [Required]
        [StringLength(400)]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGIN_PROFILE> LOGIN_PROFILE { get; set; }
    }
}
