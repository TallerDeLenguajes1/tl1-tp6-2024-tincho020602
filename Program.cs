// See https://aka.ms/new-console-template for more information


Console.WriteLine("¿que operacion desea realizar?");
Console.WriteLine("1)-Sumar");
Console.WriteLine("2)-Restar");
Console.WriteLine("3)-Multiplicar");
Console.WriteLine("4)-Dividir");
Console.WriteLine("Opcion: ");
string opcion = Console.ReadLine();
int op;
int resultado=0;
int band=0;
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