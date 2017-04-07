using System;
using System.Drawing;
using System.Windows.Forms;
using Ivi.Visa.Interop;

namespace PictureMapping
{

    public partial class Form1 : Form
    {
        private readonly ResourceManager _rm = new ResourceManager();
        private readonly FormattedIO488 _io488Con = new FormattedIO488();
        int xCoordinate;
        int yCoordinate;
        string volteSet;
        string currentSet;
        bool DisplayOn = false;
        bool OutputOn = false;
        public Form1()
        {
            InitializeComponent();
        }

        public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            xCoordinate = e.X;
            yCoordinate = e.Y;
            if (e.X > 13 && e.X < 43 && e.Y > 120 && e.Y < 140)
                this.Cursor = Cursors.Hand; //Power on Key
            else if (e.X > 60 && e.X < 100 && e.Y > 105 && e.Y < 128)
                this.Cursor = Cursors.Hand; 
            else if (e.X > 330 && e.X < 368 && e.Y > 142 && e.Y < 168)
                this.Cursor = Cursors.Hand; // Output On / off Toggle
            else if (e.X > 275 && e.X < 315 && e.Y > 105 && e.Y < 128)
                this.Cursor = Cursors.Hand; //Voltage Setup
            else if (e.X > 275 && e.X < 315 && e.Y > 142 && e.Y < 168)
                this.Cursor = Cursors.Hand; //Current setup
            else
                this.Cursor = Cursors.Default;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (xCoordinate > 13 && xCoordinate < 43 && yCoordinate > 120 && yCoordinate < 140)
                this.Close();
            else if (xCoordinate > 60 && xCoordinate < 100 && yCoordinate > 105 && yCoordinate < 128)
            {
                if (DisplayOn)

                {
                    DisplayOn = false;
                    WriteToGPIB(":DISPLAY ON;", "5");
                    OnDisplay.Text = "";
                    voltDisplay.Text = "";
                    currentDisplay.Text = "";
                }
                else if (!DisplayOn)
                {
                    DisplayOn = true;
                    WriteToGPIB(":DISPLAY OFF;", "5");
                    OnDisplay.Text = "Display OFF";
                    voltDisplay.Text = volteSet +" V";
                    currentDisplay.Text = currentSet + " A";
                }
            }
            else if (xCoordinate > 330 && xCoordinate < 368 && yCoordinate > 142 && yCoordinate < 168)
            { //Output Power On/Off Toggle
                if (OutputOn)
                {
                    OutputOn = false;
                    WriteToGPIB(":OUTP OFF;", "5");
                    OnDisplay.Text = "Output OFF";
                    voltDisplay.Text = volteSet + "V";
                    currentDisplay.Text = currentSet + "A";
                }
                else if (!OutputOn)
                {
                    OutputOn = true;
                    WriteToGPIB(":OUTP ON;", "5");
                    OnDisplay.Text = "Output ON";
                    voltDisplay.Text = volteSet + " V";
                    currentDisplay.Text = currentSet + " A";
                }
            }
            else if (xCoordinate > 275 && xCoordinate < 315 && yCoordinate > 105 && yCoordinate < 128)
            {
                volts.Visible = true;
            }
            else if (xCoordinate > 275 && xCoordinate < 315 && yCoordinate > 142 && yCoordinate < 168)
            {
                current.Visible = true;
            }
        }

        private void WriteToGPIB(string GPIBCommand, string GPIBAddress)
            //when this method is called it must include the command and GPIB adrress of the device.
        {
            var resourceString = ("GPIB0::" + GPIBAddress + "::INSTR");
            try
            {
                _io488Con.IO = (IMessage)_rm.Open(resourceString, AccessMode.NO_LOCK, 0);
                _io488Con.IO.Clear();
                _io488Con.WriteString(GPIBCommand);
                Housecleaning();
                richTextBox1.BackColor = Color.LimeGreen;
                richTextBox1.Text = @"Command Execution Completed";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _io488Con.IO.Close();
            }
        }

        private string WriteThenReadFromGPIB(string GPIBCommand, string GPIBAddress)
        {
            string GPIBRead = "";
            var resourceString = ("GPIB0::" + GPIBAddress +"::INSTR");
            try
            {
                _io488Con.IO = (IMessage)_rm.Open(resourceString, AccessMode.NO_LOCK, 0);
                _io488Con.IO.Clear();
                _io488Con.WriteString(GPIBCommand);
                {
                    GPIBRead = _io488Con.ReadString();
                    Housecleaning();
                    richTextBox1.BackColor = Color.LimeGreen;
                    richTextBox1.Text = @"Command Execution Completed";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _io488Con.IO.Close();
            }
            return GPIBRead;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            volteSet = volts.Text;
            WriteToGPIB(":VOLT " + volteSet + ".1;", "5");
            Housecleaning();
            richTextBox1.Text = ("Voltage Set To " + volteSet);
            volts.Visible = false;
        }

        public void Housecleaning()
        {
            richTextBox1.ResetBackColor();
            richTextBox1.Clear();
        }

        private void current_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSet = current.Text;
            WriteToGPIB(":CURR " + currentSet + ";", "5");
            Housecleaning();
            richTextBox1.Text = ("Current Set To " + volteSet);
            current.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Housecleaning();
            WriteToGPIB("*RST", "5");
            WriteToGPIB("*CLS", "5");
            WriteToGPIB("STAT:PRES", "5");
            WriteToGPIB("*ESE 0", "5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
