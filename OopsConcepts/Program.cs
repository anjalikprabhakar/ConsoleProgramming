


string Fname = string.Empty;
int age = 0;
double salary = 0.00;
char gender = char.MinValue;
bool working = false;
string middleName = string.Empty;


Console.WriteLine("please enter ur name");
Fname = Console.ReadLine();
Console.WriteLine("please enter ur age");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please enter ur salary");
salary = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("please enter ur gender (M/F)");
gender = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Are u working? (true/false)");
working = Convert.ToBoolean(Console.ReadLine());



Person person = new Person();
person.FirstName = Fname;



Console.WriteLine($"your name is {Fname}");
Console.WriteLine($"your age is {age}");
Console.WriteLine($"your salary is {salary}");
Console.WriteLine($"your gender is {gender}");
Console.WriteLine($"Are u Working?  {working}");