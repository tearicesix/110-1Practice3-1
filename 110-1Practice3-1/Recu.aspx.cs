using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice3_1
{
	public partial class Recu : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            int total;
            int z = 4;
            if (z % 2 != 0)
            {
                total = odd(z);
                Response.Write(total);
            }
            else
            {
                total = even(z);
                Response.Write(total);
            }
        }

        int odd(int n)
        {
            if (n == 1)
                return 11;
            else if (n == 2)
                return 11 + 4;
            else
                return odd(n - 2) + odd(n - 1);
        }
        int even(int e)
        {
            if (e == 1)
                return 11;
            else if (e == 2)
                return 18;
            else
                return even(e - 2) + even(e - 1);
        }
	}
}