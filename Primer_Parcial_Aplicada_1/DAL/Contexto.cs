using Primer_Parcial_Aplicada_1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial_Aplicada_1.DAL
{
        public class Contexto : DbContext
        {
            public Contexto() : base("ConStr")
            {

            }

            public DbSet<Grupos> Grupo { get; set; }
        }
}
