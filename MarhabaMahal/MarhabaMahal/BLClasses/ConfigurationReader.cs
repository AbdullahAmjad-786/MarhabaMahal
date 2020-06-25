using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarhabaDatabase;

namespace MarhabaMahal.BLClasses
{
    class ConfigurationReader
    {
        public double? getGST()
        {
            MarhabaEntities  entities = new MarhabaEntities();
            var conf = entities.configurations.FirstOrDefault(c => c.id == 1);
            entities.Dispose();
            return conf.gst;
        }

        public int? getLastId()
        {
            MarhabaEntities entities = new MarhabaEntities();
            var obj = entities.configurations.FirstOrDefault(c => c.id == 1);
            return obj.last_id_synced;
        }
        public string getNTN()
        {
            MarhabaEntities entities = new MarhabaEntities();
            var obj = entities.configurations.FirstOrDefault(c => c.id == 1);
            return obj.ntn;
        }

        public string getBranchCode()
        {
            MarhabaEntities entities = new MarhabaEntities();
            var obj = entities.configurations.FirstOrDefault(c => c.id == 1);
            return obj.branchCode;
        }

        public void updateLastID(int? id)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var obj = entities.configurations.FirstOrDefault(c => c.id == 1);
            obj.last_id_synced = id;
            entities.configurations.AddOrUpdate(obj);
            entities.SaveChanges();
        }
    }
}
