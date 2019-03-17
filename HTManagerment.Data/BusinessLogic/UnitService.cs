using System;
using System.Collections.Generic;
using System.Linq;
using HTManagerment.Data.Model;

namespace HTManagerment.Data.BusinessLogic
{
    public static class UnitService
    {
        private static readonly QuanLyCanContext Context = new QuanLyCanContext();

        public static List<UnitModel> GetUnit()
        {
            return Context.Units.ToList();
        }

        public static UnitModel GetById(int id)
        {
            return Context.Units.Find(id);
        }
        public static bool DeleteUnit(int unitId)
        {
            var item = Context.Units.Find(unitId);
            if (item == null) return false;
            Context.Units.Remove(item);
            Context.SaveChanges();
            return true;
        }

        public static bool UpdateUnit(UnitModel model)
        {
            if (model != null)
            {
                if (model.UnitId == 0)
                {
                    var item = new UnitModel
                    {
                        Value = model.Value,
                        DateCreated = DateTime.Now,
                        Version = 1
                    };
                    Context.Units.Add(item);
                    Context.SaveChanges();
                    return true;
                }
                var currentUnit = Context.Units.Find(model.UnitId);
                if (currentUnit == null) return false;
                currentUnit.Value = model.Value;
                currentUnit.DateModified = DateTime.Now;
                currentUnit.Version = ++currentUnit.Version;
                Context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
