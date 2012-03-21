using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModalConfirmationDialog.Managers
{
    public static class ColorManager
    {
        public static List<SelectListItem> GetColorList()
        {
            List<SelectListItem> resultList = new List<SelectListItem>();

            resultList.Add(new SelectListItem { Text = "Red", Value = "1" });
            resultList.Add(new SelectListItem { Text = "Green", Value = "2" });
            resultList.Add(new SelectListItem { Text = "Blue", Value = "3" });

            resultList.Insert(0, new SelectListItem { Text = "Please choose ..", Value = "0" });

            return resultList;
        }
    }
}