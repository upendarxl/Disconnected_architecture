using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using Dal;

namespace BAL
{
    public class BAL1
    {

        batch c = new batch();
        DAL d = new DAL();
        public void insert(batch c)
        {
            try
            {

                d.insert(c);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void delete(batch c)
        {
            try
            {
                d.delete(c);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void update(batch c)
        {
            try
            {
                d.update(c);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        public void search(batch c)
        {
            try
            {
                d.search(c);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }



    }

    
}
