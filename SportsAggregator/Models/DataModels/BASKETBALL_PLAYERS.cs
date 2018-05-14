namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BASKETBALL_PLAYERS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string LAST_NAME { get; set; }

        public int COUNTRY { get; set; }

        public int GAMES_PLAYED { get; set; }

        public int MINUTES_PLAYED { get; set; }

        public int FIELD_GOALS_MADE { get; set; }

        public int FIELD_GOALS_ATTEMPTED { get; set; }

        public int THREE_PM { get; set; }

        public int THREE_PA { get; set; }

        public int FREE_THROWS_MADE { get; set; }

        public int FREE_THROWS_ATTEMPTED { get; set; }

        public int TURNOVERS { get; set; }

        public int PERSONAL_FOULS { get; set; }

        public int OFFENSIVE_REBOUNDS { get; set; }

        public int DEFENSIVE_REBOUNDS { get; set; }

        public int CREATED_BY { get; set; }

        public DateTime CREATED_DT { get; set; }

        public int? UPDATED_BY { get; set; }

        public DateTime? UPDATED_DT { get; set; }

        public virtual AGENT AGENT { get; set; }

        public virtual AGENT AGENT1 { get; set; }

        public virtual COUNTRy COUNTRy1 { get; set; }
    }
}
