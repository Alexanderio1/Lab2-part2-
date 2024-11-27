using Lab2_part2_;
namespace TestLab2_Part2_
{
    
    using System;
    using System.IO;
   
    

    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void PersonPropertiesTest()
        {
            var person = new Employee("John", "Doe", 30, "Manager", 5);
            Assert.AreEqual("John", person.Name);
            Assert.AreEqual("Doe", person.Surname);
            Assert.AreEqual(30, person.Age);
        }

       
    }

    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void EmployeePropertiesTest()
        {
            var employee = new Employee("John", "Doe", 30, "Manager", 5);
            Assert.AreEqual("Manager", employee.Rank);
            Assert.AreEqual(5, employee.Experience);
        }
    }

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void StudentPropertiesTest()
        {
            var student = new Student("Jane", "Smith", 20, 2, "Physics");
            Assert.AreEqual(2, student.Course);
            Assert.AreEqual("Physics", student.Faculty);
        }
    }

    [TestClass]
    public class WorkingTests
    {
        [TestMethod]
        public void WorkingPropertiesTest()
        {
            var working = new Working("Alice", "Johnson", 40, "TechCorp", 8);
            Assert.AreEqual("TechCorp", working.NameOrganization);
            Assert.AreEqual(8, working.WorkDay);
        }
    }

    [TestClass]
    public class TurnerTests
    {
        [TestMethod]
        public void TurnerPropertiesTest()
        {
            var turner = new Turner("Bob", "Brown", 35, "MetalWorks", 8, 3);
            Assert.AreEqual(3, turner.Rank1);
        }
    }

    [TestClass]
    public class UndergraduateTests
    {
        [TestMethod]
        public void UndergraduatePropertiesTest()
        {
            var undergraduate = new Undergraduate("Emily", "White", 22, 3, "Engineering", "MIT");
            Assert.AreEqual("MIT", undergraduate.University);
        }
    }

    [TestClass]
    public class PartTimeStudentTests
    {
        [TestMethod]
        public void PartTimeStudentPropertiesTest()
        {
            var part_time_student = new part_time_student("David", "Green", 25, 1, "Law", "Remote");
            Assert.AreEqual("Remote", part_time_student.Status);
        }
    }

    [TestClass]
    public class ProgrammerTests
    {
        [TestMethod]
        public void ProgrammerPropertiesTest()
        {
            var programmer = new Programmer("Chris", "Blue", 28, "SoftwareHouse", 9, "C#");
            Assert.AreEqual("C#", programmer.Language);
        }
    }

}