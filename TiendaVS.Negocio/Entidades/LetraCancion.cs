using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace TiendaVS.Negocio.Entidades
{
    public class LetraCancion
    {
        public string Leer(string ruta)
        {
            try
            {
                return File.ReadAllText(ruta);
            }
            catch (FileNotFoundException f)
            {
                return $"No se encontró el archivo {f.FileName}";

            }
            catch (Exception e)
            {
                Trace.WriteLine("En la clase LetraCancion en el método Leer se produjo una excepción");
                Trace.WriteLine(e.Message);
                throw;
            }
        }
    }
}
