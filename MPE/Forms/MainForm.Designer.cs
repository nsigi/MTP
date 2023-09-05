namespace MTP
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRollUp = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnTables = new System.Windows.Forms.Button();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.SystemColors.Window;
            this.panelDesktopPane.Controls.Add(this.pictureBox1);
            this.panelDesktopPane.Controls.Add(this.label2);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(215, 70);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1169, 578);
            this.panelDesktopPane.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = global::MPE.Properties.Resources.logo1;
            this.pictureBox1.Image = global::MPE.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(319, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 391);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(398, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добро пожаловать в МТП!\r\nВы можете начать работу!\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnTables);
            this.panelMenu.Controls.Add(this.btnDraw);
            this.panelMenu.Controls.Add(this.btn2);
            this.panelMenu.Controls.Add(this.btn1);
            this.panelMenu.Controls.Add(this.btnParams);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 70);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(215, 578);
            this.panelMenu.TabIndex = 6;
            // 
            // btnDraw
            // 
            this.btnDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDraw.FlatAppearance.BorderSize = 0;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDraw.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDraw.Image = global::MPE.Properties.Resources.free_icon_maths_830834;
            this.btnDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDraw.Location = new System.Drawing.Point(0, 265);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDraw.Size = new System.Drawing.Size(215, 65);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = " Построить графики";
            this.btnDraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn2.Image = global::MPE.Properties.Resources.free_icon_number_2_3840738;
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.Location = new System.Drawing.Point(0, 200);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2.Name = "btn2";
            this.btn2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn2.Size = new System.Drawing.Size(215, 65);
            this.btn2.TabIndex = 3;
            this.btn2.Text = " 2 подзадача";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn1.Image = global::MPE.Properties.Resources.free_icon_number_1_6912872;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.Location = new System.Drawing.Point(0, 135);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn1.Size = new System.Drawing.Size(215, 65);
            this.btn1.TabIndex = 2;
            this.btn1.Text = " 1 подзадача";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnParams
            // 
            this.btnParams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParams.FlatAppearance.BorderSize = 0;
            this.btnParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParams.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnParams.Image = global::MPE.Properties.Resources.free_icon_setting_7985250;
            this.btnParams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParams.Location = new System.Drawing.Point(0, 70);
            this.btnParams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnParams.Name = "btnParams";
            this.btnParams.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnParams.Size = new System.Drawing.Size(215, 65);
            this.btnParams.TabIndex = 1;
            this.btnParams.Text = "Ввести параметры";
            this.btnParams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(215, 70);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главное меню";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnReport);
            this.panelTitleBar.Controls.Add(this.btnRollUp);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimaze);
            this.panelTitleBar.Controls.Add(this.btnCLose);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1384, 70);
            this.panelTitleBar.TabIndex = 7;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::MPE.Properties.Resources.free_icon_textbook_2228580__1_;
            this.btnReport.Location = new System.Drawing.Point(65, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(65, 70);
            this.btnReport.TabIndex = 6;
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnRollUp
            // 
            this.btnRollUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRollUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRollUp.FlatAppearance.BorderSize = 0;
            this.btnRollUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollUp.ForeColor = System.Drawing.Color.White;
            this.btnRollUp.Image = global::MPE.Properties.Resources.premium_icon_menu_4980554;
            this.btnRollUp.Location = new System.Drawing.Point(0, 0);
            this.btnRollUp.Name = "btnRollUp";
            this.btnRollUp.Size = new System.Drawing.Size(65, 70);
            this.btnRollUp.TabIndex = 5;
            this.btnRollUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRollUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRollUp.UseVisualStyleBackColor = true;
            this.btnRollUp.Click += new System.EventHandler(this.btnRollUp_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = global::MPE.Properties.Resources.premium_icon_maximize_4979885;
            this.btnMaximize.Location = new System.Drawing.Point(1310, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(32, 32);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimaze.ForeColor = System.Drawing.Color.White;
            this.btnMinimaze.Image = global::MPE.Properties.Resources.premium_icon_diagonal_arrow_4982982;
            this.btnMinimaze.Location = new System.Drawing.Point(1274, 3);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(32, 32);
            this.btnMinimaze.TabIndex = 3;
            this.btnMinimaze.UseVisualStyleBackColor = true;
            this.btnMinimaze.Click += new System.EventHandler(this.btnMinimaze_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLose.FlatAppearance.BorderSize = 0;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCLose.ForeColor = System.Drawing.Color.White;
            this.btnCLose.Image = global::MPE.Properties.Resources.premium_icon_remove_4980246__2_;
            this.btnCLose.Location = new System.Drawing.Point(1346, 3);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(32, 32);
            this.btnCLose.TabIndex = 2;
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(553, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Моделирование теплового процесса";
            // 
            // btnTables
            // 
            this.btnTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTables.FlatAppearance.BorderSize = 0;
            this.btnTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTables.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTables.Image = global::MPE.Properties.Resources.free_icon_spreadsheet_8445488__1_;
            this.btnTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTables.Location = new System.Drawing.Point(0, 330);
            this.btnTables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTables.Name = "btnTables";
            this.btnTables.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTables.Size = new System.Drawing.Size(215, 65);
            this.btnTables.TabIndex = 5;
            this.btnTables.Text = " Показать таблицы";
            this.btnTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Visible = false;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 648);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.MinimumSize = new System.Drawing.Size(1400, 650);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnRollUp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnTables;
    }
}

