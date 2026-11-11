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
    internal class RegisterConfiguration : IEntityTypeConfiguration<Register>
    {
        public void Configure(EntityTypeBuilder<Register> builder)
        {
            builder.ToTable("Registers");
            builder.HasKey( r => new { r.EventId, r.AttendeeId });
            builder.HasOne(r => r.Event)
                   .WithMany(e => e.Registers)
                   .HasForeignKey(r => r.EventId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(r => r.Attendee)
                    .WithMany(a => a.Registers)
                    .HasForeignKey(r => r.AttendeeId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
