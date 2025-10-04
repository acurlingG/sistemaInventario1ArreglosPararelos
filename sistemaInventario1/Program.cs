
string[] articulos = new string[10];
float[] precios = new float[10];
int[] cantidad = new int[10];

int indice = 0;   // variable global

void SolicitarDatos()
{
    char opcion = 's';
    do
    {
        Console.WriteLine("Ingrese el articulo");
        articulos[indice] = Console.ReadLine();
        Console.WriteLine("Ingrese el precio");
        precios[indice] = float.Parse(Console.ReadLine());
        Console.WriteLine("Desea continuar s/n");
        opcion = char.Parse(Console.ReadLine());
        indice++;

    } while (!opcion.Equals('n'));

}

void Reporte()
{
    Console.WriteLine("Reporte de Inventario");
    Console.WriteLine("---------------------");
    for (int i = 0; i < indice; i++)
    {
        if (!precios[i].Equals(0))
        {
            Console.WriteLine($"Articulo: {articulos[i]}, Precio: {precios[i]}, Cantidad: {cantidad[i]}");
        }

    }
}


void ConsultarArticulo()
{
    Console.WriteLine("Ingrese el articulo a consultar");
    string articulo = Console.ReadLine();

    int i = 0;

    while ((i < indice) && (!articulos[i].Equals(articulo)))
        i++;

    if (i >= indice)
        Console.WriteLine("Articulo no encontrado");
    else
        Console.WriteLine($"Articulo: {articulos[i]}, Precio: {precios[i]}, Cantidad: {cantidad[i]}");

}


void IngresarCantidad()
{
    Console.WriteLine("Ingrese el articulo a consultar");
    string articulo = Console.ReadLine();

    int i = 0;

    while ((i < indice) && (!articulos[i].Equals(articulo)))
        i++;

    if (i >= indice)
        Console.WriteLine("Articulo no encontrado");
    else
        Console.WriteLine("Ingrese la cantidad a ingresar");
    int cant = int.Parse(Console.ReadLine());
    cantidad[i] += cant;
    Console.WriteLine($"El inventario ha sido actualizado");
}


void Modificar()
{
    Console.WriteLine("Ingrese el articulo a consultar");
    string articulo = Console.ReadLine();

    int i = 0;

    while ((i < indice) && (!articulos[i].Equals(articulo)))
        i++;

    if (i >= indice)
        Console.WriteLine("Articulo no encontrado");
    else
        Console.WriteLine("Ingrese el articulo");
    articulos[i] = Console.ReadLine();
    Console.WriteLine("Ingrese el precio");
    precios[i] = float.Parse(Console.ReadLine());
    Console.WriteLine("El articulo ha sido modificado");
}
void RetirarCantidad()
{

}

void SubmenuInventario()
{
    char opcion = 's';
    do
    {
        Console.WriteLine("Menu de Inventario");
        Console.WriteLine("1. Ingresar Cantidad");
        Console.WriteLine("2. Retirar Cantidad");
        Console.WriteLine("3. Salir");
        int opcionMenu = int.Parse(Console.ReadLine());
        switch (opcionMenu)
        {
            case 1:
                IngresarCantidad();
                break;
            case 2:
                // RetirarCantidad();
                break;
            case 3:
                return;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    } while (!opcion.Equals('n'));
}

void menu()
{
    char opcion = 's';
    do
    {
        Console.WriteLine("Menu de opciones");
        Console.WriteLine("1. Ingresar Articulo");
        Console.WriteLine("2. Reporte de Inventario");
        Console.WriteLine("3. Consulta de Inventario");
        Console.WriteLine("4. Inventario");
        Console.WriteLine("5. Modificar");
        Console.WriteLine("6. Salir");
        int opcionMenu = int.Parse(Console.ReadLine());
        switch (opcionMenu)
        {
            case 1:
                SolicitarDatos();
                break;
            case 2:
                Reporte();
                break;
            case 3:
                ConsultarArticulo();
                break;
            case 4:
                SubmenuInventario();
                break;
            case 5:
                Modificar();
                break;
            case 6:
                return;

            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    } while (true);
}

menu();