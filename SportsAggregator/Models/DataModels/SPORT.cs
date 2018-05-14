namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPORTS")]
    public partial class SPORT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SPORT()
        {
            AGENT_ARTICLES = new HashSet<AGENT_ARTICLES>();
            AGENTS = new HashSet<AGENT>();
            NOTIFICATIONS = new HashSet<NOTIFICATION>();
            TOURNAMENTS = new HashSet<TOURNAMENT>();
            USER_ARTICLES = new HashSet<USER_ARTICLES>();
            USERS_SPORTS = new HashSet<USERS_SPORTS>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(40)]
        public string NAME { get; set; }

        public DateTime CREATED_DT { get; set; }

        public int CREATED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENT_ARTICLES> AGENT_ARTICLES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENT> AGENTS { get; set; }

        public virtual MANAGER MANAGER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICATION> NOTIFICATIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURNAMENT> TOURNAMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_ARTICLES> USER_ARTICLES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERS_SPORTS> USERS_SPORTS { get; set; }
    }
}
