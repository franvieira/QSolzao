using System;
using System.Collections.Generic;
using System.Text;

namespace QSolzao.Domain.Entity
{
    public class Cambista
    {
        public Cambista()
        {
           
        }

        public int CambistaId { get; set; }
        public string Nome { get; set; }

        public int cpf { get; set; }
    }

}
