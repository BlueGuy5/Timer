using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        public Form1()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(tabover);
            timer1.Tick += new EventHandler(TimerTick);
            timer1.Interval = 1000;
            timer1.Start();
        }
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
            //txt_Result.Text = txt_Result.Text.Replace(" (" + txt_Mynum.Text + ")","") + " (" + txt_Mynum.Text + ")";
            btn_time.Text = DateTime.Now.ToString("hh:mm:ss");
            string TimesUp = txt_numres1.Text + ":" + txt_numres2.Text;
            if(btn_time.Text.Substring(6,2) == "00")
            {
                txt_Result.Text = txt_Result.Text.Substring(0, 13);
                countdown--;
                txt_Result.Text = txt_Result.Text + " (+" + countdown + ")";
            }
            if(btn_time.Text.Substring(0,5) == TimesUp && showbox == true)
            {
                timer1.Stop();
                Set_window_to_forground(); //Must be before msgbox or it will not work.
                var msgbox = MessageBox.Show(btn_time.Text + " (" + txt_Mynum.Text + ")", "Times up!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Set_window_to_forground(); //Not needed, but to make sure this get executed.
                showbox = false;
                //txt_debug.AppendText(DateTime.Now.ToString("hh:mm:ss" ) + "Timer Tick" + showbox.ToString() + "\r\n");
                if (msgbox == DialogResult.OK)
                {
                    timer1.Start();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Image.FromFile(@"C:\Users\williamyu\Pictures\MyNotes_SetBG\time is power.jpg");
            btn_time.Text = DateTime.Now.ToString("hh:mm:ss");

            var splitTime = btn_time.Text.Split(':');
            txt_num1.Text = splitTime[0].ToString();
            txt_num2.Text = splitTime[1].ToString();
            txt_Mynum.Text = "0";
        }
        private void tabover(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab && txt_num1.Focused == true)
            {
                txt_num2.Text = string.Empty;
            }
            else if (e.KeyCode == Keys.Tab && txt_num2.Focused == true)
            {
                txt_Mynum.Text = string.Empty;
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt_num1.Text);
            int num2 = int.Parse(txt_num2.Text);
            int mynum = int.Parse(txt_Mynum.Text);

            if (mynum > 60)
            {
                MessageBox.Show("number cannot be greater than 60", "btn_Add_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (num2 + mynum == 60)
                {
                    txt_numres1.Text = (num1 + 1).ToString("00");
                    txt_numres2.Text = "00";
                }
                else if (num2 + mynum > 60)
                {
                    int minusnum = 60 - num2;
                    int remainder = mynum - minusnum;
                    txt_numres1.Text = (num1 + 1).ToString("00");
                    txt_numres2.Text = remainder.ToString("00");
                }
                else
                {
                    txt_numres1.Text = txt_num1.Text;
                    txt_numres2.Text = (num2 + mynum).ToString("00");
                }
                if (int.Parse(txt_numres1.Text) == 13)
                {
                    txt_numres1.Text = "1";
                }
                if (int.Parse(txt_num2.Text) <= int.Parse(btn_time.Text.Substring(3, 2)))
                {
                    if (int.Parse(btn_time.Text.Substring(3, 2)) + int.Parse(txt_Mynum.Text) > 60)
                    {
                        int minusnum = 60 - int.Parse(btn_time.Text.Substring(3, 2));
                        int remainder = mynum - minusnum;
                        countdown = remainder;
                    }
                    else
                    {
                        countdown = int.Parse(txt_numres2.Text) - int.Parse(btn_time.Text.Substring(3, 2));
                    }
                    txt_Result.Text = txt_num1.Text + ":" + txt_num2.Text + " - " + txt_numres1.Text + ":" + txt_numres2.Text + " (+" + countdown + ")";
                    txt_Timelog.AppendText(txt_num1.Text + ":" + txt_num2.Text + " - " + txt_numres1.Text + ":" + txt_numres2.Text + " (+" + txt_Mynum.Text + ")" + "\r\n");
                }
                else
                {
                    txt_Result.Text = txt_num1.Text + ":" + txt_num2.Text + " - " + txt_numres1.Text + ":" + txt_numres2.Text + " (+" + txt_Mynum.Text + ")";
                    txt_Timelog.AppendText(txt_Result.Text + "\r\n");
                }
                showbox = true;
                //txt_debug.AppendText(DateTime.Now.ToString("hh:mm:ss ") + "btn_Add_Click" + showbox.ToString() + "\r\n");
            }
        }

        private void btn_Subtract_Click(object sender, EventArgs e)
        {
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
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_Result.Text);           
        }
        private void btn_time_Click(object sender, EventArgs e)
        {
            var splitTime = btn_time.Text.Split(':');
            txt_num1.Text = splitTime[0].ToString();
            txt_num2.Text = splitTime[1].ToString();
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
    }
}
