namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOURNAMENTS")]
    public partial class TOURNAMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOURNAMENT()
        {
            TICKET_VENDORS = new HashSet<TICKET_VENDORS>();
        }

        public int ID { get; set; }

        public int SPORT_ID { get; set; }

        [Required]
        [StringLength(500)]
        public string NAME { get; set; }

        public int COUNTRY { get; set; }

        public int NO_OF_MATCHES { get; set; }

        [Column(TypeName = "date")]
        public DateTime START_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime END_DATE { get; set; }

        public int CREATED_BY { get; set; }

        public DateTime CREATED_DT { get; set; }

        public int? UPDATED_BY { get; set; }

        public DateTime? UPDATED_DT { get; set; }

        public virtual AGENT AGENT { get; set; }

        public virtual AGENT AGENT1 { get; set; }

        public virtual COUNTRy COUNTRy1 { get; set; }

        public virtual SPORT SPORT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKET_VENDORS> TICKET_VENDORS { get; set; }
    }
}
