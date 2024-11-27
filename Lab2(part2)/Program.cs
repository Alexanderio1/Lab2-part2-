using Lab2_part2_;

IPerson[] people = new IPerson[] 
{ 
    new Employee("John", "Doe", 30, "Manager", 5), 
    new Student("Jane", "Smith", 20, 2, "Physics"), 
    new Working("Alice", "Johnson", 40, "TechCorp", 8), 
    new Turner("Bob", "Brown", 35, "MetalWorks", 8, 3),
    new Undergraduate("Emily", "White", 22, 3, "Engineering", "MIT"),
    new part_time_student("David", "Green", 25, 1, "Law", "Work"), 
    new Programmer("Chris", "Blue", 28, "SoftwareHouse", 9, "C#") }; 
    foreach (var person in people) 
    { 
        person.Print(); 
        Console.WriteLine(person.ToString()); 
        Console.WriteLine(); 
    }