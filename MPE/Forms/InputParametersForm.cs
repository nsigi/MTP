using MTP;
using System;
using System.Windows.Forms;

namespace MPE
{
    public partial class InputParametersForm : Form
    {
        public InputHelper inputHelper;
        public InputParametersForm(InputHelper inputHelper)
        {
            InitializeComponent();
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            this.inputHelper = inputHelper;
            tb_T.Text = "200";
            tb_lx.Text = "10";
            tb_ly.Text = "6";
            tb_a.Text = "0,004";
            tb_k.Text = "0,13";
            tb_c.Text = "1,84";
            tb_u0.Text = "0";
            tb_N.Text = "100";
            tb_eps.Text = "0,000001";
        }

        private void brnDecline_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            inputHelper.T = double.Parse(tb_T.Text);
            inputHelper.l_x = double.Parse(tb_lx.Text);
            inputHelper.l_y = double.Parse(tb_ly.Text);
            inputHelper.a = double.Parse(tb_a.Text);
            inputHelper.k = double.Parse(tb_k.Text);
            inputHelper.c = double.Parse(tb_c.Text);
            inputHelper.u_0 = double.Parse(tb_u0.Text);
            inputHelper.N = int.Parse(tb_N.Text);
            inputHelper.eps = double.Parse(tb_eps.Text);
            Close();
        }
    }
}
