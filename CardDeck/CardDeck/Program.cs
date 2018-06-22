using System;
using CardDeck.Classes;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Instantiation
            Deck<Cards> deck = new Deck<Cards>();

            //Generate Complete Deck
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    deck.Add(new Cards(j, i));
                }
            }


            //Shuffle
            deck.Shuffle();


            //Draw 10 Random Cards (Adding to Hand / Removing from Deck)
            Deck<Cards> hand = new Deck<Cards>();
            for (int i = 0; i < 15; i++)
            {
                hand.Add(deck.Remove());
            }


            //Show 10 Cards
            Console.WriteLine("Your hand:\n");
            foreach (Cards card in hand)
                Console.WriteLine(card.ToString());


            //Shuffle Again
            hand.Shuffle();


            //Show Cards again
            Console.WriteLine("\nShuffled:\n");
            foreach (Cards card in hand)
                Console.WriteLine(card.ToString());


            Console.ReadLine();
        }
    }
}
