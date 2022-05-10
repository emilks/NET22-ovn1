/* Uppgift 1 
 * Klasser:
 * Employee och main
 * 
 * Uppgift 2
 * Employee har attributerna namn och lön 
 * Och metoder att skapa en employee och att skriva ut en
 */

public class Employee
{
    public string namn;
    public double lon;
    
    public Employee(string nyttNamn, double nyLon)
    {
        namn = nyttNamn;
        lon = nyLon;
    }

    public void PrintEmp()
    {
        Console.WriteLine("Anställd "+namn+" med lön "+lon);
    }
} 


class main
{
    static void Main()
    {
        Console.WriteLine("Välkommen!");
        bool exit = false;
        List<Employee> EmployeeList = new List<Employee>();
        while (!exit)
        {
            Console.WriteLine("Vill du lägga till en anställd skriv 1.");
            Console.WriteLine("Vill se alla anställda skriv 2.");
            Console.WriteLine("Vill du avsluta skriv 3.");

            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            if (val == 1){
                addEmployee(EmployeeList);
            }else if(val == 2)
            {
                listEmployees(EmployeeList);
            }else if(val == 3)
            {
                Console.WriteLine("Hej då");
                exit = true;
            }
            else
            {
                Console.WriteLine("Välj 1, 2 eller 3.");
            }
            Console.WriteLine("\n");
        }

    }

    static void addEmployee(List<Employee> EmployeeList)
    {
        Console.WriteLine("Skriv namn:");
        String namn = Console.ReadLine();
        Console.WriteLine("Skriv lön:");
        double lon = Convert.ToDouble(Console.ReadLine());

        var anstalld = new Employee(namn, lon);
        EmployeeList.Add(anstalld);
        anstalld.PrintEmp();

        return;
    }
    static void listEmployees(List<Employee> EmployeeList)
    {
        Console.WriteLine("Lista över alla anställda:");
        foreach(var i in EmployeeList)
        {
            i.PrintEmp();
        }
        return;
    }
}

