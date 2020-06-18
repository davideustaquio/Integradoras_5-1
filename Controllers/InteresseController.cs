using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CaoLendario.Models;

namespace CaoLendario.Controllers
{
    public class InteresseController : Controller
    {
        private ApplicationDbContext context;
        private IInteresseRepositorio repositorio;

        public InteresseController(IInteresseRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        public IActionResult ObterInteresse(int id)
        {
            var interesse = repositorio.ObterInteresse(id);
            return View(interesse);
        }
    }
}
