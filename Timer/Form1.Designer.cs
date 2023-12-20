namespace Timer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_minus = new System.Windows.Forms.Button();
            this.txt_Mynum = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.txt_timetmp = new System.Windows.Forms.TextBox();
            this.txt_Timelog = new System.Windows.Forms.TextBox();
            this.btn_time = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_clearTimeLog = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_min = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.txt_timetmp);
            this.panel1.Controls.Add(this.txt_Timelog);
            this.panel1.Controls.Add(this.btn_clearTimeLog);
            this.panel1.Controls.Add(this.btn_time);
            this.panel1.Controls.Add(this.txt_Result);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 136);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_minus);
            this.flowLayoutPanel1.Controls.Add(this.txt_Mynum);
            this.flowLayoutPanel1.Controls.Add(this.btn_plus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 26);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.LightCyan;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minus.ForeColor = System.Drawing.Color.Teal;
            this.btn_minus.Location = new System.Drawing.Point(3, 3);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(22, 20);
            this.btn_minus.TabIndex = 18;
            this.btn_minus.Text = "--";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // txt_Mynum
            // 
            this.txt_Mynum.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Mynum.ForeColor = System.Drawing.Color.Teal;
            this.txt_Mynum.Location = new System.Drawing.Point(31, 3);
            this.txt_Mynum.Name = "txt_Mynum";
            this.txt_Mynum.Size = new System.Drawing.Size(34, 20);
            this.txt_Mynum.TabIndex = 2;
            this.txt_Mynum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.LightCyan;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_plus.ForeColor = System.Drawing.Color.Teal;
            this.btn_plus.Location = new System.Drawing.Point(71, 3);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(31, 20);
            this.btn_plus.TabIndex = 17;
            this.btn_plus.Text = "++";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // txt_timetmp
            // 
            this.txt_timetmp.BackColor = System.Drawing.Color.LightCyan;
            this.txt_timetmp.ForeColor = System.Drawing.Color.Teal;
            this.txt_timetmp.Location = new System.Drawing.Point(6, 87);
            this.txt_timetmp.Name = "txt_timetmp";
            this.txt_timetmp.Size = new System.Drawing.Size(107, 20);
            this.txt_timetmp.TabIndex = 20;
            this.txt_timetmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Timelog
            // 
            this.txt_Timelog.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Timelog.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_Timelog.ForeColor = System.Drawing.Color.Teal;
            this.txt_Timelog.Location = new System.Drawing.Point(147, 0);
            this.txt_Timelog.Multiline = true;
            this.txt_Timelog.Name = "txt_Timelog";
            this.txt_Timelog.ReadOnly = true;
            this.txt_Timelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Timelog.Size = new System.Drawing.Size(149, 136);
            this.txt_Timelog.TabIndex = 15;
            this.txt_Timelog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_time
            // 
            this.btn_time.BackColor = System.Drawing.Color.LightCyan;
            this.btn_time.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_time.ForeColor = System.Drawing.Color.Teal;
            this.btn_time.Location = new System.Drawing.Point(40, 58);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(73, 23);
            this.btn_time.TabIndex = 14;
            this.btn_time.Text = "Time";
            this.btn_time.UseVisualStyleBackColor = false;
            this.btn_time.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Result.ForeColor = System.Drawing.Color.Teal;
            this.txt_Result.Location = new System.Drawing.Point(6, 3);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.Size = new System.Drawing.Size(135, 20);
            this.txt_Result.TabIndex = 10;
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.ForeColor = System.Drawing.Color.Teal;
            this.btn_Add.Location = new System.Drawing.Point(119, 87);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(22, 20);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "+";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightCyan;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.ForeColor = System.Drawing.Color.Teal;
            this.btn_close.Location = new System.Drawing.Point(101, 113);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(42, 20);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_clearTimeLog
            // 
            this.btn_clearTimeLog.BackColor = System.Drawing.Color.LightCyan;
            this.btn_clearTimeLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearTimeLog.ForeColor = System.Drawing.Color.Teal;
            this.btn_clearTimeLog.Location = new System.Drawing.Point(6, 113);
            this.btn_clearTimeLog.Name = "btn_clearTimeLog";
            this.btn_clearTimeLog.Size = new System.Drawing.Size(40, 20);
            this.btn_clearTimeLog.TabIndex = 16;
            this.btn_clearTimeLog.Text = "Clear";
            this.btn_clearTimeLog.UseVisualStyleBackColor = false;
            this.btn_clearTimeLog.Click += new System.EventHandler(this.btn_clearTimeLog_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.LightCyan;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_min.ForeColor = System.Drawing.Color.Teal;
            this.btn_min.Location = new System.Drawing.Point(53, 113);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(42, 20);
            this.btn_min.TabIndex = 23;
            this.btn_min.Text = "Min";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(320, 160);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Mynum;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_time;
        private System.Windows.Forms.TextBox txt_Timelog;
        private System.Windows.Forms.Button btn_clearTimeLog;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.TextBox txt_timetmp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_min;
    }
}

