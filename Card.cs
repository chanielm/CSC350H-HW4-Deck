/*

Class: Card
    Fields:
    - suit: Suit
    - rank: Rank
    - flipped: bool
    Properties:
    + Suit: Suit
    + Rank: Rank
    + IsFlipped: bool
    Methods:
    + Card(Suit, Rank)
    + FlipOver: void

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Card
{
    Suit suit;
    Rank rank;
    bool flipped;

    public Card(Suit s, Rank r) {
        suit = s;
        rank = r;
        flipped = false;
    }

    public Suit Suit { get { return suit; } }
    public Rank Rank { get { return rank; } }
    public bool IsFlipped { get { return flipped; } }

    public void FlipOver()
    {
        flipped = true;
    }
        
}
