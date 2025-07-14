using Microsoft.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
public class Integrante
{
    public string NombreUsuario{get; set;}
    public string Email{get; set;}
    public static string Password{get; set;}
    public static string CuadroDeFutbol{get;set;}
    public static string ComidaFavorita{get;set;}
    public static string Nombre{get; set;}
    public static string Apellido{get; set;}
    public static int Edad{get; set;}
    public static Integrante LevantarIntegrantes(string nombe, string contraseña)
    {
        using (SqlConnection connection = BD.ObtenerConexion())
        {
            string query = "SELECT * FROM Integrante WHERE NombreDeUsuario = @Nombreusuario AND Password = @Password";
            return connection.QueryFirstOrDefault<Integrante>(query, new { nombre, contraseña });
        }
    }
    public static Integrante BuscarXUsuar(string nombre)
    {
        using (SqlConnection connection = BD.Conexion())
        {
            string query = "SELECT * FROM Integrante WHERE NombreDeUsuario = @NombreUsuario";
            return connection.QueryFirstOrDefault<Integrante>(query, new { usuario });
        }
    }
    
}