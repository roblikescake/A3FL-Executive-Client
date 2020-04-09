using System;
using System.Drawing;
using System.Windows.Forms;

namespace A3FL_Executive_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HideCompStuff();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //Gather Inputs
            string playerName = inputPlayerName.Text;
            string supportName = inputSupportName.Text;
            string applicationStatus = "";
            bool inputsValid;

            //ERROR - Input Missing: Applicant Name
            if (playerName == "")
            {
                labelMessagePreview.Text = "ERROR: You have not entered the Applicant's Name. Try again!";
                labelMessagePreview.ForeColor = Color.Red;
                inputsValid = false;
                return;
            }

            //ERROR - Input Missing: Your Name
            if (supportName == "")
            {
                labelMessagePreview.Text = "ERROR: You have not entered Your Name. Try again!";
                labelMessagePreview.ForeColor = Color.Red;
                inputsValid = false;
                return;
            }

            //ERROR - Input Missing: Response Message
            if (inputChooseResponse.SelectedIndex == -1)
            {
                labelMessagePreview.Text = "ERROR: You have not selected a Response. Try again!";
                labelMessagePreview.ForeColor = Color.Red;
                inputsValid = false;
                return;
            }
            else
            {
                applicationStatus = inputChooseResponse.SelectedItem.ToString();
            }
    

            inputsValid = true;
            //Generate Response
            if (inputsValid == true)
            {
                labelMessagePreview.Text = " ";
                labelMessagePreview.ForeColor = Color.White;
                switch (applicationStatus)
                {
                    case "Support Ticket Completed":
                        labelMessagePreview.Text = "Hello [color=rgb(251, 160, 38)]" + playerName + "[/color],\n\n"
                            + "Your request has been completed.\n\n"
                            + "Regards,\n"
                            + "[color=rgb(100, 0, 150)]" + supportName + "[/color]\n"
                            + "[color=rgb(147, 101, 184)]Executive Team[/color]";
                        break;
                    case "Accepted Whitelist":
                        labelMessagePreview.Text = "Hello [color=rgb(251, 160, 38)]" + playerName + "[/color],\n\n"
                            + "You are now whitelisted.\n\n"
                            + "Regards,\n"
                            + "[color=rgb(100, 0, 150)]" + supportName + "[/color]\n"
                            + "[color=rgb(147, 101, 184)]Executive Team[/color]";
                        break;
                    case "Player Report":
                        labelMessagePreview.Text = "Hello [color=rgb(251, 160, 38)]" + playerName + "[/color],\n\n"
                            + "Thank you for the player report, the executive team will take it from here.\n\n"
                            + "Regards,\n"
                            + "[color=rgb(100, 0, 150)]" + supportName + "[/color]\n"
                            + "[color=rgb(147, 101, 184)]Executive Team[/color]";
                        break;
                    case "Accepted Comp Request - Items":
                        labelMessagePreview.Text = "Hello [color=rgb(251, 160, 38)]" + playerName + "[/color],\n\n"
                            + "Your compensation request has been [color=rgb(97, 189, 109)][b]approved[/b][/color] for the following items:\n\n"
                            + "[color=rgb(26, 188, 156)]"
                            + labelCompensationList.Text
                            + "[/color]\n\n"
                            + "Please [color=rgb(226, 80, 65)]contact an executive[/color] in game via /a to receive your compensation. You have [color=rgb(226, 80, 65)]1 week to claim your compensation[/color] before this request is [color=rgb(226, 80, 65)]no longer valid[/color].\n\n"
                            + "Regards,\n"
                            + "[color=rgb(100, 0, 150)]" + supportName + "[/color]\n"
                            + "[color=rgb(147, 101, 184)]Executive Team[/color]";
                        break;
                    case "Accepted Comp Request - Vehicle":
                        labelMessagePreview.Text = "Hello [color=rgb(251, 160, 38)]" + playerName + "[/color],\n\n"
                            + "Your compensation request has been [color=rgb(97, 189, 109)][b]approved[/b][/color] for the following vehicle(s):\n\n"
                            + "[color=rgb(26, 188, 156)]"
                            + labelCompensationList.Text
                            + "[/color]\n\n"
                            + "You will find your vehicle(s) [color=rgb(184, 49, 47)][b]in your garage/factory[/b][/color] next time you join the game server.\n\n"
                            + "Regards,\n"
                            + "[color=rgb(100, 0, 150)]" + supportName + "[/color]\n"
                            + "[color=rgb(147, 101, 184)]Executive Team[/color]";
                        break;
                    case "Name Change Required":
                        labelMessagePreview.Text = "Hello [color=rgb(251, 160, 38)]" + playerName + "[/color],\n\n"
                            + "Your whitelisting is [color=rgb(250, 197, 28)][i]On Hold[/i][/color] for the following reason(s):\n\n"
                            + "Name change required, you must choose a logical roleplay name [b]OR[/b] you may not use the name of a famous/fictional character. Please submit a Support Ticket. If you have nay questions or need assistance feel free to join our community Teamspeak, [color=rgb(243, 121, 52)]ts3.arma3fisherslife.net or 54.36.238.11:11690[/color] and a support member will assit you.\n\n"
                            + "Regards,\n"
                            + "[color=rgb(100, 0, 150)]" + supportName + "[/color]\n"
                            + "[color=rgb(147, 101, 184)]Executive Team[/color]";
                        break;
                    default:
                        //No item Selected
                        labelMessagePreview.Text = "ERROR: You have not selected a Response. Try again!";
                        labelMessagePreview.ForeColor = Color.Red;
                        break;
                }
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelMessagePreview.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear Inputs
            inputPlayerName.Text = "";
            inputSupportName.Text = "";

            //Clear Response chosen
            inputChooseResponse.SelectedIndex = -1;

            //Clear Outputs
            labelMessagePreview.Text = " ";
            labelCompensationList.Text = " ";
        }
        private void buttonActivityForm_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSd4itIU4X-7OVlyM7SQBXpYv4xfW-1WiW9qkQ6KGAXjDF40NA/viewform");
        }

        private void buttonActivityStats_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1Geq-nWC2NAc6hDUKzMtAQxpSLQHbVmzUISbQh0dcFEA/edit#gid=0");
        }

        private void buttonOperationsManual_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1e4ct-7Q2QQBJa5VEkcHeaidGA1UzAute4MzlBHZah4c/view");
        }

        private void buttonBattlemetrics_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.battlemetrics.com/rcon");
        }

        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://executive.arma3fisherslife.net/panel.php");
        }

        private void buttonStaffRecords_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1JfB2kZ_tSRCgNoxbgxLuCJTLDSDpwNg4UEbbkNa0Nrc/edit#gid=0");
        }

        private void buttonDisciplinaryTracker_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1af8Y0kS-yXDLd9Fr1TYSiiXjBgwNJZi-sCiejqcY50s/edit#gid=709293636");
        }

        private void buttonPunishmentSystem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1lSa0e7AJN3gjYiWE0OwwHcqN_4UvE_JwEHe8Zg_iTLc/edit");
        }

        private void buttonMainDrive_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/u/0/folders/1eT4NXxYSKr_mZP9obCe8eb8gdj3NmCQs");
        }

        private void inputChooseResponse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputChooseResponse.SelectedItem.ToString() == "Accepted Comp Request - Items")
            {
                ShowCompStuff();
            }
            else if (inputChooseResponse.SelectedItem.ToString() == "Accepted Comp Request - Vehicle")
            {
                ShowCompStuff();
            }
            else
            {
                HideCompStuff();
            }
        }

        private void HideCompStuff()
        {
            staticLabelCompItem.Visible = false;
            staticLabelCompList.Visible = false;
            inputCompensationItem.Visible = false;
            buttonAddCompensationItem.Visible = false;
            buttonClearCompensationList.Visible = false;
            labelCompensationList.Visible = false;

            inputCompensationItem.Text = "";
            labelCompensationList.Text = " ";
        }
        private void ShowCompStuff()
        {
            staticLabelCompItem.Visible = true;
            staticLabelCompList.Visible = true;
            inputCompensationItem.Visible = true;
            buttonAddCompensationItem.Visible = true;
            buttonClearCompensationList.Visible = true;
            labelCompensationList.Visible = true;
        }
        private void buttonAddCompensationItem_Click(object sender, EventArgs e)
        {
            //Add item to the compensation list
            if (labelCompensationList.Text == " ")
            {
                labelCompensationList.Text = inputCompensationItem.Text;
            }
            else
            {
                labelCompensationList.Text += "\n" + inputCompensationItem.Text;
            }
        }

        private void buttonClearCompensationList_Click(object sender, EventArgs e)
        {
            labelCompensationList.Text = " ";
        }
    }
}
