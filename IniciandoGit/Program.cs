//Nombre: Erin Yareth Soza Euceda

//Número de cuenta: 20241900227

using System;

// 1. Crear el objeto usando el Constructor
// Pasamos: usuario, contraseña, nivel y la fecha actual
comiteado miUsuario = new comiteado("Admin", "1234", 1, DateTime.Now);

// 2. Llamar a los métodos
miUsuario.MostrarNombre();
miUsuario.ValidarPassword();

// 3. Acceder a un atributo público
Console.WriteLine($"Tu nivel actual es: {miUsuario.level}");