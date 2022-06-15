//Una expresion lambda es una funcion anonima que se puede usar para crear delegados o tipos de arbol de expresion
//al usar expresiones lambda, puedes escribir funciones locales que pueden pasarse como argumentos
//o devolverse como el valor de las llamadas a funciones
//las expresiones lambda son particularmente utiles para escribir expresiones de consulta de LINQ.


static int Sumar(int a, int b) => a + b;
static int Cuadrado(int i) => i * i;
static int PorDiez(int i) => i * 10;

static void HacerAlgo()
{
    Calculos mate = new Calculos(Cuadrado);    
    Console.WriteLine(mate(8));
    
    //Delegados
    List<int> lista = new List<int> { 0,1,2,3,4,5,6,7 };

    List<int> pares = lista.FindAll(delegate (int i) { return (i % 2 == 0); });
    foreach(int par in pares)    
        Console.WriteLine(par);

    List<int> impares = lista.FindAll(delegate (int i){ return (i % 2 != 0); }); 
    foreach(int impar in impares)    
        Console.WriteLine(impar);

    //Expresion lambda
    Console.WriteLine("");
    List<int> impares2 = lista.FindAll(x => x % 2 != 0);
    impares2.ForEach(i => Console.WriteLine(i));

    //Lambda y delegados
    mate = new Calculos(x => x * x * x);
    Console.WriteLine(mate(8));//512

    Console.WriteLine("");
    Comparacion comp = (a, Numero) => a == Numero.n;
    Console.WriteLine(comp(5, new Numero { n = 5}));
}


HacerAlgo();

class Numero
{
    public int n { get; set; }
}

delegate bool Comparacion(int i, Numero n);

delegate int Calculos(int i);
