using System.Collections.Generic;
namespace Marketplace.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public Vendor(string name)
    {
      Name = name;
    }
  }
}