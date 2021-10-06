using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VuThiThuyTrang218.Models;
using VuThiThuyTrang218.Data;

namespace VuThiThuyTrang218.Data
{
public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<PersonVTTT218> PersonVTTT218 { get; set; }
    }
}
