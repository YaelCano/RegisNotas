internal class Program
{
    private static void Main(string[] args)
    {
        bool Bander = true;
        int seleccion = 0;
        List<Estudiantes> lstClase = new List<Estudiantes>();
        List<Notas> lstNotas = new List<Notas>();
        while (Bander)
        {
            Console.Clear();
            Console.WriteLine(" Colegio integrado de carare");
            Console.WriteLine(" Sistema de regsitro de notas");
            Console.WriteLine("         Menu Principal");
            Console.WriteLine("------------------------------");
            Console.WriteLine("| Bienvenido, seleccione lo que desea hacer: |");
            Console.WriteLine("| 1. Agregar Estudiante                      |");
            Console.WriteLine("| 2. Visualizar notas estudiantes            |");
            Console.WriteLine("| 3. Agregar                                 |");
            Console.WriteLine("| 4. Salir                                   |");
            Console.WriteLine("|--------------------------------------------|");
            try
            {
                seleccion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (seleccion)
                {
                    case 1:
                    Ingresar(lstClase,lstNotas);
                    break;
                    case 2:
                        Visualizar(lstClase,lstNotas);
                        break;
                    case 3:
                        Anotas(lstNotas);
                        break;
                    case 4:
                        Console
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        
        
        }
    }
}