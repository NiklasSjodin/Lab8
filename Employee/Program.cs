namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employeeInfo = new Stack<Employee>();

            Employee employeee1 = new Employee(1, "Niklas", "Male", 50000);
            Employee employeee2 = new Employee(2, "Linda", "Female", 50000);
            Employee employeee3 = new Employee(3, "Christoffer", "Male", 40000);
            Employee employeee4 = new Employee(4, "Monkey D Luffy", "Male", 100000);
            Employee employeee5 = new Employee(5, "Roronoa Zoro", "Male", 80000);

            employeeInfo.Push(employeee1);
            employeeInfo.Push(employeee2);
            employeeInfo.Push(employeee3);
            employeeInfo.Push(employeee4);
            employeeInfo.Push(employeee5);

            foreach (Employee emp in employeeInfo)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}");
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Retrive Using Pop Method\n");

            while (employeeInfo.Count > 0)
            {
                Employee popEmployee = employeeInfo.Pop();
                Console.WriteLine($"ID: {popEmployee.Id}, Name: {popEmployee.Name}, Gender: {popEmployee.Gender}, Salary: {popEmployee.Salary}");
                Console.WriteLine($"Items left in stack = {employeeInfo.Count}");
            }

            employeeInfo.Push(employeee1);
            employeeInfo.Push(employeee2);
            employeeInfo.Push(employeee3);
            employeeInfo.Push(employeee4);
            employeeInfo.Push(employeee5);

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Retrive Using Peek Method\n");

            if (employeeInfo.Count >= 3) 
            {
                Employee peekEmployee = employeeInfo.Peek();
                Console.WriteLine($"ID: {peekEmployee.Id}, Name: {peekEmployee.Name}, Gender: {peekEmployee.Gender}, Salary: {peekEmployee.Salary}");
                Console.WriteLine($"Items left in stack = {employeeInfo.Count}");

                Employee peekEmployee2 = employeeInfo.Peek();
                Console.WriteLine($"ID: {peekEmployee2.Id}, Name: {peekEmployee2.Name}, Gender: {peekEmployee2.Gender}, Salary: {peekEmployee2.Salary}");
                Console.WriteLine($"Items left in stack = {employeeInfo.Count}");

                Console.WriteLine("------------------------------------------------");

                if (employeeInfo.Contains(employeee3))
                {
                    Console.WriteLine($"Emp3 is in stack");
                }
                else 
                {
                    Console.WriteLine($"Emp3 is not in the stack.");
                }

                Console.WriteLine("------------------------------------------------");

                List<Employee> employeeList = new List<Employee>();

                employeeList.Add(employeee1);
                employeeList.Add(employeee2);
                employeeList.Add(employeee3);
                employeeList.Add(employeee4);
                employeeList.Add(employeee5);

                if (employeeList.Contains(employeee2))
                {
                    Console.WriteLine($"Employee2 object exists in the list\n");
                }
                else 
                {
                    Console.WriteLine("Employee2 doesn't exist in the list");
                }

                Employee firstMaleEmployee = employeeList.Find(employee => employee.Gender == "Male");
                if (firstMaleEmployee != null)
                {
                    Console.WriteLine($"First Male Employee: ID: {firstMaleEmployee.Id}, Name: {firstMaleEmployee.Name}, Gender: {firstMaleEmployee.Gender}, Salary: {firstMaleEmployee.Salary}\n");
                }
                else
                {
                    Console.WriteLine("No Male Employee found");
                }

                List<Employee> maleEmployees = employeeList.FindAll(employee => employee.Gender == "Male");
                Console.WriteLine("Male Employees:");
                foreach (Employee maleEmployee in maleEmployees)
                {
                    Console.WriteLine($"ID: { maleEmployee.Id}, Name: { maleEmployee.Name}, Gender: { maleEmployee.Gender}, Salary: { maleEmployee.Salary}");
                }
            }
        }

    }
}