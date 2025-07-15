using Microsoft.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
public class Integrante
{
    public string NombreUsuario{get; set;}
    public string Email{get; set;}
    public string Password{get; set;}
    public string CuadroDeFutbol{get;set;}
    public string ComidaFavorita{get;set;}
    public string Nombre{get; set;}
    public string Apellido{get; set;}
    public int Edad{get; set;}
    public static Integrante LevantarIntegrantes(string nombre, string contraseña)
    {
        using (SqlConnection connection = BD.Conexion())
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
            return connection.QueryFirstOrDefault<Integrante>(query, new { nombre });
        }
    }
    
}