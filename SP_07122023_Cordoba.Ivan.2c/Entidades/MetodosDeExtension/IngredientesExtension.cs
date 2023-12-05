using Entidades.Enumerados;
using System;


namespace Entidades.MetodosDeExtension
{
    public static class IngredientesExtension
    {
        /// <summary>
        /// Calcula el costo total del ingrediente con el aumento del enumerado en base al costoInicial recibido
        /// </summary>
        /// <param name="ingredientes"></param> Enumerado de donde se obtiene el aumento
        /// <param name="costoInicial"></param> Costo inicial de producto
        /// <returns></returns> Costo total con el aumento incluido
        public static double CalcularCostoIngredientes(this List<EIngrediente> ingredientes, int costoInicial)
        {
            double aumento = 0;
            double costoTotal;

            foreach (var item in ingredientes)
            {
                aumento += (int)item;
            }

            aumento = costoInicial * (aumento/100);
            costoTotal = costoInicial + aumento;

            return costoTotal;
        }

        /// <summary>
        /// Genera una lista de ingredientes aleatorios en base al enumerado
        /// </summary>
        /// <param name="rand"></param> Instancia de la clase random
        /// <returns></returns> Retorna una lista de algunos ingredientes aleatorios
        public static List<EIngrediente> IngredientesAleatorios(this Random rand)
        {
            List<EIngrediente> ingredientes = new List<EIngrediente>() { 
                EIngrediente.QUESO,
                EIngrediente.PANCETA,
                EIngrediente.ADHERESO,
                EIngrediente.HUEVO,
                EIngrediente.JAMON,
            };

            int numAleatorio = rand.Next(1, ingredientes.Count + 1);
            return ingredientes.Take(numAleatorio).ToList();
        }
    }
}
