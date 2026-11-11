using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Configurations
{
    internal class AttendeeConfiguration : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Attendee> builder)
        {
            builder.ToTable("Attendees");
            builder.HasKey(a => a.AID);
            builder.Property(a => a.FullName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(a => a.Address);
        }
    }
}
