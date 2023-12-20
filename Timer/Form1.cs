using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        //needed to activate timeout window when app is out of focus
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        //Form drag events
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(TimerTick);
            timer1.Interval = 1000;
            timer1.Start();
        }
        public struct time_struct
        {
            public string hour { get; set; }
            public string min { get; set; }
            public string sec { get; set; }
        }
        time_struct save_time = new time_struct();
        public void Set_window_to_forground()
        {
            var prc = Process.GetProcessesByName("Timer");
            if (prc.Length > 0)
            {
                SetForegroundWindow(prc[0].MainWindowHandle);
            }
        }

        int countdown = 0;
        bool showbox = true;
        private void TimerTick(object sender, EventArgs e)
        {
            btn_time.Text = DateTime.Now.ToString("hh:mm:ss");
            string TimesUp = save_time.hour + ":" + save_time.min + ":" + save_time.sec;
            try
            {
                //if (btn_time.Text.Substring(6, 2) == txt_timetmp.Text.Substring(6, 2))
                if (btn_time.Text.Substring(6, 2) == save_time.sec)
                {
                    txt_Result.Text = txt_Result.Text.Substring(0, 19);
                    countdown--;
                    txt_Result.Text = txt_Result.Text + " (+" + countdown + ")";
                }
                if (btn_time.Text == TimesUp && showbox == true)
                {
                    timer1.Stop();
                    SoundPlayer player = new SoundPlayer(@"C:\Users\" + Environment.UserName + @"\Documents\Voice\Ivy_Time.wav");
                    player.Play();
                    Set_window_to_forground(); //Must be before msgbox or it will not work.
                    var msgbox = MessageBox.Show(btn_time.Text + " (" + txt_Mynum.Text + ")", "Times up!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Set_window_to_forground(); //Not needed, but to make sure this get executed.
                    showbox = false;
                    if (msgbox == DialogResult.OK)
                    {
                        timer1.Start();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TimerTick()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Image.FromFile(@"C:\Users\" + Environment.UserName + @"\Pictures\MyNotes_SetBG\time is power.jpg");
            btn_time.Text = DateTime.Now.ToString("hh:mm:ss");

            txt_Mynum.Text = "0";
            txt_timetmp.Text = "00:00:00"; //add to prevent error on startup
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var splitTime = txt_timetmp.Text.Split(':');

            save_time.hour = splitTime[0];
            save_time.min = splitTime[1];
            save_time.sec = splitTime[2];

            int num_hour = int.Parse(splitTime[0]);
            int num_min = int.Parse(splitTime[1]);
            //int num_sec = int.Parse(splitTime[2]); //Variable not use. Should delete on the next review.

            int mynum = int.Parse(txt_Mynum.Text);

            if (mynum > 60)
            {
                MessageBox.Show("number cannot be greater than 60", "btn_Add_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (num_min + mynum == 60)
                {
                    save_time.hour = (num_hour + 1).ToString("00");
                    save_time.min = "00";
                }
                else if (num_min + mynum > 60)
                {
                    int minusnum = 60 - num_min;
                    int remainder = mynum - minusnum;
                    save_time.hour = (num_hour + 1).ToString("00");
                    save_time.min = remainder.ToString("00");
                }
                else
                {
                    save_time.hour = num_hour.ToString("00");
                    save_time.min = (num_min + mynum).ToString("00");
                }
                if (int.Parse(save_time.hour) == 13)
                {
                    save_time.hour = "01";
                }
                if (int.Parse(num_min.ToString()) <= int.Parse(txt_timetmp.Text.Substring(3, 2)))
                {
                    //Dec 20 2023 - Code review, does this section of code even need to exist? Basically if starting timer and
                    //time go over a new hour, the countdown starts from the new hour instead of the original time which probably
                    //is causing this known bug when countdown transition over a new hour.
                    /*
                    if (int.Parse(btn_time.Text.Substring(3, 2)) + int.Parse(txt_Mynum.Text) > 60)
                    {
                        int minusnum = 60 - int.Parse(btn_time.Text.Substring(3, 2));
                        int remainder = mynum - minusnum;
                        countdown = remainder;
                    }
                    else
                    {
                        countdown = int.Parse(save_time.min) - int.Parse(btn_time.Text.Substring(3, 2));
                    }
                    txt_Result.Text = txt_timetmp.Text + " - " + save_time.hour + ":" + save_time.min + ":" + save_time.sec + " (+" + countdown + ")";
                    */
                    countdown = int.Parse(txt_Mynum.Text); //Dec 20 2023 - new code line being testing.
                    txt_Result.Text = txt_timetmp.Text + " - " + save_time.hour + ":" + save_time.min + ":" + save_time.sec + " (+" + countdown + ")";
                    txt_Timelog.AppendText(txt_timetmp.Text + " - " + save_time.hour + ":" + save_time.min + ":" + save_time.sec + " (+" + txt_Mynum.Text + ")" + "\r\n");
                }
                else
                {
                    txt_Result.Text = txt_timetmp.Text + " - " + save_time.hour + ":" + save_time.min + ":" + save_time.sec + " (+" + txt_Mynum.Text + ")";
                    txt_Timelog.AppendText(txt_timetmp.Text + "\r\n");
                }
                showbox = true;
            }
        }

        private void btn_Subtract_Click(object sender, EventArgs e)
        {
            /*
            int num1 = int.Parse(txt_num1.Text);
            int num2 = int.Parse(txt_num2.Text);
            int mynum = int.Parse(txt_Mynum.Text);

            if (mynum > 60)
            {
                MessageBox.Show("number cannot be greater than 60", "btn_Subtract_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (num2 - mynum == 00)
                {
                    txt_numres1.Text = (num1).ToString("00");
                    txt_numres2.Text = "00";
                }
                else if (num2 - mynum < 00)
                {
                    int minusnum = mynum - num2;
                    txt_numres1.Text = (num1 - 1).ToString("00");
                    txt_numres2.Text = (60 - minusnum).ToString("00");
                }
                else
                {
                    txt_numres1.Text = txt_num1.Text;
                    txt_numres2.Text = (num2 - mynum).ToString("00");
                }
                if (int.Parse(txt_numres1.Text) == 0)
                {
                    txt_numres1.Text = "12";
                }
                txt_Result.Text = txt_num1.Text + ":" + txt_num2.Text + " - " + txt_numres1.Text + ":" + txt_numres2.Text;
                txt_Timelog.AppendText(txt_Result.Text + " (-" + txt_Mynum.Text + ")" + "\r\n");
                showbox = true;
                //txt_debug.AppendText(DateTime.Now.ToString("hh:mm:ss ") + "btn_Subtract_Click" + showbox.ToString() + "\r\n");
            }
            */
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_Result.Text);           
        }
        private void btn_time_Click(object sender, EventArgs e)
        {
            /*
            txt_timetmp.Text = btn_time.Text;
            var splitTime = btn_time.Text.Split(':');
            save_time.hour = splitTime[0];
            save_time.min = splitTime[1];
            save_time.sec = splitTime[2];  
            */

            var splitTime = btn_time.Text.Split(':');

            save_time.hour = splitTime[0];
            save_time.min = splitTime[1];
            save_time.sec = splitTime[2];

            int num_hour = int.Parse(splitTime[0]);
            int num_min = int.Parse(splitTime[1]);

            int mynum = int.Parse(txt_Mynum.Text);

            if (mynum > 60)
            {
                MessageBox.Show("number cannot be greater than 60", "btn_Add_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (num_min + mynum == 60)
                {
                    save_time.hour = (num_hour + 1).ToString("00");
                    save_time.min = "00";
                }
                else if (num_min + mynum > 60)
                {
                    int minusnum = 60 - num_min;
                    int remainder = mynum - minusnum;
                    save_time.hour = (num_hour + 1).ToString("00");
                    save_time.min = remainder.ToString("00");
                }
                else
                {
                    save_time.hour = num_hour.ToString("00");
                    save_time.min = (num_min + mynum).ToString("00");
                }
                if (int.Parse(save_time.hour) == 13)
                {
                    save_time.hour = "01";
                }
                //if (int.Parse(num_min.ToString()) <= int.Parse(btn_time.Text.Substring(3, 2)))
                //{
                    countdown = int.Parse(txt_Mynum.Text); //Dec 20 2023 - new code line being testing.
                    txt_Result.Text = btn_time.Text + " - " + save_time.hour + ":" + save_time.min + ":" + save_time.sec + " (+" + countdown + ")";
                    txt_Timelog.AppendText(btn_time.Text + " - " + save_time.hour + ":" + save_time.min + ":" + save_time.sec + " (+" + txt_Mynum.Text + ")" + "\r\n");
                //}
                //else
                //{
                //    txt_Result.Text = btn_time.Text + " - " + save_time.hour + ":" + save_time.min + ":" + save_time.sec + " (+" + txt_Mynum.Text + ")";
                //    txt_Timelog.AppendText(btn_time.Text + "\r\n");
                //}
                showbox = true;
            }
        }

        private void btn_clearTimeLog_Click(object sender, EventArgs e)
        {
            txt_Timelog.Text = string.Empty;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(txt_Mynum.Text) + 1) > 60)
            {
                txt_Mynum.Text = "0";                    
            }
            else
            {
                txt_Mynum.Text = (int.Parse(txt_Mynum.Text) + 1).ToString();
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if ((int.Parse(txt_Mynum.Text) - 1) < 0)
            {
                txt_Mynum.Text = "60";               
            }
            else
            {
                txt_Mynum.Text = (int.Parse(txt_Mynum.Text) - 1).ToString();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
