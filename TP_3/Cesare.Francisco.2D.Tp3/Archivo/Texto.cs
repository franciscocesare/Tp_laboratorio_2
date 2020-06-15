using Excepciones;
using System;
using System.IO;

namespace Archivo
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda todos los datos 
        /// </summary>
        /// <param name="archivo">Nombre del archivo</param>
        /// <param name="datos">Info que contiene el archivo</param>
        /// <returns>true si lo pudo crear, false si no pudo</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool aux = false;
            if (!string.IsNullOrEmpty(archivo) && !string.IsNullOrEmpty(datos))
            {
                try
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    using (StreamWriter sw = new StreamWriter(Path.Combine(path, archivo)))
                    {
                        sw.WriteLine(datos);
                        aux = true;
                    }

                }
                catch (Exception e)
                {
                    throw new ArchivosException(e);
                }
            }

            return aux;
        }

        /// <summary>
        /// Lee datos del path pasdao
        /// </summary>
        /// <param name="archivo">Nombre del archivo</param>
        /// <param name="datos">Donde se guarda la informacion del archivo</param>
        /// <returns>Devuelve la info del archivo o vacio si no pudo</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool aux = false;
            datos = "";
            if (!string.IsNullOrEmpty(archivo))
            {
                try
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    using (StreamReader sw = new StreamReader(Path.Combine(path, archivo)))
                    {
                       datos = sw.ReadToEnd();
                       aux = true;
                    }
                    //sw.Close();
                }
                catch (Exception e)
                {
                    throw new ArchivosException(e);
                }
            }
            return aux;
        }


    }
}
