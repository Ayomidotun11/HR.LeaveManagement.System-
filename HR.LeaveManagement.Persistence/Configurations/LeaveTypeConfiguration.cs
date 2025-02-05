﻿using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Configurations
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.HasData(
               new LeaveType
               {
                   Id = 1,
                   Name = "Vacation",
                   DefaultDays = 10,
                   DateCreated = new DateTime(2025, 02, 1), // Use a static date
                   DateModified = new DateTime(2025, 02, 1) // Use a static date
               }
           );

            builder.Property(q => q.Name)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}
