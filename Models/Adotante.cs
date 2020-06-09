﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{
    public class Adotante : User
    {
        private enum tipoMoradia { Casa, Apartamento, Sítio, Outros }
        private enum prefPorte {Pequeno, Médio, Grande, Indiferente  }
        private enum prefFilhote { Sim, Não, Indiferente }
        private enum prefCastrado { Sim, Não, Indiferente }
        private enum prefSexo { Fêmea, Macho}
        private enum alimentacao { Ração, Comida, Ambos, Outro}
        private ICollection<ProcedimentosPosAdocao> procedimentosPosAdocaos { get; set; }
        private ICollection<ProcedimentosPreAdocao> procedimentosPreAdocaos { get; set; }
        private ICollection<Interesse> interesses { get; set; }

    }
}
