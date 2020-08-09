using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnings
{
    // FWGHEDO from,where,groupby,having,expression,distinct,orderby

    // Difference bw first and FirstOrDefault is First will return InvalidOperationException if element doesnot exist.
    // Single, SingleOrDefault throws an error if we have more than one element that mathches the condition.
    //deferred execution vs immediate execution linq
    /*
     * this is defered execution 
     var def = (from s in studentList
               where s.age > 12 && s.age < 20
               select s);
      //Add new student here. then it will be taken in the defered execution. 
       foreach(var item in def) <<<< Execution is done here 
       {
               
        }
     *this is immediate execution 
     var imm = (from s in studentList
               where s.age > 12 && s.age < 20
               select s).ToList();

        */

    //Difference between List<List<>> Select and SelectMany List<>

    /*
     * Left Join
   from e in Employee.GetAllEmployees()
               join d in Department.GetAllDepartments()
               on e.DepartmentID equals d.ID into eGroup
               from d in eGroup.DefaultIfEmpty()
               select new
                   {
                        EmployeeName = e.Name,
                        DepartmentName = d == null ? "No Department" : d.Name
                      };
    */
    /*
     * Inner Join
     * var result = from e in Employee.GetAllEmployees()
                   join d in Department.GetAllDepartments()
                   on e.DepartmentID equals d.ID
                   select new
                   {
                       EmployeeName = e.Name,
                       DepartmentName = d.Name
                   };

     */
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardID { get; set; }
        public int Age { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }

    }
    public static class LearnLinq
    {
        public static void LinqOperations()
        {

            IList<Student> studentList = new List<Student>() {
                    new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID =1 },
                    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 },
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 },
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =2 },
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
                    };

            IList<Standard> standardList = new List<Standard>() {
                    new Standard(){ StandardID = 1, StandardName="Standard 1"},
                    new Standard(){ StandardID = 2, StandardName="Standard 2"},
                    new Standard(){ StandardID = 3, StandardName="Standard 3"}
                    };

            var filtered = from s in studentList
                           where s.StandardID == 1
                           select new
                           {
                               s.StudentID,
                               s.StudentName
                           };

            foreach (var item in filtered)
            {
                Console.WriteLine(item.StudentName);
            }

            // Inner join
            var innerJoin = from std in standardList
                            join s in studentList
                            on std.StandardID equals s.StandardID
                            select new
                            {
                                s.StudentID,
                                s.StudentName,
                                std.StandardName
                            };


            // left join
            var groupJoin = from std in standardList
                            join s in studentList
                            on std.StandardID equals s.StandardID
                            into studentGroup
                            select new
                            {
                                Students = studentGroup,
                                StandardName = std.StandardName
                            };

            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.StandardName);
                foreach (var stud in item.Students)
                    Console.WriteLine(stud.StudentName);
            }

        }

    }
}
