
namespace Arduino
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rbt_PowerOff_Left = new System.Windows.Forms.RadioButton();
            this.rbt_PowerOn_Left = new System.Windows.Forms.RadioButton();
            this.cb_Pos1_Left = new System.Windows.Forms.CheckBox();
            this.cb_Pos2_Left = new System.Windows.Forms.CheckBox();
            this.cb_Pos3_Left = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_ShortVCAN_Left = new System.Windows.Forms.CheckBox();
            this.cb_ShortPCAN_Left = new System.Windows.Forms.CheckBox();
            this.cb_PortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_connect = new System.Windows.Forms.Button();
            this.bt_disconnect = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cb_ShortVCAN_Right = new System.Windows.Forms.CheckBox();
            this.cb_ShortPCAN_Right = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb_PowerOn_Right = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cb_Pos3_Right = new System.Windows.Forms.CheckBox();
            this.cb_Pos2_Right = new System.Windows.Forms.CheckBox();
            this.cb_Pos1_Right = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbt_PowerOff_Left
            // 
            this.rbt_PowerOff_Left.AutoSize = true;
            this.rbt_PowerOff_Left.Location = new System.Drawing.Point(28, 51);
            this.rbt_PowerOff_Left.Name = "rbt_PowerOff_Left";
            this.rbt_PowerOff_Left.Size = new System.Drawing.Size(72, 17);
            this.rbt_PowerOff_Left.TabIndex = 2;
            this.rbt_PowerOff_Left.TabStop = true;
            this.rbt_PowerOff_Left.Text = "Power Off";
            this.rbt_PowerOff_Left.UseVisualStyleBackColor = true;
            // 
            // rbt_PowerOn_Left
            // 
            this.rbt_PowerOn_Left.AutoSize = true;
            this.rbt_PowerOn_Left.Location = new System.Drawing.Point(28, 28);
            this.rbt_PowerOn_Left.Name = "rbt_PowerOn_Left";
            this.rbt_PowerOn_Left.Size = new System.Drawing.Size(72, 17);
            this.rbt_PowerOn_Left.TabIndex = 3;
            this.rbt_PowerOn_Left.TabStop = true;
            this.rbt_PowerOn_Left.Text = "Power On";
            this.rbt_PowerOn_Left.UseVisualStyleBackColor = true;
            this.rbt_PowerOn_Left.CheckedChanged += new System.EventHandler(this.rbt_PowerOn_Left_CheckedChanged);
            // 
            // cb_Pos1_Left
            // 
            this.cb_Pos1_Left.AutoSize = true;
            this.cb_Pos1_Left.Location = new System.Drawing.Point(27, 29);
            this.cb_Pos1_Left.Name = "cb_Pos1_Left";
            this.cb_Pos1_Left.Size = new System.Drawing.Size(72, 17);
            this.cb_Pos1_Left.TabIndex = 0;
            this.cb_Pos1_Left.Text = "Position 1";
            this.cb_Pos1_Left.UseVisualStyleBackColor = true;
            this.cb_Pos1_Left.CheckedChanged += new System.EventHandler(this.cb_Pos1_Left_CheckedChanged);
            // 
            // cb_Pos2_Left
            // 
            this.cb_Pos2_Left.AutoSize = true;
            this.cb_Pos2_Left.Location = new System.Drawing.Point(27, 62);
            this.cb_Pos2_Left.Name = "cb_Pos2_Left";
            this.cb_Pos2_Left.Size = new System.Drawing.Size(72, 17);
            this.cb_Pos2_Left.TabIndex = 1;
            this.cb_Pos2_Left.Text = "Position 2";
            this.cb_Pos2_Left.UseVisualStyleBackColor = true;
            this.cb_Pos2_Left.CheckedChanged += new System.EventHandler(this.cb_Pos2_Left_CheckedChanged);
            // 
            // cb_Pos3_Left
            // 
            this.cb_Pos3_Left.AutoSize = true;
            this.cb_Pos3_Left.Location = new System.Drawing.Point(28, 96);
            this.cb_Pos3_Left.Name = "cb_Pos3_Left";
            this.cb_Pos3_Left.Size = new System.Drawing.Size(72, 17);
            this.cb_Pos3_Left.TabIndex = 2;
            this.cb_Pos3_Left.Text = "Position 3";
            this.cb_Pos3_Left.UseVisualStyleBackColor = true;
            this.cb_Pos3_Left.CheckedChanged += new System.EventHandler(this.cb_Pos3_Left_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Pos3_Left);
            this.groupBox1.Controls.Add(this.cb_Pos2_Left);
            this.groupBox1.Controls.Add(this.cb_Pos1_Left);
            this.groupBox1.Location = new System.Drawing.Point(20, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PIN Position";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_PowerOff_Left);
            this.groupBox2.Controls.Add(this.rbt_PowerOn_Left);
            this.groupBox2.Location = new System.Drawing.Point(20, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 80);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Power Control";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(12, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 575);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LEFT ECU";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_ShortVCAN_Left);
            this.groupBox4.Controls.Add(this.cb_ShortPCAN_Left);
            this.groupBox4.Location = new System.Drawing.Point(20, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(133, 96);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Short PCAN- VCAN";
            // 
            // cb_ShortVCAN_Left
            // 
            this.cb_ShortVCAN_Left.AutoSize = true;
            this.cb_ShortVCAN_Left.Location = new System.Drawing.Point(27, 65);
            this.cb_ShortVCAN_Left.Name = "cb_ShortVCAN_Left";
            this.cb_ShortVCAN_Left.Size = new System.Drawing.Size(86, 17);
            this.cb_ShortVCAN_Left.TabIndex = 2;
            this.cb_ShortVCAN_Left.Text = "Short V-CAN";
            this.cb_ShortVCAN_Left.UseVisualStyleBackColor = true;
            this.cb_ShortVCAN_Left.CheckedChanged += new System.EventHandler(this.cb_ShortVCAN_Left_CheckedChanged);
            // 
            // cb_ShortPCAN_Left
            // 
            this.cb_ShortPCAN_Left.AutoSize = true;
            this.cb_ShortPCAN_Left.Location = new System.Drawing.Point(27, 28);
            this.cb_ShortPCAN_Left.Name = "cb_ShortPCAN_Left";
            this.cb_ShortPCAN_Left.Size = new System.Drawing.Size(86, 17);
            this.cb_ShortPCAN_Left.TabIndex = 1;
            this.cb_ShortPCAN_Left.Text = "Short P-CAN";
            this.cb_ShortPCAN_Left.UseVisualStyleBackColor = true;
            this.cb_ShortPCAN_Left.CheckedChanged += new System.EventHandler(this.cb_ShortPCAN_Left_CheckedChanged);
            // 
            // cb_PortList
            // 
            this.cb_PortList.BackColor = System.Drawing.Color.White;
            this.cb_PortList.FormattingEnabled = true;
            this.cb_PortList.Location = new System.Drawing.Point(71, 61);
            this.cb_PortList.Name = "cb_PortList";
            this.cb_PortList.Size = new System.Drawing.Size(100, 21);
            this.cb_PortList.TabIndex = 10;
            this.cb_PortList.SelectedIndexChanged += new System.EventHandler(this.cb_PortList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ports";
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(209, 61);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(75, 23);
            this.bt_connect.TabIndex = 12;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // bt_disconnect
            // 
            this.bt_disconnect.Location = new System.Drawing.Point(209, 90);
            this.bt_disconnect.Name = "bt_disconnect";
            this.bt_disconnect.Size = new System.Drawing.Size(75, 23);
            this.bt_disconnect.TabIndex = 13;
            this.bt_disconnect.Text = "Disconnect";
            this.bt_disconnect.UseVisualStyleBackColor = true;
            this.bt_disconnect.Click += new System.EventHandler(this.bt_disconnect_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(676, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(295, 575);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RIGHT ECU";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cb_ShortVCAN_Right);
            this.groupBox6.Controls.Add(this.cb_ShortPCAN_Right);
            this.groupBox6.Location = new System.Drawing.Point(20, 277);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(133, 96);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Short PCAN- VCAN";
            // 
            // cb_ShortVCAN_Right
            // 
            this.cb_ShortVCAN_Right.AutoSize = true;
            this.cb_ShortVCAN_Right.Location = new System.Drawing.Point(27, 65);
            this.cb_ShortVCAN_Right.Name = "cb_ShortVCAN_Right";
            this.cb_ShortVCAN_Right.Size = new System.Drawing.Size(86, 17);
            this.cb_ShortVCAN_Right.TabIndex = 2;
            this.cb_ShortVCAN_Right.Text = "Short V-CAN";
            this.cb_ShortVCAN_Right.UseVisualStyleBackColor = true;
            this.cb_ShortVCAN_Right.CheckedChanged += new System.EventHandler(this.cb_ShortVCAN_Right_CheckedChanged);
            // 
            // cb_ShortPCAN_Right
            // 
            this.cb_ShortPCAN_Right.AutoSize = true;
            this.cb_ShortPCAN_Right.Location = new System.Drawing.Point(27, 28);
            this.cb_ShortPCAN_Right.Name = "cb_ShortPCAN_Right";
            this.cb_ShortPCAN_Right.Size = new System.Drawing.Size(86, 17);
            this.cb_ShortPCAN_Right.TabIndex = 1;
            this.cb_ShortPCAN_Right.Text = "Short P-CAN";
            this.cb_ShortPCAN_Right.UseVisualStyleBackColor = true;
            this.cb_ShortPCAN_Right.CheckedChanged += new System.EventHandler(this.cb_ShortPCAN_Right_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Controls.Add(this.rb_PowerOn_Right);
            this.groupBox7.Location = new System.Drawing.Point(20, 32);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(133, 80);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Power Control";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Power Off";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rb_PowerOn_Right
            // 
            this.rb_PowerOn_Right.AutoSize = true;
            this.rb_PowerOn_Right.Location = new System.Drawing.Point(28, 28);
            this.rb_PowerOn_Right.Name = "rb_PowerOn_Right";
            this.rb_PowerOn_Right.Size = new System.Drawing.Size(72, 17);
            this.rb_PowerOn_Right.TabIndex = 3;
            this.rb_PowerOn_Right.TabStop = true;
            this.rb_PowerOn_Right.Text = "Power On";
            this.rb_PowerOn_Right.UseVisualStyleBackColor = true;
            this.rb_PowerOn_Right.CheckedChanged += new System.EventHandler(this.rb_PowerOn_Right_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cb_Pos3_Right);
            this.groupBox8.Controls.Add(this.cb_Pos2_Right);
            this.groupBox8.Controls.Add(this.cb_Pos1_Right);
            this.groupBox8.Location = new System.Drawing.Point(20, 127);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(133, 134);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "PIN Position";
            // 
            // cb_Pos3_Right
            // 
            this.cb_Pos3_Right.AutoSize = true;
            this.cb_Pos3_Right.Location = new System.Drawing.Point(28, 96);
            this.cb_Pos3_Right.Name = "cb_Pos3_Right";
            this.cb_Pos3_Right.Size = new System.Drawing.Size(72, 17);
            this.cb_Pos3_Right.TabIndex = 2;
            this.cb_Pos3_Right.Text = "Position 3";
            this.cb_Pos3_Right.UseVisualStyleBackColor = true;
            this.cb_Pos3_Right.CheckedChanged += new System.EventHandler(this.cb_Pos3_Right_CheckedChanged);
            // 
            // cb_Pos2_Right
            // 
            this.cb_Pos2_Right.AutoSize = true;
            this.cb_Pos2_Right.Location = new System.Drawing.Point(27, 62);
            this.cb_Pos2_Right.Name = "cb_Pos2_Right";
            this.cb_Pos2_Right.Size = new System.Drawing.Size(72, 17);
            this.cb_Pos2_Right.TabIndex = 1;
            this.cb_Pos2_Right.Text = "Position 2";
            this.cb_Pos2_Right.UseVisualStyleBackColor = true;
            this.cb_Pos2_Right.CheckedChanged += new System.EventHandler(this.cb_Pos2_Right_CheckedChanged);
            // 
            // cb_Pos1_Right
            // 
            this.cb_Pos1_Right.AutoSize = true;
            this.cb_Pos1_Right.Location = new System.Drawing.Point(27, 29);
            this.cb_Pos1_Right.Name = "cb_Pos1_Right";
            this.cb_Pos1_Right.Size = new System.Drawing.Size(72, 17);
            this.cb_Pos1_Right.TabIndex = 0;
            this.cb_Pos1_Right.Text = "Position 1";
            this.cb_Pos1_Right.UseVisualStyleBackColor = true;
            this.cb_Pos1_Right.CheckedChanged += new System.EventHandler(this.cb_Pos1_Right_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 537);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.bt_connect);
            this.groupBox9.Controls.Add(this.cb_PortList);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.bt_disconnect);
            this.groupBox9.Location = new System.Drawing.Point(340, 21);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(303, 141);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Port Control";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 599);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BreakBox Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton rbt_PowerOff_Left;
        private System.Windows.Forms.RadioButton rbt_PowerOn_Left;
        private System.Windows.Forms.CheckBox cb_Pos3_Left;
        private System.Windows.Forms.CheckBox cb_Pos2_Left;
        private System.Windows.Forms.CheckBox cb_Pos1_Left;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cb_ShortVCAN_Left;
        private System.Windows.Forms.CheckBox cb_ShortPCAN_Left;
        private System.Windows.Forms.ComboBox cb_PortList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Button bt_disconnect;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cb_ShortVCAN_Right;
        private System.Windows.Forms.CheckBox cb_ShortPCAN_Right;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rb_PowerOn_Right;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox cb_Pos3_Right;
        private System.Windows.Forms.CheckBox cb_Pos2_Right;
        private System.Windows.Forms.CheckBox cb_Pos1_Right;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox9;
    }
}

