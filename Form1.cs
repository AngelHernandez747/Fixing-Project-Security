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
    public partial class Form1 : Form
    {

        Deck DeckofCards = new Deck();
        Hand PlayerHand;
        Hand DealerHand;
        Boolean FirstRun = true;
        Boolean DisplayResults = false;
        Boolean WinnerDecided = false;

        int cardsdealt = 0;

        //BackCard Image
        static string[] list2 = Directory.GetFiles(@"cards", "Wfswbackcard*.gif");
        Image Backimage = Image.FromFile(list2[0]);
        
        //Remember Values and Images
        int RememberValue;
        Image RememberImage;

        public Form1()
        {
         
            InitializeComponent();
            button1.AutoSize = true;
            this.Size = new Size(800, 1024);
            DeckofCards.shuffleCards();
            PlayerHand = new Hand("Player");
            DealerHand = new Hand("Dealer");

            if (FirstRun == true)
            {

                button2.Image = Backimage;
                label3.Text = " ";

                button3.Image = Backimage;
                label3.Text = " ";

                button4.Image = Backimage;
                label3.Text = " ";

                button5.Image = Backimage;
                label4.Text = " ";

                button6.Image = Backimage;
                label7.Text = " ";

                button7.Image = Backimage;
                label8.Text = " ";

                button8.Image = Backimage;
                label9.Text = " ";

                button11.Image = Backimage;
                label3.Text = " ";

                button12.Image = Backimage;
                label3.Text = " ";

                button13.Image = Backimage;
                label3.Text = " ";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WinnerDecided = false;
            int DealerVal1;
            int DealerVal2;

            if (FirstRun == true)
            {
                DeckofCards.shuffleCards();
                FirstRun = false;
            }

            Reset();

            Card ACard = DeckofCards.GetNextCard();
            DealerHand.DealACardtoMe(ACard);
            button2.Image = ACard.GetCardImage();
            label1.Text = " " + ACard.GetCardValue();

            DealerVal1 = ACard.GetCardValue();
            
            ACard = DeckofCards.GetNextCard();
            DealerHand.DealACardtoMe(ACard);
            button3.Image = Backimage;
            label2.Text = "??";

            DealACardtoPlayer();
            DealACardtoPlayer();

            int PlayerTotal = PlayerHand.GetTotalValueofCards();

            int cardnumber = DeckofCards.GetCurrentCardNumber();
            label10.Text = "Total Value of Dealer Hand ???";
            label11.Text = "Total Value of Player Hand " + PlayerHand.GetTotalValueofCards();

            RememberValue = ACard.GetCardValue();
            RememberImage = ACard.GetCardImage();

            DealerVal2 = ACard.GetCardValue();

            BlackJack((DealerVal1 + DealerVal2), PlayerTotal);

            cardsdealt = DeckofCards.GetCurrentCardNumber();
        }

        private void Reset()
        {

            DealerHand.ResetHand();
            PlayerHand.ResetHand();

            button4.Image = Backimage;
            label3.Text = " ";

            button5.Image = Backimage;
            label4.Text = " ";

            button6.Image = Backimage;
            label7.Text = " ";

            button7.Image = Backimage;
            label8.Text = " ";

            button8.Image = Backimage;
            label9.Text = " ";

            button11.Image = Backimage;
            label15.Text = " ";

            button12.Image = Backimage;
            label16.Text = " ";

            button13.Image = Backimage;
            label17.Text = " ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Play a card
            if (WinnerDecided == false) 
            { 
                DealACardtoPlayer(); 
            }

            cardsdealt = DeckofCards.GetCurrentCardNumber();
        }

        private void DealACardtoPlayer()
        {
            int cardnumber = PlayerHand.GetNumberofCards();

            if (cardnumber < 5)
            {
                Card ACard = DeckofCards.GetNextCard();
                PlayerHand.DealACardtoMe(ACard);
                cardnumber = PlayerHand.GetNumberofCards();
                switch (cardnumber)
                {
                    //FIRST CASE STATEMENT
                    case 1:
                        button4.Image = ACard.GetCardImage();
                        label3.Text = " " + ACard.GetCardValue();
                        break;
                    //SECOND CASE STATEMENT
                    case 2:
                        button5.Image = ACard.GetCardImage();
                        label4.Text = " " + ACard.GetCardValue();
                        break;
                    case 3:
                        button6.Image = ACard.GetCardImage();
                        label7.Text = " " + ACard.GetCardValue();
                        break;
                    case 4:
                        button7.Image = ACard.GetCardImage();
                        label8.Text = " " + ACard.GetCardValue();
                        break;
                    case 5:
                        button8.Image = ACard.GetCardImage();
                        label9.Text = " " + ACard.GetCardValue();
                        break;
                }
            }

            label11.Text = "Total Value of Player Hand " + PlayerHand.GetTotalValueofCards();
        }

        private void Remember() 
        {
            label2.Text = " " + RememberValue;
            button3.Image = RememberImage;
            label10.Text = "Total Value of Dealer Hand " + DealerHand.GetTotalValueofCards();
        }

        private void EvaluateCardsPlayer()
        {
            DisplayResults = false;
            Boolean Win = true;
            Boolean Tie = false;
            String Reason = "You Are Busted over 21!!";
            int totalDealervalue = DealerHand.GetTotalValueofCards();
            int totalPlayervalue = PlayerHand.GetTotalValueofCards();

            Remember();

            if (DisplayResults == false) 
            {
                DealerLogic();
            }

            totalDealervalue = DealerHand.GetTotalValueofCards();

            BlackJack(totalDealervalue, totalPlayervalue);


            //totalDealervalue = DealerHand.GetTotalValueofCards(); ;
            //totalPlayervalue = PlayerHand.GetTotalValueofCards();

            if (totalPlayervalue > 21 && DisplayResults == false)
            {
                Win = false;
            }

            else
            {
                if (totalPlayervalue < totalDealervalue && DisplayResults == false)
                {
                    Win = false;
                }

            }

            if (totalPlayervalue == totalDealervalue && DisplayResults == false) {
                Tie = true;
            }

                if (Win && Tie == false && DisplayResults == false)
            {
                MessageBox.Show("YOU WIN!!\nPlayer total is " + totalPlayervalue + "\nDealer total value is " + totalDealervalue, "COP2362 BlackJack!");
            }

            else if (Win == false && DisplayResults == false)
            {
                MessageBox.Show("YOU LOSE!!\nPlayer total is " + totalPlayervalue + "\nDealer total value is " + totalDealervalue, "COP2362 BlackJack!");
            }

            if (Tie == true && DisplayResults == false) {

                MessageBox.Show("IT'S A TIE!!\nPlayer total is " + totalPlayervalue + "\nDealer total value is " + totalDealervalue, "COP2362 BlackJack!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EvaluateCardsPlayer();
            WinnerDecided = true;
            cardsdealt = DeckofCards.GetCurrentCardNumber();
        }

        private void DealerLogic() {

            if (PlayerHand.GetTotalValueofCards() > 21)
            {
                Remember();

                MessageBox.Show("YOU ARE BUSTED OVER 21!! YOU LOSE!!\nPlayer total is " + PlayerHand.GetTotalValueofCards() + "\nDealer total value is "
                    + DealerHand.GetTotalValueofCards(), "COP2362 BlackJack!");

                DisplayResults = true;
            }

            else
            {
                while (DealerHand.GetTotalValueofCards() < 17 && DealerHand.GetNumberofCards() < 6)
                {
                    int Card = 0;
                    Card ACard = DeckofCards.GetNextCard();
                    DealerHand.DealACardtoMe(ACard);
                    button11.Image = ACard.GetCardImage();
                    label17.Text = " " + ACard.GetCardValue();
                    label10.Text = "Total Value of Dealer Hand " + DealerHand.GetTotalValueofCards();
                }

                if (DealerHand.GetTotalValueofCards() > 21)
                {
                    Remember();

                    MessageBox.Show("THE DEALER BUSTED OVER 21!! YOU WIN!!\nPlayer total is " + PlayerHand.GetTotalValueofCards() + "\nDealer total value is "
                        + DealerHand.GetTotalValueofCards(), "COP2362 BlackJack!");

                    DisplayResults = true;
                }
            }
        }

        private void BlackJack(int Dealer, int Player) {

            if (Dealer == 21 && Player == 21)
            {
                WinnerDecided = true;
                Remember();

                MessageBox.Show("DOUBLE BLACK JACK IT'S A TIE!!\nPlayer total is " + Player + "\nDealer total value is " + Dealer, "COP2362 BlackJack!");
                DisplayResults = true;
            }

            else if (Dealer == 21)
            {
                WinnerDecided = true;
                Remember();

                MessageBox.Show("DEALER WON WITH A BLACK JACK YOU LOSE!!\nPlayer total is " + Player + "\nDealer total value is " + Dealer, "COP2362 BlackJack!");
                DisplayResults = true;
            }

            else if (Player == 21) 
            {
                WinnerDecided = true;
                Remember();

                MessageBox.Show("BLACK JACK YOU WIN!!\nPlayer total is " + Player + "\nDealer total value is " + Dealer, "COP2362 BlackJack!");
                DisplayResults = true;
            }
        }
    }
}
