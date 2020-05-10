using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TixTaxToe
{
    public partial class GridSize : Form
    {
        private MainForm mf;
        private int width;
        private int height;
        private int win;

        public GridSize(MainForm mainForm)
        {
            mf = mainForm;
            InitializeComponent();
            widthBox.Focus();
            widthBox.Select();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(widthBox.Text, out width) && int.TryParse(heightBox.Text, out height) && int.TryParse(winBox.Text, out win)
                && width <= 20 && height <= 20 && win <= Math.Max(width, height) && width > 0 && height > 0 && win > 0)
            {
                mf.x = width;
                mf.y = height;
                mf.winRow = win;
                mf.gridChanged = true;
                this.Close();
            }
            else MessageBox.Show("Invalid input! Width and height must be between 1 and 20 (inclusive). " +
                "\nSymbols to win must be less than greater of the two.");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
