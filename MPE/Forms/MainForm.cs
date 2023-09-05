using AxAcroPDFLib;
using MPE;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MTP
{
    public partial class MainForm : Form
    {
        private Button taskButton, actionButton;
        private Form activeForm;
        private Color curColor;
        private bool isReportOpened, menuIsHided;
        private InputHelper inputHelper;

        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void HideButtons()
        {
            btn1.Visible = false;
            btn2.Visible = false;
            btnDraw.Visible = false;
            btnTables.Visible = false;
        }

        private void CustomizeDesign()
        {
            HideActionButtons();
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            menuIsHided = false;
            inputHelper = new InputHelper();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else WindowState = WindowState = FormWindowState.Normal;
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ReturnToTask()
        {
            if (actionButton != null)
            {
                DisableButton(actionButton);
                actionButton = null;
            }
            lblTitle.Text = taskButton.Text;
        }

        private void Reset()
        {
            lblTitle.Text = "Моделирование теплового процесса";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            if (taskButton != null)
            {
                DisableButton(taskButton);
                HideButtons();
            }
        }

        private void HideTaskButtons()
        {
            if (btn1.Visible) btn1.Visible = false;
            if (btn2.Visible) btn2.Visible = false;
        }

        private void ShowTaskButtons()
        {
            if (!btn1.Visible) btn1.Visible = true;
            if (!btn2.Visible) btn2.Visible = true;
        }

        private void HideActionButtons()
        {
            btnDraw.Visible = false;
            btnTables.Visible = false;
        }

        private void ShowActionButtons()
        {
            if (!btnDraw.Visible) btnDraw.Visible = true;
           // if (!btnTables.Visible) btnTables.Visible = true; если захотим, добавим таблички
        }


        private void SelectTaskButton(object sender)
        {
            if (taskButton == null)
            {
                ActivateTaskButton(sender);
                ShowActionButtons();
                taskButton = sender as Button;
            }
            else
            {
                if (taskButton == sender)
                {
                    ReturnToTask();
                    DisableButton(sender);
                    taskButton = null;
                    HideActionButtons();
                    Reset();
                    if (activeForm != null)
                    {
                        activeForm.Close();
                        activeForm = null;
                    }
                }
                else if (taskButton != sender)
                {
                    ReturnToTask();
                    DisableButton(taskButton);
                    ActivateTaskButton(sender);
                    taskButton = sender as Button;
                    if (activeForm != null)
                    {
                        activeForm.Close();
                        activeForm = null;
                    }
                }
            }
        }

        private void SelectActionButton(object sender)
        {
            if (actionButton == null)
            {
                ActivateActionButton(sender);
                actionButton = sender as Button;
            }
            else
            {
                if (actionButton == sender)
                {
                    ReturnToTask();
                    DisableButton(sender);
                    actionButton = null;
                }
                else if (taskButton != sender)
                {
                    ReturnToTask();
                    ActivateActionButton(sender);
                }
            }
        }

        private void ActivateActionButton(object sender)
        {
            actionButton = sender as Button;
            actionButton.BackColor = curColor;
            actionButton.ForeColor = Color.White;
            actionButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelTitleBar.BackColor = curColor;
            panelLogo.BackColor = ThemeColor.ChangeColorBrightness(curColor, -0.3);
            ThemeColor.PrimaryColor = curColor;
            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(curColor, -0.3);
            lblTitle.Text = actionButton.Text;
        }

        private void ActivateTaskButton(object sender)
        {
            taskButton = sender as Button;
            if (taskButton.Name == "btn1")
            {
                curColor = Color.SeaGreen;
            }
            else if (taskButton.Name == "btn2")
            {
                curColor = Color.FromArgb(107, 73, 143);
            }
            //if (curMenuButton.Text == "  Алгебра") curColor = Color.Teal;
            //else if (curMenuButton.Text == "  Математический \r\n  анализ") curColor = Color.SeaGreen;
            //else if (curMenuButton.Text == "  Геометрия") curColor = Color.DodgerBlue;
            //else if (curMenuButton.Text == "  Дискретная \r\n  математика") curColor = Color.FromArgb(107, 73, 143);
            //else if (curMenuButton.Text == "  Справка") curColor = Color.FromArgb(170, 210, 170);
            taskButton.BackColor = curColor;
            taskButton.ForeColor = Color.White;
            taskButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelTitleBar.BackColor = curColor;
            panelLogo.BackColor = ThemeColor.ChangeColorBrightness(curColor, -0.3);
            ThemeColor.PrimaryColor = curColor;
            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(curColor, -0.3);
            lblTitle.Text = taskButton.Text;
        }

        private void DisableButton(object sender)
        {
            (sender as Button).BackColor = Color.FromArgb(51, 51, 76);
            (sender as Button).ForeColor = Color.Gainsboro;
            (sender as Button).Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void OpenChildForm(Form ChildForm, object sender)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(ChildForm);
            panelDesktopPane.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            lblTitle.Text = ChildForm.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SelectTaskButton(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SelectTaskButton(sender);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            SelectActionButton(sender);
            OpenChildForm(new DrawingForm(taskButton, inputHelper), sender);
            //else
            //{
            //    activeForm.Close();
            //    activeForm = null;
            //}
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            SelectActionButton(sender);
            OpenChildForm(new TablesForm(), sender);
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRollUp_Click(object sender, EventArgs e)
        {
            if (menuIsHided)
            {
                panelMenu.Visible = true;
                menuIsHided = false;
            }
            else
            {
                panelMenu.Visible = false;
                menuIsHided = true;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            CheckButtons();
            OpenChildForm(new reportForm(), sender);
            AxAcroPDF reader = new AxAcroPDF();
            foreach (Control item in activeForm.Controls)
                if (item.GetType() == typeof(AxAcroPDF)) reader = (AxAcroPDF)item;
            if (!isReportOpened)
            {
                isReportOpened = true;
                reader.Visible = true;
            }
            else
            {
                isReportOpened = false;
                reader.Visible = false;
                lblTitle.Text = "Моделирование теплового процесса";
                activeForm.Close();
                activeForm = null;
                //panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
                //panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            }
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CheckButtons()
        {
            foreach (var button in new[] { actionButton, taskButton})
            {
                if (button != null)
                {
                    DisableButton(button);
                }
            }
            actionButton = null;
            taskButton = null;
            HideActionButtons();
            Reset();
        }

        private void btnParams_Click(object sender, EventArgs e)
        {
            var inputForm = new InputParametersForm(inputHelper);
            inputForm.Show();
            ShowTaskButtons();
        }
    }
}
