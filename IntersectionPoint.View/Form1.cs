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
            textPointFX.TextChanged += GenerateChart;
            textPointFY.TextChanged += GenerateChart;
            textPointSX.TextChanged += GenerateChart;
            textPointSY.TextChanged += GenerateChart;

        }

        public void GenerateChart(object sender, EventArgs e)
        {
            chartFunction.Series.Clear();

            chartFunction.Series.Add(SeriesCreator.CreateLine("Line1",new Vector2(float.Parse(textPointFX.Text), float.Parse(textPointFY.Text)), 
                                                                      new Vector2(float.Parse(textPointSX.Text), float.Parse(textPointSY.Text))));
            
        }

       
    }


}
