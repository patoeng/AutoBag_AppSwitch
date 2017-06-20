using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSwitch
{
    public partial class FormApp : Form
    {
        private string _popcLocation;
        private string _autobagLocation;
        private string _wiringLabelLocation;
        private string _popcTitle;
        private string _autobagTitle;
        private string _wiringLabelTitle;

        private Process _poPcProcess;
        private Process _wiringLabelProcess;
        private Process _autoBagProcess;

        public FormApp()
        {
            InitializeComponent();
            LoadSetting();
        }

        private void LoadSetting()
        {
            var setting = new Settings();
            _popcLocation = setting.POPCLocation;
            _autobagLocation = setting.AutoBagLocation;
            _wiringLabelLocation = setting.WiringLabelLocation;
            _popcTitle = setting.POPCTitle;
            _autobagTitle = setting.AutoBagTitle;
            _wiringLabelTitle = setting.WiringLabelTitle;
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            var windowWidth = Size.Width;
            var screenWidth = resolution.Width;
            var xLocation = screenWidth - windowWidth;

            Location = new Point(xLocation, 20);



        }
        private void btnWiringLabel_Click(object sender, EventArgs e)
        {
            if (_wiringLabelLocation == "")
            {
                using (FileDialog fd = new OpenFileDialog())
                {
                    fd.Title = @"Lokasi Aplikasi Wiring Label";
                    fd.Filter = @"Windows Application|*.exe";
                    fd.ShowDialog();
                    _wiringLabelLocation = fd.FileName;

                }

            }
            if (_wiringLabelLocation == "")
            {

                return;
            }
            var setting = new Settings();
            setting.WiringLabelLocation = _wiringLabelLocation;
            setting.Save();
            var exist = new FileInfo(_wiringLabelLocation).Exists;
            if (!exist)
            {
                using (FileDialog fd = new OpenFileDialog())
                {
                    fd.Title = @"Lokasi Aplikasi Wiring Label";
                    fd.Filter = @"Windows Application|*.exe";
                    fd.ShowDialog();
                    _wiringLabelLocation = fd.FileName;

                }

            }
            if (_wiringLabelLocation == "")
            {
                return;
            }
            setting = new Settings();
            setting.WiringLabelLocation = _wiringLabelLocation;
            setting.Save();
            _wiringLabelProcess = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(_wiringLabelLocation)).FirstOrDefault();
            if (_wiringLabelProcess == null || _wiringLabelProcess.HasExited)
            {
                _wiringLabelProcess = Process.Start(_wiringLabelLocation);
                _wiringLabelTitle = _wiringLabelProcess?.MainWindowTitle;
            }
            else
            {
                User32.BringToFront(_wiringLabelProcess.MainWindowTitle);
            }
            setting.WiringLabelTitle = _wiringLabelTitle;
            setting.Save();
        }

        private void FormApp_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPOPC_Click(object sender, EventArgs e)
        {
            if (_popcLocation == "")
            {
                using (FileDialog fd = new OpenFileDialog())
                {
                    fd.Title = @"Lokasi Aplikasi POPC";
                    fd.Filter = @"Windows Application|*.exe";
                    fd.ShowDialog();
                    _popcLocation = fd.FileName;

                }

            }
            if (_popcLocation == "")
            {
               
                return;
            }
            var setting = new Settings();
            setting.POPCLocation = _popcLocation;
            setting.Save();
            var exist = new FileInfo(_popcLocation).Exists;
            if (!exist)
            {
                using (FileDialog fd = new OpenFileDialog())
                {
                    fd.Title = @"Lokasi Aplikasi POPC";
                    fd.Filter = @"Windows Application|*.exe";
                    fd.ShowDialog();
                    _popcLocation = fd.FileName;

                }

            }
            if (_popcLocation == "")
            {
                return;
            }
            setting = new Settings();
            setting.POPCLocation = _popcLocation;
            setting.Save();
            _poPcProcess = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(_popcLocation)).FirstOrDefault();
            if (_poPcProcess == null || _poPcProcess.HasExited)
            {
                _poPcProcess = Process.Start(_popcLocation);
                _popcTitle = _poPcProcess?.MainWindowTitle;
            }
            else
            {
               User32.BringToFront( _poPcProcess.MainWindowTitle);
            }
            setting.POPCTitle = _popcTitle;
            setting.Save();
        }

        private void FormApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _poPcProcess?.CloseMainWindow();
                _poPcProcess?.Close();
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                _wiringLabelProcess?.CloseMainWindow();
                _wiringLabelProcess?.Close();
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                _autoBagProcess?.CloseMainWindow();
                _autoBagProcess?.Close();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnAutoBag_Click(object sender, EventArgs e)
        {
            if (_autobagLocation == "")
            {
                using (FileDialog fd = new OpenFileDialog())
                {
                    fd.Title = @"Lokasi Aplikasi Autobag Bench";
                    fd.Filter = @"Windows Application|*.exe";
                    fd.ShowDialog();
                    _autobagLocation = fd.FileName;

                }

            }
            if (_autobagLocation == "")
            {

                return;
            }
            var setting = new Settings();
            setting.AutoBagLocation = _autobagLocation;
            setting.Save();
            
            var exist = new FileInfo(_autobagLocation).Exists;
            if (!exist)
            {
                using (FileDialog fd = new OpenFileDialog())
                {
                    fd.Title = @"Lokasi Aplikasi Autobag Bench";
                    fd.Filter = @"Windows Application|*.exe";
                    fd.ShowDialog();
                    _popcLocation = fd.FileName;

                }

            }
            if (_popcLocation == "")
            {
                return;
            }
            setting = new Settings();
            setting.AutoBagLocation = _autobagLocation;
            setting.Save();
            _autoBagProcess = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(_autobagLocation)).FirstOrDefault();
            if (_autoBagProcess == null || _autoBagProcess.HasExited)
            {
                _autoBagProcess = Process.Start(_autobagLocation);
                _autobagTitle = _autoBagProcess?.MainWindowTitle;
            }
            else
            {
                User32.BringToFront(_autoBagProcess.MainWindowTitle);
            }
            setting.AutoBagTitle = _autobagTitle;
            setting.Save();
        }

        private void btnClearSetting_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show(@"Yakin ingin mengosongkan setting?",@"Clear Setting", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (msg == DialogResult.No) return;
            _popcLocation = "";
            _autobagLocation = "";
            _wiringLabelLocation = "";
            _popcTitle = "";
            _autobagTitle = "";
            _wiringLabelTitle = "";
        }

        private void btnLoadSetting_Click(object sender, EventArgs e)
        {
            LoadSetting();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show(@"Yakin ingin menutup aplikasi?", @"Close Application", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (msg == DialogResult.No) return;
            Close();
        }

        private void FormApp_SizeChanged(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                myNotifyIcon.Visible = true;
                myNotifyIcon.ShowBalloonTip(500);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                myNotifyIcon.Visible = false;
                Show();
            }

        }

        private void myNotifyIcon_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
