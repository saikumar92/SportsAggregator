namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOGIN_PROFILE
    {
        [Required]
        [StringLength(20)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string PASSWORD { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USERID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROLE_ID { get; set; }

        [StringLength(100)]
        public string LOGINSTATUS { get; set; }

        public DateTime? LASTLOGINDATE { get; set; }

        public int NO_OF_LOGINS { get; set; }

        public virtual ROLE ROLE { get; set; }

        public virtual USER USER { get; set; }
    }
}
