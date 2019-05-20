using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class CardsGame : Form
    {
        List<Card> cards = new List<Card>();
        Random random = new Random();
        CardsComparer cc;
        string DisplayCards()
        {
            string info = "5 Random cards";
            for (int i = 0; i < cards.Count; i++)
            {
                info += "\r\n" + cards[i].value + " of " + cards[i].suit;
            }
            return info;
        }
        void chooseRandomCards()
        {
            for (int i = 0; i < 5; i++)
            {
                Card card = new Card((Card.Value)random.Next(13), (Card.Suit)random.Next(4));
                if (!cards.Contains(card))
                {
                    cards.Add(card);
                    card = null;
                }
                else
                {
                    chooseRandomCards();
                }
            }
        }
        public CardsGame()
        {
            InitializeComponent();

        }

        private void randomCards_Click(object sender, EventArgs e)
        {
            chooseRandomCards();
            textBox1.Text = DisplayCards();
        }

        private void sortCards_Click(object sender, EventArgs e)
        {
            cc = new CardsComparer();
            cards.Sort(cc);
            textBox1.Text = DisplayCards();
        }
    }
}
