using ContosoRazorAm.Models;

namespace ContosoRazorAm.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var Modules = new Module[]
            {
                new Module{Title="Web Apps",Credits=3},
                new Module{Title="Database Design",Credits=3},
                new Module{Title="OOSD",Credits=3},
                new Module{Title="Mobile Systems",Credits=4},
                new Module{Title="Networking",Credits=4},
                new Module{Title="Open Source Systems",Credits=3},
                new Module{Title="Software Engineering",Credits=4}
            };

            context.Modules.AddRange(Modules);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,ModuleID=1,Grade=Grade.A},
                new Enrollment{StudentID=1,ModuleID=2,Grade=Grade.C},
                new Enrollment{StudentID=1,ModuleID=3,Grade=Grade.B},
                new Enrollment{StudentID=2,ModuleID=1,Grade=Grade.B},
                new Enrollment{StudentID=2,ModuleID=2,Grade=Grade.F},
                new Enrollment{StudentID=2,ModuleID=4,Grade=Grade.F},
                new Enrollment{StudentID=3,ModuleID=5},
                new Enrollment{StudentID=4,ModuleID=1},
                new Enrollment{StudentID=4,ModuleID=2,Grade=Grade.F},
                new Enrollment{StudentID=5,ModuleID=3,Grade=Grade.C},
                new Enrollment{StudentID=6,ModuleID=6,Grade=Grade.C},
                new Enrollment{StudentID=7,ModuleID=5,Grade=Grade.A}
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
