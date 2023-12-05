using Entidades.Exceptions;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Files
{
    public static class FileManager
    {
        private static string path;

        static FileManager()
        {
            FileManager.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileManager.path = Path.Combine(FileManager.path, "20231207_Cordoba.Ivan.2C");
            ValidaExistenciaDeDirectorio();
        }

        /// <summary>
        /// Recibe el nombre de un archivo y guarda el contenido
        /// </summary>
        /// <param name="data"></param> Contenido a guardar
        /// <param name="nombreArchivo"></param> Nombre del archivo en el que se va a guardar
        /// <param name="append"></param> True: si se desea añadir al archivo sin borrar, False: borra lo anterior 
        /// <exception cref="FileManagerException"></exception> Excepcion de que ocurrio un error y no se pudo guardar el archivo
        public static void Guardar(string data, string nombreArchivo, bool append)
        {
            string messageError = "No se pudo guardar el archivo";

            try
            {
                FileManager.path = Path.Combine(FileManager.path, nombreArchivo);

                using (StreamWriter sw = new StreamWriter(FileManager.path, append))
                {
                    sw.WriteLine(data);
                }
            }
            catch (Exception ex)
            {
                throw new FileManagerException(messageError, ex);
            }
        }

        /// <summary>
        /// Serializa en tipo JSON un elemento, recibiendo el nombre del archivo
        /// </summary>
        /// <typeparam name="T"></typeparam> 
        /// <param name="elemento"></param> Elemento a serializar
        /// <param name="nombreArchivo"></param> Nombre del archivo en el que se va a guardar
        /// <returns></returns> True: se pudo serializar de manera correcta
        /// <exception cref="FileManagerException"></exception> Excepcion de que ocurrio un error y no se pudo serializar el elemento
        public static bool Serializar<T>(T elemento, string nombreArchivo) where T : class
        {
            string messageError = "No se pudo serializar el archivo";

            try
            {
                JsonSerializerOptions opt = new JsonSerializerOptions();
                opt.WriteIndented = true;
                string json = JsonSerializer.Serialize(elemento, opt);

                FileManager.Guardar(json, nombreArchivo, false);
                return true;
            }
            catch (Exception ex)
            {
                throw new FileManagerException(messageError, ex);
            }
        }

        /// <summary>
        /// Valida la existencia del directorio a traves del atributo statico "path" y si no existe lo crea
        /// </summary>
        /// <exception cref="FileManagerException"></exception> Si no existe el directorio lo intenta crear, y si no puede lanza esta excepcion
        private static void ValidaExistenciaDeDirectorio()
        {
            string messageError = "Error al crear el directorio";

            if (!Directory.Exists(FileManager.path))
            {
                try
                {
                    Directory.CreateDirectory(FileManager.path);
                }
                catch (Exception e)
                {
                    throw new FileManagerException(messageError, e);
                }
            }
        }
    }
}
