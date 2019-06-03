using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class SwitchesContext : DbContext
    {
        public SwitchesContext(DbContextOptions<SwitchesContext> options) : base(options)
        {
        }
        public DbSet<Mountain> Mountains { get; set; }
    }
}