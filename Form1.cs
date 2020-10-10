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

        }

        static MqttClient client;

      

        #region ---------------> Przyciski

        private void PictureBox2_Click(object sender, EventArgs e)
        {

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
                    client.Subscribe(new string[] { "$SYS/broker/version", "$SYS/broker/uptime", "$SYS/broker/timestamp" }, new byte[] { 0, 0, 0 });
                }

                else MetroMessageBox.Show(this, "ERROR !! Connection Fail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            catch (Exception)
            {
                MetroMessageBox.Show(this, "Wrong Messages Format", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        #endregion


       
    }
}
