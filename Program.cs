using Won7L15;

List<Student> students = new List<Student> {
    new Student(Guid.NewGuid(),"Popescu", "Andreea", 22, Specialization.Letters),
    new Student(Guid.NewGuid(),"Crina", "Ioana", 23, Specialization.Letters),
    new Student(Guid.NewGuid(),"Popescu", "Irina", 22, Specialization.Informatics),
    new Student(Guid.NewGuid(),"Alexandru", "Alin", 21, Specialization.Informatics),
    new Student(Guid.NewGuid(),"Ioan", "Mirela", 20, Specialization.Constructions),
    new Student(Guid.NewGuid(),"Mircea", "Marin", 31, Specialization.Constructions),
};


/*Afisarea tuturor studentilor*/
students.ForEach(student =>
{
    Console.WriteLine(student);
    Console.WriteLine();
});

/*Afisare cel mai in varsta student de la informatica*/

var olderStudent = students.OrderByDescending(student => student.Age).FirstOrDefault();
Console.WriteLine("The oldest student is: " + olderStudent);

/*Afisare cel mai tanar student*/

var youngestStudent = students.OrderBy(student => student.Age).FirstOrDefault();
var youngestStudent2 = students.Min(student => student.Age).ToString();
Console.WriteLine("The youngest student from the 2 methods is: " + youngestStudent + ";and has the age: " + youngestStudent2 );
Console.WriteLine();

/*Afisati in ordine crescatoare a varstei toti studentii de la litere*/

Console.WriteLine("The students from letters specialization are: ");
var lettersStudents = students.Where(s => s.Specialization == Specialization.Letters)
    .OrderBy(s => s.Age).ToList();
lettersStudents.ForEach(Console.WriteLine);

/*Afisati primul student de la constructii cu varsta de peste 20 de ani*/

Console.WriteLine("The first student from the construction with age over 20 is: ");
var constructionStudent = students.Where(s => s.Specialization == Specialization.Constructions)
    .OrderBy(s => s.Age).FirstOrDefault();
Console.WriteLine(constructionStudent);

/*Afisati studentii avand varsta egala cu varsta media a studentilor*/

var sumAge = students.Sum(s => s.Age);
var countStudent = students.Count();
var averageAge = sumAge / countStudent;

Console.WriteLine("The average age of students is: " + averageAge);

var age = students.Where(s => s.Age == averageAge).ToList();
age.ForEach(Console.WriteLine);

/*Afisati, in ordinea descrescatoare a varstei, 
si in ordine alfabetica, dupa numele de 
familie si dupa numele mic, toti studentii
cu varsta cuprinsa intre 18 si 35 de ani*/

var orderStudents = students.Where(s => s.Age > 18 && s.Age < 35).OrderByDescending(s => s.Age)
    .ThenBy(s => s.Name)
    .ThenBy(s => s.FirstName)
    .ToList();

Console.WriteLine("The students ordered: ");
orderStudents.ForEach(Console.WriteLine);

/*Afisati ultimul elev din lista folosind LINQ*/


var lastStudentFromList = students.LastOrDefault();
Console.WriteLine("The last student from the list is: " + lastStudentFromList);

/*Afisati mesajul “Exista si minori” daca in lista
creeata exista si persone cu varsta mai mica de 
18 ani. In caz contar afesati “Nu exista minori”
*/

var underAgeStudents = students.Any(s => s.Age < 18);

if (underAgeStudents)
{
    Console.WriteLine("There is under age students.");
}
else
{
    Console.WriteLine("There is no under age students");
}