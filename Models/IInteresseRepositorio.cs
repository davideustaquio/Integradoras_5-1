using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{
    interface IInteresseRepositorio
    {
<<<<<<< HEAD
        IQueryable<Interesse> Interesses { get; set; }
=======
        IQueryable<Interesse> Interesses { get; }
>>>>>>> 348aaf1f31a26135e5f69a30113ea44453141028

        public void Create(Interesse interesse);
        public Interesse ObterInteresse(int id);
        public void Edit(Interesse interesse);
        public void Delete(Interesse interesse);
    }
}
