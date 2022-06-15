
static double Suma(double a, double b)
{
    Console.WriteLine($"a + b es = {a + b}");
    return a + b;
}

static double Division(double a, double b)
{
    Console.WriteLine($"a / b es = {a / b}");
    return a / b;
}

static double Resta(double a, double b)
{
    Console.WriteLine($"a - b es = {a - b}");
    return a - b;
}


HacerCalculo miSuma = Suma;
//miSuma(5.0, 4.0);

HacerCalculo miDivision = Division;
//miDivision(5.0, 4.0);

//Desde un solo delegado apuntamos a dos delegados
//Esto se llama multidifusion
HacerCalculo calculoMultiple = miSuma + miDivision;
calculoMultiple += Resta;//Podemos sumar metodos
calculoMultiple -= miSuma;//Podemos restar delegados
calculoMultiple(3.2, 3.2);

delegate double HacerCalculo(double x, double y);
