using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeApp.Service;
using ShapeApp.Model;
using Newtonsoft.Json;
using System.Security.Policy;

namespace ShapeApp.Views
{
    public partial class CircleForm : Form
    {
        Client client;
        Dashboard dashboard;
        public CircleForm(Dashboard dashboard)
        {
            InitializeComponent();
            client = null;
            this.dashboard = dashboard;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox1.Text);
            Circle c = new Circle(radius);
            string output = JsonConvert.SerializeObject(c);
            client = new Client(c);
            client.sendHttpRequest(output);
            MessageBox.Show("Request Sent!");
            this.Close();
            dashboard.Visible = true;
        }
    }
}
