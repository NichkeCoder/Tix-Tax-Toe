using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TixTaxToe
{
    public class Field : Button
    {
        private MainForm mf;

        public Field(MainForm mainForm, int len, int posX, int posY)
        {
            this.Text = "";
            this.Location = new Point(posX, posY);
            this.Size = new Size(len, len);
            this.TabStop = false;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Click += field_click;
            this.Font = new Font(this.Font.FontFamily, (int)((8.0 / 20) * len), FontStyle.Bold);

            mf = mainForm;
        }

        public void field_click(object sender, EventArgs e)
        {
            Field fieldBut = (Field)sender;
            if (fieldBut.Text != "") return;

            if (mf.turn == 1)
            {
                fieldBut.Text = "X";
                mf.Text = "TixTaxToe ~ O";
            }
            else
            {
                fieldBut.Text = "O";
                mf.Text = "TixTaxToe ~ X";
            }
            mf.turn *= -1;
            mf.count++;

            if (mf.Check(mf.fieldPos[fieldBut] % mf.x, mf.fieldPos[fieldBut] / mf.x, fieldBut.Text, 0) >= mf.winRow)
            {
                MessageBox.Show("Player " + fieldBut.Text + " wins!");
                mf.ClearTable();
            }
            else if (mf.count == mf.x * mf.y)
            {
                MessageBox.Show("Tie!");
                mf.ClearTable();
            }
        }
    }
}
