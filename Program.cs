// See https://aka.ms/new-console-template for more information




    // Variables para almacenar valores ingresados por el usuario
    float numero1, numero2;

    // Solicitar y validar el primer número
    Console.WriteLine("Ingrese un número:");
    while (!float.TryParse(Console.ReadLine(), out numero1))
    {
        Console.WriteLine("Error: Ingrese un número válido.");
    }

    // Mostrar operaciones para el primer número
    Console.WriteLine("\nOperaciones para el primer número:");
    Console.WriteLine($"Valor absoluto: {Math.Abs(numero1)}");
    Console.WriteLine($"Cuadrado: {Math.Pow(numero1, 2)}");
    Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero1)}");
    Console.WriteLine($"Seno: {Math.Sin(numero1)}");
    Console.WriteLine($"Coseno: {Math.Cos(numero1)}");
    Console.WriteLine($"Parte entera: {Math.Floor(numero1)}");

    // Solicitar y validar el segundo número
    Console.WriteLine("\nIngrese otro número:");
    while (!float.TryParse(Console.ReadLine(), out numero2))
    {
        Console.WriteLine("Error: Ingrese un número válido.");
    }

    // Determinar y mostrar el máximo y mínimo
    Console.WriteLine("\nOperaciones entre los dos números:");
    Console.WriteLine($"Máximo: {Math.Max(numero1, numero2)}");
    Console.WriteLine($"Mínimo: {Math.Min(numero1, numero2)}");








/*EJERCICIO 2:

Console.WriteLine("¿que operacion desea realizar?");
Console.WriteLine("1)-Sumar");
Console.WriteLine("2)-Restar");
Console.WriteLine("3)-Multiplicar");
Console.WriteLine("4)-Dividir");
Console.WriteLine("Opcion: ");
string opcion = Console.ReadLine();
int op;
int resultado=0;
int band=1;
do
{
if (int.TryParse(opcion, out op))
{
    Console.WriteLine("Ingrese numero A:");
    string numeroA = Console.ReadLine();
    int numA = Convert.ToInt32(numeroA);//Supongo que se ingresa un num int, no hago la verificacion
    Console.WriteLine("Ingrese numero B:");
    string numeroB = Console.ReadLine();
    int numB = Convert.ToInt32(numeroB);
    switch (op)
    {
        case 1:
            resultado = numA + numB;
            break;
        case 2:
            resultado = numA - numB;
            break;
        case 3:
            resultado = numA * numB;
            break;
        case 4:
            resultado = numA / numB;
            break;
        default:
        Console.WriteLine("Eligio un numero que no esta en las opciones");
        break;
    }
    Console.WriteLine("El resultado es: "+ resultado);
}
Console.WriteLine("Desea realizar otra operacion?");
Console.WriteLine("1-Si");
Console.WriteLine("2-No");
string bandera=Console.ReadLine();
band= Convert.ToInt32(bandera);


} while (band==1);
FIN EJERCICIO 2*/




/* PUNTO QUE VENIA EN EL TP:
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
    FIN*/

/* EJERCICIO 1:
int invertido = 0, resto;
Console.WriteLine("Ingrese un número: ");
string cadena = Console.ReadLine();
int numero;
//me aseguro que se ingreso una cadena con contenido unicamente numerico 
//y luego la salida(out) sera en la variable numero
if (int.TryParse(cadena, out numero))
{
    if (numero > 0)
    {
        while (numero != 0)
        {
            resto = numero % 10;
            invertido = invertido * 10 + resto;
            numero /= 10;
        }
        Console.WriteLine("El número invertido es:" + invertido);
    }
    else
    {
        Console.WriteLine("El número debe ser mayor a 0.");
    }
}  
FIN EJECICIO 1  */