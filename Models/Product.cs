using System;

namespace Uppfinnaren.Models;

public class Product
{
    public int ProductId {get; set;}
    public string Name {get; set;} = string.Empty;
    //public string Image {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public int Price {get; set;}
}
