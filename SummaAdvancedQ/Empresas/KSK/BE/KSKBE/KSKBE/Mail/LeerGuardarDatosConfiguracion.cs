using System;
using System.Configuration;

namespace KSKBE.Mail
{
    class LeerGuardarDatosConfiguracion
    {
        public LeerGuardarDatosConfiguracion()
        {

        }
        //Constructor si se pasan los parámetros clave y valor
        //escribe en el fichero de configuración el valor de esa clave
        public LeerGuardarDatosConfiguracion(string clave, string valor)
        {
            guardarValorConfiguracion(clave, valor);
        }
        public string leerValorConfiguracion(string clave)
        {
            try
            {
                string resultado =
                    ConfigurationManager.AppSettings[clave].ToString();
                return resultado;
            }
            catch (Exception error)
            {
                new EscribirLog("Error al leer valor de configuración: " +
                    error.GetType().ToString() + " " + error.Message, false);
                return "";
            }
        }
        //Guarda un valor en una clave en el fichero de configuración XML de la aplicación
        public void guardarValorConfiguracion(string clave, string valor)
        {
            try
            {
                Configuration ficheroConfXML =
                    ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //Configuration ficheroConfXML =
                //    ConfigurationManager.OpenExeConfiguration(AppDomain.CurrentDomain.BaseDirectory);                

                //Eliminamos la clave actual (si existe), de lo contrario los valores
                //se irán acumulando separados por coma
                ficheroConfXML.AppSettings.Settings.Remove(clave);

                //Asignamos el valor en la clave indicada
                ficheroConfXML.AppSettings.Settings.Add(clave, valor);

                //Guardamos los cambios definitivamente en el fichero de configuración
                ficheroConfXML.Save(ConfigurationSaveMode.Modified);
            }
            catch (Exception error)
            {
                new EscribirLog("Error al guardar valor de configuración: " +
                    error.GetType().ToString() + " " + error.Message, false);
            }
        }
    }
}
