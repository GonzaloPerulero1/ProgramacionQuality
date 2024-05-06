using System;

class veintinuevedelcuatros
{
    static void Main()
    {
        //Console.WriteLine("Ingresa un número del 1 al 7 para determinar el día de la semana:");
        //int dia = int.Parse(Console.ReadLine());
        //switch (dia) //switch (nombre)
        //{
        //    case 1: //1 es el valor, se puede poner decimales
        //        Console.WriteLine("Domingo"); //accion
        //        break;
        //    case 2:
        //        Console.WriteLine("Lunes");
        //        break;
        //    case 3:
        //        Console.WriteLine("Martes");
        //        break;
        //    case 4:
        //        Console.WriteLine("Miércoles");
        //        break;
        //    case 5:
        //        Console.WriteLine("Jueves");
        //        break;
        //    case 6:
        //        Console.WriteLine("Viernes");
        //        break;
        //    case 7:
        //        Console.WriteLine("Sábado");
        //        break;
        //    default: //Es como el else, es una opcion cuando no cumplis con ninguna de las otras opciones
        //        Console.WriteLine("Número inválido. Ingresa un número del 1 al 7.");
        //        break;
        //}

        //Console.WriteLine("Pedir cuatro numeros");
        //int n1 = int.Parse(Console.ReadLine());
        //int n2 = int.Parse(Console.ReadLine());
        //int n3 = int.Parse(Console.ReadLine());
        //int n4 = int.Parse(Console.ReadLine());

        //int iguales = n1;

        //    if (n1 == n2 && n2 == n3 && n3 == n4)
        //    {
        //        Console.WriteLine("Los numeros son iguales");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No son iguales");
        //    }

        Console.WriteLine("Dar tres notas");
        int nota1 = int.Parse(Console.ReadLine());
        int nota2 = int.Parse(Console.ReadLine());
        int nota3 = int.Parse(Console.ReadLine());

        int promedioNotas = (nota1 + nota2 + nota3) / 3;
        int promocion = 8;
        if (promedioNotas >= promocion)
        {
            Console.WriteLine("El alumno promociono");
        }
        else if (promedioNotas > 5 && promedioNotas < 8)
        {
            Console.WriteLine("El alumno aprobo");
        }
        else
        {
            Console.WriteLine("El alumno se va a coloquio");
        }


    }
}
