namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AGENTS")]
    public partial class AGENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AGENT()
        {
            AGENT_ARTICLES = new HashSet<AGENT_ARTICLES>();
            BADMINTON_PLAYERS = new HashSet<BADMINTON_PLAYERS>();
            BADMINTON_PLAYERS1 = new HashSet<BADMINTON_PLAYERS>();
            BASEBALL_PLAYERS = new HashSet<BASEBALL_PLAYERS>();
            BASEBALL_PLAYERS1 = new HashSet<BASEBALL_PLAYERS>();
            BASKETBALL_PLAYERS = new HashSet<BASKETBALL_PLAYERS>();
            BASKETBALL_PLAYERS1 = new HashSet<BASKETBALL_PLAYERS>();
            CRICKET_PLAYERS = new HashSet<CRICKET_PLAYERS>();
            CRICKET_PLAYERS1 = new HashSet<CRICKET_PLAYERS>();
            FOOTBALL_PLAYERS = new HashSet<FOOTBALL_PLAYERS>();
            FOOTBALL_PLAYERS1 = new HashSet<FOOTBALL_PLAYERS>();
            GOLF_PLAYERS = new HashSet<GOLF_PLAYERS>();
            GOLF_PLAYERS1 = new HashSet<GOLF_PLAYERS>();
            HOCKEY_PLAYERS = new HashSet<HOCKEY_PLAYERS>();
            HOCKEY_PLAYERS1 = new HashSet<HOCKEY_PLAYERS>();
            NOTIFICATIONS = new HashSet<NOTIFICATION>();
            TENNIS_PLAYERS = new HashSet<TENNIS_PLAYERS>();
            TENNIS_PLAYERS1 = new HashSet<TENNIS_PLAYERS>();
            TICKET_VENDORS = new HashSet<TICKET_VENDORS>();
            TICKET_VENDORS1 = new HashSet<TICKET_VENDORS>();
            TOURNAMENTS = new HashSet<TOURNAMENT>();
            TOURNAMENTS1 = new HashSet<TOURNAMENT>();
            USER_ARTICLES = new HashSet<USER_ARTICLES>();
            VOLLEYBALL_PLAYERS = new HashSet<VOLLEYBALL_PLAYERS>();
            VOLLEYBALL_PLAYERS1 = new HashSet<VOLLEYBALL_PLAYERS>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FIRST_NAME { get; set; }

        [StringLength(100)]
        public string MIDDLE_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string LAST_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string CONTACT { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL_ID { get; set; }

        public DateTime CREATED_DT { get; set; }

        public int CREATED_BY { get; set; }

        public DateTime? UPDATED_DT { get; set; }

        public int? UPDATED_BY { get; set; }

        public int SPORT_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENT_ARTICLES> AGENT_ARTICLES { get; set; }

        public virtual MANAGER MANAGER { get; set; }

        public virtual MANAGER MANAGER1 { get; set; }

        public virtual SPORT SPORT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BADMINTON_PLAYERS> BADMINTON_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BADMINTON_PLAYERS> BADMINTON_PLAYERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASEBALL_PLAYERS> BASEBALL_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASEBALL_PLAYERS> BASEBALL_PLAYERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASKETBALL_PLAYERS> BASKETBALL_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASKETBALL_PLAYERS> BASKETBALL_PLAYERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRICKET_PLAYERS> CRICKET_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRICKET_PLAYERS> CRICKET_PLAYERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FOOTBALL_PLAYERS> FOOTBALL_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FOOTBALL_PLAYERS> FOOTBALL_PLAYERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GOLF_PLAYERS> GOLF_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GOLF_PLAYERS> GOLF_PLAYERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCKEY_PLAYERS> HOCKEY_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCKEY_PLAYERS> HOCKEY_PLAYERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICATION> NOTIFICATIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TENNIS_PLAYERS> TENNIS_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TENNIS_PLAYERS> TENNIS_PLAYERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKET_VENDORS> TICKET_VENDORS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKET_VENDORS> TICKET_VENDORS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURNAMENT> TOURNAMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURNAMENT> TOURNAMENTS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_ARTICLES> USER_ARTICLES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOLLEYBALL_PLAYERS> VOLLEYBALL_PLAYERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOLLEYBALL_PLAYERS> VOLLEYBALL_PLAYERS1 { get; set; }
    }
}
