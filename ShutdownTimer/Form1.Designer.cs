using System.Windows.Forms;

namespace ShutdownTimer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControll = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LblDay = new System.Windows.Forms.Label();
            this.LblSeconds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LblTime = new System.Windows.Forms.Label();
            this.TbUnit = new System.Windows.Forms.TextBox();
            this.RadioSeconds = new System.Windows.Forms.RadioButton();
            this.RadioMinutes = new System.Windows.Forms.RadioButton();
            this.RadioHour = new System.Windows.Forms.RadioButton();
            this.TabTimer = new System.Windows.Forms.TabPage();
            this.LblShutdownSeconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblEndTime = new System.Windows.Forms.Label();
            this.TabControll.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TabTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControll
            // 
            this.TabControll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControll.Controls.Add(this.tabPage1);
            this.TabControll.Controls.Add(this.tabPage2);
            this.TabControll.Controls.Add(this.TabTimer);
            this.TabControll.Location = new System.Drawing.Point(12, 12);
            this.TabControll.Name = "TabControll";
            this.TabControll.SelectedIndex = 0;
            this.TabControll.Size = new System.Drawing.Size(284, 132);
            this.TabControll.TabIndex = 0;
            this.TabControll.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LblDay);
            this.tabPage1.Controls.Add(this.LblSeconds);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TimePicker);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DatePicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 106);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nach Datum";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LblDay
            // 
            this.LblDay.AutoSize = true;
            this.LblDay.Location = new System.Drawing.Point(24, 63);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(36, 13);
            this.LblDay.TabIndex = 5;
            this.LblDay.Text = "Heute";
            // 
            // LblSeconds
            // 
            this.LblSeconds.AutoSize = true;
            this.LblSeconds.Location = new System.Drawing.Point(128, 63);
            this.LblSeconds.Name = "LblSeconds";
            this.LblSeconds.Size = new System.Drawing.Size(111, 13);
            this.LblSeconds.TabIndex = 4;
            this.LblSeconds.Text = "Das sind: x Sekunden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uhrzeit:";
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(131, 40);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(74, 20);
            this.TimePicker.TabIndex = 2;
            this.TimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum:";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "dd.MM.yyyy";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(27, 40);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(98, 20);
            this.DatePicker.TabIndex = 0;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DateTimeDate_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LblTime);
            this.tabPage2.Controls.Add(this.TbUnit);
            this.tabPage2.Controls.Add(this.RadioSeconds);
            this.tabPage2.Controls.Add(this.RadioMinutes);
            this.tabPage2.Controls.Add(this.RadioHour);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 106);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nach Zeit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(126, 36);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(50, 13);
            this.LblTime.TabIndex = 4;
            this.LblTime.Text = "Stunden:";
            // 
            // TbUnit
            // 
            this.TbUnit.Location = new System.Drawing.Point(129, 52);
            this.TbUnit.Name = "TbUnit";
            this.TbUnit.Size = new System.Drawing.Size(100, 20);
            this.TbUnit.TabIndex = 3;
            // 
            // RadioSeconds
            // 
            this.RadioSeconds.AutoSize = true;
            this.RadioSeconds.Location = new System.Drawing.Point(23, 76);
            this.RadioSeconds.Name = "RadioSeconds";
            this.RadioSeconds.Size = new System.Drawing.Size(74, 17);
            this.RadioSeconds.TabIndex = 2;
            this.RadioSeconds.Text = "Sekunden";
            this.RadioSeconds.UseVisualStyleBackColor = true;
            this.RadioSeconds.CheckedChanged += new System.EventHandler(this.RadioSeconds_CheckedChanged);
            // 
            // RadioMinutes
            // 
            this.RadioMinutes.AutoSize = true;
            this.RadioMinutes.Location = new System.Drawing.Point(23, 53);
            this.RadioMinutes.Name = "RadioMinutes";
            this.RadioMinutes.Size = new System.Drawing.Size(63, 17);
            this.RadioMinutes.TabIndex = 1;
            this.RadioMinutes.Text = "Minuten";
            this.RadioMinutes.UseVisualStyleBackColor = true;
            this.RadioMinutes.CheckedChanged += new System.EventHandler(this.RadioMinutes_CheckedChanged);
            // 
            // RadioHour
            // 
            this.RadioHour.AutoSize = true;
            this.RadioHour.Checked = true;
            this.RadioHour.Location = new System.Drawing.Point(23, 30);
            this.RadioHour.Name = "RadioHour";
            this.RadioHour.Size = new System.Drawing.Size(65, 17);
            this.RadioHour.TabIndex = 0;
            this.RadioHour.TabStop = true;
            this.RadioHour.Text = "Stunden";
            this.RadioHour.UseVisualStyleBackColor = true;
            this.RadioHour.CheckedChanged += new System.EventHandler(this.RadioHour_CheckedChanged);
            // 
            // TabTimer
            // 
            this.TabTimer.Controls.Add(this.LblEndTime);
            this.TabTimer.Controls.Add(this.LblShutdownSeconds);
            this.TabTimer.Controls.Add(this.label3);
            this.TabTimer.Location = new System.Drawing.Point(4, 22);
            this.TabTimer.Name = "TabTimer";
            this.TabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.TabTimer.Size = new System.Drawing.Size(276, 106);
            this.TabTimer.TabIndex = 2;
            this.TabTimer.Text = "Timer";
            this.TabTimer.UseVisualStyleBackColor = true;
            // 
            // LblShutdownSeconds
            // 
            this.LblShutdownSeconds.AutoSize = true;
            this.LblShutdownSeconds.Location = new System.Drawing.Point(81, 42);
            this.LblShutdownSeconds.Name = "LblShutdownSeconds";
            this.LblShutdownSeconds.Size = new System.Drawing.Size(64, 13);
            this.LblShutdownSeconds.TabIndex = 1;
            this.LblShutdownSeconds.Text = "x Sekunden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Shutdown in:";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(217, 150);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Starten";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(112, 150);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stoppen";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(12, 150);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(68, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Schließen";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblEndTime
            // 
            this.LblEndTime.AutoSize = true;
            this.LblEndTime.Location = new System.Drawing.Point(81, 65);
            this.LblEndTime.Name = "LblEndTime";
            this.LblEndTime.Size = new System.Drawing.Size(30, 13);
            this.LblEndTime.TabIndex = 2;
            this.LblEndTime.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 180);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TabControll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shutdown Timer";
            this.TabControll.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.TabTimer.ResumeLayout(false);
            this.TabTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControll;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private DateTimePicker DatePicker;
        private DateTimePicker TimePicker;
        private Label label2;
        private Label LblTime;
        private TextBox TbUnit;
        private RadioButton RadioSeconds;
        private RadioButton RadioMinutes;
        private RadioButton RadioHour;
        private Label LblDay;
        private Label LblSeconds;
        private Button BtnStart;
        private Button BtnStop;
        private Button BtnClose;
        private TabPage TabTimer;
        private Label LblShutdownSeconds;
        private Label label3;
        private Timer timer1;
        private Label LblEndTime;
    }
}

