using System;
using System.Collections.Generic;

namespace Allergy.Objects
{
  public class Allergies
  {
    public int allergyScore {get; set;}
    private List<string> foundAllergies = new List<string> {};

    public Allergies(int allergyScore)
    {
      this.allergyScore = allergyScore;
    }
    public List<string> GetAll()
    {
      return foundAllergies;
    }
    public List<string> IsAllergy()
    {
      if(this.allergyScore == 1)
      {
        foundAllergies.Add("egg");
      }
      return foundAllergies;
    }
  }
}
