using System;
using System.Collections.Generic;

namespace Marketplace.Models
{
  public class Order
  {
    public string Title {get;set;}
    public string Description {get;set;}
    public int Price {get;set;}
    public DateTime Date{get;set;}
    private static List<Order> _instances = new List<Order>{};
    //code not used in current state of project
    public List<Bread> Breads {get;set;}
    public List<Pastry> Pastries {get;set;}

    public int Id {get;}
    public Order(string title, string description, int price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
      Breads = new List<Bread>{};
      Pastries = new List<Pastry>{};
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public void AddBread(Bread bread)
    {
      Breads.Add(bread);
    }
    public void AddPastry(Pastry pastry)
    {
      Pastries.Add(pastry);
    }

//this code below for future exploration/for fun!
    public int GetOrderTotal()
    {
      int pastryTotal = Pastry.GetPastryPrice();
      int breadTotal = Bread.GetLoafPrice();
      int orderTotal = 0;
      orderTotal += pastryTotal;
      orderTotal += breadTotal;
      return orderTotal;
    }
  }
}