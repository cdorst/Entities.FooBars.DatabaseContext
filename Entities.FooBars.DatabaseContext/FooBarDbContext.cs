// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.EntityFrameworkCore;

namespace Entities.FooBars.DatabaseContext
{
    /// <summary>EntityFrameworkCore database context for FooBar entities</summary>
    public class FooBarDbContext : DbContext
    {
        /// <summary>Constructs FooBarDbContext EntityFrameworkCore database context using given options</summary>
        public FooBarDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>Contains set of FooBar entities</summary>
        public DbSet<FooBar> FooBars { get; set; }
    }
}
