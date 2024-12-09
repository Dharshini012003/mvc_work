using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeWebApp.Models
{
    public class DropdownList
    {
        // Get Data Manager for "Gender" or any other type
        public static IEnumerable<SelectListItem> GetDataManager(string typeId)
        {
            using (TRAININGEntities1 db = new TRAININGEntities1())
            {
                var lst = db.DATA_MANAGER.Where(w => w.DM_TYPE_ID == typeId).Select(o => new SelectListItem{Value = o.DM_VALUE_ID,Text = o.DM_VALUE_DESC}).ToList();
                lst.Insert(0, new SelectListItem { Value = "", Text = "" }); 
                return lst;
            }
        }

        // Get Department List
        public static IEnumerable<SelectListItem> GetDepartment()
        {
            using (TRAININGEntities1 db = new TRAININGEntities1())
            {
                var lst = db.DEPTMNTs.AsEnumerable().Select(o => new SelectListItem{Value = o.DEPT_ID.ToString(), Text = o.DEPT_DESC}).ToList();
                lst.Insert(0, new SelectListItem { Value = "", Text = "" }); 
                return lst;
            }
        }

        // Get Designation List
        public static IEnumerable<SelectListItem> GetDesignation(int? selectedDesignationId = null)
        {
            using (TRAININGEntities1 db = new TRAININGEntities1())
            {
                var lst = db.DESIGINATIONs.AsEnumerable().Select(o => new SelectListItem{Value = o.DES_ID.ToString(),Text = o.DES_DESC, Selected = (o.DES_ID == selectedDesignationId) }).ToList();
                lst.Insert(0, new SelectListItem { Value = "", Text = "" }); 
                return lst;
            }
        }
    }
}
