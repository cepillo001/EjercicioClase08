/* Ejercicio Clase 08

Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios  */

Console.WriteLine("Ingrese la cantidad de Filas: ");
int lenghtFila = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de Columnas: ");
int lenghtColumna = int.Parse(Console.ReadLine());

int[,] numeros = new int[lenghtFila,lenghtColumna];
double[] promedios = new double[lenghtColumna];
// la defino como double para que el resultado me de con coma.
double suma;

// Recorriendo la matriz para su carga con numeros enteros
for (int columna = 0; columna < lenghtColumna; columna++)
{
    // Inicializo suma = 0, y cuando termine de calcular la suma de una columna, vuelve a cero.
    suma = 0;
    Console.WriteLine($"Cargue los numeros de la Columna {columna + 1}: ");
    
    for (int fila = 0; fila < lenghtFila; fila++)
    {
        Console.Write($"Tiene que cargar {lenghtFila} numeros, Cargue el numero {fila + 1}: ");
        numeros[fila,columna] = int.Parse(Console.ReadLine());
        suma = suma + numeros[fila,columna];
        Console.WriteLine();
    }
    promedios[columna] = suma / lenghtFila;
}

for (int columna = 0; columna < lenghtColumna; columna++)
{
    Console.WriteLine();
    Console.WriteLine("==============================================");
    Console.WriteLine();
    Console.WriteLine($"Los numeros ingresados en la Columna {columna + 1} son: ");
    for (int fila = 0; fila < lenghtFila; fila++)
    {
        Console.Write($"Numero: {numeros[fila,columna]}");
        Console.WriteLine();
    }
    Console.Write($"El promedio de esos numeros es: {promedios[columna]}");
}

