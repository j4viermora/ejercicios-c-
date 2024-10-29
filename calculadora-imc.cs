using System;

class Persona
{      
    private const int imcBajo = -1;
    private const int imcNormal = 0;
    private const int imcSobrepeso = 1;
    private const int mayoriaDeEdad = 18;
    private const string defaultSexo = "H";
    private string nombre { get; set; } = "";
    private int edad { get; set; } = 0;
    private int dni { get; set; }
    private string sexo { get; set; } = defaultSexo; // Cambiado a string
    private decimal peso { get; set; } = 0;
    private decimal altura { get; set; } = 0;

    public Persona() {
        this.generaDNI();
    }

    public Persona(string nombre, int edad, string sexo)
    {
        this.generaDNI();
        this.nombre = nombre;
        this.edad = edad;
        this.sexo = this.comprobarSexo(sexo);
    }

    public Persona(string nombre, int edad, string sexo, decimal peso, decimal altura)
    {    
        this.generaDNI();
        this.nombre = nombre;
        this.edad = edad;
        this.sexo = this.comprobarSexo(sexo);
        this.peso = peso;
        this.altura = altura;
    }

    public bool esMayorDeEdad() => edad >= mayoriaDeEdad;

    private string comprobarSexo(string sexo)
    {
        if (sexo.ToUpper() == "H" || sexo.ToUpper() == "M")
        {
            return sexo;
        }
        else
        {
            return defaultSexo; // Corregido el nombre de la constante
        }
    }

    private void generaDNI() 
    {
        Random rnd = new Random(); // Corregido 'Radom' a 'Random'
        int dni = rnd.Next(10000000, 99999999);
        this.dni = dni;
    }

    public int calcularIMC() // Cambiado a public para acceso
    {    
        if (this.altura == 0) {
           return imcBajo;
        }
        if (this.peso == 0) {
            return imcBajo;
        }
        decimal imc = this.peso / (this.altura * this.altura);

        if (imc < 20)
        {
            return imcBajo; // Usando la clase para acceder a la constante
        }

        if (imc >= 20 && imc <= 25)
        {
            return imcNormal;
        }

        return imcSobrepeso; // Agregado retorno
    }

    // Setters
    public void SetSexo(string sexo) => this.sexo = this.comprobarSexo(sexo);
    public void SetNombre(string nombre) => this.nombre = nombre;
    public void SetEdad(int edad) => this.edad = edad;
    public void SetPeso(decimal peso) => this.peso = peso;
    public void SetAltura(decimal altura) => this.altura = altura;

    // Getters
    public string GetSexo() => this.sexo;
    public string GetNombre() => this.nombre;
    public int GetEdad() => this.edad;
    public decimal GetPeso() => this.peso;
    public decimal GetAltura() => this.altura;
    public int GetDni() => this.dni;
}  

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hola, ¿cómo te llamas?");
        string name = Console.ReadLine();
        Console.WriteLine("Tu edad por favorcito:");
        int edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Tu sexo por favorcito:");
        string sexo = Console.ReadLine();
        Console.WriteLine("Tu peso por favorcito:");
        decimal peso = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Tu altura por favorcito:");
        decimal altura = decimal.Parse(Console.ReadLine());

        Persona personaOne = new Persona(name, edad, sexo, peso, altura);
        Persona personaTwo = new Persona(name, edad, sexo);

        Persona personaThree = new Persona();
        personaThree.SetNombre("Juan");
        personaThree.SetEdad(20);
        personaThree.SetSexo("M");
        personaThree.SetPeso(60);
        personaThree.SetAltura(1.75m);

        ImprimirResultado(personaOne);
        ImprimirResultado(personaTwo);
        ImprimirResultado(personaThree);

        void ImprimirResultado(Persona persona)
        {
            Console.WriteLine("Nombre: " + persona.GetNombre());
            Console.WriteLine("Edad: " + persona.GetEdad());
            Console.WriteLine("Sexo: " + persona.GetSexo());
            Console.WriteLine("Peso: " + persona.GetPeso());
            Console.WriteLine("Altura: " + persona.GetAltura());
            Console.WriteLine("DNI: " + persona.GetDni());
            Console.WriteLine("IMC: " + persona.calcularIMC());
            Console.WriteLine("###################################");
        }
    }
}
