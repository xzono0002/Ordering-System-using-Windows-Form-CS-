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
    public partial class DrinksMenu : UserControl
    {
        public DrinksMenu()
        {
            InitializeComponent();
        }
        //
        // Declaring Variables
        //
        int[] price = { 100, 170, 100, 130, 100, 170, 170, 180, 120, 120, 190, 130, 150 };
        decimal CBTPrice;
        decimal CBPrice;
        decimal CEPrice;
        decimal DCPrice;
        decimal EPrice;
        decimal LMPrice;
        decimal MPrice;
        decimal SFPrice;
        decimal SMPrice;
        decimal SCPrice;
        decimal VICPrice;
        decimal WMPrice;
        decimal WCCPrice;
        //
        //Numeric Up-Down
        //
        private void CBTQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            CBTPrice = CBTQuantity.Value * price[0];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = CBTPrice.ToString();
        }

        private void CBQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            CBPrice = CBQuantity.Value * price[1];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = CBPrice.ToString();
        }

        private void CEQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            CEPrice = CEQuantity.Value * price[2];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = CEPrice.ToString();
        }

        private void DCQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            DCPrice = DCQuantity.Value * price[3];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = DCPrice.ToString();
        }

        private void EQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            EPrice = EQuantity.Value * price[4];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = EPrice.ToString();
        }

        private void LMQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            LMPrice = LMQuantity.Value * price[5];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = LMPrice.ToString();
        }

        private void MQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            MPrice = MQuantity.Value * price[6];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = MPrice.ToString();
        }

        private void SFQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            SFPrice = SFQuantity.Value * price[7];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = SFPrice.ToString();
        }

        private void SMQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            SMPrice = SMQuantity.Value * price[8];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = SMPrice.ToString();
        }

        private void SCQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            SCPrice = SCQuantity.Value * price[9];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = SCPrice.ToString();
        }

        private void VICQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            VICPrice = CBTQuantity.Value * price[10];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = VICPrice.ToString();
        }

        private void WMQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            WMPrice = WMQuantity.Value * price[11];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = WMPrice.ToString();
        }

        private void WCCQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            decimal quant1 = CBTQuantity.Value + CBQuantity.Value + CEQuantity.Value + DCQuantity.Value + EQuantity.Value + LMQuantity.Value + MQuantity.Value + SFQuantity.Value + SMQuantity.Value + SCQuantity.Value + VICQuantity.Value + WMQuantity.Value + WCCQuantity.Value;
            WCCPrice = WCCQuantity.Value * price[12];
            TotalQuantity.Text = quant1.ToString();
            TotalPrice.Text = WCCPrice.ToString();
        }
        //
        // Buy Buttons
        //
        private void CBTBuy_Click(object sender, EventArgs e)
        {
            this.CBTQuantity.Value += 1;
        }

        private void CBBuy_Click(object sender, EventArgs e)
        {
            this.CBQuantity.Value += 1;
        }

        private void CEBuy_Click(object sender, EventArgs e)
        {
            this.CEQuantity.Value += 1;
        }

        private void DCBuy_Click(object sender, EventArgs e)
        {
            this.DCQuantity.Value += 1;
        }

        private void EBuy_Click(object sender, EventArgs e)
        {
            this.EQuantity.Value += 1;
        }

        private void LMBuy_Click(object sender, EventArgs e)
        {
            this.LMQuantity.Value += 1;
        }

        private void MBuy_Click(object sender, EventArgs e)
        {
            this.MQuantity.Value += 1;
        }

        private void SFBuy_Click(object sender, EventArgs e)
        {
            this.SFQuantity.Value += 1;
        }

        private void SMBuy_Click(object sender, EventArgs e)
        {
            this.SMQuantity.Value += 1;
        }

        private void SCBuy_Click(object sender, EventArgs e)
        {
            this.SCQuantity.Value += 1;
        }

        private void VICBuy_Click(object sender, EventArgs e)
        {
            this.VICQuantity.Value += 1;
        }

        private void WMBuy_Click(object sender, EventArgs e)
        {
            this.WMQuantity.Value += 1;
        }

        private void WCCBuy_Click(object sender, EventArgs e)
        {
            this.WCCQuantity.Value += 1;
        }
        //
        // Total Price
        //
        private void TotalPrice_TextChanged(object sender, EventArgs e)
        {
            decimal Amount = CBTPrice + CBPrice + CEPrice + DCPrice + EPrice + LMPrice + MPrice + SFPrice + SMPrice + SCPrice + VICPrice + WMPrice + WCCPrice;
            TotalPrice.Text = Amount.ToString();
        }
        //
        //Form
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
        // Check-Out Button
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
