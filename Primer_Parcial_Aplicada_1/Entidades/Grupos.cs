using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial_Aplicada_1.Entidades
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public Decimal Cantidad { get; set; }
        public Decimal Cantidad_Grupos { get; set; }
        public string Integrantes { get; set; }


        public Grupos(int grupoId, DateTime fecha, string descripcion, Decimal cantidad, Decimal cantidad_Grupos, string integrantes)
        {
            GrupoId = grupoId;
            Fecha = fecha;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Cantidad_Grupos = cantidad_Grupos;
            Integrantes = integrantes;

        }

        public Grupos()
        {
            this.GrupoId = 0;
            Fecha = DateTime.Now;
            this.Descripcion = string.Empty;
            this.Cantidad = 0;
            this.Cantidad_Grupos = 0;
            this.Integrantes = string.Empty;
        }
    }
}
