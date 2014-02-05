using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyValuableCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calbutton_Click(object sender, EventArgs e)
        {
            var op1 = int.Parse(op1.Text);
            var op2 = int.Parse(op2.Text);

            var sum = op1 + op2;

            mylable.Text = sum.ToString();
        }
    }
}