using System;

Deck deck = new();
deck.Shuffle();

// Take 10 cards from the shuffled deck & add to a list
List<Card> cards = [];
for (int i = 0; i < 10; i++) cards.Add(deck.TakeTopCard());

Console.WriteLine(cards[0].IsFlipped); // false

// Print the 10 cards collected from the shuffled deck
foreach (Card card in cards) {
    card.FlipOver();
    Console.WriteLine($"{card.Rank} of {card.Suit}");
}

Console.WriteLine(cards[0].IsFlipped); // true