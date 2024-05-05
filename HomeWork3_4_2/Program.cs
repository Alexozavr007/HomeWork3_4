using HomeWork3_4_2;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Оберіть тип документа");
Console.WriteLine("1 - DOC");
Console.WriteLine("2 - TXT");
Console.WriteLine("3 - XML");
var userOption = Console.ReadLine();

AbstractHandler obj  = null;
switch (userOption)
{
    case "1":
        obj = new DOCHandler();
        break;
    case "2":
        obj = new TXTHandler();
        break;
    case "3":
        obj = new XMLHandler();
        break;
    default: 
        Console.WriteLine("Неочікуваний вибір");
        break;
}
if (obj != null) { 
    obj.Change();
    obj.Create();
    obj.Save();
    obj.Open();
}
