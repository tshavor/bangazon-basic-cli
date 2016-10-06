using System;
using System.Collections.Generic;

namespace Bangazon.Orders
{
  public class Order {
    //List is a private CLASS inside the System.Collections.Generic 
    private List<string> _products = new List<string>();
    //The < > tell C# what type of things will be  working with
    //the underscore is used by convention to tell other developers that this is a PRIVATE class.

    public List<string> products
    {
      get {
        return _products;
      }
    }
//Globally Unique Identifier (Guid)
    private Guid _orderNumber = System.Guid.NewGuid();
    
    public Guid orderNumber {
      get {
        return _orderNumber;
      }
    }
    public void addProduct(string product)
    {
      _products.Add(product);
    }

    public string listProducts()
    {
      string output = "";

      foreach (string product in _products)
      {
        output += $"\nYou ordered {product}";
      }

      return output;
    }
  }
}