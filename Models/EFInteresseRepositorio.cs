using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;

namespace CaoLendario.Models
{
    public class EFInteresseRepositorio:IInteresseRepositorio
=======

namespace CaoLendario.Models
{
    public class EFInteresseRepositorio
>>>>>>> 348aaf1f31a26135e5f69a30113ea44453141028
    {
        public ApplicationDbContext context;

        public EFInteresseRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }
<<<<<<< HEAD
        public IQueryable<Interesse> Interesses => context.Interesse
        .Include(a => a.Adotante);

        

=======
        public IQueryable<Interesse> Interesse => context.Interesse
        .Include(a => a.Adotante);
>>>>>>> 348aaf1f31a26135e5f69a30113ea44453141028
        public void Create(Interesse interesse)
        {
            context.Add(interesse);
            context.SaveChanges();
        }

        public Interesse ObterInteresse(int id)
        {
            var interesse = context.Interesse
            .Include(a => a.Adotante)
           .FirstOrDefault(i => i.InteresseID == id);
            return interesse;
        }
        public void Edit(Interesse interesse)
        {
            context.Entry(interesse).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(Interesse interesse)
        {
            context.Remove(interesse);
            context.SaveChanges();
        }
    }
}
