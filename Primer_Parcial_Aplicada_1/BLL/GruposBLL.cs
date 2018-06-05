using Primer_Parcial_Aplicada_1.DAL;
using Primer_Parcial_Aplicada_1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial_Aplicada_1.BLL
{
    public class GruposBLL
    {
        public static bool Guardar(Grupos Grupo)
        {
            bool pase = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Grupo.Add(Grupo) != null)
                {
                    contexto.SaveChanges();
                    pase = true;
                }

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return pase;
        }

        public static bool Modificar(Grupos Grupo)
        {
            bool pase = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Grupo).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    pase = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return pase;
        }

        public static bool Eliminar(int id)
        {
            bool pase = false;

            Contexto contexto = new Contexto();
            try
            {
                Grupos Grupo = contexto.Grupo.Find(id);

                contexto.Grupo.Remove(Grupo);

                if (contexto.SaveChanges() > 0)
                {
                    pase = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return pase;
        }

        public static Grupos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Grupos Grupo = new Grupos();
            try
            {
                Grupo = contexto.Grupo.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return Grupo;
        }

        public static List<Grupos> GetList(Expression<Func<Grupos, bool>> expression)
        {
            List<Grupos> Grupos = new List<Grupos>();
            Contexto contexto = new Contexto();
            try
            {
                Grupos = contexto.Grupo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return Grupos;
        }
    }
}
