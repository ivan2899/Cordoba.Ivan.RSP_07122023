using System.Data.SqlClient;
using Entidades.Excepciones;
using Entidades.Exceptions;
using Entidades.Interfaces;
using Entidades.Modelos;

namespace Entidades.DataBase
{
    public static class DataBaseManager
    {
        private static SqlConnection connection;
        private static string stringConnection;

        static DataBaseManager()
        {
            DataBaseManager.stringConnection = "Server=.;Database=20230622SP;Trusted_Connection=True;";
        }

        /// <summary>
        /// Obtiene la imagen de la comida de la base de datos en la tabla COMIDAS
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        /// <exception cref="ComidaInvalidaExeption"></exception> Si no posee columnas para poder leer la imagen lanza esta excepcion
        /// <exception cref="DataBaseManagerException"></exception> Si no se pudo leer la imagen se lanza esta excepcion
        public static string GetImagenComida(string tipo)
        {
            string messageError = "No se pudo obtener la comida de la base de datos";

            try
            {
                using (DataBaseManager.connection = new SqlConnection(DataBaseManager.stringConnection))
                {
                    string query = "SELECT * FROM comidas WHERE tipo_comida = @tipo";
                    SqlCommand command = new SqlCommand(query, DataBaseManager.connection);
                    command.Parameters.AddWithValue("tipo", tipo);
                    DataBaseManager.connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        return reader.GetString(2);
                    }
                    else
                    {
                        throw new ComidaInvalidaExeption(messageError);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DataBaseManagerException("Error al leer de la base de datos", ex);
            }
        }

        /// <summary>
        /// Guarda el ticket en la base de datos en la tabla TICKETS
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nombreEmpleado"></param> Recibe el nombre del empleado para guardar
        /// <param name="comida"></param> Recibe la comida para guardar
        /// <returns></returns> True: si todo funciono correctamente
        /// <exception cref="DataBaseManagerException"></exception> Lanza esta excepcion en caso de ocurrir un error al escribir en la base de datos
        public static bool GuardarTicket<T>(string nombreEmpleado, T comida) where T : IComestible, new()
        {
            string messageError = "Error al escribir en la base de datos";

            try
            {
                using (DataBaseManager.connection = new SqlConnection(DataBaseManager.stringConnection))
                {
                    string query = "INSERT INTO tickets (empleado,ticket)" +
                        "values (@empleado,@ticket);";

                    SqlCommand command = new SqlCommand(query, DataBaseManager.connection);
                    command.Parameters.AddWithValue("empleado", nombreEmpleado);
                    command.Parameters.AddWithValue("ticket", comida.Ticket);
                    DataBaseManager.connection.Open();
                    command.ExecuteNonQuery();
                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new DataBaseManagerException(messageError, ex);
            }
        }

    }
}
