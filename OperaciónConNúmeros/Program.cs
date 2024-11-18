// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int sum = 7 + 5;
Console.WriteLine("Sum: " + sum);
int difference = 7 - 5;
Console.WriteLine("Difference: " + difference);
int product = 7 * 5;
Console.WriteLine("Product: " + product);
int quotient = 7 / 5;
Console.WriteLine("Quotient: " + quotient);
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal Quotient: {decimalQuotient}");

//resto despues de la division de enteros
Console.WriteLine($"Modulos de 200 / 5:  { 200 % 5}");
Console.WriteLine($"Modulos de 7 / 5: {7 % 5}");

//orden de la operaciones
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

//OPERADORE DE ASIGNACION
//incremento y decremento
int value = 0; //value is now 0
value = value + 5; // value is now 5
value += 5; // value is now 10

int value4 = 0; //value is now 0
value4 = value4 + 1; //value is now 1
value4++; //value is now 2

//si usa el operador delante del valor ++value, el incremento se producirá antes de recuperar el valor
//operador despues del valor value++ incrementará el valor una vez recuperado

int value5 = 1;
value5 = value5 + 1;
Console.WriteLine("First Increment: " + value5);

value5 += 1;
Console.WriteLine("Second Increment: " + value5);

value5++;
Console.WriteLine("Third Increment: " + value5);

value5 = value - 1;
Console.WriteLine("First Decrement: " + value5);

value5 -= 1;
Console.WriteLine("Second Decrement: " + value5);

value5--;
Console.WriteLine("Third decrement: " + value5);

int value6 = 1;
value6++;
Console.WriteLine("First: " + value6);
Console.WriteLine($"Second: {value6++}");
Console.WriteLine("Third: " + value6);
Console.WriteLine("Fourth: " + (++value6));

//ejeercicio
int farenheit = 94;
decimal celcius = (farenheit - 32m) * (5m / 9m);

Console.WriteLine($"the temperature is {celcius} celcius");

