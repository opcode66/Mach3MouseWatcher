namespace Mach3MouseWatcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnHide = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRect = new System.Windows.Forms.Label();
            this.lblApp = new System.Windows.Forms.Label();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDefine = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X=,Y=";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Mach3MouseWatcher";
            this.notifyIcon1.Visible = true;
            // 
            // btnHide
            // 
            this.btnHide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHide.Location = new System.Drawing.Point(514, 476);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "Close";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rect:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "App:";
            // 
            // lblRect
            // 
            this.lblRect.AutoSize = true;
            this.lblRect.Location = new System.Drawing.Point(76, 32);
            this.lblRect.Name = "lblRect";
            this.lblRect.Size = new System.Drawing.Size(113, 13);
            this.lblRect.TabIndex = 6;
            this.lblRect.Text = "X=,Y=,Width=,Height=";
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(76, 54);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(104, 13);
            this.lblApp.TabIndex = 7;
            this.lblApp.Text = "Blah Blah Some App";
            // 
            // btnTerminate
            // 
            this.btnTerminate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTerminate.Location = new System.Drawing.Point(473, 12);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(116, 23);
            this.btnTerminate.TabIndex = 8;
            this.btnTerminate.Text = "Exit Monitoring App";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(572, 264);
            this.listBox1.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdate.Location = new System.Drawing.Point(17, 476);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(73, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update List";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMonitor.Location = new System.Drawing.Point(96, 476);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(122, 23);
            this.btnMonitor.TabIndex = 11;
            this.btnMonitor.Text = "Monitor Selected App";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(352, 476);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Selected App";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDefine
            // 
            this.btnDefine.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDefine.Location = new System.Drawing.Point(371, 12);
            this.btnDefine.Name = "btnDefine";
            this.btnDefine.Size = new System.Drawing.Size(93, 23);
            this.btnDefine.TabIndex = 13;
            this.btnDefine.Text = "Define Area";
            this.btnDefine.UseVisualStyleBackColor = true;
            this.btnDefine.Click += new System.EventHandler(this.btnDefine_Click);
            // 
            // btnLast
            // 
            this.btnLast.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLast.Location = new System.Drawing.Point(224, 476);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(122, 23);
            this.btnLast.TabIndex = 14;
            this.btnLast.Text = "Monitor Last Active App";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mouse:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(76, 77);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(104, 13);
            this.lblLast.TabIndex = 17;
            this.lblLast.Text = "Blah Blah Some App";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Last:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Last Error:";
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(79, 122);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(510, 54);
            this.txtError.TabIndex = 19;
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(18, 99);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(36, 13);
            this.Timer.TabIndex = 16;
            this.Timer.Text = "Timer:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(76, 99);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(46, 13);
            this.lblTimer.TabIndex = 17;
            this.lblTimer.Text = "Enabled";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 511);
            this.ControlBox = false;
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnDefine);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.lblRect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "Mach3MouseWatcher";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRect;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDefine;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label lblTimer;
    }
}

