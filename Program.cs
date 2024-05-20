// See https://aka.ms/new-console-template for more information



int invertido = 0, resto;
Console.WriteLine("Ingrese un número: ");
string cadena = Console.ReadLine();
int numero;
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







/* PUNTO QUE VENIA EN EL TP:
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
    FIN*/