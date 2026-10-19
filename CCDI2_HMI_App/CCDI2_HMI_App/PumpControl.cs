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
using System.Data.SqlTypes;
using System.CodeDom;

namespace CCDI2_HMI_App
{
    public partial class PumpControl : Form
    {

        // Storing the values in Form
        private readonly string _IP;
        private readonly string _BitName;
        private readonly string _PumpNumber;
        private readonly string _PumpStatus;
        public PumpControl(string IP, string BitName, string PumpNumber, string PumpStatus)
        {
            InitializeComponent();
            _IP = IP;
            _BitName = BitName;
            _PumpNumber = PumpNumber;
            _PumpStatus = PumpStatus;
         }

        //turn on
        private void PumpOn_Click(object sender, EventArgs e)
        {
            // Create the tag right here
            var tag = new Tag()
            {

                Name = _BitName, //"B3:1/9",
                Gateway = _IP,//"192.168.1.10",          // ← your ENI IP
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

        }
        //Turn Off
        private void PumpOff_Click(object sender, EventArgs e)
        {
            // Create the tag right here
            var tag = new Tag()
            {

                Name = _BitName,
                Gateway = _IP,           // ← your ENI IP
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
            finally
            {
                tag.Dispose();   // good practice
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Pump Number Scan
            PumpNumber.Text = _PumpNumber;
            
            // Create the tag

            var tag = new Tag()
            {
                Name = _PumpStatus,
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



        /*
                public void Word_0()
                {
                    // Create the tag
                    var tag = new Tag()
                    {
                        Name = "N7:200",
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
                            Int16 W200 = tag.GetInt16(0);          // recommended for a bool
                                                                   // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON
                            label2.Text = W200.ToString();

                        }
                        else
                        {
                            MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        tag.Dispose();   // good practice
                    }
                }

               public void Word_1()
                {
                    // Create the tag
                    var tag = new Tag()
                    {
                        Name = "N7:201",
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
                            Int16 W200 = tag.GetInt16(0);          // recommended for a bool
                                                                   // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON
                            label3.Text = W200.ToString();

                        }
                        else
                        {
                            MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        tag.Dispose();   // good practice
                    }
                }
                public void Word_2()
                {
                    // Create the tag
                    var tag = new Tag()
                    {
                        Name = "N7:202",
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
                            Int16 W200 = tag.GetInt16(0);          // recommended for a bool
                                                                   // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON
                            label4.Text = W200.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    finally
                    {
                        tag.Dispose();   // good practice
                    }
                }

                public void Word_3()
                {
                    // Create the tag
                    var tag = new Tag()
                    {
                        Name = "N7:203",
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
                            Int16 W200 = tag.GetInt16(0);          // recommended for a bool
                                                                   // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON
                            label5.Text = W200.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    finally
                    {
                        tag.Dispose();   // good practice
                    }
                }

                public void Word_4()
                {
                    // Create the tag
                    var tag = new Tag()
                    {
                        Name = "N7:204",
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
                            Int16 W200 = tag.GetInt16(0);          // recommended for a bool
                                                                   // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON
                            label6.Text = W200.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    finally
                    {
                        tag.Dispose();   // good practice
                    }
                }

                public void Word_5()
                {
                    // Create the tag
                    var tag = new Tag()
                    {
                        Name = "N7:205",
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
                            Int16 W200 = tag.GetInt16(0);          // recommended for a bool
                                                                   // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON
                            label7.Text = W200.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    finally
                    {
                        tag.Dispose();   // good practice
                    }
                }

                public void Word_6()
                {
                    // Create the tag
                    var tag = new Tag()
                    {
                        Name = "N7:206",
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
                            Int16 W200 = tag.GetInt16(0);          // recommended for a bool
                                                                   // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON
                            label8.Text = W200.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    finally
                    {
                        tag.Dispose();   // good practice
                    }
                }

                public void Word_7()
                {
                    // Create the tag
                    var tag = new Tag()
                    {
                        Name = "N7:207",
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
                            Int16 W200 = tag.GetInt16(0);          // recommended for a bool
                                                                   // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON
                            label9.Text = W200.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    finally
                    {
                        tag.Dispose();   // good practice
                    }
                }

                public void Word_8()
                {
                    // Create the tag
                    var tag = new Tag()
                    {
                        Name = "N7:208",
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
                            Int16 W200 = tag.GetInt16(0);          // recommended for a bool
                                                                   // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON
                            label10.Text = W200.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    finally
                    {
                        tag.Dispose();   // good practice
                    }
                }

                public void Word_9()
                {
                    // Create the tag
                    var tag = new Tag()
                    {
                        Name = "N7:209",
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
                            Int16 W200 = tag.GetInt16(0);          // recommended for a bool
                                                                   // alternative: byte value = tag.GetUInt8(0);  // 0 = OFF, non-zero = ON
                            label11.Text = W200.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Connection failed: {tag.GetStatus()}");
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        tag.Dispose();   // good practice
                    } 
                }*/
    }
}
