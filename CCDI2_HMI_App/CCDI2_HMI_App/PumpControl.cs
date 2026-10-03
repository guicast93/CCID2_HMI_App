using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libplctag;
using Status = libplctag.Status;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace CCDI2_HMI_App
{
    public partial class PumpControl : Form
    {
        public PumpControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create the tag right here
            var tag = new Tag()
            {

                Name = "B3:1/9",
                Gateway = "192.168.1.10",          // ← your ENI IP
                PlcType = PlcType.MicroLogix,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(10)
            };

            try
            {
                tag.Initialize();

                if (tag.GetStatus() == Status.Ok)
                {
                    MessageBox.Show("Connection successful");

                }
                else
                {
                    MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create the tag right here
            var tag = new Tag()
            {

                Name = "N20:8/0",
                Gateway = "192.168.1.10",          // ← your ENI IP
                PlcType = PlcType.MicroLogix,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };

            try
            {
                tag.Initialize();

                if (tag.GetStatus() == Status.Ok)
                {
                    MessageBox.Show("Connection successful");

                    // Turn Output 1 ON
                    tag.SetUInt8(0, 1);
                    tag.Write();
                }
                else
                {
                    MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create the tag right here
            var tag = new Tag()
            {

                Name = "N20:8/0",
                Gateway = "192.168.1.10",          // ← your ENI IP
                PlcType = PlcType.MicroLogix,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };

            try
            {
                tag.Initialize();

                if (tag.GetStatus() == Status.Ok)
                {
                    // MessageBox.Show("Connection successful");

                    // Turn Output 1 OFF
                    tag.SetUInt8(0, 0);
                    tag.Write();
                }
                else
                {
                    MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create the tag
            var tag = new Tag()
            {
                Name = "B3:1/9",
                Gateway = "192.168.1.10",          // ← your ENI IP
                PlcType = PlcType.MicroLogix,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };

            try
            {
                tag.Initialize();

                if (tag.GetStatus() == Status.Ok)
                {
                    // Read the current value from the PLC
                    tag.Read();

                    // Because it is a bit tag, GetBit(0) or GetUInt8(0) both work
                    // GetBit returns true/false, GetUInt8 returns 0 or 1 (or non-zero)
                    bool isOn = tag.GetBit(0);          // recommended for a bool
                                                        // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON

                    //MessageBox.Show($"B3:1/9 is currently: {(isOn ? "ON" : "OFF")}");
                    if (isOn == true)
                    {
                        label1.Text = "B3:1/9 is currently: On";
                    }
                    else
                    {
                        label1.Text = "B3:1/9 is currently: Off";
                    }
                }
                else
                {
                    MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                tag.Dispose();   // good practice
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Create the tag
            var tag = new Tag()
            {
                Name = "N7:200/0",
                Gateway = "192.168.1.10",          // ← your ENI IP
                PlcType = PlcType.MicroLogix,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };


            try
            {
                tag.Initialize();

                if (tag.GetStatus() == Status.Ok)
                {
                    // Read the current value from the PLC
                    tag.Read();

                    // Because it is a bit tag, GetBit(0) or GetUInt8(0) both work
                    // GetBit returns true/false, GetUInt8 returns 0 or 1 (or non-zero)
                    bool isOn = tag.GetBit(0);          // recommended for a bool
                                                        // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON

                    //MessageBox.Show($"B3:1/9 is currently: {(isOn ? "ON" : "OFF")}");
                    if (isOn == true)
                    {
                        label1.Text = "B3:1/9 is currently: On";
                        label2.BackColor = Color.Green;
                    }
                    else
                    {
                        label1.Text = "B3:1/9 is currently: Off";
                        label2.BackColor = Color.Gray;
                    }
                }
                else
                {
                    MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                tag.Dispose();   // good practice
            }
        }
    }
}
