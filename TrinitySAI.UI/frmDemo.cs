using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinitySAI;

namespace TrinitySAI.UI
{
    public partial class frmDemo : Form
    {
        private Config config;
        private Process sai;
        public frmDemo()
        {
            InitializeComponent();
            config = new Config();
            sai = new Process(config);
        }

        private void frmDemo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            config.Load();
            sai.ConnectDb(2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            config.AddServer("localhost", "world-3.3.5", "trinity", "trinity");
            config.AddServer("localhost", "world_saieditor", "trinity", "trinity");

            config.Save();
        }

        private void btnTestQuery_Click(object sender, EventArgs e)
        {
            var result = sai.TestQuery();
            MessageBox.Show(result);
        }
    }
}
