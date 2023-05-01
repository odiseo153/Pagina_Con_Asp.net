
using CursoMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Contexto
{
    public class LasTablas : DbContext
    {
        public LasTablas(DbContextOptions<LasTablas> options) : base(options)
        {


        }




        public DbSet<Pelis> pelis { get; set; }




    }
}
