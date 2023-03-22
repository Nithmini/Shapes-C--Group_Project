using ShapeApp.Model;
using ShapeApp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeApp.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shape = shapes.Text;
            switch (shape) { 
                case "Square":
                    this.Visible = false;
                    new SquareForm(this).ShowDialog();
                    
                    break;
                case "Rectangle":
                    this.Visible = false;
                    new RectangleForm(this).ShowDialog();
                    
                    break;
                case "Circle":
                    this.Visible = false;
                    new CircleForm(this).ShowDialog();
                    
                    break;
                default:
                    MessageBox.Show("Invalid Shape!");
                    break;
            }
        }
    }
}
