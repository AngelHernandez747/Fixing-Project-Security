using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class Card
    {
        Image image;
        int value;

        public Card(Image myimage, int myvalue)
        {
            image = myimage;
            value = myvalue;
        }

        public Image GetCardImage()
        {
            return image;
        }

        public int GetCardValue()
        {
            return value;
        }



    }
}
