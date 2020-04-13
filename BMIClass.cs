using System;
using System.Windows.Forms;

namespace BMICalculator
{
    public class BMIClass
    {
        public Single height, weight;

        //Methods
        public String Calculate(string h, string w)
        {
            if (!float.TryParse(h, out _) || !float.TryParse(w, out _))
            {
                MessageBox.Show("Please enter an appropriate value");
            }
            else
            {
                height = Convert.ToSingle(h);
                weight = Convert.ToSingle(w);

                var squareOfHeight = height * height;
                var result = (float)Math.Round(weight / squareOfHeight, 2);

                return result.ToString();
            }
            return null;
        }
    }
}
