namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COUNTRIES")]
    public partial class COUNTRy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COUNTRy()
        {
            BADMINTON_PLAYERS = new HashSet<BADMINTON_PLAYERS>();
            BASEBALL_PLAYERS = new HashSet<BASEBALL_PLAYERS>();
            BASKETBALL_PLAYERS = new HashSet<BASKETBALL_PLAYERS>();
            CRICKET_PLAYERS = new HashSet<CRICKET_PLAYERS>();
            FOOTBALL_PLAYERS = new HashSet<FOOTBALL_PLAYERS>();
            GOLF_PLAYERS = new HashSet<GOLF_PLAYERS>();
            HOCKEY_PLAYERS = new HashSet<HOCKEY_PLAYERS>();
            TENNIS_PLAYERS = new HashSet<TENNIS_PLAYERS>();
            TOURNAMENTS = new HashSet<TOURNAMENT>();
            USERS = new HashSet<USER>();
            VOLLEYBALL_PLAYERS = new HashSet<VOLLEYBALL_PLAYERS>();
        }

        public int ID { get; set; }

        [Column("COUNTRY")]
        [Required]
        [StringLength(40)]
        public string COUNTRY1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BADMINTON_PLAYERS> BADMINTON_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASEBALL_PLAYERS> BASEBALL_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASKETBALL_PLAYERS> BASKETBALL_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRICKET_PLAYERS> CRICKET_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FOOTBALL_PLAYERS> FOOTBALL_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GOLF_PLAYERS> GOLF_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCKEY_PLAYERS> HOCKEY_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TENNIS_PLAYERS> TENNIS_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURNAMENT> TOURNAMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER> USERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOLLEYBALL_PLAYERS> VOLLEYBALL_PLAYERS { get; set; }
    }
}
