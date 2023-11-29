using System.Collections.Generic;

namespace OnetezSoft.Models
{
  public class UserOnboardingModel
  {
    public string id { get; set; }
    public string name { get; set; }
    public bool is_alone
    {
      get
      {
        return functions.Count == 1;
      }
    }
    public string url { get; set; }

    public List<FunctionOnboardingModel> functions { get; set; } = new();
  }
  public class FunctionOnboardingModel
  {
    public string id { get; set; }
    public string name { get; set; }
    public List<string> images { get; set; } = new();
  }
}
