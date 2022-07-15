using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    private static List<Item> _instances = new List<Item> {};
    // constructor
    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }
  }
}