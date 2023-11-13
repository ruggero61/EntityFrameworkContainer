using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataModel
{
  public class Book : IBook
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public int Pages { get; set; }
  }
}
