using System;
using System.Diagnostics;
using System.Windows.Forms;
using AutoShutdown.Classes;

namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        private static DateTime _date, _startDate, _endDate;
        private static int _diffSeconds;
        private static int _selectedTab = 0;
        public Form1()
        {
            InitializeComponent();
            TabTimer.Enabled = false;
            DatePicker.Value = DateTime.Today;
            TimePicker.Value = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var span = _endDate - _startDate;
            var logic = ((span.Days * 24 + span.Hours) * 60 + span.Minutes) * 60 + span.Seconds;
            LblShutdownSeconds.Text = $@"{logic} Sekunden";
            LblEndTime.Text = _endDate.ToShortTimeString();
        }

        private void DateTimeDate_ValueChanged(object sender, EventArgs e)
        {
            _date = DatePicker.Value;
            var culture = new System.Globalization.CultureInfo("de-DE");
            LblDay.Text = culture.DateTimeFormat.GetDayName(_date.DayOfWeek);
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            var dtp = new DateTime(DatePicker.Value.Year, DatePicker.Value.Month, DatePicker.Value.Day,
                TimePicker.Value.Hour, TimePicker.Value.Minute, TimePicker.Value.Second);
            var span = dtp - DateTime.Now;
            var logic = ((span.Days * 24 + span.Hours) * 60 + span.Minutes) * 60 + span.Seconds;
            LblSeconds.Text = $@"Das sind {logic} Sekunden";
        }

        private void RadioHour_CheckedChanged(object sender, EventArgs e)
        {
            LblTime.Text = "Stunden:";
        }

        private void RadioMinutes_CheckedChanged(object sender, EventArgs e)
        {
            LblTime.Text = "Minuten:";
        }

        private void RadioSeconds_CheckedChanged(object sender, EventArgs e)
        {
            LblTime.Text = "Sekunden:";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var shutdown = new Shutdown();
            switch (_selectedTab)
            {
                case 0:
                    shutdown.Date(Shutdown.Parse.ParseEndDate(DatePicker.Value, TimePicker.Value));
                    break;
                case 1:
                    _startDate = DateTime.Now;
                    if (RadioHour.Checked)
                    {
                        _endDate = _startDate.AddHours(Convert.ToInt32(TbUnit.Text));
                    }
                    else if (RadioMinutes.Checked)
                    {
                        _endDate = _startDate.AddMinutes(Convert.ToInt32(TbUnit.Text));
                    }
                    else if (RadioSeconds.Checked)
                    {
                        _endDate = _startDate.AddSeconds(Convert.ToInt32(TbUnit.Text));
                    }
                    var span = _endDate - _startDate;
                    var logic = ((span.Days * 24 + span.Hours) * 60 + span.Minutes) * 60 + span.Seconds;
                    Process.Start("shutdown", $"/s /t {logic}");
                    break;
            }
            TabTimer.Enabled = true;
            TabControll.SelectTab(2);
            tabPage1.Enabled = false;
            tabPage2.Enabled = false;
            timer1.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            tabPage1.Enabled = true;
            tabPage2.Enabled = true;
            TabControll.SelectTab(0);
            TabTimer.Enabled = false;
            timer1.Stop();
            Process.Start("shutdown", $"/a");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTab = TabControll.SelectedIndex;
        }
    }
}
