using JuegoDeCartas.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace JuegoDeCartas.Modelos
{
    public class Deck
    {
        public List<Card> Hand { get; set; }
        public List<Card> DiscardPile { get; set; }
        public List<Card> DrawPile { get; set; }

        public Deck(int defensa, int ataque, string personaje) { 
            Hand = new ();
            DiscardPile = new ();
            DrawPile = new ();
            for (int i = 0; i < 8; i++)
            {
                Card AttackCard = new ("Ataque", "Ataque", 1, ataque, Resources.baseAttackCard);
                Card DefenseCard = new ("Defensa", "Defensa", 1, defensa, Resources.baseDefenseCard);
                DrawPile.Add(DefenseCard);
                DrawPile.Add(AttackCard);
            }
            for (int i = 0; i < 4; i++)
            {
                Card HealCard = new ("Curar", "Curar", 1, 5, Resources.healBaseCard);
                DrawPile.Add(HealCard);
            }
        }

        public void AddCard(Card card)
        {
            DrawPile.Add (card);
        }

        public void Shuffle()
        {
            Random rng = new();
            int n = DrawPile.Count;
            while (n > 1) {
                n--;
                int k = rng.Next(n + 1);
                Card temp = DrawPile[k];
                DrawPile[k] = DrawPile[n];
                DrawPile[n] = temp;
            }
        }

        public void endTurn()
        {
            DiscardPile.AddRange(Hand);
            Hand.Clear();
        }

        public Card DrawCard()
        {
            if (DrawPile.Count == 0)
            {
                ResetDeck();
            }
            Card drawnCard = DrawPile[0];
            Hand.Add(drawnCard);
            DrawPile.Remove(drawnCard);
            return drawnCard;
        }

        public void AddCardToHand(Card card)
        {
            Hand.Add(card);
        }

        public void DiscardCard(Card card)
        {
            Hand.Remove(card);
            DiscardPile.Add(card);
        }

        public void ResetDeck()
        {
            DrawPile.AddRange(DiscardPile);
            DiscardPile.Clear();
            Shuffle();
        }

        public void CombatEnds()
        {
            DrawPile.AddRange(Hand);
            DrawPile.AddRange(DiscardPile);
            DiscardPile.Clear();
            Hand.Clear();
        }
    }
}
