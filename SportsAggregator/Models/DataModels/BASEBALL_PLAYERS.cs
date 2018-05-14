namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BASEBALL_PLAYERS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string LAST_NAME { get; set; }

        public int COUNTRY { get; set; }

        public int AT_BATS { get; set; }

        public int RUNS { get; set; }

        public int HITS { get; set; }

        public int RUNS_BATTED_IN { get; set; }

        public int BASE_ON_BALLS { get; set; }

        public int BATTING_AVG { get; set; }

        public int CREATED_BY { get; set; }

        public DateTime CREATED_DT { get; set; }

        public int? UPDATED_BY { get; set; }

        public DateTime? UPDATED_DT { get; set; }

        public virtual AGENT AGENT { get; set; }

        public virtual AGENT AGENT1 { get; set; }

        public virtual COUNTRy COUNTRy1 { get; set; }
    }
}
