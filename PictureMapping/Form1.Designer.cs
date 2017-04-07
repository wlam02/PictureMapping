namespace PictureMapping
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.volts = new System.Windows.Forms.ComboBox();
            this.current = new System.Windows.Forms.ComboBox();
            this.voltDisplay = new System.Windows.Forms.RichTextBox();
            this.currentDisplay = new System.Windows.Forms.RichTextBox();
            this.OnDisplay = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PictureMapping.Properties.Resources.FP;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(583, 21);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Status";
            // 
            // volts
            // 
            this.volts.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.volts.FormattingEnabled = true;
            this.volts.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5"});
            this.volts.Location = new System.Drawing.Point(286, 118);
            this.volts.Name = "volts";
            this.volts.Size = new System.Drawing.Size(41, 21);
            this.volts.TabIndex = 2;
            this.volts.Visible = false;
            this.volts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // current
            // 
            this.current.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.current.FormattingEnabled = true;
            this.current.Items.AddRange(new object[] {
            ".1",
            ".2",
            ".25",
            ".5",
            ".75",
            "1",
            "1.25",
            "1.5",
            "1.75",
            "2"});
            this.current.Location = new System.Drawing.Point(288, 154);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(41, 21);
            this.current.TabIndex = 3;
            this.current.Visible = false;
            this.current.SelectedIndexChanged += new System.EventHandler(this.current_SelectedIndexChanged);
            // 
            // voltDisplay
            // 
            this.voltDisplay.BackColor = System.Drawing.Color.Black;
            this.voltDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.voltDisplay.Font = new System.Drawing.Font("DS-Digital", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltDisplay.ForeColor = System.Drawing.Color.Turquoise;
            this.voltDisplay.Location = new System.Drawing.Point(132, 38);
            this.voltDisplay.Name = "voltDisplay";
            this.voltDisplay.ReadOnly = true;
            this.voltDisplay.Size = new System.Drawing.Size(121, 42);
            this.voltDisplay.TabIndex = 4;
            this.voltDisplay.Text = "";
            // 
            // currentDisplay
            // 
            this.currentDisplay.BackColor = System.Drawing.Color.Black;
            this.currentDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentDisplay.Font = new System.Drawing.Font("DS-Digital", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDisplay.ForeColor = System.Drawing.Color.Turquoise;
            this.currentDisplay.Location = new System.Drawing.Point(259, 38);
            this.currentDisplay.Name = "currentDisplay";
            this.currentDisplay.ReadOnly = true;
            this.currentDisplay.Size = new System.Drawing.Size(118, 42);
            this.currentDisplay.TabIndex = 5;
            this.currentDisplay.Text = "";
            // 
            // OnDisplay
            // 
            this.OnDisplay.BackColor = System.Drawing.Color.Black;
            this.OnDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OnDisplay.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnDisplay.ForeColor = System.Drawing.Color.Turquoise;
            this.OnDisplay.Location = new System.Drawing.Point(383, 38);
            this.OnDisplay.Name = "OnDisplay";
            this.OnDisplay.ReadOnly = true;
            this.OnDisplay.Size = new System.Drawing.Size(88, 42);
            this.OnDisplay.TabIndex = 6;
            this.OnDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 227);
            this.Controls.Add(this.OnDisplay);
            this.Controls.Add(this.currentDisplay);
            this.Controls.Add(this.voltDisplay);
            this.Controls.Add(this.current);
            this.Controls.Add(this.volts);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Agilent 66309D Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox volts;
        private System.Windows.Forms.ComboBox current;
        private System.Windows.Forms.RichTextBox voltDisplay;
        private System.Windows.Forms.RichTextBox currentDisplay;
        private System.Windows.Forms.RichTextBox OnDisplay;
    }
}

