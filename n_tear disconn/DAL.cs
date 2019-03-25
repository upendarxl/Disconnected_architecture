using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BEL;



namespace Dal
{
    public class DAL

    {
        DataRow dr;
        DataColumn dc;
        SqlDataAdapter da;

        DataSet data = new DataSet();
        void update()
        {
            SqlCommandBuilder sb = new SqlCommandBuilder(da);
            da.Update(data);
        }
        void fill_dataset()
        {
            SqlConnection con = new SqlConnection("data source=DESKTOP-GQADM33;initial catalog=adotest;integrated security=true");
            da = new SqlDataAdapter("Select * from adotest", con);
            da.Fill(data);
        }
        public void insert(batch Batch)
        {
            try
            {
                fill_dataset();
                dr = data.Tables[0].NewRow();
                dr["First_name"] = Batch.First_name;
                dr["Last_name"] = Batch.Last_name;
                dr["Email"] = Batch.Email;
                dr["Phone"] = Batch.Phone;

                data.Tables[0].Rows.Add(dr);
                update();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void delete(batch Batch)
        {
            try
            {
                fill_dataset();
                foreach (DataRow dr in data.Tables[0].Rows)
                {
                    if (Convert.ToInt16(dr["Address_ID"]) == Batch.Address_ID)
                    {
                        dr.Delete();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            update();

        }
        public void update(batch course)
        {
            try
            {
                fill_dataset();
                foreach (DataRow dr in data.Tables[0].Rows)
                {
                    if (Convert.ToInt16(dr["Address_ID"]) == course.Address_ID)
                    {
                        dr["First_name"] = course.First_name;
                        dr["Last_name"] = course.Last_name;
                        
                    }
                }
                update();
            }
            catch (Exception e)
            {
                throw (e);
            }

        }

        public void search(batch course)
        {
            fill_dataset();
            try
            {
                foreach (DataRow dr in data.Tables[0].Rows)
                {
                    if (Convert.ToInt16(dr["Address_ID"]) == course.Address_ID)
                    {
                        course.First_name = Convert.ToString(dr["course_name"]);
                        course.Last_name = Convert.ToString(dr["Last_name"]);
                        course.Email = Convert.ToString(dr["Email"]);
                    }
                }
                update();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }





    }
}
