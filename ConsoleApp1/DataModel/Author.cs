using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataModel
{
  public class Author : IAuthor
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string WebSite { get; set; }
  }
}
