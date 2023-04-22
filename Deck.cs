using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GreenvilleRevenueGUI
{
    class Deck
    {
        Random ranNumberGenerator;

        int currentcardnumber = -1;
        Card[] AllCards = new Card[52];
        public Deck()
        {
            ranNumberGenerator = new Random();
            LoadCards();
        }
        private void LoadCards()
        {
            Card ACard;
            string[] list = Directory.GetFiles(@"cards", "*.gif");

            for (int index = 0; index < 52; index++)
            {
                int value = GetNextCardValue(index);
                Image image = Image.FromFile(list[index]);

                ACard = new Card(image, value);
                AllCards[index] = ACard;
            }
        }

        private int GetNextCardValue(int currentcardnumber)
        {
            int cardvalue = 0;
            if (currentcardnumber < 33)
                cardvalue = (currentcardnumber / 4) + 2;
            else
            {
                cardvalue = 10;
            }
            if (currentcardnumber > 31 && currentcardnumber < 36)
                cardvalue = 11;//aces
            return cardvalue;
        }

        public Card GetNextCard()
        {
            currentcardnumber++;
            //int value = currentcardnumber;

            if (currentcardnumber >= 52)
            {
                currentcardnumber = 0;
                LoadCards();
            }

            return AllCards[currentcardnumber];

        }
        public int GetCurrentCardNumber()
        {
            return currentcardnumber;

        }
        public void shuffleCards()
        {
            int timestoshuffle = ranNumberGenerator.Next(0, 100);
            for (int index = 0; index < timestoshuffle; index++)
            {

                int r1 = ranNumberGenerator.Next(0, 51);
                int r2 = ranNumberGenerator.Next(0, 51);
                Card Card1 = AllCards[r1];
                Card Card2 = AllCards[r2];
                AllCards[r1] = Card2;
                AllCards[r2] = Card1;
            }
        }
    }
}