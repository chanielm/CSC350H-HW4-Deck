﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Deck
{
    List<Card> cards = new List<Card>();

    //Deck Constructor
    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    List<Card> Cards { get { return cards; } }

    //Takes top card from deck (if deck is not empty, otherwise return null)
    public Card TakeTopCard()
    {   
        if (cards.Count == 0) return null;

        Card c = cards[0];
        cards.RemoveAt(0);
        c.FlipOver();
        return c;
    }

    //Shuffle Method
    public void Shuffle()
    {
        Random rand = new();
        for (int i = 0; i < cards.Count; i++) {
            Card temp = cards[0];
            cards[0] = cards[i];
            cards[i] = temp;
        }
    }

    //Cut method
    public void Cut(int index)
    {
        cards.RemoveRange(index, cards.Count - index);
    }
}

