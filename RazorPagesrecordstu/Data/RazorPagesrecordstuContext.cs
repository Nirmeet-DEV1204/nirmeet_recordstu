#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesrecordstu.Models;

    public class RazorPagesrecordstuContext : DbContext
    {
        public RazorPagesrecordstuContext (DbContextOptions<RazorPagesrecordstuContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesrecordstu.Models.recordstu> recordstu { get; set; }
    }
