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

namespace ShapeApp.Views
{
    public partial class SquareForm : Form
    {
        Client client;
        Dashboard dashboard;

        public SquareForm(Dashboard dashboard) {
            InitializeComponent();
            client = null;
            this.dashboard = dashboard;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side = double.Parse(textBox1.Text);
            Square s = new Square(side);
            string output = JsonConvert.SerializeObject(s);
            client = new Client(s);
            client.sendHttpRequest(output);
            MessageBox.Show("Request Sent!");
            this.Close();
            dashboard.Visible = true;
        }
    }
}
