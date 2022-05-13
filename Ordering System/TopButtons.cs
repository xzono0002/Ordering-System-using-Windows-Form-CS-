using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ordering_System
{
    static class TopButtons
    {
        static bool isMax = false;
        static Point old_loc, default_loc;
        static Size old_size, default_size;

        public static void SetIntial(Form form) //will display when the system starts
        {
            old_loc = form.Location;
            old_size = form.Size;
            default_loc = form.Location;
            default_size = form.Size;
        }

        public static void DoMaximize(Form form, Button Maxbtn)
        {
            if (isMax == false) // if app is not maximized
            {
                old_loc = new Point(form.Location.X, form.Location.Y);
                old_size = new Size(form.Size.Width, form.Size.Height);
                Maximize(form);
                isMax = true;
            }

            else // bring it back to normal size
            {
                if (old_size.Width >= SystemInformation.WorkingArea.Width || old_size.Height >= SystemInformation.WorkingArea.Height)
                {
                    form.Location = default_loc;
                    form.Size = default_size;
                }
                else
                {
                    form.Location = old_loc;
                    form.Size = old_size;
                }
                isMax = false;
            }
        }

        public static void Maximize(Form form)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            form.WindowState = FormWindowState.Normal;
            form.Location = new Point(0, 0);
            form.Size = new Size(x, y);
        }

        public static void Minimize(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public static void Exit()
        {
            Application.Exit();
        }
    }
}