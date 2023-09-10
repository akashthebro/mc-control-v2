using MinecraftConnection;
using System.Net;

namespace mc_control_v2

{
    public partial class Form1 : Form
    {
        string address = "127.0.0.1";
        ushort port = 25575;
        string pass = "minecraft";
        public Form1()
        {
            InitializeComponent();
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void debugsend_button_Click(object sender, EventArgs e)
        {
            MinecraftCommands command = new MinecraftCommands(address, port, pass);
            command.DisplayMessage(debugtext_box.Text);
        }
    }
}