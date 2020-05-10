using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TixTaxToe
{
    public partial class MainForm : Form
    {
        private const int startX = 0;
        private const int startY = 24;

        private int locX = startX;
        private int locY = startY;
        public int x = 3;
        public int y = 3;

        List<List<Button>> fields = new List<List<Button>>();
        Dictionary<Button, int> fieldPos = new Dictionary<Button, int>();

        int turn = 1;
        int count = 0;
        public int winRow = 3;
        public bool gridChanged = false;

        public MainForm()
        {
            InitializeComponent();
            InitialaizeTable();
        }

        private void InitialaizeTable()
        {
            locX = startX;
            locY = startY;
            count = 0;
            turn = 1;
            int len = 500 / (int)Math.Max(x, y);
            for (int i = 0; i < y; i++)
            {
                List<Button> temp = new List<Button>();
                for (int j = 0; j < x; j++)
                {
                    Button field = new Button();
                    field.Text = "";
                    field.Location = new Point(locX, locY);
                    field.Size = new Size(len, len);
                    field.TabStop = false;
                    field.FlatStyle = FlatStyle.Flat;
                    field.FlatAppearance.BorderSize = 0;
                    field.Click += field_click;
                    field.Font = new Font(field.Font.FontFamily, (int)((8.0 / 20) * len), FontStyle.Bold);

                    temp.Add(field);
                    fieldPos.Add(field, i * x + j);
                    this.Controls.Add(field);

                    locX += len;
                }
                locX = startX;
                locY += len;

                fields.Add(temp);
            }

            this.Text = "TixTaxToe ~ X";
            this.Width = len * x + 17;
            this.Height = len * y + 64;
            this.CenterToScreen();
        }

        private void ClearTable()
        {
            count = 0;
            turn = 1;
            for (int i = 0; i < fields.Count(); i++)
            {
                for (int j = 0; j < fields[i].Count(); j++)
                {
                    fields[i][j].Text = "";
                }
            }
            this.Text = "TixTaxToe ~ X";
        }

        private void field_click(object sender, EventArgs e)
        {
            Button fieldBut = (Button)sender;
            if (fieldBut.Text != "") return;

            if (turn == 1)
            {
                fieldBut.Text = "X";
                this.Text = "TixTaxToe ~ O";
            }
            else
            {
                fieldBut.Text = "O";
                this.Text = "TixTaxToe ~ X";
            }
            turn *= -1;
            count++;

            if (Check(fieldPos[fieldBut] % x, fieldPos[fieldBut] / x, fieldBut.Text, 0) >= winRow)
            {
                MessageBox.Show("Player " + fieldBut.Text + " wins!");
                ClearTable();
            }
            else if (count == x * y)
            {
                MessageBox.Show("Tie!");
                ClearTable();
            }
        }

        private double Check(int tx, int ty, string comp, int dir)
        {
            if (tx < 0 || ty < 0 || tx >= x || ty >= y || fields[ty][tx].Text.ToString() != comp) return 0;
            if (dir == 0)
            {
                double hor = Check(tx - 1, ty, comp, -1) + Check(tx + 1, ty, comp, 1) + 1;
                double vert = Check(tx, ty - 1, comp, -2) + Check(tx, ty + 1, comp, 2) + 1;
                double diag1 = Check(tx - 1, ty - 1, comp, -3) + Check(tx + 1, ty + 1, comp, 3) + 1;
                double diag2 = Check(tx + 1, ty - 1, comp, -4) + Check(tx - 1, ty + 1, comp, 4) + 1;
                return Math.Max(vert, Math.Max(hor, Math.Max(diag1, diag2)));
            }
            if (dir == -1)
                return Check(tx - 1, ty, comp, -1) + 1;
            if (dir == 1)
                return Check(tx + 1, ty, comp, 1) + 1;
            if (dir == -2)
                return Check(tx, ty - 1, comp, -2) + 1;
            if (dir == 2)
                return Check(tx, ty + 1, comp, 2) + 1;
            if (dir == -3)
                return Check(tx - 1, ty - 1, comp, -3) + 1;
            if (dir == 3)
                return Check(tx + 1, ty + 1, comp, 3) + 1;
            if (dir == -4)
                return Check(tx + 1, ty - 1, comp, -4) + 1;
            if (dir == 4)
                return Check(tx - 1, ty + 1, comp, 4) + 1;
            return 1;
        }

        private void clearTool_Click(object sender, EventArgs e)
        {
            ClearTable();
        }

        private void gridSizeTool_Click(object sender, EventArgs e)
        {
            GridSize gs = new GridSize(this);
            gs.ShowDialog();
            if (gridChanged)
            {
                for (int i = 0; i < fields.Count(); i++)
                {
                    for (int j = 0; j < fields[i].Count(); j++)
                    {
                        this.Controls.Remove(fields[i][j]);
                        fields[i][j].Dispose();
                    }
                }

                fields.Clear();
                fieldPos.Clear();

                InitialaizeTable();
            }
        }
    }
}
