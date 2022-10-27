using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Entidades.Productos;
using Entidades.ExcepcionesPropias;
using Entidades.Tienda;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Prueba_Carga_De_Strock_En_Tienda()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsNotNull(TiendaDeElectronica.InventarioTienda.Count>0);
        }

        [TestMethod]
        public void Prueba_Metodo_Igualacion_Productos()
        {
            //Arrange
            Producto p1 = new Producto("p1", 100, 101, "", ECategoriaElectronico.Leds);
            Producto p2 = new Producto("p2", 100, 101, "", ECategoriaElectronico.Leds,5);
            //Act
            bool resultado = p1 == p2;
            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Prueba_Buscadar_una_palabra_en_una_cadena()
        {
            //Arrange
            string auxString = "Las lunas de plutón";
            //Act
            bool resultado = Buscador.BuscarPorPalabraEnCadena("plutón", auxString);
            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Prueba_Buscadar_una_palabra_en_una_cadena_por_primeras_letras()
        {
            //Arrange
            string auxString = "Las lunas de plutón";
            //Act
            bool resultado = Buscador.BuscarPorPalabraEnCadena("plut", auxString);
            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Prueba_extraer_Primeras_letras_de_una_cadena()
        {
            //Arrange
            string auxString = "Las lunas de plutón";
            //Act
            string resultado = Buscador.ExtraerPrimerasLetrasPalabra(auxString, 3);
            //Assert
            Assert.AreEqual("Las", resultado);
        }

        [TestMethod]
        public void Prueba_sumar_un_Id_a_la_tienda()
        {
            //Arrange
            TiendaDeElectronica tienda = new TiendaDeElectronica();
            int id = 110;
            //Act
            bool resultado = tienda + id;
            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ListaVaciaException))]
        public void Prueba_que_se_genere_excepcion_por_No_Encontrar_productos_en_una_lista()
        {
            //Arrange
            //Act
            double auxPromedio = Estadisticas.PromedioVentasProducto(ECategoriaElectronico.Leds);
            //Assert

        }

        [TestMethod]
        [ExpectedException(typeof(NumeroFueraDeRangoException))]
        public void Prueba_que_se_genere_excepcion_por_Intentar_asignar_un_numero_negativo_al_saldo_de_la_tienda()
        {
            //Arrange
            double auxNum = -100;
            //Act
            TiendaDeElectronica.CuentaTienda = auxNum;
            //Assert
        }


    }
}
