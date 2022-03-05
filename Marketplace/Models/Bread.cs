using System.Collections.Generic;

namespace Marketplace.Models
{
  public class Bread
  {
    public string BreadType{get;set;}

    private static List<Bread> _instances = new List<Bread>{};

    public Bread(string breadType)
    {
      BreadType = breadType;
      _instances.Add(this);
    }

    public static int GetLoafPrice()
    {
      int loafCount = _instances.Count;
      int loafPrice = 0;
      List<int>loafList = new List<int>{};
      for(int i = 0; i <= loafCount; i++)
      {
        loafList.Add(i);
      }
      foreach(int loaf in loafList)
      {
        if(loaf % 3 == 0)
        {
          loafPrice += 0;
        }
        else
        {
          loafPrice += 5;
        }
      }
      return loafPrice;
    }
    public static List<Bread> GetAllBread()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}