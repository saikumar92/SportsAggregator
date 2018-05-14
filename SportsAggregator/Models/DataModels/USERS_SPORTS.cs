namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERS_SPORTS
    {
        public int ID { get; set; }

        public int USER_ID { get; set; }

        public int SPORT_ID { get; set; }

        public DateTime CREATED_DT { get; set; }

        public virtual SPORT SPORT { get; set; }

        public virtual USER USER { get; set; }
    }
}
