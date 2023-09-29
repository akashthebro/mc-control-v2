
using System.Net;



namespace mc_control_v2

{



    public partial class Form1 : Form
    {
        public static string adress;
        public static ushort port;
        public static string pass;

        public void cmdsend(string prompt)
        {



        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            adress = ip_textbox.Text;
            port = (ushort)(int)port_box.Value;
            pass = pw_textbox.Text;

            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}