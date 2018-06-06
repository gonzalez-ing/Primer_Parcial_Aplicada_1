using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primer_Parcial_Aplicada_1.BLL;
using Primer_Parcial_Aplicada_1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial_Aplicada_1.BLL.Tests
{
    [TestClass()]
    public class GruposBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Grupos Grupo = new Grupos();
            Grupo.GrupoId = 0;
            Grupo.Descripcion = "Aplicada";
            Grupo.Cantidad = 0;
            Grupo.Cantidad_Grupos = 0;

            bool pase = BLL.GruposBLL.Guardar(Grupo);
            Assert.AreEqual(pase,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Grupos Grupo = new Grupos();
            Grupo.GrupoId = 1;
            Grupo.Descripcion = "Aplicada1";
            Grupo.Cantidad = 1;
            Grupo.Cantidad_Grupos = 1;

            bool pase = BLL.GruposBLL.Modificar(Grupo);
            Assert.AreEqual(pase, true);

        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool pase = BLL.GruposBLL.Eliminar(1);
            Assert.AreEqual(pase, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Grupos Grupo = new Grupos();
            Grupo = BLL.GruposBLL.Buscar(2);
            Assert.IsNotNull(Grupo);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}