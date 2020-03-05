using System.Collections.Generic;

namespace NumberWords.Models
{
  public class NumberConvert
  {
    public static Dictionary<int, string> ones = new Dictionary <int, string>()
    {
      {0, "zero"},
      {1, "one"},
      {2, "two"},
      {3, "three"},
      {4, "four"},
      {5, "five"},
      {6, "six"},
      {7, "seven"},
      {8, "eight"},
      {9, "nine"},
      {10, "ten"},
      {11, "eleven"},
      {12, "twelve"},
      {13, "thirteen"},
      {14, "fourteen"},
      {15, "fifteen"},
      {16, "sixteen"},
      {17, "seventeen"},
      {18, "eighteen"},
      {19, "nineteen"}
    };
   
    public static Dictionary<int, string> tens = new Dictionary <int, string>()
    {
      {20, "twenty"},
      {30, "thirty"},
      {40, "forty"},
      {50, "fifty"},
      {60, "sixty"},
      {70, "seventy"},
      {80, "eighty"},
      {90, "ninety"},

    };

    public int Number { get; set; }

    public NumberConvert(int number)
    {
      Number = number;
    }

    public string OnesName()
    {
      return ones[Number];
    }

    public string TensName()
    {
      int onesColumn = Number % 10;
      int tensColumn = Number - onesColumn;
      return (tens[tensColumn] + " " + ones[onesColumn]);
    }

  }
}