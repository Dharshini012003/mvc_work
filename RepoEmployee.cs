using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeWebApp.Models;

namespace EmployeWebApp.Repository
{
    public class RepoEmployee
    {
        TRAININGEntities1 db = new TRAININGEntities1();

        public List<EMPLOYEE> GetList()
        {
            List<EMPLOYEE> empList = db.EMPLOYEEs.ToList();
            return empList;
        }

        public EMPLOYEE GetEmpDetails(int id)
        {
            EMPLOYEE employee = new EMPLOYEE();
            if (id == 0)
            {
                employee = new EMPLOYEE();
            }
            else
            {
                employee = db.EMPLOYEEs.SingleOrDefault(e => e.EMP_ID == id);
            }
            return employee;
        }
    }
}
