using System;

public class L_BuscarUsuario
{
    private D_BuscarUsuario dBuscarUsuario = new D_BuscarUsuario();

    // Método que dado un nombre de usuario devuelve el email
    public string ObtenerCorreoPorNombreUsuario(string nombreUsuario)
    {
        if (string.IsNullOrWhiteSpace(nombreUsuario))
            throw new ArgumentException("El nombre de usuario no puede estar vacío.");

        int? idUsuario = dBuscarUsuario.ObtenerIdPorUsuario(nombreUsuario.Trim());

        if (!idUsuario.HasValue || idUsuario <= 0)
            throw new Exception("Usuario no encontrado o Id inválido.");

        string email = dBuscarUsuario.ObtenerCorreoPorUsuario(idUsuario.Value);

        if (string.IsNullOrEmpty(email))
            throw new Exception("No se encontró correo para el usuario.");

        return email;
    }

    public string ObtenerCorreoPorId(int idUsuario)
    {
        if (idUsuario <= 0)
            throw new ArgumentException("IdUsuario debe ser mayor que cero.");

        return dBuscarUsuario.ObtenerCorreoPorUsuario(idUsuario);
    }

    public int? ObtenerIdPorUsuario(string nombreUsuario)
    {
        return dBuscarUsuario.ObtenerIdPorUsuario(nombreUsuario);
    }
}
