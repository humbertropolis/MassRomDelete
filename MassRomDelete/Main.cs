using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassRomDelete
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnRomsFolder_Click(object sender, EventArgs e)
        {
            if (romsFolderDialog.ShowDialog() == DialogResult.OK)
            {
                txtRomsFolder.Text = romsFolderDialog.SelectedPath;
            }
        }

        private void btnImagesFolder_Click(object sender, EventArgs e)
        {
            if (imagesFolderDialog.ShowDialog() == DialogResult.OK)
            {
                txtImagesFolder.Text = imagesFolderDialog.SelectedPath;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
