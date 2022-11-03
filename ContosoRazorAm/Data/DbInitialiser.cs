using ContosoRazorAm.Models;

namespace ContosoRazorAm.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(ApplicationDbContext context)
        {
            AddStudents(context);

            AddModules(context);

            AddEnrollments(context);
        }

        private static void AddEnrollments(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Enrollments.Any())
            {
                return;   // DB has been seeded
            }

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,ModuleID=8,Grade=Grade.A},
                new Enrollment{StudentID=1,ModuleID=9,Grade=Grade.C},
                new Enrollment{StudentID=1,ModuleID=10,Grade=Grade.B},
                new Enrollment{StudentID=2,ModuleID=8,Grade=Grade.B},
                new Enrollment{StudentID=2,ModuleID=9,Grade=Grade.F},
                new Enrollment{StudentID=2,ModuleID=11,Grade=Grade.F},
                new Enrollment{StudentID=3,ModuleID=12},
                new Enrollment{StudentID=4,ModuleID=8},
                new Enrollment{StudentID=4,ModuleID=9,Grade=Grade.F},
                new Enrollment{StudentID=5,ModuleID=11,Grade=Grade.C},
                new Enrollment{StudentID=6,ModuleID=13,Grade=Grade.C},
                new Enrollment{StudentID=7,ModuleID=12,Grade=Grade.A}
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }

        private static void AddModules(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Modules.Any())
            {
                return;   // DB has been seeded
            }

            var Modules = new Module[]
            {
                new Module{Code = "CO550", Title="Web Apps",Credits=3},
                new Module{Code = "CO567", Title="Database Design",Credits=3},
                new Module{Code = "CO544", Title="OOSD",Credits=3},
                new Module{Code = "CO568", Title="Mobile Systems",Credits=4},
                new Module{Code = "CO587", Title="Networking",Credits=4},
                new Module{Code = "CO588", Title="Open Source Systems",Credits=3},
                new Module{Code = "CO566", Title="Software Engineering",Credits=4}
            };

            context.Modules.AddRange(Modules);
            context.SaveChanges();
        }

        private static void AddStudents(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Derek",LastName="Peacock",EnrollmentDate=DateTime.Parse("2019-09-01")},
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
        }
    }
}
