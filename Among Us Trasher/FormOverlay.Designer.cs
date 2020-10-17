namespace Among_Us_Trasher
{
    partial class FormOverlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.coordsLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MovementPanel = new System.Windows.Forms.Panel();
            this.ShiftSprintButton = new System.Windows.Forms.CheckBox();
            this.ClickTeleportButton = new System.Windows.Forms.CheckBox();
            this.MovementButton = new System.Windows.Forms.Button();
            this.HUDPanel = new System.Windows.Forms.Panel();
            this.MeetingCDButton = new System.Windows.Forms.CheckBox();
            this.SpeedButton = new System.Windows.Forms.CheckBox();
            this.CoordinatesButton = new System.Windows.Forms.CheckBox();
            this.HUDButton = new System.Windows.Forms.Button();
            this.HUDCollapseTimer = new System.Windows.Forms.Timer(this.components);
            this.MovementCollapseTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.MeetingBar = new System.Windows.Forms.ProgressBar();
            this.MenuPanel.SuspendLayout();
            this.MovementPanel.SuspendLayout();
            this.HUDPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // coordsLabel
            // 
            this.coordsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.coordsLabel.AutoSize = true;
            this.coordsLabel.BackColor = System.Drawing.Color.White;
            this.coordsLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordsLabel.Location = new System.Drawing.Point(14, 443);
            this.coordsLabel.Name = "coordsLabel";
            this.coordsLabel.Size = new System.Drawing.Size(53, 22);
            this.coordsLabel.TabIndex = 0;
            this.coordsLabel.Text = "X: Y: ";
            this.coordsLabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // speedLabel
            // 
            this.speedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.Color.White;
            this.speedLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(14, 421);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(67, 22);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "speed";
            this.speedLabel.Visible = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.Controls.Add(this.MovementPanel);
            this.MenuPanel.Controls.Add(this.HUDPanel);
            this.MenuPanel.Location = new System.Drawing.Point(543, 33);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(132, 442);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.Visible = false;
            // 
            // MovementPanel
            // 
            this.MovementPanel.Controls.Add(this.ShiftSprintButton);
            this.MovementPanel.Controls.Add(this.ClickTeleportButton);
            this.MovementPanel.Controls.Add(this.MovementButton);
            this.MovementPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovementPanel.Location = new System.Drawing.Point(3, 3);
            this.MovementPanel.MaximumSize = new System.Drawing.Size(125, 85);
            this.MovementPanel.MinimumSize = new System.Drawing.Size(125, 30);
            this.MovementPanel.Name = "MovementPanel";
            this.MovementPanel.Size = new System.Drawing.Size(125, 85);
            this.MovementPanel.TabIndex = 0;
            // 
            // ShiftSprintButton
            // 
            this.ShiftSprintButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShiftSprintButton.BackColor = System.Drawing.Color.Red;
            this.ShiftSprintButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShiftSprintButton.FlatAppearance.BorderSize = 0;
            this.ShiftSprintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShiftSprintButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftSprintButton.ForeColor = System.Drawing.Color.White;
            this.ShiftSprintButton.Location = new System.Drawing.Point(0, 58);
            this.ShiftSprintButton.Name = "ShiftSprintButton";
            this.ShiftSprintButton.Size = new System.Drawing.Size(125, 28);
            this.ShiftSprintButton.TabIndex = 6;
            this.ShiftSprintButton.Text = "Shift To Sprint";
            this.ShiftSprintButton.UseVisualStyleBackColor = false;
            // 
            // ClickTeleportButton
            // 
            this.ClickTeleportButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ClickTeleportButton.BackColor = System.Drawing.Color.Red;
            this.ClickTeleportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClickTeleportButton.FlatAppearance.BorderSize = 0;
            this.ClickTeleportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickTeleportButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickTeleportButton.ForeColor = System.Drawing.Color.White;
            this.ClickTeleportButton.Location = new System.Drawing.Point(0, 30);
            this.ClickTeleportButton.Name = "ClickTeleportButton";
            this.ClickTeleportButton.Size = new System.Drawing.Size(125, 28);
            this.ClickTeleportButton.TabIndex = 5;
            this.ClickTeleportButton.Text = "Click To Teleport";
            this.ClickTeleportButton.UseVisualStyleBackColor = false;
            // 
            // MovementButton
            // 
            this.MovementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MovementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovementButton.FlatAppearance.BorderSize = 0;
            this.MovementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovementButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovementButton.ForeColor = System.Drawing.Color.White;
            this.MovementButton.Location = new System.Drawing.Point(0, 0);
            this.MovementButton.Name = "MovementButton";
            this.MovementButton.Size = new System.Drawing.Size(125, 30);
            this.MovementButton.TabIndex = 4;
            this.MovementButton.Text = "Movement";
            this.MovementButton.UseVisualStyleBackColor = false;
            this.MovementButton.Click += new System.EventHandler(this.MovementButton_Click);
            // 
            // HUDPanel
            // 
            this.HUDPanel.Controls.Add(this.MeetingCDButton);
            this.HUDPanel.Controls.Add(this.SpeedButton);
            this.HUDPanel.Controls.Add(this.CoordinatesButton);
            this.HUDPanel.Controls.Add(this.HUDButton);
            this.HUDPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HUDPanel.Location = new System.Drawing.Point(3, 94);
            this.HUDPanel.MaximumSize = new System.Drawing.Size(125, 114);
            this.HUDPanel.MinimumSize = new System.Drawing.Size(125, 30);
            this.HUDPanel.Name = "HUDPanel";
            this.HUDPanel.Size = new System.Drawing.Size(125, 114);
            this.HUDPanel.TabIndex = 0;
            // 
            // MeetingCDButton
            // 
            this.MeetingCDButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MeetingCDButton.BackColor = System.Drawing.Color.Red;
            this.MeetingCDButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MeetingCDButton.FlatAppearance.BorderSize = 0;
            this.MeetingCDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeetingCDButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingCDButton.ForeColor = System.Drawing.Color.White;
            this.MeetingCDButton.Location = new System.Drawing.Point(0, 86);
            this.MeetingCDButton.Name = "MeetingCDButton";
            this.MeetingCDButton.Size = new System.Drawing.Size(125, 28);
            this.MeetingCDButton.TabIndex = 7;
            this.MeetingCDButton.Text = "Show MeetingCD";
            this.MeetingCDButton.UseVisualStyleBackColor = false;
            // 
            // SpeedButton
            // 
            this.SpeedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SpeedButton.BackColor = System.Drawing.Color.Red;
            this.SpeedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpeedButton.FlatAppearance.BorderSize = 0;
            this.SpeedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeedButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedButton.ForeColor = System.Drawing.Color.White;
            this.SpeedButton.Location = new System.Drawing.Point(0, 58);
            this.SpeedButton.Name = "SpeedButton";
            this.SpeedButton.Size = new System.Drawing.Size(125, 28);
            this.SpeedButton.TabIndex = 6;
            this.SpeedButton.Text = "Show Speed";
            this.SpeedButton.UseVisualStyleBackColor = false;
            this.SpeedButton.CheckedChanged += new System.EventHandler(this.SpeedButton_CheckedChanged);
            // 
            // CoordinatesButton
            // 
            this.CoordinatesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.CoordinatesButton.BackColor = System.Drawing.Color.Red;
            this.CoordinatesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoordinatesButton.FlatAppearance.BorderSize = 0;
            this.CoordinatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CoordinatesButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordinatesButton.ForeColor = System.Drawing.Color.White;
            this.CoordinatesButton.Location = new System.Drawing.Point(0, 30);
            this.CoordinatesButton.Name = "CoordinatesButton";
            this.CoordinatesButton.Size = new System.Drawing.Size(125, 28);
            this.CoordinatesButton.TabIndex = 5;
            this.CoordinatesButton.Text = "Show Coordinates";
            this.CoordinatesButton.UseVisualStyleBackColor = false;
            this.CoordinatesButton.CheckedChanged += new System.EventHandler(this.CoordinatesButton_CheckedChanged);
            // 
            // HUDButton
            // 
            this.HUDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HUDButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HUDButton.FlatAppearance.BorderSize = 0;
            this.HUDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HUDButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUDButton.ForeColor = System.Drawing.Color.White;
            this.HUDButton.Location = new System.Drawing.Point(0, 0);
            this.HUDButton.Name = "HUDButton";
            this.HUDButton.Size = new System.Drawing.Size(125, 30);
            this.HUDButton.TabIndex = 4;
            this.HUDButton.Text = "HUD";
            this.HUDButton.UseVisualStyleBackColor = false;
            this.HUDButton.Click += new System.EventHandler(this.HUDButton_Click);
            // 
            // HUDCollapseTimer
            // 
            this.HUDCollapseTimer.Interval = 10;
            this.HUDCollapseTimer.Tick += new System.EventHandler(this.HUDCollapseTimer_Tick);
            // 
            // MovementCollapseTimer
            // 
            this.MovementCollapseTimer.Interval = 10;
            this.MovementCollapseTimer.Tick += new System.EventHandler(this.MovementCollapseTimer_Tick);
            // 
            // MeetingBar
            // 
            this.MeetingBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MeetingBar.Location = new System.Drawing.Point(14, 465);
            this.MeetingBar.Name = "MeetingBar";
            this.MeetingBar.Size = new System.Drawing.Size(140, 10);
            this.MeetingBar.TabIndex = 0;
            this.MeetingBar.Visible = false;
            // 
            // FormOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(755, 482);
            this.Controls.Add(this.MeetingBar);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.coordsLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOverlay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.FormOverlay_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MovementPanel.ResumeLayout(false);
            this.HUDPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coordsLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.FlowLayoutPanel MenuPanel;
        private System.Windows.Forms.Panel MovementPanel;
        private System.Windows.Forms.CheckBox ShiftSprintButton;
        private System.Windows.Forms.CheckBox ClickTeleportButton;
        private System.Windows.Forms.Button MovementButton;
        private System.Windows.Forms.Timer HUDCollapseTimer;
        private System.Windows.Forms.Timer MovementCollapseTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar MeetingBar;
        private System.Windows.Forms.Panel HUDPanel;
        private System.Windows.Forms.CheckBox MeetingCDButton;
        private System.Windows.Forms.CheckBox SpeedButton;
        private System.Windows.Forms.CheckBox CoordinatesButton;
        private System.Windows.Forms.Button HUDButton;
    }
}