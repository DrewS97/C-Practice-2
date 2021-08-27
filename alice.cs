using System;
using System.Collections.Generic;

namespace Practice2 {
  public class Alice {
    public static Dictionary<char, int> alice = new Dictionary<char, int>(){};

    public static void ListChars()
    {
      string test = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

      for(int i = 0; i < test.Length; i++)
      {
        char c = test[i];
        if(!alice.ContainsKey(c))
        {
          alice.Add(c, 1);
        }
        else
        {
          int value = alice[c];
          
          alice[c] = value + 1;
        }
      }

      foreach (KeyValuePair<char, int> kvp in alice)
      {
        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
      }
      
    }
  }
}