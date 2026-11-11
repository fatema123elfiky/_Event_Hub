using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Configurations
{
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");
            builder.HasKey(e => e.EID);
            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.MaxNumberOfAttendees)
                .IsRequired();
            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(e => e.Conference)
                   .WithMany()
                   .HasForeignKey(e => e.ConfEID)
                   .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
