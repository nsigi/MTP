using System.Windows.Forms;

namespace MPE
{
    public partial class AddTableForm : Form
    {
        public int[] param_t;
        public AddTableForm(int[] t)
        {
            InitializeComponent();
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            param_t = t;
        }

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            param_t[0] = int.Parse(tb_t.Text);
            Close();
        }

        private void brnDecline_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
