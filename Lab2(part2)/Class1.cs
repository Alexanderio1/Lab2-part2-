using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2_part2_
{
    public interface IPerson
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        void Print();
    }
    
    public interface IStudent
    {
        int Course { get; set; }
        string Faculty { get; set; }
    }

    public abstract class Person: IPerson
    {
        public string name;
        public string surname;
        public int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public string Surname
        {
            set { this.surname = value; }
            get { return this.surname; }
        }
        public int Age
        {
            set { this.age = value; }
            get { return this.age; }
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {name}\nSurname: {surname}\nAge:{age}");
        }

        public override string ToString()
        {
            return $"Name: {name}\nSurname: {surname}\nAge:{age}";
        }
    }

    public class Employee:Person
    {
        public string rank;
        public int experience;

        public Employee(string name, string surname, int age, string rank, int experience)
            :base(name, surname, age)
        {
            this.rank = rank;
            this.experience = experience;
        }

        public string Rank
        {
            set { this.rank = value; }
            get { return this.rank; }
        }
        public int Experience
        {
            set { this.Experience = value; }
            get { return this.experience; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Звание: {rank}\nВыслуга{experience}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nЗвание: {rank}\nВыслуга{experience}";
        }
    }

    public class Student : Person, IStudent
    {
        public int course;
        public string faculty;

        public Student(string name, string surname, int age,  int course, string faculty)
            :base(name, surname, age)
        {
            this.course = course;
            this.faculty = faculty;
        }

        public int Course
        {
            set { this.course = value; }
            get { return this.course; }
        }
        public string Faculty
        {
            set { this.faculty = value;}
            get { return this.faculty; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Обучающийся на {course} курсе, факультете: {faculty}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Обучающийся на {course} курсе, факультете: {faculty}";
        }
    }

    public class Working : Person
    {
        public string nameOrganization;
        public int WorkDay;

        public Working(string name, string surname, int age, string nameOrganization, int WorkDay)
            :base(name, surname, age)
        {
            this.nameOrganization = nameOrganization;
            this.WorkDay = WorkDay;
        }

        public string NameOrganization
        {
            set { this.nameOrganization = value; }
            get { return this.nameOrganization; }
        }

        public int workday
        {
            set { this.WorkDay = value; }
            get { return this.WorkDay; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Название организации: {nameOrganization}, Рабочий день {WorkDay} часов");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nНазвание организации: {nameOrganization}, Рабочий день {WorkDay} часов";
        }
        
    }

    public class Turner : Working
    {
        public int rank;
        public Turner(string name, string surname, int age , string nameOrganization, int workday, int rank)
            :base(name, surname, age, nameOrganization, workday)
        {
            this.rank = rank;
        }

        public int Rank1 
        {
            set { this.rank = value; }
            get { return this.rank; }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Специальность токарь, разряд: {rank}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nСпециальность токарь, разряд: {rank}";
        }
    }

    public class Undergraduate : Student
    {
        public string university;
        public Undergraduate(string name, string surname, int age, int course, string faculty, string university)
            :base(name, surname, age, course, faculty)
        {
            this.university = university;
        }
        public string University
        {
            set { this.university = value; }
            get { return this.university; }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Обучающийся является студентом в университете: {university}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nОбучающийся является студентом в университете: {university}";
        }
    }
    public class part_time_student : Student
    {
        public string status;
        public part_time_student(string name, string surname, int age, int course, string faculty,string status)
            :base(name, surname, age, course, faculty)
        {
            this.status = status;
        }
        public string Status
        {
            set { this.status = value; }
            get { return this.status; }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Студент-заочник во внеучебное время:{status}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nСтудент-заочник во внеучебное время:{status}";
        }
    }

    public sealed class Programmer : Working
    {
        public string language;
        public Programmer(string name, string surname, int age, string nameOrganization, int WorkDay, string language)
            : base(name, surname, age, nameOrganization, WorkDay)
        {
            this.language = language;
        }
        public string Language
        {
            set { this.language = value; }
            get { return this.language; }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Программист пишет на языке:{language}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}Программист пишет на языке:{language}";
        }

    }
    
}
