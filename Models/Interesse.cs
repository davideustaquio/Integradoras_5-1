using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{
<<<<<<< HEAD

        public class Interesse
        {
            private int interesseID;
            private DateTime data;
            private Boolean adotado;

            public int InteresseID { get; set; }
            public DateTime Data { get; set; }
            public Boolean Adotado { get; set; }

            public int AnimalID { get; set; }
            public Animal Animal { get; set; }
            public int AdotanteID { get; set; }
            public Adotante Adotante { get; set; }
        }
=======
    public class Interesse: Adotante
    {
        private DateTime data;
        private Boolean adotado;

        public DateTime Data { get; set; }
        public Boolean Adotado { get; set; }
    }
>>>>>>> 348aaf1f31a26135e5f69a30113ea44453141028
}
