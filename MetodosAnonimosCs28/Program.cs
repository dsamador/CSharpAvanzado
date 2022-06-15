
ObtenerDelegadoTexto miDelegado = delegate (string nombre)
{
    return "Hola, " + nombre;
};

Console.WriteLine(miDelegado("David"));
//DecirHola();
Mostrar(miDelegado);

//Delegado que recibe un delegado
static void Mostrar(ObtenerDelegadoTexto miDelegado)
{
    Console.WriteLine(miDelegado("Mundo"));
}

static void DecirHola()
{
    Console.WriteLine("Los metodos nombrados son compilados primero");
}

delegate string ObtenerDelegadoTexto(string nombre);

