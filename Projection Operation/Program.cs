List<string> words = new() { "I love coding", "I eat apple", "How are you" };

var result = words.SelectMany(e => e).ToList();


List<Product> products = new()
{
    new Product { Id = 1, Name="Mahmoud" , Phones={"12345" ,"2222222","4532111" } },
    new Product { Id = 2, Name="Ahmed",Phones={"876543" ,"23456","98754" }},
    new Product { Id = 3, Name="Kassem", Phones = { "12345765", "6524652", "9809123" }},
};

var phones = products.Select(e => e.Phones);

var phonesWithQuery = from product in products
                      select product.Phones;

var phonesWithSMany = products.SelectMany(e => e.Phones);

var phonesWithQuery1 = from product in products
                       from phone in product.Phones
                       select phone;

//List<int> ids = products.Select(x => x.Id).ToList();

var idss = from product in products
           select product.Id;


string[] colorName = { "Red", "Green", "Blue" };
string[] colorHex = { "FF0000", "00FF00", "0000FF" };

var colors = colorName.Zip(colorHex, (name, hex) => $"{name} : {hex}");


var first2Products = products.ToArray()[..3];
var last2Products = products.ToArray()[^2..];

var productsZip = first2Products.Zip(last2Products, (first, second) => $"{first.Name} : {second.Name}");

Console.WriteLine();
class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<string> Phones { get; set; } = new();
}