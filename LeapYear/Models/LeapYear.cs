using System.Collections.Generic;
using System;

namespace LeapYear.Models
{
  public class cLeapYear
  {
    private int _year;

    public cLeapYear(int year)
    {
      _year = year;
    }

    public bool IsLeapYear(int year)
    {
      if (year % 400 == 0)
      {
        return true;
      }
      else if (year % 100 == 0)
      {
        return false;
      }
      else
      {
        return year % 4 == 0;
      }
    }

    public int GetYear()
    {
      return _year;
    }
  }
}
