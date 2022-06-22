using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using agilisSDOPINcustomAPI;
using Diebold.Agilis.Power.SDO;

namespace CustomPINSample
{
    public partial class Main : Form
    {
        private agilisSDOPINcustom customPIN;
        private string activeKeys;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            try
            {
                customPIN = new agilisSDOPINcustom();
                txtHistory.Text += string.Format("Initialize = [{0}]{1}", customPIN.Initialize(), Environment.NewLine);
            }
            catch (Exception ex)
            {
                txtHistory.Text += "Initialize Exception: " +
                                   " - Message = " + ex.Message + Environment.NewLine +
                                   " - StackTrace = " + ex.StackTrace + Environment.NewLine;               
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                string result = (customPIN != null && customPIN.Close() == 0) ? "Success" : "Failed";

                txtHistory.Text += string.Format("Close = [{0}]{1}", result, Environment.NewLine);
            }
            catch (Exception ex)
            {
                txtHistory.Text += "Close Exception: " +
                                   " - Message = " + ex.Message + Environment.NewLine +
                                   " - StackTrace = " + ex.StackTrace + Environment.NewLine;
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                customPIN.GetStatus();
                txtHistory.Text += string.Format("Status: Device = [{0}]; InUse = [{1}] {2}", 
                                                 customPIN.devStatus ?? "NULL", 
                                                 customPIN.inuseStatus ?? "NULL", 
                                                 Environment.NewLine);               
            }
            catch (Exception ex)
            {
                txtHistory.Text += "Status Exception: " +
                                   " - Message = " + ex.Message + Environment.NewLine +
                                   " - StackTrace = " + ex.StackTrace + Environment.NewLine;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            activeKeys = (checkR1.Checked ? "1" : "0") +
                         (checkR2.Checked ? "1" : "0") +
                         (checkR3.Checked ? "1" : "0") +
                         (checkR4.Checked ? "1" : "0") +
                         (checkL1.Checked ? "1" : "0") +
                         (checkL2.Checked ? "1" : "0") +
                         (checkL3.Checked ? "1" : "0") +
                         (checkL4.Checked ? "1" : "0");
           
            txtActivateKeys.Text = activeKeys;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                txtHistory.Text += string.Format("Activate Keys = [{0}]; Result = [{1}]{2}", activeKeys, customPIN.setActivePairKeys(activeKeys), Environment.NewLine);
            }
            catch (Exception ex)
            {
                txtHistory.Text += "Activate Exception: " +
                                   " - Message = " + ex.Message + Environment.NewLine +
                                   " - StackTrace = " + ex.StackTrace + Environment.NewLine;
            }
        }

        private void btnStartInput_Click(object sender, EventArgs e)
        {
            try
            {
                string result = "Not Start";
                if (customPIN != null && customPIN.startinput() == 0)
                {
                    result = "Waiting...";
                    customPIN.inputEnd += CustomPIN_inputEnd;
                    customPIN.keyPress += CustomPIN_keyPress;
                }
                txtHistory.Text += string.Format("StartInput: {0}{1}", result, Environment.NewLine);               
            }
            catch (Exception ex)
            {
                txtHistory.Text += "StartInput Exception: " +
                                   " - Message = " + ex.Message + Environment.NewLine +
                                   " - StackTrace = " + ex.StackTrace + Environment.NewLine;
            }
        }

        private void CustomPIN_keyPress(object sender, AgilisPinKeyPressEventEventArgs e)
        {            
            customPIN.keyPress -= CustomPIN_keyPress;
            customPIN.inputEnd -= CustomPIN_inputEnd;
            txtHistory.Text += string.Format("StartInput KeyPress = [{0}]{1}", e.keyAscii, Environment.NewLine);
            txtHistory.Text += string.Format("StartInput Finish{0}", Environment.NewLine);
        }

        private void CustomPIN_inputEnd(object sender, AgilisPinAtInputEndEventArgs e)
        {
            customPIN.inputEnd -= CustomPIN_inputEnd;
            customPIN.keyPress -= CustomPIN_keyPress;
            txtHistory.Text += string.Format("StartInput InputEnd = [{0}]{1}", e.reply, Environment.NewLine);
            txtHistory.Text += string.Format("StartInput Finish{0}", Environment.NewLine);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHistory.Text = string.Empty;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            string result;
            try
            {
                result = (customPIN != null && customPIN.Close() == 0) ? "Success" : "Failed";                
            }
            catch (Exception ex)
            {
                result = "Form Close Exception: " +
                         " - Message = " + ex.Message + Environment.NewLine +
                         " - StackTrace = " + ex.StackTrace + Environment.NewLine;
            }
            Console.WriteLine(result);
        }
    }
}
