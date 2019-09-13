using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FashionWorld
{
    public class Algos
    {

        /*protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LUCKY\\LUCKY;Initial Catalog=FashionWorld;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select top 1 product_category_tree,image from products;", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string str = reader[0].ToString();
                string[] val = category(str);
                //Response.Write(val[0]);
                str = reader[1].ToString();
                string[] val2 = image(str);
                //Image1.ImageUrl = val2[0];
            }
            con.Close();
            cmd.Dispose();
        }*/

        public string[] category(string str)
        {
            int count = 0;
            string st1 = null;
            string[] pro = new string[10];
            char[] temp = str.ToCharArray();
            foreach (char c in temp)
            {
                if (c == '"' || c == '[' || c == ']')
                {

                }
                else
                {
                    if (c != '>')
                    {
                        st1 = st1 + c.ToString();
                    }
                    else
                    {
                        if (st1 != null)
                        {
                            pro[count] = st1;
                            count++;
                            st1 = null;
                        }
                    }
                }
            }

            return (pro);
        }
       public string[] image(string str)
        {
            int count = 0;
            string st1 = null;
            string[] pro = new string[5];
            char[] temp = str.ToCharArray();
            foreach (char c in temp)
            {
                if (c == '"' || c == '[' || c == ']')
                {

                }
                else
                {
                    if (c != ',')
                    {
                        st1 = st1 + c.ToString();
                    }
                    else
                    {
                        if (st1 != null)
                        {
                            pro[count] = st1;
                            count++;
                            if(count >= 5)
                            {
                                break;
                            }
                            st1 = null;
                        }
                    }
                }
            }
            return (pro);
        }
        public string[] specs(string str)
        {
            string st1 = null;
            int count = 0;
            string[] obj = new string[20];
            char[] temp = str.ToCharArray();
            foreach(char c in temp)
            {
                if(c == '[')
                {

                }
            }
            return (obj);
        }
    }
}