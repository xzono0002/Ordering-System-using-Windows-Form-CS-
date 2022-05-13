using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ordering_System
{
    public partial class PastriesMenu : UserControl
    {
        public PastriesMenu()
        {
            InitializeComponent();
        }
        //
        // Declaring Variables
        //
        int[] price = { 250, 200, 250, 150, 250, 300, 150, 150, 150, 150, 250, 150, 150 };
        decimal BCPrice;
        decimal BPPrice;
        decimal CCPrice;
        decimal CDPrice;
        decimal CCGBPrice;
        decimal GDPrice;
        decimal LCPrice;
        decimal MPrice;
        decimal OCPrice;
        decimal PCPrice;
        decimal SCPrice;
        decimal SCCPrice;
        decimal SDPrice;
        //
        // Numeric Up-Down
        //
        private void BCQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value ;
            BCPrice = BCQuantity.Value * price[0];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = BCPrice.ToString();
        }

        private void BPQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            BPPrice = BPQuantity.Value * price[1];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = BPPrice.ToString();
        }

        private void CCQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            CCPrice = CCQuantity.Value * price[2];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = CCPrice.ToString();
        }

        private void CDQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            CDPrice = CDQuantity.Value * price[3];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = CDPrice.ToString();
        }

        private void CCGBQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            CCGBPrice = CCGBQuantity.Value * price[4];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = CCGBPrice.ToString();
        }

        private void GDQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            GDPrice = GDQuantity.Value * price[5];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = GDPrice.ToString();
        }

        private void LCQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            LCPrice = LCQuantity.Value * price[6];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = LCPrice.ToString();
        }

        private void MQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            MPrice = MQuantity.Value * price[7];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = MPrice.ToString();
        }

        private void OCQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            OCPrice = OCQuantity.Value * price[8];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = OCPrice.ToString();
        }

        private void PCQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            PCPrice = PCQuantity.Value * price[9];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = PCPrice.ToString();
        }

        private void SCQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            SCPrice = SCQuantity.Value * price[10];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = SCPrice.ToString();
        }

        private void SCCQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            SCCPrice = SCCQuantity.Value * price[11];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = SCCPrice.ToString();
        }

        private void SDQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = BCQuantity.Value + BPQuantity.Value + CCQuantity.Value + CDQuantity.Value + CCGBQuantity.Value + GDQuantity.Value + LCQuantity.Value + MQuantity.Value + OCQuantity.Value + PCQuantity.Value + SCQuantity.Value + SCCQuantity.Value + SDQuantity.Value;
            SDPrice = SDQuantity.Value * price[12];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = SDPrice.ToString();
        }
        //
        // Buy Buttons
        //
        private void BCBuy_Click(object sender, EventArgs e)
        {
            this.BCQuantity.Value += 1;
        }

        private void BPBuy_Click(object sender, EventArgs e)
        {
            this.BPQuantity.Value += 1;
        }

        private void CCBuy_Click(object sender, EventArgs e)
        {
            this.CCQuantity.Value += 1;
        }

        private void CDBuy_Click(object sender, EventArgs e)
        {
            this.CDQuantity.Value += 1;
        }

        private void CCGBBuy_Click(object sender, EventArgs e)
        {
            this.CCGBQuantity.Value += 1;
        }

        private void GDBuy_Click(object sender, EventArgs e)
        {
            this.GDQuantity.Value += 1;
        }

        private void LCBuy_Click(object sender, EventArgs e)
        {
            this.LCQuantity.Value += 1;
        }

        private void MBuy_Click(object sender, EventArgs e)
        {
            this.MQuantity.Value += 1;
        }

        private void OCBuy_Click(object sender, EventArgs e)
        {
            this.OCQuantity.Value += 1;
        }

        private void PCBuy_Click(object sender, EventArgs e)
        {
            this.PCQuantity.Value += 1;
        }

        private void SCBuy_Click(object sender, EventArgs e)
        {
            this.SCQuantity.Value += 1;
        }

        private void SCCBuy_Click(object sender, EventArgs e)
        {
            this.SCCQuantity.Value += 1;
        }

        private void SDBuy_Click(object sender, EventArgs e)
        {
            this.SDQuantity.Value += 1;
        }
        //
        // Total Price
        //
        private void TotalPrice_TextChanged(object sender, EventArgs e)
        {
            decimal Amount = BCPrice + BPPrice + CCPrice + CDPrice + CCGBPrice + GDPrice + LCPrice + MPrice + OCPrice + PCPrice + SCPrice + SCCPrice + SDPrice;
            TotalPrice.Text = Amount.ToString();
        }
        //
        // Form
        //
        private void FName_Enter(object sender, EventArgs e)
        {
            if (FName.Text == "Enter Full Name")
            {
                FName.Text = "";
            }
        }

        private void Phone_Enter(object sender, EventArgs e)
        {
            if (Phone.Text == "Enter Your Phone Number")
            {
                Phone.Text = "";
            }
        }

        private void Address_Enter(object sender, EventArgs e)
        {
            if (Address.Text == "Enter Your Full Address")
            {
                Address.Text = "";
            }
        }       
        //
        // Check-out Button
        //
        private void CheckOut_Click(object sender, EventArgs e)
        {
            if (FName.Text == "" || FName.Text == "Enter Full Name" || Phone.Text == "" || Phone.Text == "Enter Your Phone Number" || Address.Text == "" || Address.Text == "Enter Your Full Address")
            {
                MessageBox.Show("You didn't fill all the neccessary information. Please try again!", "Order Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (TotalPrice.Text == "|" || TotalPrice.Text == "0" && TotalQuantity.Text == "0")
            {
                MessageBox.Show("You haven't placed an order yet.", "Order Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Your order has been placed. Thank you for shopping with us!", "Order success!", MessageBoxButtons.OK);
            }
        }

        
    }
}
