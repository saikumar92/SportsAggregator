namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TICKET_VENDORS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME { get; set; }

        public int TOURNAMENT_ID { get; set; }

        [Required]
        [StringLength(2000)]
        public string URL { get; set; }

        public DateTime CREATED_DT { get; set; }

        public int CREATED_BY { get; set; }

        public DateTime? UPDATED_DT { get; set; }

        public int? UPDATED_BY { get; set; }

        public virtual AGENT AGENT { get; set; }

        public virtual AGENT AGENT1 { get; set; }

        public virtual TOURNAMENT TOURNAMENT { get; set; }
    }
}
