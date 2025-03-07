using System;
using System.Data;
using System.Data.SqlClient;

public class ConectarSQL
{
    //Atributo que almacena la cadena de conexión
    private string connectionString;

    //Constructor que recibe la cadena de conexión
    public ConectarSQL()
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "10.0.0.4";
        //builder.InitialCatalog = "SummaAdvKSK";
        builder.InitialCatalog = "SummaAdv";
        builder.UserID = "sa";
        builder.Password = "Soporte1";
    
        this.connectionString = builder.ConnectionString;
    }

    public DataTable EjecutarConsulta(string query)
    {
        // Crear un objeto DataTable para almacenar los resultados
        DataTable table = new DataTable();

        try
        {
            // Usar using para manejar automáticamente la liberación de recursos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Llenar el DataTable con los datos del adaptador
                        adapter.Fill(table);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Manejar la excepción
            Console.WriteLine(ex.Message);
        }

        return table;
    }


    public void EjecutarSPSinRespuesta(string store)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        { 
            using (SqlCommand command = new SqlCommand(store, new SqlConnection(connectionString)))
            {
                // Aquí configuraremos los parámetros del Stored Procedure si los hay
                // command.Parameters.AddWithValue("@parametro", valor);

                // Especificamos que se trata de un Stored Procedure
                command.CommandType = System.Data.CommandType.StoredProcedure;

                connection.Open();
                // Ejecutamos el Stored Procedure
                command.ExecuteNonQuery();
            }
        }
    }

    public void EjecutarQuerySinRespuesta(string store)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            using (SqlCommand command = new SqlCommand(store, connection))
            {

                connection.Open();

                // Ejecutamos 
                command.ExecuteNonQuery();
            }
        }
    }
    public DataTable EjecutarConsultaSP(string query)
    {
        //Crear un objeto SqlConnection con la cadena de conexión
        SqlConnection connection = new SqlConnection(connectionString);

        //Crear un objeto SqlCommand con el query y la conexión
        SqlCommand command = new SqlCommand(query, connection);

        //Crear un objeto SqlDataAdapter con el comando
        SqlDataAdapter adapter = new SqlDataAdapter(command);

        command.CommandType = System.Data.CommandType.StoredProcedure;
        //Crear un objeto DataTable para almacenar los resultados
        DataTable table = new DataTable();

        try
        {
            //Abrir la conexión
            connection.Open();

            //Llenar el DataTable con los datos del adaptador
            adapter.Fill(table);
        }
        catch (Exception ex)
        {
            //Manejar la excepción
            Console.WriteLine(ex.Message);
        }
        finally
        {
            //Cerrar la conexión
            connection.Close();
        }

        //Devolver el DataTable
        return table;
    }
}
