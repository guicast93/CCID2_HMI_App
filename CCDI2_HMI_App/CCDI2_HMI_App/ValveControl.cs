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

namespace CCDI2_HMI_App
{
    public partial class ValveControl : Form
    {
        // Storing the values in Form
        private readonly string _IP;
        private readonly string _BitNameLatch;
        private readonly string _BitNameUnlatch;
        private readonly string _ValveNumber;
        private readonly string _ValveStatus;
        public ValveControl(string IP, string BitNameLatch, string BitNameUnlatch, string ValveNumber, string ValveStatus)
        {
            InitializeComponent();
            _IP = IP;
            _BitNameLatch = BitNameLatch;
            _BitNameUnlatch = BitNameUnlatch;
            _ValveNumber = ValveNumber;
            _ValveStatus = ValveStatus;
        }

        public ValveControl()
        {
            InitializeComponent();
        }

        private void ValveControl_Load(object sender, EventArgs e)
        {

        }


        //ValveOn will Energize "BitNameLatch" and De-Energize "BitNameUnlatch"
        private void ValveOn_Click(object sender, EventArgs e)
        {
            // Create the tag right here TO TURN ON
            var tag = new Tag()
            {

                Name = _BitNameLatch, 
                Gateway = _IP,  // ← your ENI IP
                PlcType = PlcType.MicroLogix,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };

            try
            {
                tag.Initialize();

                if (tag.GetStatus() == Status.Ok)
                {
                    //MessageBox.Show("Connection successful");

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
            finally
            {
                tag.Dispose();   // good practice
            }

            //CreateTag her to TURN OFF
            var tag2 = new Tag()
            {

                Name = _BitNameUnlatch,
                Gateway = _IP,  // ← your ENI IP
                PlcType = PlcType.MicroLogix,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };

            try
            {
                tag2.Initialize();

                if (tag2.GetStatus() == Status.Ok)
                {
                    //MessageBox.Show("Connection successful");

                    // Turn Output 1 ON
                    tag2.SetUInt8(0, 0);
                    tag2.Write();
                }
                else
                {
                    MessageBox.Show($"Connection failed: {tag2.GetStatus()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                tag2.Dispose();   // good practice
            }
        }

        //ValveOn will De-energize "BitNameLatch" and Energize "BitNameUnlatch"
        private void ValveOff_Click(object sender, EventArgs e)
        {
            // Create the tag right here TO TURN ON
            var tag = new Tag()
            {

                Name = _BitNameLatch,
                Gateway = _IP,  // ← your ENI IP
                PlcType = PlcType.MicroLogix,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };

            try
            {
                tag.Initialize();

                if (tag.GetStatus() == Status.Ok)
                {
                    //MessageBox.Show("Connection successful");

                    // Turn Output 1 ON
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
            finally
            {
                tag.Dispose();   // good practice
            }

            //CreateTag her to TURN OFF
            var tag2 = new Tag()
            {

                Name = _BitNameUnlatch,
                Gateway = _IP,  // ← your ENI IP
                PlcType = PlcType.MicroLogix,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };

            try
            {
                tag2.Initialize();

                if (tag2.GetStatus() == Status.Ok)
                {
                    //MessageBox.Show("Connection successful");

                    // Turn Output 1 ON
                    tag2.SetUInt8(0, 1);
                    tag2.Write();
                }
                else
                {
                    MessageBox.Show($"Connection failed: {tag2.GetStatus()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                tag2.Dispose();   // good practice
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Pump Number Scan
            ValveNumber.Text = _ValveNumber;

            // Create the tag

            var tag = new Tag()
            {
                Name = _ValveStatus,
                Gateway = _IP,          // ← your ENI IP
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
                    bool isOn = tag.GetBit(0);


                    //Change Panel Back Color
                    if (isOn == true)
                    {
                        StatusPanel.BackColor = Color.Lime;
                    }
                    else
                    {
                        StatusPanel.BackColor = Color.Gray;
                    }
                }
            }
            catch (Exception ex)
            {
                StatusPanel.BackColor = Color.Gray;
            }
            finally
            {
                tag.Dispose();   // good practice
            }
        }
    }
}
