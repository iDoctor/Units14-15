// 14.3.3

var phoneBook = new List<Contact>();

// добавляем контакты
phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

var sortedPgoneBookList = phoneBook.OrderBy(x => x.Name).ThenBy(x => x.LastName).ToList();
foreach (var contact in sortedPgoneBookList)
{
    Console.WriteLine($"{contact.Name} {contact.LastName}: '{contact.PhoneNumber}'");
}



//15.6.6

var classes = new[]
{
    new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
    new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
    new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
};
var allStudents = GetAllStudents(classes);

Console.WriteLine(string.Join(" ", allStudents));

 
string[] GetAllStudents(Classroom[] classes)
{
    List<string> namesList = new List<string>();
    if (classes.Length > 0)
    {
        foreach (var student in classes[0].Students)
            namesList.Add(student);
        
        foreach (var singleClass in classes.Skip(1))
        {
            namesList = namesList.Concat(singleClass.Students).ToList();
        }
    }
    
    return namesList.ToArray();
}



// 14.3.3
public class Contact
{
    public Contact(string name, string lastName, long phoneNumber, String email)
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public String Name { get; }
    public String LastName { get; }
    public long PhoneNumber { get; }
    public String Email { get; }
}

//15.6.6
public class Classroom
{
    public List<string> Students = new List<string>();
}