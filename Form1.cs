using System;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace SunMQTT_Stats
{
    public partial class logowanie : Form
    {
        public logowanie()
        {
            InitializeComponent();

            BrokerTxtB.Text = "192.168.0.178";
            PortTxtB.Text = "1883";
            UserTxB.Text = "khadas";
            PasswordTxtB.Text = "password";
            StatusCHK.Visible = false;
            PnlStatus.Visible = false;
            

        }

        static MqttClient client;

      

        #region ---------------> Przyciski

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forum.lothar-team.pl");
            System.Diagnostics.Process.Start("https://suniotprojects.blogspot.com");
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new MqttClient(BrokerTxtB.Text, int.Parse(PortTxtB.Text), false, MqttSslProtocols.None, null, null);
                client.ProtocolVersion = MqttProtocolVersion.Version_3_1;
                byte code = client.Connect(Guid.NewGuid().ToString(), UserTxB.Text, PasswordTxtB.Text);
                if (code == 0)
                {
                    StatusCHK.Visible = true;

                    MetroMessageBox.Show(this, "Successfully Connect to Broker", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                    client.Subscribe(new string[] { "$SYS/broker/version", "$SYS/broker/uptime", "$SYS/broker/timestamp" }, new byte[] { 0, 0, 0 });

                    label1.Text = "MQTT Status";
                    PnlStatus.Visible = true;
                    
                }

                else MetroMessageBox.Show(this, "ERROR !! Connection Fail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            catch (Exception)
            {
                MetroMessageBox.Show(this, "Wrong Messages Format", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        #endregion

        Action<string, string> ReceiveAction;
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            ReceiveAction = Receive;
            try
            {
                this.BeginInvoke(ReceiveAction, Encoding.UTF8.GetString(e.Message), e.Topic);
            }
            catch { };
        }

        void Receive(string message, string topic)
        {
            if (topic == "$SYS/broker/version")
            {
               
                LblVers.Text = message;
                return;
            }
            if (topic == "$SYS/broker/uptime")
            {
                LblUtime.Text = message;
                
            }
            if (topic == "$SYS/broker/timestamp")
            {
                LblTStamp.Text = message;
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forum.lothar-team.pl");
            System.Diagnostics.Process.Start("https://suniotprojects.blogspot.com");
        }
    }
}
