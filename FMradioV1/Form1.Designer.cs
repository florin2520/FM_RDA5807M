namespace FMradioV1
{
    partial class radioFmForm
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
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.porturiLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.portLabel = new System.Windows.Forms.Label();
            this.startRadioButton = new System.Windows.Forms.Button();
            this.freqTextBox = new System.Windows.Forms.TextBox();
            this.freqUpButton = new System.Windows.Forms.Button();
            this.freqDownButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tuneButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.volTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stationLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(45, 50);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(90, 21);
            this.portNameComboBox.TabIndex = 0;
            // 
            // porturiLabel
            // 
            this.porturiLabel.AutoSize = true;
            this.porturiLabel.Location = new System.Drawing.Point(8, 53);
            this.porturiLabel.Name = "porturiLabel";
            this.porturiLabel.Size = new System.Drawing.Size(31, 13);
            this.porturiLabel.TabIndex = 1;
            this.porturiLabel.Text = "Ports";
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectButton.Location = new System.Drawing.Point(45, 89);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(90, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(150, 58);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(93, 13);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port disconnected";
            // 
            // startRadioButton
            // 
            this.startRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startRadioButton.Location = new System.Drawing.Point(438, 50);
            this.startRadioButton.Name = "startRadioButton";
            this.startRadioButton.Size = new System.Drawing.Size(100, 36);
            this.startRadioButton.TabIndex = 4;
            this.startRadioButton.Text = "Start Radio";
            this.startRadioButton.UseVisualStyleBackColor = true;
            this.startRadioButton.Click += new System.EventHandler(this.startRadioButton_Click);
            // 
            // freqTextBox
            // 
            this.freqTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.freqTextBox.Location = new System.Drawing.Point(214, 145);
            this.freqTextBox.Name = "freqTextBox";
            this.freqTextBox.ReadOnly = true;
            this.freqTextBox.Size = new System.Drawing.Size(131, 32);
            this.freqTextBox.TabIndex = 7;
            this.freqTextBox.TextChanged += new System.EventHandler(this.freqTextBox_TextChanged);
            // 
            // freqUpButton
            // 
            this.freqUpButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.freqUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.freqUpButton.Location = new System.Drawing.Point(295, 258);
            this.freqUpButton.Name = "freqUpButton";
            this.freqUpButton.Size = new System.Drawing.Size(123, 41);
            this.freqUpButton.TabIndex = 8;
            this.freqUpButton.Text = ">>";
            this.freqUpButton.UseVisualStyleBackColor = false;
            this.freqUpButton.Click += new System.EventHandler(this.freqUpButton_Click);
            // 
            // freqDownButton
            // 
            this.freqDownButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.freqDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.freqDownButton.Location = new System.Drawing.Point(153, 258);
            this.freqDownButton.Name = "freqDownButton";
            this.freqDownButton.Size = new System.Drawing.Size(124, 41);
            this.freqDownButton.TabIndex = 9;
            this.freqDownButton.Text = "<<";
            this.freqDownButton.UseVisualStyleBackColor = false;
            this.freqDownButton.Click += new System.EventHandler(this.freqDownButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Silver;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(30, 305);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(511, 42);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tuneButton
            // 
            this.tuneButton.BackColor = System.Drawing.Color.Silver;
            this.tuneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tuneButton.ForeColor = System.Drawing.Color.Blue;
            this.tuneButton.Location = new System.Drawing.Point(225, 199);
            this.tuneButton.Name = "tuneButton";
            this.tuneButton.Size = new System.Drawing.Size(106, 50);
            this.tuneButton.TabIndex = 11;
            this.tuneButton.Text = "Tune";
            this.tuneButton.UseVisualStyleBackColor = false;
            this.tuneButton.Click += new System.EventHandler(this.tuneButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.Location = new System.Drawing.Point(438, 113);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 35);
            this.stopButton.TabIndex = 12;
            this.stopButton.Text = "Stop Radio";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(167, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "FM RADIO with RDA5807M";
            // 
            // volTrackBar
            // 
            this.volTrackBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.volTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volTrackBar.Location = new System.Drawing.Point(45, 154);
            this.volTrackBar.Name = "volTrackBar";
            this.volTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volTrackBar.Size = new System.Drawing.Size(42, 104);
            this.volTrackBar.TabIndex = 14;
            this.volTrackBar.Scroll += new System.EventHandler(this.volTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "87";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(103, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "90";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(168, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "93";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(243, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "96";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(513, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "108";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(445, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "105";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(377, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "102";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(310, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "99";
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stationLabel.Location = new System.Drawing.Point(243, 124);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(72, 20);
            this.stationLabel.TabIndex = 23;
            this.stationLabel.Text = "Station:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Volume";
            // 
            // radioFmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(567, 385);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.tuneButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.freqDownButton);
            this.Controls.Add(this.freqUpButton);
            this.Controls.Add(this.freqTextBox);
            this.Controls.Add(this.startRadioButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.porturiLabel);
            this.Controls.Add(this.portNameComboBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(575, 412);
            this.Name = "radioFmForm";
            this.Text = "FM radio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.Label porturiLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button startRadioButton;
        private System.Windows.Forms.TextBox freqTextBox;
        private System.Windows.Forms.Button freqUpButton;
        private System.Windows.Forms.Button freqDownButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button tuneButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar volTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.Label label10;
    }
}

