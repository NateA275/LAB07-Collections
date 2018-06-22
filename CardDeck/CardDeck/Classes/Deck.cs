using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardDeck.Classes
{
    public class Deck<T> : IEnumerable
    {
        public T[] allCards = new T[13];
        public int counter;


        /// <summary>
        /// Add - Adds a New Card to Collection
        /// </summary>
        /// <param name="newCard"> <T> - New Card to be added to collection </T></param>
        public void Add(T newCard)
        {
            if (counter == allCards.Length)
            {
                Array.Resize(ref allCards, (allCards.Length * 2));
            }
            allCards[counter++] = newCard;
        }


        /// <summary>
        /// Remove - Removes the Card that is on the top of the Deck.
        /// </summary>
        /// <returns> Cards - Returns top card to user </returns>
        public T Remove()
        {
            if (counter > 0)
            {
                T draw = allCards[counter - 1];
                T[] newDeck = new T[--counter];
                for (int i = 0; i < counter; i++)
                    newDeck[i] = allCards[i];
                allCards = newDeck;
                return draw;
            }
            else
                throw new Exception("Deck is Empty");
        }


        /// <summary>
        /// Shuffle - Randomly Rearranges order of cards within deck
        /// </summary>
        public void Shuffle()
        {
            Random rand = new Random();

            for (int i = 0; i < counter; i++)
            {
                int r = i + rand.Next(counter - i);

                T temp = allCards[r];
                allCards[r] = allCards[i];
                allCards[i] = temp;
            }
        }


        //Allows for Enumeration outside of class
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < counter; i++)
            {
                yield return allCards[i];
            }
        }

        //Magic
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
