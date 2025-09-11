namespace Grundlagen_CSharp;
public class Article
{
    //attributes
    private int _id;
    private string _articleName;
    private decimal _price;
    private int _stockQuantity;
    private string _category;
    private bool _isAvailable;
    
    //Ctor
    public Article(int id, string name, decimal price, int stock, Category category bool available)
    {
        this._id = id;
        this._articleName = name;
        this._price = price;
        this._stockQuantity = stock;
        this.Category = category;
        this._isAvailable = available;
    }
    public Article() : this(0, "", 0.0m, 0, Category.Notspecified, false)
    {
    }
    
    //methods
    public int Id
    {
        get { return this._id; }
        set
        {
            if (value >= 0)
            {
                this._id = value;
            }
        }
    }
    
    //automatic property
    public string Articlename { get; set; }

    public decimal Price
    {
        get { return this._price; }
        set
        {
            if (value >= 0)
            {
                this._price = value;
            }
            else
            {
                this._price = null;
            }
        }
    }

    public bool IsAvailable
    {
        get { return this._isAvailable; }
        set
        {
            if (value)
            {
                this._isAvailable = true;
            }
            else
            {
                this._isAvailable = false;
            }
        }
    }
    
    //automatic property
    public Category Category { get; set; }
    
    //automatic property
    public int StockQuantity { get; set; }
    
    //ToString Methode 
    public override string ToString()
    {
        return $"Id: {this.Id}, Article Name: {this.Arcticlename}, " +
               $"Price in €: {this.Price}, Quantity: {this.StockQuantity}, Category: {this.Category}, " +
               $"Available: {this.IsAvailable}";
    }
}