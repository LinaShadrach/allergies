using Nancy;
using System.Collections.Generic;
using System;
using Allergy.Objects;

namespace Allergy
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<string> foundAllergies = new List<string> {};
        return View["allergyScore.cshtml", foundAllergies];
      };
    Post["/new-score"] = _ => {
      int newScore = int.Parse(Request.Form["allergyScore"]);
      Allergies newAllergy = new Allergies(newScore);
      List<string> model = newAllergy.IsAllergy();
      Console.WriteLine("model-" + model[0]);
      return View["allergyScore.cshtml", model];
    };

    }
  }
}
