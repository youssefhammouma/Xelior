using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xelior.Models;

    public class DataBaseContext : DbContext
    {
        public DataBaseContext (DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        public DbSet<Xelior.Models.TaskItem> TaskItem { get; set; }

        public DbSet<Xelior.Models.JalonItem> JalonItem { get; set; }

        public DbSet<Xelior.Models.ExigenceItem> ExigenceItem { get; set; }
        
        public DbSet<Xelior.Models.UserItem> UserItems { get; set; }
        public DbSet<Xelior.Models.TodoItem> TodoItems { get; set; }
        public DbSet<Xelior.Models.ProjectItem> ProjectItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskItem>()
                .HasOne<UserItem>()
                .WithMany()
                .HasForeignKey(task => task.UserId);
            
            modelBuilder.Entity<JalonItem>()
                .HasOne<TaskItem>()
                .WithMany()
                .HasForeignKey(jalon => jalon.TaskId);
            
            modelBuilder.Entity<JalonItem>()
                .HasOne<ExigenceItem>()
                .WithMany()
                .HasForeignKey(jalon => jalon.ExigenceId);
            
            modelBuilder.Entity<ProjectItem>()
                .HasOne<JalonItem>()
                .WithMany()
                .HasForeignKey(project => project.JalonId);
        }
    }
