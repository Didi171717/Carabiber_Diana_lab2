using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Carabiber_Diana_la2.Models;

namespace Carabiber_Diana_la2.Data
{
    public class Carabiber_Diana_la2Context : DbContext
    {
        public Carabiber_Diana_la2Context (DbContextOptions<Carabiber_Diana_la2Context> options)
            : base(options)
        {
        }

        public DbSet<Carabiber_Diana_la2.Models.Book> Book { get; set; } = default!;

        public DbSet<Carabiber_Diana_la2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Carabiber_Diana_la2.Models.Author>? Author { get; set; }
    }
}
