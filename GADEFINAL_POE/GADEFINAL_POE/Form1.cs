using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADEFINAL_POE
{

    public partial class frmGameSimulation : Form
    {
        int tmr = 0;

        GameEngine eg = new GameEngine();
        public frmGameSimulation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(btnPause.Text == "pause")
            {
                btnPause.Text = "continue";
                tmrCounter.Stop();
            }
            else if(btnPause.Text == "continue")
            {
                btnPause.Text = "pause";
                tmrCounter.Start();
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmr = 0;
            eg.map.BattleField();
            eg.map.PopulateMap();
            tmrCounter.Start();
            if(btnPause.Text == "continue")
            {
                btnPause.Text = "pause";
            }
        }

        private void tmrCounter_Tick(object sender, EventArgs e)
        {
            cmbUnitsDisplay.Items.Clear();
            for(int a =0; a < eg.map.units.Length; a++)
            {
                if (eg.map.units[a] != null)
                    cmbUnitsDisplay.Items.Add(eg.map.units[a].ToString());
            }

            eg.StartGame();
            tmr++;
            lblTimeDisplay.Text = +tmr + " s";

            MapRefresh();
        }

        public void MapRefresh()
        {
            lblMapDisplay.Text = " ";
            for(int x =0; x < 20; x++)
            {
                for(int y =0; y < 20; y++)
                {
                    lblMapDisplay.Text += eg.map.GameMap[x, y];
                }
                lblMapDisplay.Text += Environment.NewLine;
            }
        }
    }
}
