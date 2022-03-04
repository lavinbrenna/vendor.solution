using System.Collections.Generic;

namespace Marketplace.Models
{
  public class Order
  {
    public string Title {get;set;}
    
    public Order(string title)
    {
      Title = title;
    }
  }
}