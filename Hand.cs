using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenvilleRevenueGUI
{
    class Hand
    {
        String NameofPlayer;
        Card[] MyCards = new Card[5];
        int totalvalue = 0;
        int numberofcards = 0;
        public Hand(String Name)
        {

            NameofPlayer = Name;


        }
        public void DealACardtoMe(Card ACard)
        {
            if (numberofcards < 5)
            {

                MyCards[numberofcards] = ACard;
                totalvalue = totalvalue + ACard.GetCardValue();
                numberofcards++;
            }
        }

        public int GetNumberofCards()
        {
            return numberofcards;
        }
        public int GetTotalValueofCards()
        {
            return totalvalue;
        }
        public void ResetHand()
        {
            totalvalue = 0;
            numberofcards = 0;
        }

    }
}
