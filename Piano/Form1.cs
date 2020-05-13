using Piano.Scale;
using Piano.Tempo;
using Piano.Tempo.BarsTempo;
using Piano.Note;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Piano.Generate;
using Piano.Player;

namespace Piano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listen listen = new Listen();
            listen.ShowDialog();
        }
    }
}
