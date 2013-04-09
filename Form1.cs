using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerCmd.Paladin.Wirecast.Interfaces;
using ControllerCmd.Paladin.Wirecast;

namespace WirecastTestingGUI
{
    public partial class Form1 : Form
    {
        IWirecastControl controller1;
        public Form1()
        {
            controller1 = new WirecastControl(new Wirecast());

            InitializeComponent();
        }

        private void StartInstanceAsyncCallback(bool successful)
        {
            if (successful)
            {
                autolive.Enabled = true;
                autolive.Checked = controller1.IsAutoLive;
                toggle_broadcast.Enabled = true;
                status.Text = "Got Wirecast";
            }
        }

        private void start_wirecast_Click(object sender, EventArgs e)
        {
            if (!controller1.IsRunning)
            {
                controller1.StartInstanceAsync(StartInstanceAsyncCallback);
            }
        }

        private void autolive_CheckedChanged(object sender, EventArgs e)
        {
            controller1.IsAutoLive = autolive.Checked;
        }

        private void toggle_broadcast_Click(object sender, EventArgs e)
        {
            controller1.BroadcastAsync(!controller1.IsBroadcasting);
        }

    }
}
