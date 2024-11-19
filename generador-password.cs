using System;
using System.Text.RegularExpressions;

class Password
{
    private int longitud { get; set; } = 8;
    private string contraseña { get; set; }
    public Password() { }
    public Password(int longitud) { }

    public bool EsFuerte()
    {
        // Definir la expresión regular
        string pattern = @"^(?=(.*[A-Z]){3,})(?=(.*[a-z]){2,})(?=(.*[0-9]){6,}).*$";

        // Verificar si la contraseña cumple con el patrón
        return Regex.IsMatch(contraseña, pattern);
    }


    public void GenerarPassword()
    {
        const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789abcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        char[] passwordArray = new char[longitud];

        // Generar la contraseña carácter por carácter
        for (int i = 0; i < longitud; i++)
        {
            passwordArray[i] = caracteres[random.Next(caracteres.Length)];
        }

        // Convertir el array de caracteres en una cadena y asignarla al atributo
        contraseña = new string(passwordArray);
    }

    public int getLongitud()
    {
        return this.longitud;
    }

    public string getContraseña()
    {
        return this.contraseña;
    }

    public void setLongitud(int longitud)
    {
        this.longitud = longitud;
    }




}


class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Indica el número de contraseñas: ");
        int n = int.Parse(Console.ReadLine()); // Lee el tamaño del array
        Password[] passwords = new Password[n]; // Crea el array de Passwords
        bool[] seguridadDeLasConstrasenas = new bool[n]; // Crea el array de booleanos para almacenar los resultados
        Console.Write("Indica la longitud de la contraseña: ");
        int longitud = int.Parse(Console.ReadLine()); // Lee la longitud de la contraseña

        for (int i = 0; i < n; i++)
        {
            passwords[i] = new Password(); // Inicializa el objeto Password
            passwords[i].setLongitud(longitud); // Asigna la longitud al objeto Password
            passwords[i].GenerarPassword(); // Genera la contraseña y la asigna
            seguridadDeLasConstrasenas[i] = passwords[i].EsFuerte(); // Verifica si la contraseña es fuerte
            Console.WriteLine($"Contraseña generada: {passwords[i].getContraseña()} - {(passwords[i].EsFuerte() ? "Fuerte" : "Debil")}");
        }
    }
}
