using Microsoft.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

public class BD
{
 private static string _connectionString = @"Server=localhost; Database=NombreBase;Integrated Security=True;TrustServerCertificate=True;";

   public static Integrante Conexion()
   {
      return new SqlConnection(_connectionString);
   }
}