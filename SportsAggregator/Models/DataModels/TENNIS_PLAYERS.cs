namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TENNIS_PLAYERS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string LAST_NAME { get; set; }

        public int COUNTRY { get; set; }

        public int NO_OF_GAMES { get; set; }

        public int WON { get; set; }

        public int LOST { get; set; }

        public int ACES { get; set; }

        public int SERVE_SPEED_MPH { get; set; }

        public int DOUBLE_FAULTS { get; set; }

        public int FSRP { get; set; }

        public int SSRP { get; set; }

        public int BPW { get; set; }

        public int LRC { get; set; }

        public int CREATED_BY { get; set; }

        public DateTime CREATED_DT { get; set; }

        public int? UPDATED_BY { get; set; }

        public DateTime? UPDATED_DT { get; set; }

        public virtual AGENT AGENT { get; set; }

        public virtual AGENT AGENT1 { get; set; }

        public virtual COUNTRy COUNTRy1 { get; set; }
    }
}
