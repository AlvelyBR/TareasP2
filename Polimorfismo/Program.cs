namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            DocentePorHora doc1 = new DocentePorHora("Alvely", "Bencosme", 192);
            Console.WriteLine($"Empleado: {doc1.nombre} {doc1.apellido} \nSueldo Mensual total:" + doc1.Salario());

            DocenteFijo docf1 = new DocenteFijo("Maria", "Mendez", 100000m, true);
            Console.WriteLine($"\nEmpleando: {docf1.nombre} {docf1.apellido}\nSueldo Mensual:" + docf1.Salario());

            Administrativo adm1 = new Administrativo("AA", "BB", 30000m, true, "Secretaria");
            Console.WriteLine($"\nEmpleando: {adm1.nombre} {adm1.apellido}\nSueldo Mensual:" + adm1.Salario());


        }
    }
}