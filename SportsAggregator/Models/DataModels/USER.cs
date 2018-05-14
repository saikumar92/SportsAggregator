namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERS")]
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            LOGIN_PROFILE = new HashSet<LOGIN_PROFILE>();
            USER_ARTICLES = new HashSet<USER_ARTICLES>();
            USERS_SPORTS = new HashSet<USERS_SPORTS>();
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
        [StringLength(200)]
        public string ADDRESS_LINE_1 { get; set; }

        [StringLength(200)]
        public string ADDRESS_LINE_2 { get; set; }

        [Required]
        [StringLength(40)]
        public string CITY { get; set; }

        [Required]
        [StringLength(40)]
        public string STATE { get; set; }

        public int COUNTRY { get; set; }

        public int ZIPCODE { get; set; }

        [StringLength(20)]
        public string CONTACT { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL_ID { get; set; }

        public DateTime CREATED_DT { get; set; }

        public DateTime? UPDATED_DT { get; set; }

        public virtual COUNTRy COUNTRy1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGIN_PROFILE> LOGIN_PROFILE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_ARTICLES> USER_ARTICLES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERS_SPORTS> USERS_SPORTS { get; set; }
    }
}
