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
    public partial class FoodMenu : UserControl
    {
        public FoodMenu()
        {
            InitializeComponent();
        }
        //
        // Declaring Variables
        //
        int[] price = { 260, 180, 250, 250, 180, 200, 300, 270, 180, 250, 170, 300, 240 };
        decimal APPrice;
        decimal BTPrice;
        decimal BPPrice;
        decimal CPrice;
        decimal CFTPrice;
        decimal FSPrice;
        decimal PCPPrice;
        decimal PPPrice;
        decimal PSPrice;
        decimal SPPrice;
        decimal SPrice;
        decimal SHPPrice;
        decimal TSSPrice;
        //
        // Numeric Up-Down
        //
        private void APQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            APPrice = APQuantity.Value * price[0];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = APPrice.ToString();
        }

        private void BTQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            BTPrice = BTQuantity.Value * price[1];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = BTPrice.ToString();
        }

        private void BPQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            BPPrice = BPQuantity.Value * price[2];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = BPPrice.ToString();
        }

        private void CQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            CPrice = CQuantity.Value * price[3];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = CPrice.ToString();
        }

        private void CFTQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            CFTPrice = CFTQuantity.Value * price[4];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = CFTPrice.ToString();
        }

        private void FSQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            FSPrice = FSQuantity.Value * price[5];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = FSPrice.ToString();
        }

        private void PCPQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            PCPPrice = PCPQuantity.Value * price[6];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = PCPPrice.ToString();
        }

        private void PPQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            PPPrice = PPQuantity.Value * price[7];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = PPPrice.ToString();
        }

        private void PSQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = PSQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            PSPrice = PSQuantity.Value * price[8];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = PSPrice.ToString();
        }

        private void SPQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            SPPrice = SPQuantity.Value * price[9];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = SPPrice.ToString();
        }

        private void SQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            SPrice = SQuantity.Value * price[10];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = SPrice.ToString();
        }

        private void SHPQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            SHPPrice = SHPQuantity.Value * price[11];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = SHPPrice.ToString();
        }

        private void TSSQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal quant = APQuantity.Value + BTQuantity.Value + BPQuantity.Value + CQuantity.Value + CFTQuantity.Value + FSQuantity.Value + PCPQuantity.Value + PPQuantity.Value + PSQuantity.Value + SPQuantity.Value + SQuantity.Value + SHPQuantity.Value + TSSQuantity.Value;
            TSSPrice = TSSQuantity.Value * price[12];
            TotalQuantity.Text = quant.ToString();
            TotalPrice.Text = TSSPrice.ToString();
        }
        //
        // Buy Buttons
        private void APBuy_Click(object sender, EventArgs e)
        {
            this.APQuantity.Value += 1;
        }

        private void BTBuy_Click(object sender, EventArgs e)
        {
            this.BTQuantity.Value += 1;
        }

        private void BPBuy_Click(object sender, EventArgs e)
        {
            this.BPQuantity.Value += 1;
        }

        private void CBuy_Click(object sender, EventArgs e)
        {
            this.CQuantity.Value += 1;
        }

        private void CFTBuy_Click(object sender, EventArgs e)
        {
            this.CFTQuantity.Value += 1;
        }

        private void FSBuy_Click(object sender, EventArgs e)
        {
            this.FSQuantity.Value += 1;
        }

        private void PCPBuy_Click(object sender, EventArgs e)
        {
            this.PCPQuantity.Value += 1;
        }

        private void PPBuy_Click(object sender, EventArgs e)
        {
            this.PPQuantity.Value += 1;
        }

        private void PSBuy_Click(object sender, EventArgs e)
        {
            this.PSQuantity.Value += 1;
        }

        private void SPBuy_Click(object sender, EventArgs e)
        {
            this.SPQuantity.Value += 1;
        }

        private void SBuy_Click(object sender, EventArgs e)
        {
            this.SQuantity.Value += 1;
        }

        private void SHPBuy_Click(object sender, EventArgs e)
        {
            this.SHPQuantity.Value += 1;
        }

        private void TSSBuy_Click(object sender, EventArgs e)
        {
            this.TSSQuantity.Value += 1;
        }
        //
        // Total Price
        //
        private void TotalPrice_TextChanged(object sender, EventArgs e)
        {
            decimal Amount = APPrice + BTPrice + BPPrice + CPrice + CFTPrice + FSPrice + PCPPrice + PPPrice + PSPrice + SPPrice + SPrice + SHPPrice + TSSPrice;
            TotalPrice.Text = Amount.ToString();
        }
        //
        // Forms
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
