using System;

public class comiteado
{
    public string user;
    public string password; // Atributo
    public int level;
    DateTime log;

    public comiteado(string user, string password, int level, DateTime log)
    {
        this.user = user;
        this.password = password;
        this.level = level;
        this.log = log;
    }

    // Cambié el nombre a 'ValidarPassword' para que no choque con el atributo 'password'
    public void ValidarPassword()
    {
        Console.WriteLine("INGRESE LA CONTRASEÑA:");
        string temp = Console.ReadLine() ?? "-/-/-";
        if (temp != this.password)
            Console.WriteLine("Error de Autentificación");
        else
            Console.WriteLine("Autentificación realizada con éxito");
    }

    public void MostrarNombre()
    {
        Console.WriteLine($"Bienvenido: {user} acabas de ingresar el: {log}");
    }
}

