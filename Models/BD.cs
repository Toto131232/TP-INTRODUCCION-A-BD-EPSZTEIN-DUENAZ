using Microsoft.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

public class BD
{
 private static string _connectionString = @"Server=localhost; Database=NombreBase;Integrated Security=True;TrustServerCertificate=True;";

   public static Integrante LevantarIntegrantes(string nombre, string contraseña)
   {
      Integrante integrante = null;
      using (SqlConnection connection = new SqlConnection(_connectionString))
      {
         string query = "SELECT * FROM alumno";
         integrante = connection.QueryFirstOrDefault<Integrante>(query, new { Nombre = nombre, Password = contraseña });
      }
      return integrante;
   }
}