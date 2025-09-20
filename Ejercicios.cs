using System;
using System.Collections.Generic;
using System.Linq;

class Ejercicios
{
    static void Solucion()
    {
        // === Listas de datos ===
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
        List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };
        List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
        List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };

        // === 1. Filtrar y mostrar números pares ===
        var pares = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Números pares:");
        pares.ForEach(Console.WriteLine);

        // === 2. Suma de los impares ===
        var sumaImpares = numbers.Where(n => n % 2 != 0).Sum();
        Console.WriteLine($"\nSuma de números impares: {sumaImpares}");

        // === 3. Ordenar números mayores que 5 descendente ===
        var mayoresQueCinco = numbers.Where(n => n > 5).OrderByDescending(n => n).ToList();
        Console.WriteLine("\nNúmeros mayores que 5 ordenados descendente:");
        mayoresQueCinco.ForEach(Console.WriteLine);

        // === 4. Contar números <= 3 ===
        var menoresOIgual3 = numbers.Count(n => n <= 3);
        Console.WriteLine($"\nCantidad de números <= 3: {menoresOIgual3}");

        // === 5. Multiplicar por 2 ===
        var multiplicados = numbers.Select(n => n * 2).ToList();
        Console.WriteLine("\nNúmeros multiplicados por 2:");
        multiplicados.ForEach(Console.WriteLine);

        // === 6. Ordenar nombres alfabéticamente ===
        var nombresOrdenados = names.OrderBy(n => n).ToList();
        Console.WriteLine("\nNombres ordenados alfabéticamente:");
        nombresOrdenados.ForEach(Console.WriteLine);

        // === 7. Nombres que empiezan con 'A' ===
        var nombresConA = names.Where(n => n.StartsWith("A")).ToList();
        Console.WriteLine("\nNombres que empiezan con A:");
        nombresConA.ForEach(Console.WriteLine);

        // === 8. Nombres con más de 5 caracteres ===
        var nombresLargos = names.Count(n => n.Length > 5);
        Console.WriteLine($"\nCantidad de nombres con más de 5 caracteres: {nombresLargos}");

        // === 9. Concatenar nombres ===
        var nombresConcatenados = names.Aggregate((a, b) => $"{a} {b}");
        Console.WriteLine("\nNombres concatenados:");
        Console.WriteLine(nombresConcatenados);

        // === 10. Nombre más largo ===
        var nombreMasLargo = names.OrderByDescending(n => n.Length).First();
        Console.WriteLine($"\nNombre más largo: {nombreMasLargo}");

        // === 11. Verificar si todas las palabras tienen más de 3 caracteres ===
        var todasLargas = words.All(w => w.Length > 3);
        Console.WriteLine($"\n¿Todas las palabras tienen más de 3 caracteres?: {todasLargas}");

        // === 12. Primera palabra que empieza con 'b' ===
        var palabraConB = words.FirstOrDefault(w => w.StartsWith("b"));
        Console.WriteLine($"\nPrimera palabra que empieza con 'b': {palabraConB}");

        // === 13. Contar palabras que contienen 'e' ===
        var palabrasConE = words.Count(w => w.Contains("e"));
        Console.WriteLine($"\nCantidad de palabras que contienen 'e': {palabrasConE}");

        // === 14. Palabras en mayúsculas ===
        var palabrasMayus = words.Select(w => w.ToUpper()).ToList();
        Console.WriteLine("\nPalabras en mayúsculas:");
        palabrasMayus.ForEach(Console.WriteLine);

        // === 15. ¿Alguna palabra termina en 'y'? ===
        var terminaEnY = words.Any(w => w.EndsWith("y"));
        Console.WriteLine($"\n¿Alguna palabra termina en 'y'?: {terminaEnY}");

        // === 16. Combinar y ordenar data y moreData ===
        var combinadas = data.Concat(moreData).OrderBy(n => n).ToList();
        Console.WriteLine("\nData y moreData combinadas y ordenadas:");
        combinadas.ForEach(Console.WriteLine);

        // === 17. Suma de pares en data ===
        var sumaPares = data.Where(n => n % 2 == 0).Sum();
        Console.WriteLine($"\nSuma de los números pares en data: {sumaPares}");

        // === 18. Número más grande en data ===
        var mayorEnData = data.Max();
        Console.WriteLine($"\nNúmero más grande en data: {mayorEnData}");

        // === 19. Unir listas sin duplicados ===
        var sinDuplicados = data.Union(moreData).ToList();
        Console.WriteLine("\nUnión de listas sin duplicados:");
        sinDuplicados.ForEach(Console.WriteLine);

        // === 20. Promedio de moreData y números en data mayores a ese promedio ===
        var promedioMoreData = moreData.Average();
        var mayoresAlPromedio = data.Where(n => n > promedioMoreData).ToList();
        Console.WriteLine($"\nPromedio de moreData: {promedioMoreData}");
        Console.WriteLine("Números en data mayores que ese promedio:");
        mayoresAlPromedio.ForEach(Console.WriteLine);

        // === 21. Contar primos en moreData ===
        var cantidadPrimos = moreData.Count(EsPrimo);
        Console.WriteLine($"\nCantidad de números primos en moreData: {cantidadPrimos}");
    }

    // Función para determinar si un número es primo
    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}
