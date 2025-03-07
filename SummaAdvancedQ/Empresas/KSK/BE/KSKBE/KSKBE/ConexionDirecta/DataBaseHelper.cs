using System;
using System.Data;
using System.Data.SqlClient;

public static class DatabaseHelper
{
    private static string connectionString;

    // Constructor estático para inicializar la cadena de conexión.
    static DatabaseHelper()
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "10.0.0.4";   // Dirección del servidor
        builder.InitialCatalog = "SummaAdv";      // Nombre de la base de datos
        builder.UserID = "sa";                    // Usuario de la base de datos
        builder.Password = "Soporte1";                // Contraseña

        connectionString = builder.ConnectionString; // Construye el connectionString
    }

    public static bool EjecutarStoreProcedure(string storedProcedureName, SqlParameter[] parametros)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros recibidos.
                    if (parametros != null)
                    {
                        command.Parameters.AddRange(parametros);
                    }

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Ejecuta el SP

                    return rowsAffected > 0; // Devuelve true si al menos una fila fue afectada.
                }
            }
        }
        catch (Exception ex)
        {
            // Manejo de errores, puedes hacer log de la excepción.
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public static SqlParameter CrearParametro(string nombre, SqlDbType tipo, object valor)
    {
        SqlParameter param = new SqlParameter(nombre, tipo);
        param.Value = valor;
        return param;
    }
}
