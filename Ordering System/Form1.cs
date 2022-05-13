using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ordering_System
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            homePage1.BringToFront();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            homePage1.BringToFront();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ProductsButton.Height;
            SidePanel.Top = ProductsButton.Top;
            Categories.BringToFront();     
        }

        private void DrinksButton_Click(object sender, EventArgs e)
        {
            drinksMenu2.BringToFront();
        }

        private void PastriesButton_Click(object sender, EventArgs e)
        {
            pastriesMenu1.BringToFront();
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            foodMenu1.BringToFront();
        }

        private void CstmrService_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CstmrService.Height;
            SidePanel.Top = CstmrService.Top;
            contactUS1.BringToFront();
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = QuestionButton.Height;
            SidePanel.Top = QuestionButton.Top;
            aboutUs1.BringToFront();
        }

        private void FbIcon_Click(object sender, EventArgs e)
        {
            facebookUN1.BringToFront();
        }

        private void IgIcon_Click(object sender, EventArgs e)
        {
            igUN1.BringToFront();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            TopButtons.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            TopButtons.Minimize(this);
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            TopButtons.DoMaximize(this,btn);
        }

    }
}
