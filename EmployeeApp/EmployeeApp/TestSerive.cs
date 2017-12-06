using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp
{
  public interface ITestService
  {
    int Test(int input);
  }

  public class TestSerive : ITestService
  {
    public int Test(int input)
    {
      return input + 10;
    }
  }
}
