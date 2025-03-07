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
        builder.DataSource = "192.168.100.120";
        builder.InitialCatalog = "SummaAdv";
        builder.UserID = "sa";
        builder.Password = "Soporte1";
    
        this.connectionString = builder.ConnectionString;
    }

    //Método que ejecuta una consulta y devuelve un DataTable con los resultados
    public DataTable EjecutarConsulta(string query)
    {
        //Crear un objeto SqlConnection con la cadena de conexión
        SqlConnection connection = new SqlConnection(connectionString);

        //Crear un objeto SqlCommand con el query y la conexión
        SqlCommand command = new SqlCommand(query, connection);

        //Crear un objeto SqlDataAdapter con el comando
        SqlDataAdapter adapter = new SqlDataAdapter(command);

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

    public void EjecutarSPSinRespuesta(string store)
    {
        using (SqlCommand command = new SqlCommand(store, new SqlConnection(connectionString)))
        {
            // Aquí configuraremos los parámetros del Stored Procedure si los hay
            // command.Parameters.AddWithValue("@parametro", valor);

            // Especificamos que se trata de un Stored Procedure
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Ejecutamos el Stored Procedure
            command.ExecuteNonQuery();
        }

    }
}
