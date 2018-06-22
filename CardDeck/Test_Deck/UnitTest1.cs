using System;
using Xunit;
using CardDeck.Classes;

namespace Test_Deck
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddCardToDeck()
        {
            //Arrange
            Deck<Cards> deck = new Deck<Cards>();
            Cards myCard = new Cards(1, 1);

            //Act
            deck.Add(myCard);

            //Assert
            Assert.Equal(deck.allCards[0], myCard);
        }

        [Fact]
        public void CardGettersAndSettersWork()
        {
            //Arrange
            Cards myCard = new Cards(1, 1);

            //Act
            myCard.Rank = Cards.R.King;

            //Assert
            Assert.Equal(Cards.R.King, myCard.Rank);

        }

        [Fact]
        public void CanRemoveCardThatExistsFromDeck()
        {
            //Arrange
            Deck<Cards> deck = new Deck<Cards>();
            Cards myCard = new Cards(1, 1);
            deck.Add(myCard);

            //Act
            deck.Remove();

            //Assert
            Assert.Empty(deck);
        }

        [Fact]
        public void CannotRemoveCardThatDoesNotExist()
        {
            //Arrange
            Deck<Cards> deck = new Deck<Cards>();

            //Act
            Exception ex = Assert.Throws<Exception>(() => deck.Remove());

            //Assert
            Assert.Equal("Deck is Empty", ex.Message);
        }

        [Fact]
        public void DeckCanBeShuffled()
        {
            //Arrange
            Deck<Cards> deck = new Deck<Cards>();
            deck.Add(new Cards(1, 1));
            deck.Add(new Cards(2, 1));
            deck.Add(new Cards(3, 1));
            deck.Add(new Cards(4, 1));
            deck.Add(new Cards(5, 1));
            deck.Add(new Cards(6, 1));

            //Act
            Cards firstCard = deck.allCards[0];
            deck.Shuffle();
            Cards newFirstCard = deck.allCards[0];


            //Assert
            Assert.NotEqual(firstCard, newFirstCard);
        }
    }
}
