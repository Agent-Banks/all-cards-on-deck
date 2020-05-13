using System;
using System.Collections.Generic;
using System.Linq;

namespace all_cards_on_deck
{
  class Program
  {
    static void Main(string[] args)
    {
      // list created for suits and ranks of cards
      var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
      var ranks = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10","Jack", "Queen", "King", "Ace",};
      var deck = new List<string>();

      // assign and combine values to each card
      for (var suitIndex = 0; suitIndex < suits.Count(); suitIndex++)
      {
       for (var rankIndex = 0; rankIndex < ranks.Count(); rankIndex++)
       {
          var currentRank = ranks[rankIndex];
          var currentSuit = suits[suitIndex];
          var currentCard = $"The {currentRank} of {currentSuit}";
          deck.Add(currentCard);
       }
      }
      
      // make n = 52 since we are dealing with 52 elements
      var n = 52;
     //for firstIndex from n - 1 down to 1 do:
     for (var firstIndex = n-1; firstIndex >= 1; firstIndex--)
     {
     //secondIndex = random integer that is greater than or equal to 0 and LESS than firstIndex
       Random rnd = new Random();
       var secondIndex = rnd.Next(firstIndex); 
     //Now swap the values at firstIndex and secondIndex by doing this:
     var firstValue = deck[firstIndex];
     var secondValue = deck[secondIndex];
     deck[firstIndex] = secondValue;
     deck[secondIndex] = firstValue;
     //firstValue = the value from items[firstIndex]
     //secondValue = the value from items[secondIndex]
     //items[firstIndex] = secondValue
     //items[secondIndex] = firstValue
     }
     


    }
  }
}
