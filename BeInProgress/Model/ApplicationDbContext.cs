using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Auth;


namespace BeInProgress.Model
{
    public class ApplicationDbContext : IdentityDbContext< User >
    {
        public ApplicationDbContext( DbContextOptions< ApplicationDbContext > options ) : base( options )
        {

        }

        public DbSet  <BookItem> BookItems { get; set; }
        protected override void OnModelCreating( ModelBuilder builder )
        {
            builder.Entity<BookItem>(entity =>
           {
               entity.Property(e => e.Name)
               .IsRequired()
               .HasMaxLength( 200 );

               entity.Property( e => e.Author )
               .IsRequired( false )
               .HasMaxLength( 100 );

               entity.Property(e => e.Genre)
               .IsRequired(false);
 
               entity.Property( e => e.Description )
               .IsRequired( false )
               .HasMaxLength(200);

               entity.Property(e => e.Status)
               .IsRequired()
               .HasMaxLength(1);
           });
            base.OnModelCreating( builder );
        }
    }
}