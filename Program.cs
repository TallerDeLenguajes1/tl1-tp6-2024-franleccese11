// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Timers;

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

Console.WriteLine("Escriba un numero que quiere invertir:");
string cad = Console.ReadLine();
float num=0;
if(float.TryParse(cad,out num))
{
    if(num>0)
    {
        num = 1/num;
        Console.WriteLine(num);
    }else
    {
        Console.WriteLine("numero ingresado menor que cero");
    }
    
}else
{
    Console.WriteLine("ERROR no ingresaste un numero");
}


//calculadora v1

int menu=0;
string cad_1= "";

do
{
    
    
    do
    {
        Console.WriteLine("ingrese el numero segun que calculo desea realizar:");
        Console.WriteLine("1) sumar");
        Console.WriteLine("2) restar");
        Console.WriteLine("3) multiplicar");
        Console.WriteLine("4) dividir");
        Console.WriteLine("0) finalizar programa");
        cad_1 = Console.ReadLine();   
    } while (!int.TryParse(cad_1,out menu));
    
    if(menu != 0)
    {
        Console.WriteLine("ingrese el primer numero:");
        string cad1 = Console.ReadLine();
        Console.WriteLine("ingrese el segundo numero:");
        string cad2 = Console.ReadLine();
        float num1=0,num2=0;
        bool esNum1 = float.TryParse(cad1,out num1);
        bool esnum2 = float.TryParse(cad2,out num2);
        if (esNum1 && esnum2)
        {
            float resultado=0;
            switch (menu)
            {
                case 1:
                    resultado = num1 + num2; 
                break;

                case 2:
                    resultado = num1 - num2;
                break;

                case 3:
                    resultado = num1 * num2;
                break;

                case 4:
                    resultado = num1 / num2;
                break;
                default:
                    Console.WriteLine("numero ingresado no valido");
                break;
            }
            if (resultado != 0)
            {
                Console.WriteLine("el resultado es "+ resultado);
            }  
        }
        }
} while (menu>0 && menu <5);


//CALCULADORA V2

float num3=0;
string cad3 = "";
do
{   
    cad3 = Console.ReadLine();
    
} while (!float.TryParse(cad3,out num3));

if(num3<0)
{
    Console.WriteLine("su valor absoluto es: "+ (-num3));
}else
{
    Console.WriteLine("su valor absoluto es: "+ num3);
}

Console.WriteLine("su cuadrado es "+  (num3*num3));
Console.WriteLine("su raiz cuadrada es "+ (Math.Sqrt(num3)));
Console.WriteLine("su seno es: "+ (Math.Sin(num3)));
Console.WriteLine("su coseno es: " + (Math.Cos(num3)));
int num4 = (int) num3;
Console.WriteLine("su parte entera es: "+ num4);



Console.WriteLine("Ingrese 2 numeros de los que quiera determinar su maximo y minimo:");
bool esnum3,esnum4;
float num5=0,num6=0;
do
{
   string cad4 = Console.ReadLine();
    string cad5 = Console.ReadLine();
    esnum3 = float.TryParse(cad4,out num5);
    esnum4 = float.TryParse(cad5,out num6); 
} while (!esnum3 &&  !esnum4);
if (num5 >num6)
{
    Console.WriteLine("el maximo es: "+num5+" el minimo es: "+num6);
}else
{
    if (num5 < num6)
    {
        Console.WriteLine("el maximo es: "+num6+" el minimo es: "+num5);
    }else
    {
        Console.WriteLine("no existe maximo ni minimo porque ambos numeros son iguales");
    }
}






