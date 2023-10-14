using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftConnection;
using MinecraftConnection.RCON;


namespace mc_control_v2
{

    public partial class Form2 : Form
    {
        //server connection initialize
        static string address = Form1.adress;
        static ushort port = Form1.port;
        static string pass = Form1.pass;

        MinecraftCommands command = new MinecraftCommands(address, port, pass);

        public Form2()
        {
            InitializeComponent();
            gamemodeDrop.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripStatusLabel1.Text = address + " : " + port;
            //dropdown list item insert gamemodes
            gamemodeDrop.Items.Insert(0, "Survival");
            gamemodeDrop.Items.Insert(1, "Creative");
            gamemodeDrop.Items.Insert(2, "Adventure");
            gamemodeDrop.Items.Insert(3, "Spectator");
            gamemodeDrop.SelectedIndex = 0;

            //dropdown list item insert difficulty
            difficultyDrop.Items.Insert(0, "Peaceful");
            difficultyDrop.Items.Insert(1, "Easy");
            difficultyDrop.Items.Insert(2, "Normal");
            difficultyDrop.Items.Insert(3, "Hard");
            difficultyDrop.SelectedIndex = 2;
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

                    //
                    richTextLog.AppendText("\r\n" + "Changing user gamemode to Survival" + " User " + usernametextbox.Text);
                    richTextLog.ScrollToCaret();

                    command.SendCommand("gamemode survival " + usernametextbox.Text);

                    richTextLog.AppendText("");

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

                command.SendCommand("pardon " + usernametextbox.Text);

            }

            if (radio_pardonip.Checked)
            {
                //execute pardon ip

                richTextLog.AppendText("\r\n" + "Unbanning" + " User IP " + pardontextbox.Text);
                richTextLog.ScrollToCaret();

                command.SendCommand("pardon-ip " + pardontextbox.Text);

            }

            if (radio_tp.Checked)
            {
                //execute teleport

                richTextLog.AppendText("\r\n" + "Teleporting " + usernametextbox.Text + " To " + targettp_box.Text);
                richTextLog.ScrollToCaret();

                command.SendCommand("tp " + usernametextbox + " " + targettp_box.Text);
            }

            if (radio_say.Checked)
            {
                //say message

                richTextLog.AppendText("\r\n" + "Sending message to " + targetsay_box.Text);
                richTextLog.ScrollToCaret();

                command.SendCommand("tellraw " + targetsay_box.Text + " " + "{" + $"\"text\":\"{say_msg.Text}\",\"color\":\"White\"" + "}");
            }

            if (radio_diff.Checked)
            {
                //set difficulty

                if (difficultyDrop.SelectedIndex == 0)
                {
                    //set diff to Peaceful

                    richTextLog.AppendText("\r\n" + "Changing Difficulty to Peaceful");
                    richTextLog.ScrollToCaret();

                    command.SendCommand("difficulty peaceful");
                }

                else if (difficultyDrop.SelectedIndex == 1)
                {
                    //set diff to easy

                    richTextLog.AppendText("\r\n" + "Changing Difficulty to Easy");
                    richTextLog.ScrollToCaret();

                    command.SendCommand("difficulty easy");
                }

                else if (difficultyDrop.SelectedIndex == 2)
                {
                    //set diff to normal

                    richTextLog.AppendText("\r\n" + "Changing Difficulty to Normal");
                    richTextLog.ScrollToCaret();

                    command.SendCommand("difficulty normal");
                }

                else if (difficultyDrop.SelectedIndex == 3)
                {
                    //set diff to hard

                    richTextLog.AppendText("\r\n" + "Changing Difficulty to Hard");
                    richTextLog.ScrollToCaret();

                    command.SendCommand("difficulty hard");
                }

                else
                {
                    //return error

                    MessageBox.Show("Invalid option slected, please select a valid option", "Invalid option!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            if (radio_downfall.Checked)
            {
                //toggle downfall

                richTextLog.AppendText("\r\n" + "toggledownfall triggered");
                command.SendCommand("toggledownfall");
            }

            if (radio_time.Checked)
            {
                //set time

                richTextLog.AppendText("\r\n" + "Changing time");
                command.SendCommand("time set " + timevalBox.Text);
            }

            if (radio_daylightcycle.Checked)
            {
                //change gamerule daylightcycle

                if(grt.Checked)
                {
                    richTextLog.AppendText("\r\n" + "setting gamerule to true");
                    command.SendCommand("gamerule dodaylightcycle true");
                }

                else if (grf.Checked)
                {
                    richTextLog.AppendText("\r\n" + "setting gamerule to false");
                    command.SendCommand("gamerule dodaylightcycle false");
                }
            }

            if (radio_keepinv.Checked)
            {
                //change gamerule keepinventory

                if (grt.Checked)
                {
                    richTextLog.AppendText("\r\n" + "setting gamerule to true");
                    command.SendCommand("gamerule keepinventory true");
                }

                else if (grf.Checked)
                {
                    richTextLog.AppendText("\r\n" + "setting gamerule to false");
                    command.SendCommand("gamerule keepinventory false");
                }
            }

        }







        //user selection logging
        private void radio_Gamemode_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Gamemode.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected Gamemode change");
                richTextLog.ScrollToCaret();
            }

        }

        private void richTextLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void radio_unban_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_unban.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected pardon player " + usernametextbox.Text);
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_OP_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_OP.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected OP player " + usernametextbox.Text);
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_Deop_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Deop.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected DeOP player " + usernametextbox.Text);
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_Kick_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Kick.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected Kick player " + usernametextbox.Text);
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_Ban_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Ban.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected Ban player " + usernametextbox.Text);
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_tp_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_tp.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected teleport player " + usernametextbox.Text);
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_Ipban_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Ipban.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected IP ban player " + usernametextbox.Text);
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_pardonip_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_pardonip.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected pardon IP ");
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_say_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_say.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected Send message to target ");
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_diff_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_diff.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected Set game difficulty");
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_downfall_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_downfall.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected Toggle down fall");
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_time_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_time.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected Set time");
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_daylightcycle_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_daylightcycle.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected set gamerule 'Daylight cycle'");
                richTextLog.ScrollToCaret();
            }
        }

        private void radio_keepinv_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_keepinv.Checked)
            {
                richTextLog.AppendText("\r\n" + "pc >> " + address + " : " + port + " Selected set gamerule 'keep inventory'");

                richTextLog.ScrollToCaret();
            }
        }
    }
}
