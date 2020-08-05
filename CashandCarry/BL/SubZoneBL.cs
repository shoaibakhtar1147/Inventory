using CashandCarry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashandCarry.BL
{
    class SubZoneBL
    {
        public int SubRouteId {get;set;}
        public string SubRouteName{get;set;}
        public int ZoneID { get; set; }
        public string ZoneName { get; set; }

        public void Save()
        {
            using(var context=new CashCarryEntities3())
            {
                Tbl_SubZone obj = new Tbl_SubZone() 
                {
                SubRouteName=SubRouteName,
                ZoneID=ZoneID
                };
                context.Tbl_SubZone.Add(obj);
                context.SaveChanges();
            }
        }

        public List<View_SubZone> Select()
        {
            using(var context=new CashCarryEntities3())
            {
                return context.View_SubZone.ToList();
            }
        }

        public List<View_SubZone> SearchByZone()
        {
            using (var context = new CashCarryEntities3())
            {
                return context.View_SubZone.Where(a => a.ZoneID == ZoneID).ToList();
            }
        }
        
        public List<View_SubZone> SearchByName()
        {
            using(var context=new CashCarryEntities3())
            {
                return context.View_SubZone.Where(a => a.SubRouteName.Contains(SubRouteName.ToLower())).ToList();
            }
        }
    }
}
