using Entidades.Enumerados;
using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Interfaces;
using Entidades.MetodosDeExtension;
using System.Text;
using Entidades.DataBase;

namespace Entidades.Modelos
{
    public class Hamburguesa : IComestible
    {

        private double costo;
        private static int costoBase;
        private bool esDoble;
        private bool estado;
        private string imagen;
        private List<EIngrediente> ingredientes;
        private Random random;

        static Hamburguesa() => Hamburguesa.costoBase = 1500;


        public Hamburguesa() : this(false)
        {
        }

        public Hamburguesa(bool esDoble)
        {
            this.esDoble = esDoble;
            this.random = new Random();
        }

        public bool Estado { get => this.estado; set => this.estado = value; }
        public string Imagen { get => this.imagen; set => this.imagen = value; }
        public string Ticket => $"{this}\nTotal a pagar:{this.costo}";

        /// <summary>
        /// Agrega ingredientes de manera aleatoria al atributo "ingredientes"
        /// </summary>
        private void AgregarIngredientes()
        {
            this.ingredientes = this.random.IngredientesAleatorios();
        }

        /// <summary>
        /// Asigna el costo a la hamburguesa y luego cambia de estado el atributo "estado"
        /// </summary>
        /// <param name="cocinero"></param>
        public void FinalizarPreparacion(string cocinero)
        {
            this.costo = this.ingredientes.CalcularCostoIngredientes(Hamburguesa.costoBase);
            this.estado = !this.estado;
        }

        /// <summary>
        /// Si el estado es False: genera un numero aleatorio entre 1 y 8 y obtiene una imagen de hamburguesa de la BD
        /// </summary>
        public void IniciarPreparacion()
        {
            if (!this.estado)
            {
                try
                {
                    int numRandom = this.random.Next(1, 9);
                    this.imagen = DataBaseManager.GetImagenComida($"Hamburguesa_{numRandom}");

                }
                catch (Exception ex)
                {
                    FileManager.Guardar(ex.Message, "logs.txt", true);
                }
                AgregarIngredientes();
            }
        }

        /// <summary>
        /// Muestra todos los datos concatenados de la comida (Si es simple o no y todos sus ingredientes)
        /// </summary>
        /// <returns></returns> Retorna el string concatenado
        private string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Hamburguesa {(this.esDoble ? "Doble" : "Simple")}");
            stringBuilder.AppendLine("Ingredientes: ");
            this.ingredientes.ForEach(i => stringBuilder.AppendLine(i.ToString()));
            return stringBuilder.ToString();
        }

        public override string ToString() => this.MostrarDatos();
    }
}