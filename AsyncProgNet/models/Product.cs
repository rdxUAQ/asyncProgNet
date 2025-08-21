class Product
{
    private string? Id { get; set; }
    private float price { get; set; }
    private string? name { get; set; }

    public Product(string Id, float price, string name)
    {
        this.Id = Id;
        this.price = price;
        this.name = name;
        
    }

    override
    public string ToString()
    {
        return
        $"Id: {this.Id}\n" +
        $"Price: {this.price}\n" +
        $"Name: {this.name}\n";
    }
    
}