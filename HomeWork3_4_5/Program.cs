using HomeWork3_4_5;

Console.OutputEncoding = System.Text.Encoding.Unicode;

var author = new Author("Корній Чуковський");
var title = new Title("Муха Цокотуха");
var content = new Content("Пішла муха на базар і купила РПГ");

var myLitlleBook = new Book(author, title, content);
myLitlleBook.Show();
