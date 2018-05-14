namespace SportsAggregator.Models.DataModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<AGENT_ARTICLES> AGENT_ARTICLES { get; set; }
        public virtual DbSet<AGENT> AGENTS { get; set; }
        public virtual DbSet<BADMINTON_PLAYERS> BADMINTON_PLAYERS { get; set; }
        public virtual DbSet<BASEBALL_PLAYERS> BASEBALL_PLAYERS { get; set; }
        public virtual DbSet<BASKETBALL_PLAYERS> BASKETBALL_PLAYERS { get; set; }
        public virtual DbSet<COUNTRy> COUNTRIES { get; set; }
        public virtual DbSet<CRICKET_PLAYERS> CRICKET_PLAYERS { get; set; }
        public virtual DbSet<FOOTBALL_PLAYERS> FOOTBALL_PLAYERS { get; set; }
        public virtual DbSet<GOLF_PLAYERS> GOLF_PLAYERS { get; set; }
        public virtual DbSet<HOCKEY_PLAYERS> HOCKEY_PLAYERS { get; set; }
        public virtual DbSet<LOGIN_PROFILE> LOGIN_PROFILE { get; set; }
        public virtual DbSet<MANAGER> MANAGERS { get; set; }
        public virtual DbSet<NOTIFICATION> NOTIFICATIONS { get; set; }
        public virtual DbSet<ROLE> ROLES { get; set; }
        public virtual DbSet<SPORT> SPORTS { get; set; }
        public virtual DbSet<TENNIS_PLAYERS> TENNIS_PLAYERS { get; set; }
        public virtual DbSet<TICKET_VENDORS> TICKET_VENDORS { get; set; }
        public virtual DbSet<TOURNAMENT> TOURNAMENTS { get; set; }
        public virtual DbSet<USER_ARTICLES> USER_ARTICLES { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<USERS_SPORTS> USERS_SPORTS { get; set; }
        public virtual DbSet<VOLLEYBALL_PLAYERS> VOLLEYBALL_PLAYERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AGENT_ARTICLES>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT_ARTICLES>()
                .Property(e => e.DESCRIPTION1)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT_ARTICLES>()
                .Property(e => e.DESCRIPTION2)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.MIDDLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.EMAIL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.AGENT_ARTICLES)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.POSTED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.BADMINTON_PLAYERS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.BADMINTON_PLAYERS1)
                .WithOptional(e => e.AGENT1)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.BASEBALL_PLAYERS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.BASEBALL_PLAYERS1)
                .WithOptional(e => e.AGENT1)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.BASKETBALL_PLAYERS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.BASKETBALL_PLAYERS1)
                .WithOptional(e => e.AGENT1)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.CRICKET_PLAYERS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.CRICKET_PLAYERS1)
                .WithOptional(e => e.AGENT1)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.FOOTBALL_PLAYERS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.FOOTBALL_PLAYERS1)
                .WithOptional(e => e.AGENT1)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.GOLF_PLAYERS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.GOLF_PLAYERS1)
                .WithOptional(e => e.AGENT1)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.HOCKEY_PLAYERS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.HOCKEY_PLAYERS1)
                .WithOptional(e => e.AGENT1)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.NOTIFICATIONS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.TENNIS_PLAYERS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.TENNIS_PLAYERS1)
                .WithOptional(e => e.AGENT1)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.TICKET_VENDORS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.TICKET_VENDORS1)
                .WithOptional(e => e.AGENT1)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.TOURNAMENTS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.TOURNAMENTS1)
                .WithOptional(e => e.AGENT1)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.USER_ARTICLES)
                .WithOptional(e => e.AGENT)
                .HasForeignKey(e => e.VALIDATED_BY);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.VOLLEYBALL_PLAYERS)
                .WithRequired(e => e.AGENT)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENT>()
                .HasMany(e => e.VOLLEYBALL_PLAYERS1)
                .WithOptional(e => e.AGENT1)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<BADMINTON_PLAYERS>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BADMINTON_PLAYERS>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASEBALL_PLAYERS>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASEBALL_PLAYERS>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASKETBALL_PLAYERS>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASKETBALL_PLAYERS>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRy>()
                .Property(e => e.COUNTRY1)
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRy>()
                .HasMany(e => e.BADMINTON_PLAYERS)
                .WithRequired(e => e.COUNTRy1)
                .HasForeignKey(e => e.COUNTRY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COUNTRy>()
                .HasMany(e => e.BASEBALL_PLAYERS)
                .WithRequired(e => e.COUNTRy1)
                .HasForeignKey(e => e.COUNTRY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COUNTRy>()
                .HasMany(e => e.BASKETBALL_PLAYERS)
                .WithRequired(e => e.COUNTRy1)
                .HasForeignKey(e => e.COUNTRY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COUNTRy>()
                .HasMany(e => e.CRICKET_PLAYERS)
                .WithRequired(e => e.COUNTRy1)
                .HasForeignKey(e => e.COUNTRY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COUNTRy>()
                .HasMany(e => e.FOOTBALL_PLAYERS)
                .WithRequired(e => e.COUNTRy1)
                .HasForeignKey(e => e.COUNTRY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COUNTRy>()
                .HasMany(e => e.GOLF_PLAYERS)
                .WithRequired(e => e.COUNTRy1)
                .HasForeignKey(e => e.COUNTRY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COUNTRy>()
                .HasMany(e => e.HOCKEY_PLAYERS)
                .WithRequired(e => e.COUNTRy1)
                .HasForeignKey(e => e.COUNTRY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COUNTRy>()
                .HasMany(e => e.TENNIS_PLAYERS)
                .WithRequired(e => e.COUNTRy1)
                .HasForeignKey(e => e.COUNTRY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COUNTRy>()
                .HasMany(e => e.TOURNAMENTS)
                .WithRequired(e => e.COUNTRy1)
                .HasForeignKey(e => e.COUNTRY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COUNTRy>()
                .HasMany(e => e.USERS)
                .WithRequired(e => e.COUNTRy1)
                .HasForeignKey(e => e.COUNTRY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COUNTRy>()
                .HasMany(e => e.VOLLEYBALL_PLAYERS)
                .WithRequired(e => e.COUNTRy1)
                .HasForeignKey(e => e.COUNTRY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRICKET_PLAYERS>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CRICKET_PLAYERS>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<FOOTBALL_PLAYERS>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<FOOTBALL_PLAYERS>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GOLF_PLAYERS>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GOLF_PLAYERS>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<HOCKEY_PLAYERS>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<HOCKEY_PLAYERS>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_PROFILE>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_PROFILE>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_PROFILE>()
                .Property(e => e.LOGINSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<MANAGER>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MANAGER>()
                .Property(e => e.MIDDLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MANAGER>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MANAGER>()
                .Property(e => e.CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<MANAGER>()
                .Property(e => e.EMAIL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<MANAGER>()
                .HasMany(e => e.AGENTS)
                .WithOptional(e => e.MANAGER)
                .HasForeignKey(e => e.UPDATED_BY);

            modelBuilder.Entity<MANAGER>()
                .HasMany(e => e.AGENTS1)
                .WithRequired(e => e.MANAGER1)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MANAGER>()
                .HasMany(e => e.SPORTS)
                .WithRequired(e => e.MANAGER)
                .HasForeignKey(e => e.CREATED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOTIFICATION>()
                .Property(e => e.NOTIFICATION1)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.ROLE1)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .HasMany(e => e.LOGIN_PROFILE)
                .WithRequired(e => e.ROLE)
                .HasForeignKey(e => e.ROLE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SPORT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SPORT>()
                .HasMany(e => e.AGENT_ARTICLES)
                .WithRequired(e => e.SPORT)
                .HasForeignKey(e => e.SPORT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SPORT>()
                .HasMany(e => e.AGENTS)
                .WithRequired(e => e.SPORT)
                .HasForeignKey(e => e.SPORT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SPORT>()
                .HasMany(e => e.NOTIFICATIONS)
                .WithRequired(e => e.SPORT)
                .HasForeignKey(e => e.SPORT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SPORT>()
                .HasMany(e => e.TOURNAMENTS)
                .WithRequired(e => e.SPORT)
                .HasForeignKey(e => e.SPORT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SPORT>()
                .HasMany(e => e.USER_ARTICLES)
                .WithRequired(e => e.SPORT)
                .HasForeignKey(e => e.SPORT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SPORT>()
                .HasMany(e => e.USERS_SPORTS)
                .WithRequired(e => e.SPORT)
                .HasForeignKey(e => e.SPORT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TENNIS_PLAYERS>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TENNIS_PLAYERS>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_VENDORS>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TICKET_VENDORS>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<TOURNAMENT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TOURNAMENT>()
                .HasMany(e => e.TICKET_VENDORS)
                .WithRequired(e => e.TOURNAMENT)
                .HasForeignKey(e => e.TOURNAMENT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER_ARTICLES>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_ARTICLES>()
                .Property(e => e.DESCRIPTION1)
                .IsUnicode(false);

            modelBuilder.Entity<USER_ARTICLES>()
                .Property(e => e.DESCRIPTION2)
                .IsUnicode(false);

            modelBuilder.Entity<USER_ARTICLES>()
                .Property(e => e.VALID_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.MIDDLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.ADDRESS_LINE_1)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.ADDRESS_LINE_2)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.EMAIL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.LOGIN_PROFILE)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.USER_ARTICLES)
                .WithRequired(e => e.USER)
                .HasForeignKey(e => e.POSTED_BY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.USERS_SPORTS)
                .WithRequired(e => e.USER)
                .HasForeignKey(e => e.USER_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VOLLEYBALL_PLAYERS>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<VOLLEYBALL_PLAYERS>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);
        }
    }
}
