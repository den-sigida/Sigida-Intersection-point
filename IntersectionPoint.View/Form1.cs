using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IntersectionPoint.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void SeriesDataChanged(object sender, EventArgs e)
        {
            //chartFunction.Series[0].Points[0].XValue = float.Parse(textPointFX.Text);
            //chartFunction.Series[0].Points[0].YValues = new double[] { float.Parse(textPointFY.Text) };
            //chartFunction.Update();

        }



    }


}
