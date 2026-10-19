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
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void P1ValveControlPictureBox_Click(object sender, EventArgs e)
        {
            string ip = IPAddressTextBox.Text;
            string bitNameLatch = "N20:9/0";   // Hardcoded string 
            string bitNameUnlatch = "N20:9/1"; // Hardcoded string 
            string valveNumber = "P1";    // Hardcoded string
            string ValveStatus = "N7:211/0"; //Hardcoded String
            ValveControl valveForm = new ValveControl(ip, bitNameLatch, bitNameUnlatch, valveNumber, ValveStatus);
            valveForm.ShowDialog();
        }

        private void P1PumpControlPictureBox_Click(object sender, EventArgs e)
        {

            string ip = IPAddressTextBox.Text;
            string bitName = "N20:8/0";    // Hardcoded string
            string pumpNumber = "P1";    // Hardcoded string
            string PumpStatus = "N7:200/0"; //Hardcoded String
            PumpControl pumpForm = new PumpControl(ip, bitName, pumpNumber, PumpStatus);

            pumpForm.ShowDialog();
            

        }

        private void P2ValveControlPictureBox_Click(object sender, EventArgs e)
        {
            string ip = IPAddressTextBox.Text;
            string bitNameLatch = "N20:9/2";   // Hardcoded string
            string bitNameUnlatch = "N20:9/3"; // Hardcoded string 
            string valveNumber = "P2";    // Hardcoded string
            string ValveStatus = "N7:211/1"; //Hardcoded String
            ValveControl valveForm = new ValveControl(ip, bitNameLatch, bitNameUnlatch, valveNumber, ValveStatus);
            valveForm.ShowDialog();
        }

        private void P2PumpControlPictureBox_Click(object sender, EventArgs e)
        {
            string ip = IPAddressTextBox.Text;
            string bitName = "B3:1/9";   // Hardcoded string -!!!!NEED CHANGE
            string pumpNumber = "P2";    // Hardcoded string
            string PumpStatus = "N7:200/1"; //Hardcoded String
            PumpControl pumpForm = new PumpControl(ip, bitName, pumpNumber, PumpStatus);

            pumpForm.ShowDialog();
        }

        private void P3ValveControlPictureBox_Click(object sender, EventArgs e)
        {
            string ip = IPAddressTextBox.Text;
            string bitNameLatch = "N20:9/4";   // Hardcoded string
            string bitNameUnlatch = "N20:9/5"; // Hardcoded string
            string valveNumber = "P3";    // Hardcoded string
            string ValveStatus = "N7:211/2"; //Hardcoded String
            ValveControl valveForm = new ValveControl(ip, bitNameLatch, bitNameUnlatch, valveNumber, ValveStatus);
            valveForm.ShowDialog();
        }

        private void P3PumpControlPictureBox_Click(object sender, EventArgs e)
        {
            string ip = IPAddressTextBox.Text;
            string bitName = "N20:8/4";   // Hardcoded string
            string pumpNumber = "P3";    // Hardcoded string
            string PumpStatus = "N7:200/2"; // Hardcoded string
            PumpControl pumpForm = new PumpControl(ip, bitName, pumpNumber, PumpStatus);

            pumpForm.ShowDialog();
        }




        private void P5ValveControlPictureBox_Click(object sender, EventArgs e)
        {
            string ip = IPAddressTextBox.Text;
            string bitNameLatch = "N20:9/8";   // Hardcoded string 
            string bitNameUnlatch = "N20:9/9"; // Hardcoded string 
            string valveNumber = "P5";    // Hardcoded string
            string ValveStatus = "N7:211/4"; //Hardcoded String
            ValveControl valveForm = new ValveControl(ip, bitNameLatch, bitNameUnlatch, valveNumber, ValveStatus);
            valveForm.ShowDialog();
        }

        private void P5PumpControlPictureBox_Click(object sender, EventArgs e)
        {
            string ip = IPAddressTextBox.Text;
            string bitName = "N20:8/8";    // Hardcoded string
            string pumpNumber = "P5";    // Hardcoded string
            string PumpStatus = "N7:200/4"; //Hardcoded String
            PumpControl pumpForm = new PumpControl(ip, bitName, pumpNumber, PumpStatus);

            pumpForm.ShowDialog();
        }

        private void P6ValveControlPictureBox_Click(object sender, EventArgs e)
        {
            string ip = IPAddressTextBox.Text;
            string bitNameLatch = "N20:9/10";   // Hardcoded string 
            string bitNameUnlatch = "N20:9/11"; // Hardcoded string 
            string valveNumber = "P5";    // Hardcoded string
            string ValveStatus = "N7:211/5"; //Hardcoded String
            ValveControl valveForm = new ValveControl(ip, bitNameLatch, bitNameUnlatch, valveNumber, ValveStatus);
            valveForm.ShowDialog();
        }

        private void P6PumpControlPictureBox_Click(object sender, EventArgs e)
        {
            string ip = IPAddressTextBox.Text;
            string bitName = "N20:8/10";    // Hardcoded string
            string pumpNumber = "P5";    // Hardcoded string
            string PumpStatus = "N7:200/5"; //Hardcoded String
            PumpControl pumpForm = new PumpControl(ip, bitName, pumpNumber, PumpStatus);

            pumpForm.ShowDialog();
        }

        private void P7ValveControlPictureBox_Click(object sender, EventArgs e)
        {
            string ip = IPAddressTextBox.Text;
            string bitNameLatch = "N20:9/12";   // Hardcoded string 
            string bitNameUnlatch = "N20:9/13"; // Hardcoded string 
            string valveNumber = "P6";    // Hardcoded string
            string ValveStatus = "N7:211/6"; //Hardcoded String
            ValveControl valveForm = new ValveControl(ip, bitNameLatch, bitNameUnlatch, valveNumber, ValveStatus);
            valveForm.ShowDialog();
        }

        private void P7PumpControlPictureBox_Click(object sender, EventArgs e)
        {
            string ip = IPAddressTextBox.Text;
            string bitName = "N20:8/12";    // Hardcoded string
            string pumpNumber = "P6";    // Hardcoded string
            string PumpStatus = "N7:200/6"; //Hardcoded String
            PumpControl pumpForm = new PumpControl(ip, bitName, pumpNumber, PumpStatus);

            pumpForm.ShowDialog();
        }



        /*Logic for Timer Reading*/
        //Used for Status of Tags in Timer
        private Tag statusTag = null;

       //TagConnection Start
        private Tag CreateStatusTag()
        {
            var tag = new Tag()
            {
                Name = "N7:200",
                ElementCount = 13,                 // N7:200 → N7:212
                Gateway = IPAddressTextBox.Text,
                PlcType = PlcType.MicroLogix,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(2)
            };
            tag.Initialize();
            return tag;
        }
        //Timer reading all inputs
        private void FourHzPollTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (statusTag == null)
                    statusTag = CreateStatusTag();

                if (statusTag.GetStatus() != Status.Ok)
                {
                    //Label Write Status of PLC
                    PLCStatusLabel.Text = "No PLC Connection";
                    PLCStatusLabel.ForeColor = Color.Red;
                    //Change Time Staus depending on Connection Status
                    FourHzPollTimer.Enabled = false;

                    //Pump and Valve Click Disable with No PLC Connection
                    P1PumpControlPictureBox.Enabled = false;
                    P1ValveControlPictureBox.BackColor = Color.Gray;
                    P2PumpControlPictureBox.Enabled = false;
                    P2PumpControlPictureBox.BackColor = Color.Gray;
                    P3PumpControlPictureBox.Enabled = false;
                    P3PumpControlPictureBox.BackColor = Color.Gray;
                    P5PumpControlPictureBox.Enabled = false;
                    P5PumpControlPictureBox.BackColor = Color.Gray;
                    P6PumpControlPictureBox.Enabled = false;
                    P6PumpControlPictureBox.BackColor = Color.Gray;
                    P7PumpControlPictureBox.Enabled = false;
                    P7PumpControlPictureBox.BackColor = Color.Gray;

                    P1ValveControlPictureBox.Enabled = false;
                    P1ValveControlPictureBox.BackColor = Color.Gray;
                    P2ValveControlPictureBox.Enabled = false;
                    P2ValveControlPictureBox.BackColor = Color.Gray;
                    P3ValveControlPictureBox.Enabled = false;
                    P3ValveControlPictureBox.BackColor = Color.Gray;
                    P5ValveControlPictureBox.Enabled = false;
                    P5ValveControlPictureBox.BackColor = Color.Gray;
                    P6ValveControlPictureBox.Enabled = false;
                    P6ValveControlPictureBox.BackColor = Color.Gray;
                    P7ValveControlPictureBox.Enabled = false;
                    P7ValveControlPictureBox.BackColor = Color.Gray;


                    //Tag Logic Status
                    statusTag.Dispose();
                    statusTag = null;
                    return;
                    
                }
                PLCStatusLabel.Text = "PLC Connected";
                PLCStatusLabel.ForeColor = Color.LimeGreen;

                //Pump and Valve Click Enable with PLC Connection
                P1PumpControlPictureBox.Enabled = true;
                P1PumpControlPictureBox.BackColor = Color.Transparent;
                P2PumpControlPictureBox.Enabled = true;
                P2PumpControlPictureBox.BackColor = Color.Transparent;
                P3PumpControlPictureBox.Enabled = true;
                P3PumpControlPictureBox.BackColor = Color.Transparent;
                P5PumpControlPictureBox.Enabled = true;
                P5PumpControlPictureBox.BackColor = Color.Transparent;
                P6PumpControlPictureBox.Enabled = true;
                P6PumpControlPictureBox.BackColor = Color.Transparent;
                P7PumpControlPictureBox.Enabled = true;
                P7PumpControlPictureBox.BackColor = Color.Transparent;


                P1ValveControlPictureBox.Enabled = true;
                P1ValveControlPictureBox.BackColor = Color.Transparent;
                P2ValveControlPictureBox.Enabled = true;
                P2ValveControlPictureBox.BackColor = Color.Transparent;
                P3ValveControlPictureBox.Enabled = true;
                P3ValveControlPictureBox.BackColor = Color.Transparent;
                P5ValveControlPictureBox.Enabled = true;
                P5ValveControlPictureBox.BackColor = Color.Transparent;
                P6ValveControlPictureBox.Enabled = true;
                P6ValveControlPictureBox.BackColor = Color.Transparent;
                P7ValveControlPictureBox.Enabled = true;
                P7ValveControlPictureBox.BackColor = Color.Transparent;


                statusTag.Read();

                // ---------- Words ----------
                short w200 = statusTag.GetInt16(0);   // N7:200
                short w201 = statusTag.GetInt16(1);   // N7:201
                short w202 = statusTag.GetInt16(2);   // N7:202
                short w203 = statusTag.GetInt16(3);   // N7:203
                short w206 = statusTag.GetInt16(6);   // N7:206
                short w207 = statusTag.GetInt16(7);   // N7:207
                short w208 = statusTag.GetInt16(8);   // N7:208
                short w209 = statusTag.GetInt16(9);   // N7:209
                short w211 = statusTag.GetInt16(11);  // N7:211
                short w212 = statusTag.GetInt16(12);  // N7:212

                // ============================================================
                // N7:200 – Outputs
                // ============================================================

                // N7:200/0  P1 Output
                bool p1Output = (w200 & (1 << 0)) != 0;
                P1OutputPanel.BackColor = p1Output ? Color.LimeGreen : Color.Gray;

                // N7:200/1  P2 Output
                bool p2Output = (w200 & (1 << 1)) != 0;
                P2OutputPanel.BackColor = p2Output ? Color.LimeGreen : Color.Gray;

                // N7:200/2  P3 Output
                bool p3Output = (w200 & (1 << 2)) != 0;
                P3OutputPanel.BackColor = p3Output ? Color.LimeGreen : Color.Gray;

                // N7:200/4  P5 Output
                bool p5Output = (w200 & (1 << 4)) != 0;
                P5OutputPanel.BackColor = p5Output ? Color.LimeGreen : Color.Gray;

                // N7:200/5  P6 Output
                bool p6Output = (w200 & (1 << 5)) != 0;
                P6OutputPanel.BackColor = p6Output ? Color.LimeGreen : Color.Gray;

                // N7:200/6  P7 Output
                bool p7Output = (w200 & (1 << 6)) != 0;
                P7OutputPanel.BackColor = p7Output ? Color.LimeGreen : Color.Gray;

                // ============================================================
                // N7:201 – Site / Intrusion / Power / Alarms
                // ============================================================

                // N7:201/0  Site Power
                bool sitePower = (w201 & (1 << 0)) != 0;
                SitePowerPanel.BackColor = sitePower ? Color.LimeGreen : Color.Gray;

                // N7:201/1  Spare
                bool SpareN7_201_1 = (w201 & (1 << 1)) != 0;
                // no panel

                // N7:201/7  RTU Intrusion
                bool rtuIntrusion = (w201 & (1 << 7)) != 0;
                RTUIntrusionPanel.BackColor = rtuIntrusion ? Color.Red : Color.Gray;

                // N7:201/8  South Elec Rm Intrusion
                bool southElecRmIntrusion = (w201 & (1 << 8)) != 0;
                SouthRmIntrusionPanel.BackColor = southElecRmIntrusion ? Color.Red : Color.Gray;

                // N7:201/9  North Elec Rm Intrusion
                bool northElecRmIntrusion = (w201 & (1 << 9)) != 0;
                NorthRmIntrusionPanel.BackColor = northElecRmIntrusion ? Color.Red : Color.Gray;

                // N7:201/10 Hi Canal MCC-HC Power
                bool hiCanalMccHcPower = (w201 & (1 << 10)) != 0;
                HiMCCHCPowerPanel.BackColor = hiCanalMccHcPower ? Color.LimeGreen : Color.Gray;

                // N7:201/11 Lo Canal MCC-LC Power
                bool loCanalMccLcPower = (w201 & (1 << 11)) != 0;
                LoMCCHCPowerPanel.BackColor = loCanalMccLcPower ? Color.LimeGreen : Color.Gray;

                // N7:201/12 Plant Lo Intake Alarm
                bool plantLoIntakeAlarm = (w201 & (1 << 12)) != 0;
                PlantLoIntakeAlarmPanel.BackColor = plantLoIntakeAlarm ? Color.Red : Color.Gray;

                // N7:201/13 Lo Line Lockout Alarm
                bool loLineLockoutAlarm = (w201 & (1 << 13)) != 0;
                LoLineLockoutAlarmPanel.BackColor = loLineLockoutAlarm ? Color.Red : Color.Gray;

                // ============================================================
                // N7:202 / N7:203 – Flow
                // ============================================================

                // N7:202  Hi Canal Disch Flow FT  (analog)
                short hiCanalDischFlowFT = w202;
                HiDischFlowFTTextBox.Text = hiCanalDischFlowFT.ToString();

                // N7:203  Lo Canal Disch Flow FT  (analog)
                short LoCanalDischFlowFT = w203;
                LoDischFlowFTTextBox.Text = LoCanalDischFlowFT.ToString();

                // ============================================================
                // N7:206 – Aux + Remote
                // ============================================================

                // N7:206/0  P1 Aux
                bool p1Aux = (w206 & (1 << 0)) != 0;
                P1PumpAuxPanel.BackColor = p1Aux ? Color.LimeGreen : Color.Gray;

                // N7:206/1  P2 Aux
                bool p2Aux = (w206 & (1 << 1)) != 0;
                P2PumpAuxPanel.BackColor = p2Aux ? Color.LimeGreen : Color.Gray;

                // N7:206/2  P3 Aux
                bool p3Aux = (w206 & (1 << 2)) != 0;
                P3PumpAuxPanel.BackColor = p3Aux ? Color.LimeGreen : Color.Gray;

                // N7:206/3  P4 Aux
                bool p4Aux = (w206 & (1 << 3)) != 0;
                P4PumpAuxPanel.BackColor = p4Aux ? Color.LimeGreen : Color.Gray;

                // N7:206/4  P5 Aux
                bool p5Aux = (w206 & (1 << 4)) != 0;
                P5PumpAuxPanel.BackColor = p5Aux ? Color.LimeGreen : Color.Gray;

                // N7:206/5  P6 Aux
                bool p6Aux = (w206 & (1 << 5)) != 0;
                P6PumpAuxPanel.BackColor = p6Aux ? Color.LimeGreen : Color.Gray;

                // N7:206/6  P7 Aux
                bool p7Aux = (w206 & (1 << 6)) != 0;
                P7PumpAuxPanel.BackColor = p7Aux ? Color.LimeGreen : Color.Gray;

                // N7:206/7  P8 Aux
                bool p8Aux = (w206 & (1 << 7)) != 0;
                P8PumpAuxPanel.BackColor = p8Aux ? Color.LimeGreen : Color.Gray;

                // N7:206/8  P1 Remote
                bool p1Remote = (w206 & (1 << 8)) != 0;
                P1RemotePanel.BackColor = p1Remote ? Color.LimeGreen : Color.Gray;
                P1PumpControlPictureBox.Enabled = p1Remote ? true : false;
                P1PumpControlPictureBox.BackColor = p1Remote ? Color.Transparent : Color.Gray;
                P1ValveControlPictureBox.Enabled = p1Remote ? true : false;
                P1ValveControlPictureBox.BackColor = p1Remote ? Color.Transparent : Color.Gray;

                // N7:206/9  P2 Remote
                bool p2Remote = (w206 & (1 << 9)) != 0;
                P2RemotePanel.BackColor = p2Remote ? Color.LimeGreen : Color.Gray;
                P2PumpControlPictureBox.Enabled = p2Remote ? true : false;
                P2PumpControlPictureBox.BackColor = p2Remote ? Color.Transparent : Color.Gray;
                P2ValveControlPictureBox.Enabled = p1Remote ? true : false;
                P2ValveControlPictureBox.BackColor = p1Remote ? Color.Transparent : Color.Gray;

                // N7:206/10 P3 Remote
                bool p3Remote = (w206 & (1 << 10)) != 0;
                P3RemotePanel.BackColor = p3Remote ? Color.LimeGreen : Color.Gray;
                P3PumpControlPictureBox.Enabled = p3Remote ? true : false;
                P3PumpControlPictureBox.BackColor = p3Remote ? Color.Transparent : Color.Gray;
                P3ValveControlPictureBox.Enabled = p1Remote ? true : false;
                P3ValveControlPictureBox.BackColor = p1Remote ? Color.Transparent : Color.Gray;

                // N7:206/12 P5 Remote
                bool p5Remote = (w206 & (1 << 12)) != 0;
                P5RemotePanel.BackColor = p5Remote ? Color.LimeGreen : Color.Gray;
                P5PumpControlPictureBox.Enabled = p5Remote ? true : false;
                P5PumpControlPictureBox.BackColor = p5Remote ? Color.Transparent : Color.Gray;
                P5ValveControlPictureBox.Enabled = p1Remote ? true : false;
                P5ValveControlPictureBox.BackColor = p1Remote ? Color.Transparent : Color.Gray;

                // N7:206/13 P6 Remote
                bool p6Remote = (w206 & (1 << 13)) != 0;
                P6RemotePanel.BackColor = p6Remote ? Color.LimeGreen : Color.Gray;
                P6PumpControlPictureBox.Enabled = p6Remote ? true : false;
                P6PumpControlPictureBox.BackColor = p6Remote ? Color.Transparent : Color.Gray;
                P6ValveControlPictureBox.Enabled = p1Remote ? true : false;
                P6ValveControlPictureBox.BackColor = p1Remote ? Color.Transparent : Color.Gray;

                // N7:206/14 P7 Remote
                bool p7Remote = (w206 & (1 << 14)) != 0;
                P7RemotePanel.BackColor = p7Remote ? Color.LimeGreen : Color.Gray;
                P7PumpControlPictureBox.Enabled = p7Remote ? true : false;
                P7PumpControlPictureBox.BackColor = p7Remote ? Color.Transparent : Color.Gray;
                P7ValveControlPictureBox.Enabled = p1Remote ? true : false;
                P7ValveControlPictureBox.BackColor = p1Remote ? Color.Transparent : Color.Gray;

                // ============================================================
                // N7:207 – Lockout + Winding Temp Alm
                // ============================================================

                // N7:207/0  P1 Lockout Alm
                bool p1LockoutAlm = (w207 & (1 << 0)) != 0;
                P1LockoutPanel.BackColor = p1LockoutAlm ? Color.Red : Color.Gray;

                // N7:207/1  P2 Lockout Alm
                bool p2LockoutAlm = (w207 & (1 << 1)) != 0;
                P2LockoutPanel.BackColor = p2LockoutAlm ? Color.Red : Color.Gray;

                // N7:207/2  P3 Lockout Alm
                bool p3LockoutAlm = (w207 & (1 << 2)) != 0;
                P3LockoutPanel.BackColor = p3LockoutAlm ? Color.Red : Color.Gray;

                // N7:207/4  P5 Lockout Alm
                bool p5LockoutAlm = (w207 & (1 << 4)) != 0;
                P5LockoutPanel.BackColor = p5LockoutAlm ? Color.Red : Color.Gray;

                // N7:207/5  P6 Lockout Alm
                bool p6LockoutAlm = (w207 & (1 << 5)) != 0;
                P6LockoutPanel.BackColor = p6LockoutAlm ? Color.Red : Color.Gray;

                // N7:207/6  P7 Lockout Alm
                bool p7LockoutAlm = (w207 & (1 << 6)) != 0;
                P7LockoutPanel.BackColor = p7LockoutAlm ? Color.Red : Color.Gray;

                // N7:207/8  P1 Winding Temp Alm
                bool p1WindingTempAlm = (w207 & (1 << 8)) != 0;
                P1WindingTempAlmPanel.BackColor = p1WindingTempAlm ? Color.Red : Color.LimeGreen;

                // N7:207/9  P2 Winding Temp Alm
                bool p2WindingTempAlm = (w207 & (1 << 9)) != 0;
                P2WindingTempAlmPanel.BackColor = p2WindingTempAlm ? Color.Red : Color.Gray;

                // N7:207/10 P3 Winding Temp Alm
                bool p3WindingTempAlm = (w207 & (1 << 10)) != 0;
                P3WindingTempAlmPanel.BackColor = p3WindingTempAlm ? Color.Red : Color.Gray;

                // N7:207/12 P5 Winding Temp Alm
                bool p5WindingTempAlm = (w207 & (1 << 12)) != 0;
                P5WindingTempAlmPanel.BackColor = p5WindingTempAlm ? Color.Red : Color.Gray;

                // N7:207/13 P6 Winding Temp Alm
                bool p6WindingTempAlm = (w207 & (1 << 13)) != 0;
                P6WindingTempAlmPanel.BackColor = p6WindingTempAlm ? Color.Red : Color.Gray;

                // N7:207/14 P7 Winding Temp Alm
                bool p7WindingTempAlm = (w207 & (1 << 14)) != 0;
                P7WindingTempAlmPanel.BackColor = p7WindingTempAlm ? Color.Red : Color.Gray;

                // ============================================================
                // N7:208 – Bearing Temp Alm + Vlv OP LS
                // ============================================================

                // N7:208/0  P1 Bearing Temp Alm
                bool p1BearingTempAlm = (w208 & (1 << 0)) != 0;
                P1BearingTempAlmPanel.BackColor = p1BearingTempAlm ? Color.Red : Color.LimeGreen;

                // N7:208/1  P2 Bearing Temp Alm
                bool p2BearingTempAlm = (w208 & (1 << 1)) != 0;
                P2BearingTempAlmPanel.BackColor = p2BearingTempAlm ? Color.Red : Color.Gray;

                // N7:208/2  P3 Bearing Temp Alm
                bool p3BearingTempAlm = (w208 & (1 << 2)) != 0;
                P3BearingTempAlmPanel.BackColor = p3BearingTempAlm ? Color.Red : Color.Gray;

                // N7:208/4  P5 Bearing Temp Alm
                bool p5BearingTempAlm = (w208 & (1 << 4)) != 0;
                P5BearingTempAlmPanel.BackColor = p5BearingTempAlm ? Color.Red : Color.Gray;

                // N7:208/5  P6 Bearing Temp Alm
                bool p6BearingTempAlm = (w208 & (1 << 5)) != 0;
                P6BearingTempAlmPanel.BackColor = p6BearingTempAlm ? Color.Red : Color.Gray;

                // N7:208/6  P7 Bearing Temp Alm
                bool p7BearingTempAlm = (w208 & (1 << 6)) != 0;
                P7BearingTempAlmPanel.BackColor = p7BearingTempAlm ? Color.Red : Color.Gray;

                // N7:208/8  P1 Vlv OP LS
                bool p1VlvOPLS = (w208 & (1 << 8)) != 0;
                P1VlvOPLSPanel.BackColor = p1VlvOPLS ? Color.LimeGreen : Color.Gray;

                // N7:208/9  P2 Vlv OP LS
                bool p2VlvOPLS = (w208 & (1 << 9)) != 0;
                P2VlvOPLSPanel.BackColor = p2VlvOPLS ? Color.LimeGreen : Color.Gray;

                // N7:208/10 P3 Vlv OP LS
                bool p3VlvOPLS = (w208 & (1 << 10)) != 0;
                P3VlvOPLSPanel.BackColor = p3VlvOPLS ? Color.LimeGreen : Color.Gray;

                // N7:208/11 P4 Vlv OP LS
                bool p4VlvOPLS = (w208 & (1 << 11)) != 0;
                P4VlvOPLSPanel.BackColor = p4VlvOPLS ? Color.LimeGreen : Color.Gray;

                // N7:208/12 P5 Vlv OP LS
                bool p5VlvOPLS = (w208 & (1 << 12)) != 0;
                P5VlvOPLSPanel.BackColor = p5VlvOPLS ? Color.LimeGreen : Color.Gray;

                // N7:208/13 P6 Vlv OP LS
                bool p6VlvOPLS = (w208 & (1 << 13)) != 0;
                P6VlvOPLSPanel.BackColor = p6VlvOPLS ? Color.LimeGreen : Color.Gray;

                // N7:208/14 P7 Vlv OP LS
                bool p7VlvOPLS = (w208 & (1 << 14)) != 0;
                P7VlvOPLSPanel.BackColor = p7VlvOPLS ? Color.LimeGreen : Color.Gray;

                // N7:208/15 P8 Vlv OP LS
                bool p8VlvOPLS = (w208 & (1 << 15)) != 0;
                P8VlvOPLSPanel.BackColor = p8VlvOPLS ? Color.LimeGreen : Color.Gray;

                // ============================================================
                // N7:209 – Vlv CL LS + Vlv Remote ss
                // ============================================================

                // N7:209/0  P1 Vlv CL LS
                bool p1VlvCLLS = (w209 & (1 << 0)) != 0;
                P1VlvCLLSPanel.BackColor = p1VlvCLLS ? Color.LimeGreen : Color.Gray;
                

                // N7:209/1  P2 Vlv CL LS
                bool p2VlvCLLS = (w209 & (1 << 1)) != 0;
                P2VlvCLLSPanel.BackColor = p2VlvCLLS ? Color.LimeGreen : Color.Gray;

                // N7:209/2  P3 Vlv CL LS
                bool p3VlvCLLS = (w209 & (1 << 2)) != 0;
                P3VlvCLLSPanel.BackColor = p3VlvCLLS ? Color.LimeGreen : Color.Gray;

                // N7:209/3  P4 Vlv CL LS
                bool p4VlvCLLS = (w209 & (1 << 3)) != 0;
                P4VlvCLLSPanel.BackColor = p4VlvCLLS ? Color.LimeGreen : Color.Gray;

                // N7:209/4  P5 Vlv CL LS
                bool p5VlvCLLS = (w209 & (1 << 4)) != 0;
                P5VlvCLLSPanel.BackColor = p5VlvCLLS ? Color.LimeGreen : Color.Gray;

                // N7:209/5  P6 Vlv CL LS
                bool p6VlvCLLS = (w209 & (1 << 5)) != 0;
                P6VlvCLLSPanel.BackColor = p6VlvCLLS ? Color.LimeGreen : Color.Gray;

                // N7:209/6  P7 Vlv CL LS
                bool p7VlvCLLS = (w209 & (1 << 6)) != 0;
                P7VlvCLLSPanel.BackColor = p7VlvCLLS ? Color.LimeGreen : Color.Gray;

                // N7:209/7  P8 Vlv CL LS
                bool p8VlvCLLS = (w209 & (1 << 7)) != 0;
                P8VlvCLLSPanel.BackColor = p8VlvCLLS ? Color.LimeGreen : Color.Gray;

                // N7:209/8  P1 Vlv Remote ss
                bool p1VlvRemotess = (w209 & (1 << 8)) != 0;
                P1VlvRemotessPanel.BackColor = p1VlvRemotess ? Color.LimeGreen : Color.Gray;

                // N7:209/9  P2 Vlv Remote ss
                bool p2VlvRemotess = (w209 & (1 << 9)) != 0;
                P2VlvRemotessPanel.BackColor = p2VlvRemotess ? Color.LimeGreen : Color.Gray;

                // N7:209/10 P3 Vlv Remote ss
                bool p3VlvRemotess = (w209 & (1 << 10)) != 0;
                P3VlvRemotessPanel.BackColor = p3VlvRemotess ? Color.LimeGreen : Color.Gray;

                // N7:209/11 P4 Vlv Remote ss
                bool p4VlvRemotess = (w209 & (1 << 11)) != 0;
                P4VlvRemotessPanel.BackColor = p4VlvRemotess ? Color.LimeGreen : Color.Gray;

                // N7:209/12 P5 Vlv Remote ss
                bool p5VlvRemotess = (w209 & (1 << 12)) != 0;
                P5VlvRemotessPanel.BackColor = p5VlvRemotess ? Color.LimeGreen : Color.Gray;

                // N7:209/13 P6 Vlv Remote ss
                bool p6VlvRemotess = (w209 & (1 << 13)) != 0;
                P6VlvRemotessPanel.BackColor = p6VlvRemotess ? Color.LimeGreen : Color.Gray;

                // N7:209/14 P7 Vlv Remote ss
                bool p7VlvRemotess = (w209 & (1 << 14)) != 0;
                P7VlvRemotessPanel.BackColor = p7VlvRemotess ? Color.LimeGreen : Color.Gray;

                // N7:209/15 P8 Vlv Remote ss
                bool p8VlvRemotess = (w209 & (1 << 15)) != 0;
                P8VlvRemotessPanel.BackColor = p8VlvRemotess ? Color.LimeGreen : Color.Gray;

                // ============================================================
                // N7:211 – Vlv OPEN Output
                // ============================================================

                // N7:211/0  P1 Vlv OPEN Output
                bool p1VlvOpenOutput = (w211 & (1 << 0)) != 0;
                P1VlvOPENOutputPanel.BackColor = p1VlvOpenOutput ? Color.LimeGreen : Color.Gray;

                // N7:211/1  P2 Vlv OPEN Output
                bool p2VlvOpenOutput = (w211 & (1 << 1)) != 0;
                P2VlvOPENOutputPanel.BackColor = p2VlvOpenOutput ? Color.LimeGreen : Color.Gray;

                // N7:211/2  P3 Vlv OPEN Output
                bool p3VlvOpenOutput = (w211 & (1 << 2)) != 0;
                P3VlvOPENOutputPanel.BackColor = p3VlvOpenOutput ? Color.LimeGreen : Color.Gray;

                // N7:211/3  P4 Vlv OPEN Output
                bool p4VlvOpenOutput = (w211 & (1 << 3)) != 0;
                P4VlvOPENOutputPanel.BackColor = p4VlvOpenOutput ? Color.LimeGreen : Color.Gray;

                // N7:211/4  P5 Vlv OPEN Output
                bool p5VlvOpenOutput = (w211 & (1 << 4)) != 0;
                P5VlvOPENOutputPanel.BackColor = p5VlvOpenOutput ? Color.LimeGreen : Color.Gray;

                // N7:211/5  P6 Vlv OPEN Output
                bool p6VlvOpenOutput = (w211 & (1 << 5)) != 0;
                P6VlvOPENOutputPanel.BackColor = p6VlvOpenOutput ? Color.LimeGreen : Color.Gray;

                // N7:211/6  P7 Vlv OPEN Output
                bool p7VlvOpenOutput = (w211 & (1 << 6)) != 0;
                P7VlvOPENOutputPanel.BackColor = p7VlvOpenOutput ? Color.LimeGreen : Color.Gray;

                // N7:211/7  P8 Vlv OPEN Output
                bool p8VlvOpenOutput = (w211 & (1 << 7)) != 0;
                P8VlvOPENOutputPanel.BackColor = p8VlvOpenOutput ? Color.LimeGreen : Color.Gray;

                // ============================================================
                // N7:212 – Vlv CLOSE Output
                // ============================================================

                // N7:212/0  P1 Vlv CLOSE Output
                bool p1VlvCloseOutput = (w212 & (1 << 0)) != 0;
                P1VlvCLOSEOutputPanel.BackColor = p1VlvCloseOutput ? Color.LimeGreen : Color.Gray;

                // N7:212/1  P2 Vlv CLOSE Output
                bool p2VlvCloseOutput = (w212 & (1 << 1)) != 0;
                P2VlvCLOSEOutputPanel.BackColor = p2VlvCloseOutput ? Color.LimeGreen : Color.Gray;

                // N7:212/2  P3 Vlv CLOSE Output
                bool p3VlvCloseOutput = (w212 & (1 << 2)) != 0;
                P3VlvCLOSEOutputPanel.BackColor = p3VlvCloseOutput ? Color.LimeGreen : Color.Gray;

                // N7:212/3  P4 Vlv CLOSE Output
                bool p4VlvCloseOutput = (w212 & (1 << 3)) != 0;
                P4VlvCLOSEOutputPanel.BackColor = p4VlvCloseOutput ? Color.LimeGreen : Color.Gray;

                // N7:212/4  P5 Vlv CLOSE Output
                bool p5VlvCloseOutput = (w212 & (1 << 4)) != 0;
                P5VlvCLOSEOutputPanel.BackColor = p5VlvCloseOutput ? Color.LimeGreen : Color.Gray;

                // N7:212/5  P6 Vlv CLOSE Output
                bool p6VlvCloseOutput = (w212 & (1 << 5)) != 0;
                P6VlvCLOSEOutputPanel.BackColor = p6VlvCloseOutput ? Color.LimeGreen : Color.Gray;

                // N7:212/6  P7 Vlv CLOSE Output
                bool p7VlvCloseOutput = (w212 & (1 << 6)) != 0;
                P7VlvCLOSEOutputPanel.BackColor = p7VlvCloseOutput ? Color.LimeGreen : Color.Gray;

                // N7:212/7  P8 Vlv CLOSE Output
                bool p8VlvCloseOutput = (w212 & (1 << 7)) != 0;
                P8VlvCLOSEOutputPanel.BackColor = p8VlvCloseOutput ? Color.LimeGreen : Color.Gray;
            }
            catch
            {
                //Label Write Status of PLC
                PLCStatusLabel.Text = "No PLC Connection";
                PLCStatusLabel.ForeColor = Color.Red;
                //Change Time Staus depending on Connection Status
                FourHzPollTimer.Enabled = false;

                //Pump Disable with failed PLC Connection
                P1PumpControlPictureBox.Enabled = false;
                P1PumpControlPictureBox.BackColor = Color.Gray;
                P2PumpControlPictureBox.Enabled = false;
                P2PumpControlPictureBox.BackColor = Color.Gray;
                P3PumpControlPictureBox.Enabled = false;
                P3PumpControlPictureBox.BackColor = Color.Gray;
                P5PumpControlPictureBox.Enabled = false;
                P5PumpControlPictureBox.BackColor = Color.Gray;
                P6PumpControlPictureBox.Enabled = false;
                P6PumpControlPictureBox.BackColor = Color.Gray;
                P7PumpControlPictureBox.Enabled = false;
                P7PumpControlPictureBox.BackColor = Color.Gray;

                P1ValveControlPictureBox.Enabled = false;
                P1ValveControlPictureBox.BackColor = Color.Gray;
                P2ValveControlPictureBox.Enabled = false;
                P2ValveControlPictureBox.BackColor = Color.Gray;
                P3ValveControlPictureBox.Enabled = false;
                P3ValveControlPictureBox.BackColor = Color.Gray;
                P5ValveControlPictureBox.Enabled = false;
                P5ValveControlPictureBox.BackColor = Color.Gray;
                P6ValveControlPictureBox.Enabled = false;
                P6ValveControlPictureBox.BackColor = Color.Gray;
                P7ValveControlPictureBox.Enabled = false;
                P7ValveControlPictureBox.BackColor = Color.Gray;

                if (statusTag != null)
                {
                    //Tag Logic Status
                    statusTag.Dispose();
                    statusTag = null;
                }
            }
        }

        private void EditIPButton_Click(object sender, EventArgs e)
        {
            IPAddressTextBox.BackColor = Color.White;
            IPAddressTextBox.Enabled = true;
        }

        private void ConnectIPButton_Click(object sender, EventArgs e)
        {
            IPAddressTextBox.Enabled = false;
            IPAddressTextBox.BackColor = Color.Silver;
            FourHzPollTimer.Enabled = true;
        }


        //Not sure on these... no rmeote in to turn off..
        private void P4ValveControlPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void P8ValveControlPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
