using Microsoft.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

public class BD
{
 private static string _connectionString = @"Server=localhost; Database=NombreBase;Integrated Security=True;TrustServerCertificate=True;";

 public static List<Integrante> LevantarIntegrantes()
 {
    List<Integrante> integrante =new List<Integrante>();
    using(SqlConnection connection =new SqlConnection(_connectionString))
    {
        string query="SELECT * FROM alumno";
        integrante=connection.Query<Integrante>(query).ToList();
    }
    return integrante;
 }
}