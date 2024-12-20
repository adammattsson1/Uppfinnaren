using System;
using System.ComponentModel.DataAnnotations;

namespace Uppfinnaren.Models;

public class Product
{
    public int ProductId {get; set;}
    public int CategoryId {get; set;}
    public string Name {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public int Price {get; set;}
}
