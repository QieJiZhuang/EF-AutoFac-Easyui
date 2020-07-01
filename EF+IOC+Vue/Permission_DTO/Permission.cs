namespace Permission_DTO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Permission : DbContext
    {
        public Permission()
            : base("name=Permission")
        {
        }

        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Operation> Operation { get; set; }
        public virtual DbSet<Permission_Info> Permission_Info { get; set; }
        public virtual DbSet<Permission_Menu> Permission_Menu { get; set; }
        public virtual DbSet<Permission_Operation> Permission_Operation { get; set; }
        public virtual DbSet<Role_Info> Role_Info { get; set; }
        public virtual DbSet<Role_Permission> Role_Permission { get; set; }
        public virtual DbSet<User_Info> User_Info { get; set; }
        public virtual DbSet<User_Role> User_Role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Operation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Operation>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Operation>()
                .Property(e => e.Method)
                .IsUnicode(false);

            modelBuilder.Entity<Operation>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Permission_Info>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Role_Info>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User_Info>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<User_Info>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<User_Info>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<User_Info>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User_Info>()
                .Property(e => e.Creater)
                .IsUnicode(false);
        }
    }
}
