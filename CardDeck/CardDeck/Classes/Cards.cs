using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck.Classes
{
    public class Cards
    {
        public R Rank { get; set; }
        public S Suit { get; set; }

        //Basic constructor
        public Cards(R rank, S suit)
        {
            Rank = rank;
            Suit = suit;
        }

        //Constructor that takes integers
        public Cards(int r, int s)
        {
            Rank = (R)r;
            Suit = (S)s;
        }

        //Possible Ranks
        public enum R
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
        }

        //Possible Suits
        public enum S
        {
            Spades = 1,
            Diamonds,
            Clubs,
            Hearts,
        }

        /// <summary>
        /// ToString - Returns a Card Object in String Format
        /// </summary>
        /// <returns>String - Representing Card Instance </returns>
        public override string ToString()
        {
            return ($"{Rank} of {Suit}");
        }
    }
}
