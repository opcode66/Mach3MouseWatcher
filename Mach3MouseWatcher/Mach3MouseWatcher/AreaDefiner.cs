//Written by Todd R. Mariana a.k.a. Opcode66
//http://mantra.audio http://deepgroovesmastering.com http://groovegraphics.net http://cutterheadrepair.com

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace Mach3MouseWatcher
{
    public partial class AreaDefiner : Form
    {
        private Point startPos;
        private Point currentPos;
        private Rectangle theRect;
        private bool mouseDown;
        private Form1 parentForm;

        public AreaDefiner()
        {

            InitializeComponent();

            canvas.MouseDown += canvas_MouseDown;
            canvas.MouseMove += canvas_MouseMove;
            canvas.MouseUp += canvas_MouseUp;
            canvas.Paint += canvas_Paint;
        }
        
        public void Init(Form1 form)
        {
            parentForm = form;
            theRect = form.theRect;
        }

        private Rectangle getRectangle()
        {
            try
            {
                theRect = new Rectangle(
                    Math.Min(startPos.X, currentPos.X),
                    Math.Min(startPos.Y, currentPos.Y),
                    Math.Abs(startPos.X - currentPos.X),
                    Math.Abs(startPos.Y - currentPos.Y));
            }
            catch (Exception e)
            {
                //Do Nothing
            }

            return theRect;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                mouseDown = true;
                currentPos = startPos = e.Location;
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (mouseDown)
                {
                    currentPos = e.Location;
                    theRect = getRectangle();
                    canvas.Invalidate();
                }
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                mouseDown = false;
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.DrawRectangle(Pens.Red, theRect);
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText($"{Application.StartupPath}{"\\settings.txt"}", $"X={theRect.X},Y={theRect.Y},Width={theRect.Width},Height={theRect.Height},Application={parentForm.theApp}");
                parentForm.theRect = theRect;
                parentForm.StartTimer();
                Close();
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            parentForm.StartTimer();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                Rectangle bounds = Screen.FromControl(this).Bounds;
                Bitmap captureBitmap = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);

                captureGraphics.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size);

                canvas.Image = captureBitmap;
                Opacity = 100;
            } catch (Exception ex)
            {
                //Do Nothing
            }
        }
    }
}
