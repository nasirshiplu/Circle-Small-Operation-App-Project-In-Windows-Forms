using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleSmallOperationApp
{
    public partial class CircleOperationUI : Form
    {
        public CircleOperationUI()
        {
            InitializeComponent();
        }


      
        private void showButton_Click(object sender, EventArgs e)
        {


            if (radiusTextBox.Text == "" )
            {
                MessageBox.Show("Don;t submit null value ");

   
            }
            else
            {
                Circle circle = new Circle();
                circle.radius = Convert.ToDouble(radiusTextBox.Text);

                double cDiameter = circle.GetDiameter(circle.radius);
                double cPerimeter = circle.GetPerimeter(circle.radius);
                double cArea = circle.GetArea(circle.radius);

                MessageBox.Show("Radius is : " + circle.radius + "\n" + "Diameter is : " + cDiameter + "\n" +
                                "Perimeter is : " + cPerimeter + "\n" + "Area is : " + cArea);
            }

        }
    }
}