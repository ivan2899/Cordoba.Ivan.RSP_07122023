using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Modelos;

namespace MisTest
{
    [TestClass]
    public class TestCocina
    {
        [TestMethod]
        [ExpectedException(typeof(FileManagerException))]
        public void AlGuardarUnArchivo_ConNombreInvalido_TengoUnaExcepcion()
        {
            //arrange
            string pruebaData = "Pueba actual para verificar el test";

            //act
            FileManager.Guardar(pruebaData, null, false);

            //assert
        }

        [TestMethod]

        public void AlInstanciarUnCocinero_SeEspera_PedidosCero()
        {
            //arrange
            string nombre = "Julio";
            Cocinero<Hamburguesa> cocinero;

            //act
             cocinero = new Cocinero<Hamburguesa>(nombre);

            //assert
            Assert.IsTrue(cocinero.CantPedidosFinalizados == 0);            
        }
    }
}