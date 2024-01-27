// See https://aka.su nombre ems/new-console-template for more information

using System.Threading.Channels;
using System.Timers;
using System.Xml.Schema;


/*int valor1 = 56; //32bits

long l = 34543345; //64 bits
byte b = 255;
short s = 345;
flotantes

float flotantes = 3.14f;
double doble = 5.684d;
decimal dec = 36494.12m;

boleanos
bool boleano = false;

caracter
string nombre = "alex;";
string apellido="miranda";
char //comilla simple

Console.WriteLine(nombre+ " "+apellido);

Console.WriteLine("Digite un nombre");
nombre = Console.ReadLine();

Console.WriteLine("su nombres es:"+nombre+" "+apellido);

num1 = 10;
num2 = 3;

Console.WriteLine("sumar: "+(num1+num2));
Console.WriteLine("multiplicar:"+(num1*num2));

Console.WriteLine("Digite un valor");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("digigte otro valor");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("multiplicar:" + (num1 * num2));*/






float camisas = 100;
float pantalones = 200;
float medias = 50;

float precio = 400;
float total = 0;
float stotal = 0;
float descuento = 0;
int cantidad;
float IVA = 0;
int opcion = 0;
string articulo = "";
    


do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("++++++++TIENDA LA BARATIJA+++++++");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("que desea comprar");
    Console.WriteLine("1-camisas");
    Console.WriteLine("2-pantalones");
    Console.WriteLine("3-medias");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Que desea comorar...");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        precio = camisas;
        articulo = "camisas";
    }
    else if (opcion == 2)
    {
        precio = pantalones;
        articulo = "pantalones";
    }
    else if (opcion == 3)
    {
        precio = medias;
        articulo = "medias";
    }



} while (opcion <1 || opcion>3);
;



Console.WriteLine("Digite la cantidad");
cantidad = int.Parse(Console.ReadLine());
Console.WriteLine("digite el descuento");
descuento = int.Parse(Console.ReadLine());
stotal=cantidad * precio;
Console.WriteLine("el subtotal a pagar es de :........{0}",stotal);
descuento = stotal * (descuento / 100);
Console.WriteLine("el descuento es ...........{0}",descuento);
stotal = stotal - descuento;
Console.WriteLine("el subtotal con decuento..........",stotal);
Console.WriteLine("el descuento es {0}",descuento);
IVA = stotal * 0.13f;
Console.WriteLine("el impuesto es.........{0}", IVA);
Console.WriteLine("EL TOTAL A PAGAR por {1} ES DE .......{0}", stotal +IVA, articulo);








