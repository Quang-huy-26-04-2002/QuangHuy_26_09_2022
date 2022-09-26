using DangQuangHuy_CourseSignupSysten.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DangQuangHuy_CourseSignupSysten.Configurations
{
    public class DangNhap : IEntityTypeConfiguration<dangnhap>
    {
        public void Configure(EntityTypeBuilder<dangnhap> builder)
        {
            builder.ToTable("dangnhap");

            builder.HasKey(x => x.username);

            builder.Property(x => x.Value).IsRequired(true);
        }
    }

}