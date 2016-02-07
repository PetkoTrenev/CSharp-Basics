using System;

    class DeckOfCards
    {
        static void Main()
        {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] suits = new string[4] { "♣", "♦","♥", "♠" };
        for (int i = 0; i < 52; i++)
        {
            Console.Write("{0}", cards[i % 13]);
            Console.Write(suits[i / 13]);
        }
    }
}



