using Assighment.Contexts;
using Assighment.Entities;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            AppDbContext Context = new AppDbContext();

            // Create

            var course = new Course()
            {
                ID = 1,
                Name = ".Net",
                Description = "Programming"
            };

            Context.Courses.Add(course);

            var student = new Student()
            {
                ID = 1,
                FName = "omar",
                LName = "ali",
                Address = "Cairo",
                Age = 23
            };

            Context.Students.Add(student);

            var instructor = new Instructor()
            {
                ID = 1 ,
                Name = "Ahmed Ali",
                Address = "giza",
                Bouns = 1000,
                Salary = 12000,
                HourRate = 300
            };

            Context.Instructors.Add(instructor);

            var department = new Department()
            {
                ID = 1,
                Name = "CS"
            };

            Context.Departments.Add(department);

            var topic = new Topic()
            {
                ID = 1,
                Name = "delegate"
            };

            Context.Topics.Add(topic);


            var topic02 = new Topic()
            {
                ID = 2,
                Name = "java"
            };
            Context.Topics.Add(topic02);

            // Update

            var result01 = Context.Topics.FirstOrDefault(t => t.ID == 1);
            result01.Name = "Cpp";

            //Delete

            var result02 = Context.Topics.FirstOrDefault(t => t.ID == 2);
            Context.Topics.Remove(result02);


            Context.SaveChanges();

        }
    }
}
