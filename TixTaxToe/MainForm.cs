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

        public List<List<Field>> fields = new List<List<Field>>();
        public Dictionary<Field, int> fieldPos = new Dictionary<Field, int>();

        public int turn = 1;
        public int count = 0;
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
                List<Field> temp = new List<Field>();
                for (int j = 0; j < x; j++)
                {
                    Field field = new Field(this, len, locX, locY);
                    
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

        public void ClearTable()
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

        public double Check(int tx, int ty, string comp, int dir)
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
