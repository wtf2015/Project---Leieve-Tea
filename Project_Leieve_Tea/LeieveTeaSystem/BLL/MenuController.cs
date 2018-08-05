using LeieveTea.Data.Entities;
using LeieveTeaSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeieveTeaSystem.BLL
{
    [DataObject]
    public class MenuController
    {
        #region CRUD
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<MenuItem> MenuItems_List()
        {
            using (var context = new LeieveContext())
            {
                return context.MenuItems.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void Add_MenuItem (MenuItem item)
        {
            using (var context = new LeieveContext())
            {
                context.MenuItems.Add(item);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
