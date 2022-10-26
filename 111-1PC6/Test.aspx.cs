using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC6
{
    public partial class Test : System.Web.UI.Page
    {
        string[] s_school = new string[3] { "台科", "北科", "亞東" };
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i_ct = 0; i_ct < s_school.Length; i_ct++)
            {
                ListItem L_I = new ListItem();
                L_I.Text = s_school[i_ct];
                L_I.Value = s_school[i_ct];

                dd1_Test.Items.Add(L_I);

            }
            
        }
    }
}