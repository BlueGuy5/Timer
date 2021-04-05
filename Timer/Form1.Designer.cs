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
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_clearTimeLog = new System.Windows.Forms.Button();
            this.txt_Timelog = new System.Windows.Forms.TextBox();
            this.btn_time = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_Subtract = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Mynum = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_timetmp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txt_timetmp);
            this.panel1.Controls.Add(this.btn_minus);
            this.panel1.Controls.Add(this.btn_plus);
            this.panel1.Controls.Add(this.btn_clearTimeLog);
            this.panel1.Controls.Add(this.txt_Timelog);
            this.panel1.Controls.Add(this.btn_time);
            this.panel1.Controls.Add(this.btn_copy);
            this.panel1.Controls.Add(this.txt_Result);
            this.panel1.Controls.Add(this.btn_Subtract);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.txt_Mynum);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 177);
            this.panel1.TabIndex = 0;
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.LightCyan;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minus.ForeColor = System.Drawing.Color.Teal;
            this.btn_minus.Location = new System.Drawing.Point(37, 98);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(22, 20);
            this.btn_minus.TabIndex = 18;
            this.btn_minus.Text = "--";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.LightCyan;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_plus.ForeColor = System.Drawing.Color.Teal;
            this.btn_plus.Location = new System.Drawing.Point(105, 98);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(31, 20);
            this.btn_plus.TabIndex = 17;
            this.btn_plus.Text = "++";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_clearTimeLog
            // 
            this.btn_clearTimeLog.BackColor = System.Drawing.Color.LightCyan;
            this.btn_clearTimeLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearTimeLog.ForeColor = System.Drawing.Color.Teal;
            this.btn_clearTimeLog.Location = new System.Drawing.Point(253, 13);
            this.btn_clearTimeLog.Name = "btn_clearTimeLog";
            this.btn_clearTimeLog.Size = new System.Drawing.Size(40, 20);
            this.btn_clearTimeLog.TabIndex = 16;
            this.btn_clearTimeLog.Text = "Clear";
            this.btn_clearTimeLog.UseVisualStyleBackColor = false;
            this.btn_clearTimeLog.Click += new System.EventHandler(this.btn_clearTimeLog_Click);
            // 
            // txt_Timelog
            // 
            this.txt_Timelog.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Timelog.ForeColor = System.Drawing.Color.Teal;
            this.txt_Timelog.Location = new System.Drawing.Point(142, 43);
            this.txt_Timelog.Multiline = true;
            this.txt_Timelog.Name = "txt_Timelog";
            this.txt_Timelog.ReadOnly = true;
            this.txt_Timelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Timelog.Size = new System.Drawing.Size(151, 131);
            this.txt_Timelog.TabIndex = 15;
            this.txt_Timelog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_time
            // 
            this.btn_time.BackColor = System.Drawing.Color.LightCyan;
            this.btn_time.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_time.ForeColor = System.Drawing.Color.Teal;
            this.btn_time.Location = new System.Drawing.Point(47, 151);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(73, 23);
            this.btn_time.TabIndex = 14;
            this.btn_time.Text = "Time";
            this.btn_time.UseVisualStyleBackColor = false;
            this.btn_time.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.LightCyan;
            this.btn_copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.ForeColor = System.Drawing.Color.Teal;
            this.btn_copy.Location = new System.Drawing.Point(200, 13);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(47, 20);
            this.btn_copy.TabIndex = 11;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Result.ForeColor = System.Drawing.Color.Teal;
            this.txt_Result.Location = new System.Drawing.Point(6, 14);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.Size = new System.Drawing.Size(188, 20);
            this.txt_Result.TabIndex = 10;
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Subtract
            // 
            this.btn_Subtract.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Subtract.ForeColor = System.Drawing.Color.Teal;
            this.btn_Subtract.Location = new System.Drawing.Point(50, 125);
            this.btn_Subtract.Name = "btn_Subtract";
            this.btn_Subtract.Size = new System.Drawing.Size(22, 20);
            this.btn_Subtract.TabIndex = 9;
            this.btn_Subtract.Text = "-";
            this.btn_Subtract.UseVisualStyleBackColor = false;
            this.btn_Subtract.Click += new System.EventHandler(this.btn_Subtract_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.ForeColor = System.Drawing.Color.Teal;
            this.btn_Add.Location = new System.Drawing.Point(94, 125);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(22, 20);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "+";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Mynum
            // 
            this.txt_Mynum.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Mynum.ForeColor = System.Drawing.Color.Teal;
            this.txt_Mynum.Location = new System.Drawing.Point(65, 99);
            this.txt_Mynum.Name = "txt_Mynum";
            this.txt_Mynum.Size = new System.Drawing.Size(34, 20);
            this.txt_Mynum.TabIndex = 2;
            this.txt_Mynum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // txt_timetmp
            // 
            this.txt_timetmp.BackColor = System.Drawing.Color.LightCyan;
            this.txt_timetmp.ForeColor = System.Drawing.Color.Teal;
            this.txt_timetmp.Location = new System.Drawing.Point(37, 46);
            this.txt_timetmp.Name = "txt_timetmp";
            this.txt_timetmp.Size = new System.Drawing.Size(94, 20);
            this.txt_timetmp.TabIndex = 20;
            this.txt_timetmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(320, 204);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Mynum;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Subtract;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_time;
        private System.Windows.Forms.TextBox txt_Timelog;
        private System.Windows.Forms.Button btn_clearTimeLog;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.TextBox txt_timetmp;
    }
}

