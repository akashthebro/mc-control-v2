using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftConnection;

namespace mc_control_v2
{

    public partial class Form2 : Form
    {
        //server connection initialize
        static string address = Form1.adress;
        static ushort port = Form1.port;
        static string pass = Form1.pass;

        MinecraftCommands command = new MinecraftCommands(address, port, pass);

        //vars for selections




        public Form2()
        {
            InitializeComponent();
            gamemodeDrop.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripStatusLabel1.Text = address + " : " + port;
            //dropdown list item insert
            gamemodeDrop.Items.Insert(0, "Survival");
            gamemodeDrop.Items.Insert(1, "Creative");
            gamemodeDrop.Items.Insert(2, "Adventure");
            gamemodeDrop.Items.Insert(3, "Spectator");
            gamemodeDrop.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //gamemode changer
            if (radio_Gamemode.Checked)
            {
                if (gamemodeDrop.SelectedIndex == 0)
                {
                    //set gamemode survival

                    //richTextLog.AppendText("\r\n" + "===================================================");
                    richTextLog.AppendText("\r\n" + "Changing user gamemode to Survival" + " User " + usernametextbox.Text);
                    richTextLog.ScrollToCaret();

                    command.SendCommand("gamemode survival " + usernametextbox.Text);

                }
                else if (gamemodeDrop.SelectedIndex == 1)
                {
                    //set gamemode creative

                    richTextLog.AppendText("\r\n" + "Changing user gamemode to Creative" + " User " + usernametextbox.Text);
                    richTextLog.ScrollToCaret();

                    command.SendCommand("gamemode creative " + usernametextbox.Text);

                }
                else if (gamemodeDrop.SelectedIndex == 2)
                {
                    //set gamemode adventure

                    richTextLog.AppendText("\r\n" + "Changing user gamemode to Adventure" + " User " + usernametextbox.Text);
                    richTextLog.ScrollToCaret();

                    command.SendCommand("gamemode adventure " + usernametextbox.Text);

                }
                else if (gamemodeDrop.SelectedIndex == 3)
                {
                    //set gamemode spectator

                    richTextLog.AppendText("\r\n" + "Changing user gamemode to Spectator" + " User " + usernametextbox.Text);
                    richTextLog.ScrollToCaret();

                    command.SendCommand("gamemode spectator " + usernametextbox.Text);

                }
                else
                {
                    MessageBox.Show("Invalid option slected, please select a valid option", "Invalid option!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //other (op | deop | kick | ban | ipban)

            if (radio_OP.Checked)
            {
                //op player

                richTextLog.AppendText("\r\n" + "Giving operator permission to" + " User " + usernametextbox.Text);
                richTextLog.ScrollToCaret();

                command.SendCommand("op " + usernametextbox.Text);
            }

            if (radio_Deop.Checked)
            {
                //deop player

                richTextLog.AppendText("\r\n" + "Removing operator permission from" + " User " + usernametextbox.Text);
                richTextLog.ScrollToCaret();
            }

            if (radio_Kick.Checked)
            {
                //kick player

                richTextLog.AppendText("\r\n" + "kicking" + " User " + usernametextbox.Text + " ,Due to " + kbreasontextbox.Text);
                richTextLog.ScrollToCaret();

                command.SendCommand("kick " + usernametextbox.Text + " " + kbreasontextbox.Text);

            }

            if (radio_Ban.Checked)
            {
                //ban player

                richTextLog.AppendText("\r\n" + "Banning" + " User " + usernametextbox.Text + " ,Due to " + kbreasontextbox.Text);
                richTextLog.ScrollToCaret();

                command.SendCommand("ban " + usernametextbox.Text + " " + kbreasontextbox.Text);

            }

            if (radio_Ipban.Checked)
            {
                //execute ipban 

                richTextLog.AppendText("\r\n" + "Banning" + " User IP " + usernametextbox.Text + " ,Due to " + kbreasontextbox.Text);
                richTextLog.ScrollToCaret();

                command.SendCommand("ipban " + usernametextbox.Text + " " + kbreasontextbox.Text);

            }

            if (radio_unban.Checked)
            {
                //execute unban player

                richTextLog.AppendText("\r\n" + "Unbanning" + " User " + usernametextbox.Text);
                richTextLog.ScrollToCaret();

                command.SendCommand("unban " + usernametextbox.Text);

            }

            if (radio_pardonip.Checked)
            {
                //execute pardon ip

                richTextLog.AppendText("\r\n" + "Unbanning" + " User IP " + pardontextbox.Text);
                richTextLog.ScrollToCaret();

                command.SendCommand("pardon-ip " + pardontextbox.Text);

            }

        }







        //user selection logging
        private void radio_Gamemode_CheckedChanged(object sender, EventArgs e)
        {
            richTextLog.AppendText("\r\n" + "===================================================");
            richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + "Selected Gamemode change");
            richTextLog.ScrollToCaret();
        }

        private void radio_OP_CheckedChanged(object sender, EventArgs e)
        {
            richTextLog.AppendText("\r\n" + "===================================================");
            richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + "Selected Op player");
            richTextLog.ScrollToCaret();
        }

        private void radio_Deop_CheckedChanged(object sender, EventArgs e)
        {
            richTextLog.AppendText("\r\n" + "===================================================");
            richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + "Selected DeOp player");
            richTextLog.ScrollToCaret();
        }

        private void radio_Kick_CheckedChanged(object sender, EventArgs e)
        {
            richTextLog.AppendText("\r\n" + "===================================================");
            richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + "Selected Kick player");
            richTextLog.ScrollToCaret();
        }

        private void radio_Ban_CheckedChanged(object sender, EventArgs e)
        {
            richTextLog.AppendText("\r\n" + "===================================================");
            richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + "Selected Ban player");
            richTextLog.ScrollToCaret();
        }

        private void radio_Ipban_CheckedChanged(object sender, EventArgs e)
        {
            richTextLog.AppendText("\r\n" + "===================================================");
            richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + "Selected IP Ban");
            richTextLog.ScrollToCaret();
        }
    }
}
