using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BEL;


namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        batch c = new batch();
        BAL1 b = new BAL1();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                c.First_name = TextBox2.Text;
                c.Last_name = (TextBox3.Text);
                c.Email = TextBox4.Text;
                c.Phone = Convert.ToChar(TextBox5.Text);
                b.insert(c);
            }
            catch (Exception E)
            {

            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                c.First_name = TextBox2.Text;
                c.Last_name = TextBox3.Text;
                
                b.update(c);
            }
            catch (Exception E)

            {
                Response.Write(E.Message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                //BusinessLayer d = new BusinessLayer();
                c.Address_ID = Convert.ToInt16(TextBox1.Text);
                b.delete(c);
            }
            catch (Exception E)
            {
                Response.Write(E.Message);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
               
                c.Address_ID = Convert.ToInt16(TextBox1.Text);
                b.search(c);
                c.First_name = TextBox2.Text;
                c.Last_name = TextBox3.Text;
                c.Email = TextBox4.Text;
                c.Phone= Convert.ToChar(TextBox5.Text);
            }
            catch (Exception E)
            {
                Response.Write(E.Message);
            }
        }

    }
}
}

       
    

