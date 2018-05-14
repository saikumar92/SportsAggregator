namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOCKEY_PLAYERS
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

        public int GOALS { get; set; }

        public int ASSISTS { get; set; }

        public int POINTS { get; set; }

        public int PENALITIES_IN_MINS { get; set; }

        public int SHOTS_ON_GOAL { get; set; }

        public int GAME_WINNING_GOALS { get; set; }

        public int POINT_SHARES { get; set; }

        public int CREATED_BY { get; set; }

        public DateTime CREATED_DT { get; set; }

        public int? UPDATED_BY { get; set; }

        public DateTime? UPDATED_DT { get; set; }

        public virtual AGENT AGENT { get; set; }

        public virtual AGENT AGENT1 { get; set; }

        public virtual COUNTRy COUNTRy1 { get; set; }
    }
}
