using demo.Contexts;
using demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision

            // EF Core: ORM in .NET
            // ORM

            // 1. Mapping
            //      Code First [Generate Table Per Class]
            //      DB First [Generate Class Per Table]
            //      L2E [C# Code (LINQ) ----> EF Core ----> SQL DB]

            // 3 Ways Generate
            //      1. TPC  : Table Per Class
            //      2. TPH  : Table Per Hierarchy
            //      3. TPCC : Table Per Concrete Class

            // Code


            #endregion

            // CRUD Operation
            // Create – Read – Update – Delete

            //DBContext context = new DBContext();

            //try
            //{
            //    // Code
            //}
            //finally
            //{
            //    context.Dispose();
            //}
            
            //using (DBContext context = new DBContext())
            //{
            //    // CRUD
            //}

            //Note : CLR Can't do operation on UnManaged Resourse Like Database or file 
            using DBContext context = new DBContext();

            #region Create - insert
            //// Create - insert

            //var employee = new Employee()
            //{
            //     Name = "Ahmed Ali",
            //    Address = "Cairo",
            //    Salary = 12000,
            //    Age = 23
            //};

            ////Console.WriteLine(context.Entry(employee).State); //Detached

            ////employee.Name = "Mohamed Ali";

            ////Console.WriteLine(context.Entry(employee).State); //Detached

            ////context.Employee.Add(employee);

            ////Console.WriteLine(context.Entry(employee).State); //Added

            ////var Result = context.SaveChanges();
            ////Console.WriteLine( Result);

            ////Console.WriteLine(context.Entry(employee).State); //Unchanged

            ////employee.Name = "Ahmed Ali";

            ////Console.WriteLine(context.Entry(employee).State); //Modified

            //Console.WriteLine(context.Entry(employee).State); // Detached

            //context.Entry(employee).State = EntityState.Added;

            //Console.WriteLine(context.Entry(employee).State); // Added

            //context.SaveChanges(); 
            #endregion

            #region Read - Select
            //// Read - Select

            ////var result = context.Employee.Where(e => e.EmpId == 30).FirstOrDefault();
            ////var result = context.Employee.FirstOrDefault(e => e.EmpId == 30);
            ////Console.WriteLine(context.Entry(result).State); //Unchanged(Tracked)
            ////                                                // Note : a state of Any Data from database is Unchanged
            ////result.Name = "Omar Ali";
            ////Console.WriteLine(context.Entry(result).State); //Modified

            ////Console.WriteLine( result?.Name);

            //var result = context.Employee.Select(e => e.Name);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Update

            ////Update

            //var result = context.Employee.FirstOrDefault(e => e.EmpId == 10);
            //Console.WriteLine(context.Entry(result).State); //Unchanged

            //result.Name = "Ahmed Ali";
            //Console.WriteLine(context.Entry(result).State); //Modified

            //context.Update(result);
            //Console.WriteLine(context.Entry(result).State); //Modified

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(result).State); //Unchanged 
            #endregion

            #region Delete

            //var result = context.Employee.FirstOrDefault(e => e.EmpId == 20);

            //Console.WriteLine(context.Entry(result).State); //Unchanged

            //context.Employee.Remove(result);

            //Console.WriteLine(context.Entry(result).State); //Deleted

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(result).State); //Detached

            #endregion

            Employee e = new Employee();
            
            Department d = new Department();

            

        }
    }
}
