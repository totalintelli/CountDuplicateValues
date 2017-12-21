using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDuplicateValues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            double[] numbers = { 1, 1, 1, 2, 3, 3, 4, 4, 5 };



            List<double> sameNumbers = numbers.ToList().FindAll(SameNumber);
        }

        public static bool SameNumber(double value1, double Value2)
        {
            if (value1 == Value2 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
