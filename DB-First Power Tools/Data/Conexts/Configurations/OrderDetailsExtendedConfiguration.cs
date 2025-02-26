﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DB_First_Power_Tools.Data.Conexts;
using DB_First_Power_Tools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DB_First_Power_Tools.Data.Conexts.Configurations
{
    public partial class OrderDetailsExtendedConfiguration : IEntityTypeConfiguration<OrderDetailsExtended>
    {
        public void Configure(EntityTypeBuilder<OrderDetailsExtended> entity)
        {
            entity
                .HasNoKey()
                .ToView("Order Details Extended");

            entity.Property(e => e.ExtendedPrice).HasColumnType("money");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(40);
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrderDetailsExtended> entity);
    }
}
