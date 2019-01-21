//Written by Todd R. Mariana a.k.a. Opcode66
//http://mantra.audio http://deepgroovesmastering.com http://groovegraphics.net http://cutterheadrepair.com

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace Mach3MouseWatcher
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private const uint GA_PARENT = 1;
        private const uint GA_ROOT = 2;
        private const uint GA_ROOTOWNER = 3;

        public Rectangle theRect;
        public string theApp = "";

        private string lastWindowText = "";
        private bool trigger1 = false;
        private ContextMenu contextMenu1;
        private MenuItem menuItem5 = new MenuItem();
        private MenuItem menuItem1 = new MenuItem();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var settings = File.ReadAllText($"{Application.StartupPath}{"\\settings.txt"}");
                var parts = settings.Split(',');
                List<int> list = new List<int>();

                for (int i = 0; i < parts.Length; i++)
                {
                    try
                    {
                        list.Add(Convert.ToInt32(parts[i].Split('=')[1]));
                    }
                    catch
                    {
                        switch (i) {
                            case 0:
                                list.Add(100);
                                break;
                            case 1:
                                list.Add(100);
                                break;
                            case 2:
                                list.Add(200);
                                break;
                            case 3:
                                list.Add(100);
                                break;
                        }

                    }
                }

                var parts2 = parts[4].Split('=');
                if (parts2.Length > 1) theApp = parts2[1];

                theRect = new Rectangle(list[0], list[1], list[2], list[3]);

                components = new System.ComponentModel.Container();
                contextMenu1 = new ContextMenu();
                MenuItem menuItem2 = new MenuItem();
                MenuItem menuItem3 = new MenuItem();
                MenuItem menuItem4 = new MenuItem();
                MenuItem menuItem6 = new MenuItem();

                contextMenu1.MenuItems.AddRange(new MenuItem[] { menuItem1, menuItem2, menuItem3, menuItem4, menuItem5, menuItem6 });

                menuItem3.Index = 0;
                menuItem3.Text = "Monitor Foreground App";
                menuItem3.Click += new EventHandler(menuItem3_Click);

                menuItem4.Index = 1;
                menuItem4.Text = "Clear Monitor App";
                menuItem4.Click += new EventHandler(menuItem4_Click);

                menuItem2.Index = 2;
                menuItem2.Text = "Define Area";
                menuItem2.Click += new EventHandler(menuItem2_Click);

                menuItem1.Index = 3;
                menuItem1.Text = "Show Options";
                menuItem1.Click += new EventHandler(menuItem1_Click);

                menuItem5.Index = 4;
                menuItem5.Text = "Close Options";
                menuItem5.Enabled = false;
                menuItem5.Click += new EventHandler(menuItem5_Click);

                menuItem6.Index = 5;
                menuItem6.Text = "Exit Monitoring App";
                menuItem6.Click += new EventHandler(menuItem6_Click);

                notifyIcon1.ContextMenu = contextMenu1;

                SetWindowTitles();

                timer1.Enabled = true;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            try
            {
                menuItem5.Enabled = true;
                menuItem1.Enabled = false;
                Opacity = 1;
                timer1_Tick(this, new EventArgs());
                Opacity = 100;
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
        }

        private void menuItem2_Click(object Sender, EventArgs e)
        {
            DefineArea();
        }

        private void menuItem3_Click(object Sender, EventArgs e)
        {
            try
            {
                theApp = lastWindowText;
                WriteSettings();
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
        }

        private void menuItem4_Click(object Sender, EventArgs e)
        {
            try
            {
                theApp = "";
                WriteSettings();
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
        }


        private void menuItem5_Click(object Sender, EventArgs e)
        {
            try
            {
                menuItem5.Enabled = false;
                menuItem1.Enabled = true;
                Opacity = 0;
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
        }


        private void menuItem6_Click(object Sender, EventArgs e)
        {
            Application.Exit();
        }

        int updateCount = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var pos = MousePosition;

                updateCount++;

                if (updateCount > 3)
                {
                    updateCount = 0;

                    const int nChars = 256;
                    StringBuilder Buff = new StringBuilder(nChars);

                    IntPtr fg = GetForegroundWindow();

                    if (GetWindowText(fg, Buff, nChars) > 0)
                    {
                        string title = Buff.ToString();
                        if (title != Text) lastWindowText = title;
                    }
                }

                if (Opacity > 0)
                {
                    label1.Text = $"X={pos.X}, Y={pos.Y}";
                    lblRect.Text = $"X={theRect.X},Y={theRect.Y},Width={theRect.Width},Height={theRect.Height}";
                    lblApp.Text = (theApp != "" ? theApp : "No application set to monitor.");
                    lblLast.Text = (theApp != "" ? lastWindowText : "");
                    lblTimer.Text = (theApp != "" ? "Enabled" : "Dixabled");
                }

                if (theApp == "") return;

                if (Opacity == 0)
                {
                    if ((pos.X >= theRect.X && pos.Y >= theRect.Y) && (pos.X <= (theRect.X + theRect.Width) && pos.Y <= (theRect.Y + theRect.Height)))
                    {
                        if (!trigger1) SendKeysToWindow();
                    }
                    else
                    {
                        if (trigger1) SendKeysToWindow();
                    }
                }
            }
            catch (Exception ex)
            {
                if (Opacity > 1)
                {
                    txtError.Text = ex.Message;
                } else
                {
                    MessageBox.Show(this, ex.Message);
                }
            }
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            try
            {
                menuItem5.Enabled = false;
                menuItem1.Enabled = true;
                Opacity = 0;
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SetWindowTitles();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex < 0)
                {
                    MessageBox.Show("Nothing selected.");
                }
                else
                {
                    theApp = listBox1.SelectedItem.ToString();
                    WriteSettings();
                }
            }
            catch (Exception ex)
            {
                txtError.Text = ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                theApp = "";
                WriteSettings();
            }
            catch (Exception ex)
            {
                txtError.Text = ex.Message;
            }
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            DefineArea();
        }

        public void StartTimer()
        {
            timer1.Start();
        }

        private void SendKeysToWindow()
        {
            try
            {
                IntPtr window = FindWindow(null, theApp);

                if (window != IntPtr.Zero)
                {
                    IntPtr fg = GetForegroundWindow();
                    if (fg != IntPtr.Zero) {
                        if (fg.Equals(window))
                        {
                            if (!trigger1)
                            {
                                SendKeys.SendWait("^(n)");
                            }
                            else
                            {
                                SendKeys.SendWait("^(m)");
                            }
                            SendKeys.Flush();

                            trigger1 = !trigger1;
                        }
                    }
                } else
                {
                    //Do Nothing
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SetWindowTitles()
        {
            try
            {
                Process[] processlist = Process.GetProcesses();
                StringBuilder s = new StringBuilder();

                listBox1.Items.Clear();

                foreach (Process process in processlist)
                {
                    if (!string.IsNullOrEmpty(process.MainWindowTitle))
                    {
                        listBox1.Items.Add(process.MainWindowTitle);
                    }
                }
            }
            catch (Exception ex)
            {
                txtError.Text = ex.Message;
            }
        }

        private void DefineArea()
        {
            try
            {
                AreaDefiner form = new AreaDefiner();
                form.Init(this);
                timer1.Stop();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                if (Opacity >= 1)
                {
                    txtError.Text = ex.Message;
                }
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                theApp = lastWindowText;
                WriteSettings();
            }
            catch (Exception ex)
            {
                txtError.Text = ex.Message;
            }
        }

        private void WriteSettings()
        {
            try
            {
                File.WriteAllText($"{Application.StartupPath}{"\\settings.txt"}", $"X={theRect.X},Y={theRect.Y},Width={theRect.Width},Height={theRect.Height},Application={theApp}");
            }
            catch (Exception ex)
            {
                txtError.Text = ex.Message;
            }
        }
    }
}
