using System.Windows.Forms;

namespace CustServCounter
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }
    }
}
