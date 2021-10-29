using System;
using System.Windows.Forms;

namespace MaHoa.UI
{
    public partial class Index : Form
    {
        int defaultTab;

        public Index()
        {
            InitializeComponent();
            panel1.Controls.Add(new PlayFair());
            defaultTab = 1;
        }

        private void playFairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (defaultTab == 1)
            {
                panel1.Controls.Clear();
                defaultTab = 1;
                panel1.Controls.Add(new PlayFair());
            }
        }
    }
}
