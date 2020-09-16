using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;

namespace chatApp
{
    public partial class Form1 : Form
    {

        IHubProxy _proxy;
        public Form1()
        {
            InitializeComponent();

            HubConnection con = new HubConnection("http://localhost:54479");
            _proxy = con.CreateHubProxy("chat");

            con.Start();
            _proxy.On<string, string>("newMessage", (name, message) => lbl_messages.Invoke(new Action(()=>lbl_messages.Items.Add(name + " : " + message))));

            _proxy.On<string, string>("newMember", (name, groupName) => lbl_messages.Invoke(new Action(() => lbl_messages.Items.Add(name + " joined " + groupName))));

            _proxy.On<string, string, string>("newGroupMessage", (name, groupName, message) => lbl_messages.Invoke(new Action(() => lbl_messages.Items.Add(name +"("+groupName+") : "+message))));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_message_Click(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("sendMessage", txt_name.Text, txt_message.Text);
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("joinGroup", txt_group.Text, txt_name.Text);
        }

        private void btn_send_group_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("sendGroup", txt_group.Text, txt_name.Text, txt_message.Text);
        }
    }
}
