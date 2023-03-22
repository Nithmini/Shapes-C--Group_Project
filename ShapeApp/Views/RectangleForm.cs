using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeApp.Service;
using ShapeApp.Model;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace ShapeApp.Views
{
    public partial class RectangleForm : Form
    {
        Client client;
        Dashboard dashboard;
        public RectangleForm(Dashboard dashboard)
        {
            InitializeComponent();
            client = null;
            this.dashboard = dashboard;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length = double.Parse(textBox1.Text);
            double breadth = double.Parse(textBox2.Text);
            Rectangle r = new Rectangle(length, breadth);
            string output = JsonConvert.SerializeObject(r);
            client = new Client(r);
            client.sendHttpRequest(output);
            MessageBox.Show("Request Sent!");
            this.Close();
            dashboard.Visible = true;
        }
    }
}
