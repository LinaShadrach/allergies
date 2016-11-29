using Xunit;
using System;
using System.Collections.Generic;
using Allergy.Objects;

namespace  Allergy
{
  public class AllergyTest
  {
    [Fact]
    public void IsAllergy_AllergicToEggs_true()
    {
      //Arrange
      int allergyScore = 1;
      Allergies newAllergies = new Allergies(allergyScore);
      List<string> eggList = new List<string> {"eggs"};
      //Assert
      Assert.Equal(eggList, newAllergies.IsAllergy());
    }

    [Fact]
    public void IsAllergy_HighestAllergy_true()
    {
      //Arrange
      int allergyScore = 128;
      Allergies newAllergies = new Allergies(allergyScore);
      List<string> catList = new List<string> {"cats"};
      Assert.Equal(catList, newAllergies.IsAllergy());
    }
    [Fact]
    public void IsAllergy_AllAllergies_true()
    {
      //Arrange
      int allergyScore = 255;
      Allergies newAllergies = new Allergies(allergyScore);
      List<string> allList = new List<string> {"cats", "pollen", "chocolate", "tomatoes", "strawberries", "shellfish", "peanuts", "eggs"};
      Assert.Equal(allList, newAllergies.IsAllergy());
    }
  }

}
