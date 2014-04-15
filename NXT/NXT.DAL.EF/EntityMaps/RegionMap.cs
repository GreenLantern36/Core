﻿using NXT.DAL.Entities.Regions;
using System.Data.Entity.ModelConfiguration;

namespace NXT.DAL.EF.EntityMaps
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Identifier);

            HasMany(x => x.RegionNames)
                .WithRequired(x => x.Owner)
                .HasForeignKey(x => x.OwnerId);

            ToTable("regions");
        }
    }
}
