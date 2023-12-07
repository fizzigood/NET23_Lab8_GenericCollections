namespace NET23_Lab8_AmieM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Fem instanser/objekt av klassen Employee:
            var employee1 = new Employee(001, "Fjor Sigurdsson", "Male", 35000);
            var employee2 = new Employee(002, "Robin Karlsson", "Other", 35000);
            var employee3 = new Employee(003, "Hanna Nordström", "Female", 40000);
            var employee4 = new Employee(004, "Onnie Baummann", "Female", 20000);
            var employee5 = new Employee(005, "Gunnar Björnsson", "Male", 25000);

            
            //En stack för Employee som stoppar in instanserna/objekten av Employee i en Stack med hjälp av push-metoden:
            Stack<Employee> estack = new Stack<Employee>(); 
            estack.Push(employee1); 
            estack.Push(employee2); 
            estack.Push(employee3); 
            estack.Push(employee4); 
            estack.Push(employee5); 


            // Foreach-loop som skriver ut alla elementen i stacken:
            Console.WriteLine("Employee details:");
            foreach (var employee in estack)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            }
            Console.WriteLine("Total people hired: {0}", estack.Count);


            // While-loop som hämtar element från stacken med Pop-metoden:
            while (estack.Count > 0)
            {
                Employee employee = estack.Pop();
                Console.WriteLine($"This one quit: ID: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
                Console.WriteLine("Number of employees left: {0} ", estack.Count);
            }


            // Stoppar tillbaka employees i stacken med hjälp av push-metoden och list:
            var elist = new List<Employee> { employee1, employee2, employee3, employee4, employee5 };
            foreach (var employee in elist)
            {
                estack.Push(employee);
            }
            Console.WriteLine("\nTotal people re-hired to our employee stack, after they said that they were sorry: {0}", estack.Count);


            //Villkor med contains-metoden för att kolla om ett visst objekt finns i listan:
            Console.WriteLine("\nDid Hanna come back to work?");
            if (elist.Contains(employee3))
            {
                Console.WriteLine($"{employee3.Name} is in the building.");
            }
            else
            {
                Console.WriteLine($"{employee3.Name} did not apologize and wasn't welcome back.");
            }


            // Hittar första male employee med hjälp av find-metoden: 
            Employee maleEmployee = elist.Find(employee => employee.Gender == "Male");
            if (maleEmployee != null)
            {
                Console.WriteLine($"\nIf you need someone to open a jar or something, you can ask: ID: {maleEmployee.Id}, Name: {maleEmployee.Name}, Salary: {maleEmployee.Salary}");
            }
            else
            {
                Console.WriteLine("No male employees found. You will have to smash the jar in order to get to the jam.");
            }


            // Hitta alla male employees med hjälp av FindAll och skriver ut info med hjälp av for-loop:
            List<Employee> maleEmployees = elist.FindAll(employee => employee.Gender == "Male");
            Console.WriteLine("... or use this list of potential jar-openers:");
            for (int i = 0; i < maleEmployees.Count; i++)
            {
                Console.WriteLine($"ID: {maleEmployees[i].Id}, Name: {maleEmployees[i].Name}, Salary: {maleEmployees[i].Salary}");
            }

        }
    }
}