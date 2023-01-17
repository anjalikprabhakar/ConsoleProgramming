
using System.Globalization;
using CsvHelper;


string path = Environment.CurrentDirectory;
string[] pathSplit = path.Split(@"\".ToCharArray());
var list = pathSplit.TakeWhile(x => x != "bin").ToList();
list.Add("Statements");
list.Add("statement.csv");
String pathString = string.Join(@"/", list.ToArray());
Console.WriteLine(pathString);



using var streamReader = File.OpenText(pathString);
using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);

var statement = new Statement(date,amount);


double balance = 0.0;
double monthlybalance = 0.0;

var result =
from data in statement.Take(int.MaxValue)
group data by new { date = data.Date.ToString("MMM") } into newData
select new
{
    Month = newData.Key.date,
    Blance = newData.Sum(x => x.Amount),

};
foreach (var item in result)
{
    Console.WriteLine($"{item.Month}------------------{item.Blance}");
    balance += item.Blance;
}
Console.WriteLine($"Net Balance------------------{balance}");











