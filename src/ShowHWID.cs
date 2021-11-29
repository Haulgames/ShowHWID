using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aLib.Microsoft;

namespace ShowHWID
{
    public partial class ShowHWID : Form
    {
        public ShowHWID()
        {
            InitializeComponent();
            MessageBox.Show("Here is Your HWID...", "Show Your HWID");
            MessageBox.Show(mm_Encryptions.License.GetUHId(), "Show Your HWID");
            Environment.Exit(0);
        }
    }
}
