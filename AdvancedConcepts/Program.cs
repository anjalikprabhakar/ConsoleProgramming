
//methods


Console.WriteLine("Enter the first Number");
 int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Second Number");
int num2 = Convert.ToInt32(Console.ReadLine());

 void Add(int a, int b){
    Console.WriteLine($"Addition : {a + b}");
}

Add(num1, num2);
Add(4, 5);


int GreaterThan(int a,int b,int c)
{
    int largest = a;
    if (b >largest) {
    largest= b;
    }
    if (c > largest) {
        largest = c;
    }
    return largest;
}


int largest=GreaterThan(4, 5, 6);
Console.WriteLine( largest);


//string


string fname = "fstname";
string lname = "lname";

if (fname.CompareTo(lname) == 0)
{
    Console.WriteLine("fstname and  last name areequl");
}

//arrays

string Tosplit = "a,b,c,d";
string[] names=Tosplit.Split(',');

int[] marks= new int[5];

for (int i = 0;i <= marks.Length; i++)
{
   Console.WriteLine("Enter Marks : ");
    marks[i]=Convert.ToInt32(Console.ReadLine());

}

for ( int i = 0; i <= marks.Length; i++)
{
    Console.WriteLine(marks[i]);

}


List <string> devs= new List<string>();
string dev = string.Empty;


while (!dev.Equals("-1"))
{
    Console.WriteLine("Enter dev name");
    dev = Console.ReadLine();
    if  (dev !=string.Empty && dev.Equals("-1"))
    devs.Add(dev);
}
foreach (string name in devs)
{
    Console.WriteLine(name); 
}



//datetime

DateTime date = new DateTime();
Console.WriteLine(date);

DateTime dob= new DateTime(1995,12,13);
Console.WriteLine(dob);


DateTime now = DateTime.Now;
Console.WriteLine(now.AddHours(1));




//exception handling

Console.WriteLine("Enter the first Number");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Second Number");
int n2 = Convert.ToInt32(Console.ReadLine());

try
{
    int c = n1 / n2;
    Console.WriteLine($"Result is {c}");
}
catch (DivideByZeroException e)
{

    Console.WriteLine($"Illegal operation {e.Message}");
}
catch (Exception ex)
{

    throw ex;
}
finally
{
    Console.WriteLine("Exit");
}

