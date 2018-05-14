namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NOTIFICATIONS")]
    public partial class NOTIFICATION
    {
        public int ID { get; set; }

        [Column("NOTIFICATION")]
        [Required]
        [StringLength(4000)]
        public string NOTIFICATION1 { get; set; }

        public DateTime CREATED_DT { get; set; }

        public int CREATED_BY { get; set; }

        public int SPORT_ID { get; set; }

        public virtual AGENT AGENT { get; set; }

        public virtual SPORT SPORT { get; set; }
    }
}
