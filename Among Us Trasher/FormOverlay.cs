using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Among_Us_Trasher
{
    public partial class FormOverlay : Form
    {
        public FormOverlay()
        {
            InitializeComponent();
        }

        RECT rect;
        public const string WINDOW_NAME = "Among Us";
        IntPtr handle = FindWindow(null, WINDOW_NAME);

        Memory.Mem memory = new Memory.Mem();

        public struct RECT
        {
            public int left, top, right, bottom;
        }

        //Import functions
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        System.Diagnostics.Process AmongUSProcess;

        private void FormOverlay_Load(object sender, EventArgs e)
        {
            AmongUSProcess = Process.GetProcessesByName(WINDOW_NAME).FirstOrDefault();

            memory.OpenProcess(AmongUSProcess.Id);

            int initialStyle = GetWindowLong(this.Handle, -20); //851976
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Top = rect.top;
            this.Left = rect.left;

            //Minimize DropDown
            MovementPanel.Size = MovementPanel.MinimumSize;
            HUDPanel.Size = HUDPanel.MinimumSize;
        }


        //Get in-Game coordinates from screen positon
        public Tuple<float, float> GetCoords(RECT rect, float screenX, float screenY)
        {
            float XPosMid = rect.left + (rect.right - rect.left) / 2;
            float YPosMid = rect.top + (rect.bottom - rect.top) / 2;
            float Height = rect.bottom - rect.top;

            //The scale var should be accurate enough
            double scale = -3.8816598899431 * Math.Pow(10, -13) * Math.Pow(Height, 4) + 1.357082821356 * Math.Pow(10, -9) * Math.Pow(Height, 3) - 1.7535383397460 * Math.Pow(10, -6) * Math.Pow(Height, 2) + 0.000981296 * Height - 0.19041;

            float newX = memory.ReadFloat(Pointers.PlayerX) + (XPosMid - screenX) * -(float)scale;
            float newY = memory.ReadFloat(Pointers.PlayerY) + ((YPosMid + (5f / 108f) * Height) - screenY) * (float)scale;
            return Tuple.Create(newX,newY);
        }


        bool Mpressed = false;
        bool Spressed = false;
        bool STRGpressed = false;
        float oldS = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //move overlay
            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Top = rect.top;
            this.Left = rect.left;

            //update HUD
            coordsLabel.Text = "X: " + Convert.ToString(memory.ReadFloat(Pointers.PlayerX)) + " Y: " + Convert.ToString(memory.ReadFloat(Pointers.PlayerY));
            if (SpeedButton.Checked)
            {
                speedLabel.Text = "Speed: " + Convert.ToString(memory.ReadFloat(Pointers.PlayerSpeed));
            }

            MeetingBar.Maximum = (int)(memory.Read2Byte(Pointers.EmergencyCD) * 10);
            if (MeetingCDButton.Checked && memory.ReadFloat(Pointers.EmergencyCDlive) >= 0 && memory.ReadFloat(Pointers.EmergencyCDlive) <= memory.Read2Byte(Pointers.EmergencyCD))
            {
                MeetingBar.Visible = true;
                MeetingBar.Value = (int)(memory.ReadFloat(Pointers.EmergencyCDlive)*10);
            }
            else
            {
                MeetingBar.Visible = false;
            }

            //hotkeys

            //speed
            if (GetAsyncKeyState(Keys.ShiftKey) < 0 && ShiftSprintButton.Checked)
            {
                if (Spressed == false)
                {
                    Spressed = true;
                    oldS = memory.ReadFloat(Pointers.PlayerSpeed);
                    memory.WriteMemory(Pointers.PlayerSpeed, "float", Convert.ToString(oldS * 2));
                }
            }
            else
            {
                if (Spressed == true)
                {
                    Spressed = false;
                    memory.WriteMemory(Pointers.PlayerSpeed, "float", Convert.ToString(oldS));
                }
            }

            //Teleport
            //Console.WriteLine(Convert.ToString(GetCoords(rect, MousePosition.X, MousePosition.Y)));
           if (GetAsyncKeyState(Keys.RButton) < 0 && ClickTeleportButton.Checked)
            {
                if (Mpressed == false)
                {
                    Mpressed = true;
                    memory.WriteMemory(Pointers.PlayerX, "float", Convert.ToString(GetCoords(rect, MousePosition.X, MousePosition.Y).Item1));
                    memory.WriteMemory(Pointers.PlayerY, "float", Convert.ToString(GetCoords(rect, MousePosition.X, MousePosition.Y).Item2));
                }
            }
            else
            {
                Mpressed = false;
            }

            //Menu
            if (GetAsyncKeyState(Keys.ControlKey) < 0)
            {
                if (STRGpressed == false)
                {
                    STRGpressed = true;
                    SetWindowLong(this.Handle, -20, 851976);
                    MenuPanel.Visible = true;
                }
            }
            else
            {
                if (STRGpressed == true)
                {
                    SetWindowLong(this.Handle, -20, 852008);
                    MenuPanel.Visible = false;
                    SetForegroundWindow(AmongUSProcess.MainWindowHandle);
                }
                STRGpressed = false;
            }
        }


        //DropDown
        bool HUDCollapsed = true;
        bool MovementCollapsed = true;

        private void HUDCollapseTimer_Tick(object sender, EventArgs e)
        {
            if (HUDCollapsed)
            {
                HUDPanel.Height += 15;
                if (HUDPanel.Size == HUDPanel.MaximumSize)
                {
                    HUDCollapsed = false;
                    HUDCollapseTimer.Stop();
                }
            }
            else
            {
                HUDPanel.Height -= 15;
                if (HUDPanel.Size == HUDPanel.MinimumSize)
                {
                    HUDCollapsed = true;
                    HUDCollapseTimer.Stop();
                }
            }
        }

        private void MovementCollapseTimer_Tick(object sender, EventArgs e)
        {
            if (MovementCollapsed)
            {
                MovementPanel.Height += 15;
                if (MovementPanel.Size == MovementPanel.MaximumSize)
                {
                    MovementCollapsed = false;
                    MovementCollapseTimer.Stop();
                }
            }
            else
            {
                MovementPanel.Height -= 15;
                if (MovementPanel.Size == MovementPanel.MinimumSize)
                {
                    MovementCollapsed = true;
                    MovementCollapseTimer.Stop();
                }
            }
        }

        private void HUDButton_Click(object sender, EventArgs e)
        {
            HUDCollapseTimer.Start();
        }

        private void MovementButton_Click(object sender, EventArgs e)
        {
            MovementCollapseTimer.Start();
        }

        private void SpeedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SpeedButton.Checked)
            {
                speedLabel.Visible = true;
            }
            else
            {
                speedLabel.Visible = false;
            }
        }

        private void CoordinatesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CoordinatesButton.Checked)
            {
                coordsLabel.Visible = true;
            }
            else
            {
                coordsLabel.Visible = false;
            }
        }
    }
}
