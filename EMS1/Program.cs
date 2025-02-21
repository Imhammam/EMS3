using EMS.Entity;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace EMS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var dbContext = new EMSDbcontext();
            // AddDepartment(dbContext);
            // AddPosition(dbContext);
            // AddEmployee(dbContext);
            //UpdateEmployee(dbContext);
           // StartProgram(dbContext);

            //RequestVacation(dbContext);
            //AllEmployee(dbContext);

           // ApproveVacation(dbContext);
           AddNewEmployee(dbContext);

        }

        private static void AddDepartment(EMSDbcontext dbContext)
        {
            var department1 = new Department("HR");
            var department2 = new Department("IT");
            var department3 = new Department("Administration");
            var department4 = new Department("Marketing");
            var department5 = new Department("Sales");
            var department6 = new Department("Operations");
            var department7 = new Department("Logistics");
            var department8 = new Department("Procurement");
            var department9 = new Department("Service");
            var department10 = new Department("Relations");
            var department11 = new Department("Quality Assurance");
            var department12 = new Department("Development");
            var department13 = new Department("Training");
            var department14 = new Department("Security");
            var department15 = new Department("Medical");
            var department16 = new Department("Engineering");
            var department17 = new Department("Maintenance");
            var department18 = new Department("Support");
            var department19 = new Department("Finance");
            var department20 = new Department("R&D");



            dbContext.Departments.Add(department1);
            dbContext.Departments.Add(department2);
            dbContext.Departments.Add(department3);
            dbContext.Departments.Add(department4);
            dbContext.Departments.Add(department5);
            dbContext.Departments.Add(department6);
            dbContext.Departments.Add(department7);
            dbContext.Departments.Add(department8);
            dbContext.Departments.Add(department9);
            dbContext.Departments.Add(department10);
            dbContext.Departments.Add(department11);
            dbContext.Departments.Add(department12);
            dbContext.Departments.Add(department13);
            dbContext.Departments.Add(department14);
            dbContext.Departments.Add(department15);
            dbContext.Departments.Add(department16);
            dbContext.Departments.Add(department17);
            dbContext.Departments.Add(department18);
            dbContext.Departments.Add(department19);
            dbContext.Departments.Add(department20);


            dbContext.SaveChanges();
        }
        private static void AddPosition(EMSDbcontext dbContext)
        {
            var position1 = new Position(1, "HR Manager");
            var position2 = new Position(2, "IT Support Specialist");
            var position3 = new Position(3, "Administrative Assistant");
            var position4 = new Position(4, "Marketing Manager");
            var position5 = new Position(5, "Sales Representative");
            var position6 = new Position(6, "Operations Manager");
            var position7 = new Position(7, "Logistics Coordinator");
            var position8 = new Position(8, "Procurement Officer");
            var position9 = new Position(9, " Service Representative");
            var position10 = new Position(10, "Public Relations Officer");
            var position11 = new Position(11, "QA Engineer");
            var position12 = new Position(12, "Business Development ");
            var position13 = new Position(13, "Training Manager");
            var position14 = new Position(14, "Security Manager");
            var position15 = new Position(15, "Medical Director");
            var position16 = new Position(16, "Project Engineer");
            var position17 = new Position(17, "Maintenance Technician");
            var position18 = new Position(18, "Technical Support ");
            var position19 = new Position(19, "Financial Analyst");
            var position20 = new Position(20, "Research Scientist");

            dbContext.Positions.Add(position1);
            dbContext.Positions.Add(position2);
            dbContext.Positions.Add(position3);
            dbContext.Positions.Add(position4);
            dbContext.Positions.Add(position5);
            dbContext.Positions.Add(position6);
            dbContext.Positions.Add(position7);
            dbContext.Positions.Add(position8);
            dbContext.Positions.Add(position9);
            dbContext.Positions.Add(position10);
            dbContext.Positions.Add(position11);
            dbContext.Positions.Add(position12);
            dbContext.Positions.Add(position13);
            dbContext.Positions.Add(position14);
            dbContext.Positions.Add(position15);
            dbContext.Positions.Add(position16);
            dbContext.Positions.Add(position17);
            dbContext.Positions.Add(position18);
            dbContext.Positions.Add(position19);
            dbContext.Positions.Add(position20);

            dbContext.SaveChanges();
        }

        private static void AddNewEmployee(EMSDbcontext dbcontext)
        {
            Console.WriteLine("Enter Name of Employee");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Department ID");
            int DepID = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Position ID");
            int PosID = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Gender");
            char Gen= char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Salary");
            decimal Sala = Decimal.Parse(Console.ReadLine());

            string id = GenerateEmployeeNumber(dbcontext);

            var emp = new Employee(id, name, DepID, PosID, Gen, Sala);

            dbcontext.Employees.Add(emp);
            dbcontext.SaveChanges();
        }

        private static void AddEmployee(EMSDbcontext dbcontext)
        {
            var employee1 = new Employee("1001", "Hammam Malabeh", 2, 2, 'M', 5000);
            var employee2 = new Employee("1002", "Ali Ahmed", 1, 1, 'M', 5000);
            var employee3 = new Employee("1003", "Omar Khalid", 3, 3, 'M', 6000);
            var employee4 = new Employee("1004", "Laila Hasan", 4, 4, 'F', 4800);
            var employee5 = new Employee("1005", "Mohamed Noor", 5, 5, 'M', 5200);
            var employee6 = new Employee("1006", "Nour Al-Deen", 6, 6, 'M', 5800);
            var employee7 = new Employee("1007", "Hana Sami", 7, 7, 'F', 5300);
            var employee8 = new Employee("1008", "Yousef Tamer", 8, 8, 'M', 5900);
            var employee9 = new Employee("1009", "Maya Adel", 9, 9, 'F', 6200);
            var employee10 = new Employee("1010", "Sara Mahmoud", 10, 10, 'F', 5500);

            dbcontext.Employees.Add(employee1);
            dbcontext.Employees.Add(employee2);
            dbcontext.Employees.Add(employee3);
            dbcontext.Employees.Add(employee4);
            dbcontext.Employees.Add(employee5);
            dbcontext.Employees.Add(employee6);
            dbcontext.Employees.Add(employee7);
            dbcontext.Employees.Add(employee8);
            dbcontext.Employees.Add(employee9);
            dbcontext.Employees.Add(employee10);
            dbcontext.SaveChanges();

        }

        private static void UpdateEmployee(EMSDbcontext dbcontext)
        {
            Console.WriteLine("Enter The Number Of Employee");
            string EmpNum = Console.ReadLine();

            var emp = dbcontext.Employees.Where(x => x.EmployeeNumber == EmpNum).FirstOrDefault();

            if (emp != null)
            {

                Console.WriteLine($"Employee found: {emp.EmployeeName}, Salary: {emp.Salary}");


                Console.WriteLine("Select the field to update:");
                Console.WriteLine("1. Update Name");
                Console.WriteLine("2. Update Salary");
                Console.WriteLine("3. Update Department");
                Console.WriteLine("4. Update Position");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        Console.Write("Enter the new name: ");
                        emp.EmployeeName = Console.ReadLine();
                        break;
                    case "2":

                        Console.Write("Enter the new salary: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal newSalary))
                        {
                            emp.Salary = newSalary;
                        }
                        else
                        {
                            Console.WriteLine("Invalid salary input.");
                        }
                        break;
                    case "3":

                        Console.Write("Enter the new department ID: ");
                        if (int.TryParse(Console.ReadLine(), out int newDeptId))
                        {
                            emp.DepartmentId = newDeptId;
                        }
                        else
                        {
                            Console.WriteLine("Invalid department ID.");
                        }
                        break;
                    case "4":

                        Console.Write("Enter the new position ID: ");
                        if (int.TryParse(Console.ReadLine(), out int newPositionId))
                        {
                            emp.PositionID = newPositionId;
                        }
                        else
                        {
                            Console.WriteLine("Invalid position ID.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        return;
                }


                dbcontext.SaveChanges();
                Console.WriteLine("Employee information updated successfully.");
            }
            else
            {
                Console.WriteLine("No Employee with this ID.");
            }
        }

        private static void StartProgram(EMSDbcontext dbcontext)
        {
            Console.WriteLine("Welcome to ITCONIC Company");
            Console.WriteLine("If You are Admin press 1");
            Console.WriteLine("If You are Employee press 2");

            string start = Console.ReadLine();
            switch (start)
            {
                case "1":
                    Console.WriteLine("Enter Your Admin ID And Password");
                    Console.WriteLine("Enter Your Admin ID : ");
                    string ID = Console.ReadLine();
                    Console.WriteLine("Enter Your Password : ");
                    string Pass = Console.ReadLine();
                    var check = dbcontext.Employees.Where(x => x.EmployeeNumber == "1001").FirstOrDefault();
                    if (check != null & Pass == "1234")
                    {
                        Console.WriteLine($"Welcome: {check.EmployeeName}");
                        Console.WriteLine("Select The Field :");
                        Console.WriteLine("1. Add Employee ");
                        Console.WriteLine("2. Update");
                        Console.WriteLine("3. Vacation");
                        Console.WriteLine("4. All Employee");
                        Console.WriteLine("5. Exit");

                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                AddNewEmployee(dbcontext);
                                break;
                            case "2":
                                UpdateEmployee(dbcontext);
                                break;
                            case "3":
                                ApproveVacation(dbcontext);
                                break;
                            case "4":
                                AllEmployee(dbcontext);
                                break;
                            case "5":
                                Console.WriteLine("Good Bye");
                                break;

                            default: Console.WriteLine("Wrong Number"); return;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Something Wrong");
                        return;
                    }
                    return;
                case "2":
                    Console.WriteLine("Enter Your Emplyee ID ");
                    string id = Console.ReadLine();
                    var checkk = dbcontext.Employees.Where(x => x.EmployeeNumber == id).FirstOrDefault();
                    if (checkk != null)
                    {
                        Console.WriteLine($"Welcome: {checkk.EmployeeName}");
                        Console.WriteLine("Select The Field :");
                        Console.WriteLine("1. Your Information");
                        Console.WriteLine("2. Vacation");
                        Console.WriteLine("3. Exit");

                        string choicee = Console.ReadLine();
                        switch (choicee)
                        {
                            case "1":
                                Console.WriteLine($"Employee ID : {checkk.EmployeeNumber}, Employee Name : {checkk.EmployeeName}, Department : {checkk.DepartmentId} , Position:{checkk.PositionID} " +
                                      $"Gender : {checkk.Gender} , Salary : {checkk.Salary} , Vacation Day Left : {checkk.VacationDayLeft}");
                                break;
                            case "2":
                                Console.WriteLine("Select");
                                Console.WriteLine("1. Request Vacation");
                                Console.WriteLine("2. Your Vacation");
                                Console.WriteLine("3. Exit");
                                string vacation = Console.ReadLine();
                                switch (vacation)
                                {
                                    case "1":
                                        RequestVacation(dbcontext);
                                        break;
                                    case "2":
                                        //vacation State
                                        break;
                                    case "3":
                                        Console.WriteLine("Good Bye");
                                        break;
                                    default:
                                        Console.WriteLine("Wring Number");
                                        return;
                                }
                                return;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Something Wrong");
                        return;
                    }


                    return;
            }



        }

        private static void RequestVacation(EMSDbcontext dbcontext)
        {
            Console.WriteLine("Enter Employee Number:");
            string empNum = Console.ReadLine();

            var employee = dbcontext.Employees.FirstOrDefault(x => x.EmployeeNumber == empNum);
            if (employee == null)
            {
                Console.WriteLine("No employee found with this number.");
                return;
            }
            Console.WriteLine($"Request Vacation For: {employee.EmployeeName}");

            Console.WriteLine("Enter The Description:");
            string description = Console.ReadLine();

            Console.WriteLine("Enter Vacation Type Code (e.g., A for Annual, S for Sick, M for Maternity):");
            string vacationTypeCode = Console.ReadLine();

            
            var vacationType = dbcontext.VacationTypes
                                        .FirstOrDefault(v => v.VacationTypeCode == vacationTypeCode);

            if (vacationType == null)
            {
                Console.WriteLine("Vacation type not found in the system. Would you like to add it? (y/n)");
                string addVacationTypeResponse = Console.ReadLine();

                if (addVacationTypeResponse.ToLower() == "y")
                {

                    Console.WriteLine("Enter the Vacation Type Name (e.g., Annual Leave, Sick Leave, etc.):");
                    string vacationTypeName = Console.ReadLine();

                    vacationType = new Vacation
                    {
                        VacationTypeCode = vacationTypeCode,
                        VacationTypeName = vacationTypeName
                    };

                    dbcontext.VacationTypes.Add(vacationType);
                    dbcontext.SaveChanges();

                    Console.WriteLine($"Vacation type '{vacationTypeName}' added successfully.");
                }
                else
                {
                    Console.WriteLine("Vacation request cancelled as the type was not found.");
                    return;
                }
            }

            Console.WriteLine("Enter Start Date (yyyy-mm-dd):");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
            {
                Console.WriteLine("Invalid start date format.");
                return;
            }

            Console.WriteLine("Enter End Date (yyyy-mm-dd):");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
            {
                Console.WriteLine("Invalid end date format.");
                return;
            }

            if (startDate > endDate)
            {
                Console.WriteLine("Start date cannot be after end date.");
                return;
            }

            int totalDays = (endDate - startDate).Days + 1;

            // OverLapping
            bool isOverlapping = dbcontext.VacationRequests
                .Any(v => v.EmployeeNumber == empNum && v.StateId != 3 &&
                          ((startDate >= v.StartDate && startDate <= v.EndDate) ||
                           (endDate >= v.StartDate && endDate <= v.EndDate)));

            if (isOverlapping)
            {
                Console.WriteLine("Error: Vacation period overlaps with an existing request.");
                return;
            }

            var vacationRequest = new VacationRequest
            {
                EmployeeNumber = empNum,
                VacationTypeCode = vacationType.VacationTypeCode,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                TotalVacationDays = totalDays,
                StateId = 1 // Pending
            };
            

            dbcontext.VacationRequests.Add(vacationRequest);
            dbcontext.SaveChanges();

            Console.WriteLine("Vacation request submitted successfully.");
            employee.VacationRequestID = vacationRequest.RequestId;
            dbcontext.Employees.Update(employee);
            dbcontext.SaveChanges();
        }


        private static void ApproveVacation(EMSDbcontext dbcontext)
        {
            
            var pendingRequests = dbcontext.VacationRequests
                                           .Include(vr => vr.RequestState) 
                                           .Include(vr => vr.Employee) 
                                           .Where(vr => vr.RequestState.StateId == 1) 
                                           .ToList();

            if (pendingRequests.Count == 0)
            {
                Console.WriteLine("No Request ");
                return;
            }

            Console.WriteLine("Waiting Request:");

            // Show All Request
            foreach (var vr in pendingRequests)
            {
                Console.WriteLine($"Employee ID: {vr.EmployeeNumber}, Request ID: {vr.RequestId}, " +
                                  $"Request State: {vr.RequestState.StateName}, " +
                                  $"Total Vacation Days: {vr.TotalVacationDays}");
            }

            // Admin select the State 
            Console.WriteLine("Write the Request id :");
            int requestId = int.Parse(Console.ReadLine());

            // Make sure the state is exiest
            var selectedRequest = pendingRequests.FirstOrDefault(vr => vr.RequestId == requestId);

            if (selectedRequest == null)
            {
                Console.WriteLine("Wrong number");
                return;
            }

            Console.WriteLine($"Employee Name: {selectedRequest.Employee.EmployeeName}, " +  
                              $"Total Vacation Days: {selectedRequest.TotalVacationDays}");

            // Check the day Left
            var employee = selectedRequest.Employee;  

            if (employee.VacationDayLeft < selectedRequest.TotalVacationDays)
            {
                Console.WriteLine("Error: Employee Does Not Have Days to Vacation");
                return;
            }

            // Accept or Decline
            Console.WriteLine("Approve The State ? (y/n)");
            string action = Console.ReadLine().ToLower();

            if (action == "y")
            {
                
                selectedRequest.StateId = 2; // Approved
                employee.VacationDayLeft -= selectedRequest.TotalVacationDays;

                Console.WriteLine("Enter Your Admin Id");
                string adminId= Console.ReadLine();
                var admin =dbcontext.Employees.Where(x=>x.EmployeeNumber==adminId) ;

                Console.WriteLine("Enter Your Admin Password");


                selectedRequest.ApprovedByEmployee = adminId;



                dbcontext.VacationRequests.Update(selectedRequest);
                dbcontext.Employees.Update(employee);
                dbcontext.SaveChanges();

                Console.WriteLine("Accepted The Request");
            }
            else if (action == "n")
            {
                Console.WriteLine("Enter Your Admin Id");
                string adminId = Console.ReadLine();
                var admin = dbcontext.Employees.Where(x => x.EmployeeNumber == adminId);

                Console.WriteLine("Enter Your Admin Password");


                selectedRequest.DeclineByEmployee = adminId;

                selectedRequest.StateId = 3; // Declined
                dbcontext.VacationRequests.Update(selectedRequest);
                dbcontext.SaveChanges();

                Console.WriteLine("Decline The Request");
            }
            else
            {
                Console.WriteLine("Select if Yes Or No");
            }
        }






        private static void AllEmployee(EMSDbcontext dbcontext)
        {
            foreach (var obj in dbcontext.Employees)
            {
                Console.WriteLine($"Employee ID : {obj.EmployeeNumber}, Employee Name : {obj.EmployeeName}, Department : {obj.DepartmentId} , Position:{obj.PositionID} " +
                    $"Gender : {obj.Gender} , Salary : {obj.Salary} ");
            }
        }

        private static string GenerateEmployeeNumber(EMSDbcontext dbContext)
        {
            
            var lastEmployee = dbContext.Employees
                .OrderByDescending(e => e.EmployeeNumber)
                .FirstOrDefault();

            if (lastEmployee == null)
            {
                return "1001"; 
            }

            // Convert to int then string
            if (int.TryParse(lastEmployee.EmployeeNumber, out int lastNumber))
            {
                return (lastNumber + 1).ToString("D4"); 
            }
            return "-9999";


        }
    }
}
