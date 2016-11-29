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
      if(this.AllergyScore>=64)
      {
        this.AllergyScore -=64;
        foundAllergies.Add("pollen");
      }
      if(this.AllergyScore>=32)
      {
        this.AllergyScore -=32;
        foundAllergies.Add("chocolate");
      }
      if(this.AllergyScore>=16)
      {
        this.AllergyScore -=16;
        foundAllergies.Add("tomatoes");
      }
      if(this.AllergyScore>=8)
      {
        this.AllergyScore -=8;
        foundAllergies.Add("strawberries");
      }
      if(this.AllergyScore>=4)
      {
        this.AllergyScore -=4;
        foundAllergies.Add("shellfish");
      }
      if(this.AllergyScore>=2)
      {
        this.AllergyScore -=2;
        foundAllergies.Add("peanuts");
      }
      if(this.AllergyScore == 1)
      {
        foundAllergies.Add("eggs");
      }
      return foundAllergies;
    }
  }
}
