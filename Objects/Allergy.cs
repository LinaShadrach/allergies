using System;
using System.Collections.Generic;

namespace Allergy.Objects
{
  public class Allergies
  {
    public int AllergyScore {get; set;}
    private List<string> foundAllergies = new List<string> {};

    public Allergies(int allergyScore)
    {
      this.AllergyScore = allergyScore;
    }
    public List<string> GetAll()
    {
      return foundAllergies;
    }
    public List<string> IsAllergy()
    {
      if(this.AllergyScore>=128)
      {
        this.AllergyScore -=128;
        foundAllergies.Add("cats");
      }
      if(this.AllergyScore == 1)
      {
        foundAllergies.Add("egg");
      }
      return foundAllergies;
    }
  }
}
