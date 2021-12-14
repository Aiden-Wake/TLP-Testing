using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableLayout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.RowCount = 10;
            table.ColumnCount = 10;


            table.SuspendLayout();
            for(int y = 0; y < 10; y++)
            {
                table.RowStyles[y].Height = 10;
                table.RowStyles[y].SizeType = SizeType.Percent;
                for (int x = 0; x < 10; x++)
                {
                    table.ColumnStyles[x].Width = 10;
                    table.ColumnStyles[x].SizeType = SizeType.Percent;
                    Button b = new Button();
                    b.Text = $"X: {x} Y: {y}";
                    table.Controls.Add(b);
                    
                }
            }
            table.Dock = DockStyle.Fill;
            table.ResumeLayout();
            
            
            
        }
    }
}
