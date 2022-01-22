﻿using System.Drawing;
using System.Windows.Forms;

namespace FileContainerUI.Buttons
{
    public class FlatButton : Button
    {
        public FlatButton()
        {
            FlatStyle = FlatStyle.Flat;
            Width = 60;
            Height = 35;
            Font = new Font(new FontFamily("Calibri"), 11.25f, FontStyle.Regular);
        }
    }
}
