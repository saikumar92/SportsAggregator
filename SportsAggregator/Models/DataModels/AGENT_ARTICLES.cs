namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AGENT_ARTICLES
    {
        public int ID { get; set; }

        public int SPORT_ID { get; set; }

        [Required]
        [StringLength(500)]
        public string TITLE { get; set; }

        [Required]
        [StringLength(4000)]
        public string DESCRIPTION1 { get; set; }

        [StringLength(4000)]
        public string DESCRIPTION2 { get; set; }

        [StringLength(4000)]
        public string DOCUMENT1 { get; set; }

        [StringLength(4000)]
        public string DOCUMENT2 { get; set; }

        [StringLength(4000)]
        public string IMAGE1 { get; set; }

        public int POSTED_BY { get; set; }

        public DateTime POSTED_DT { get; set; }

        public virtual AGENT AGENT { get; set; }

        public virtual SPORT SPORT { get; set; }
    }
}
