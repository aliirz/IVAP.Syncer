using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IVAP.Syncer
{
    public class Syncrhonizerer
    {
        public List<SyncedSurvey> syncedSurvey(List<Survey> unsyncedSurvey)
        {
            List<SyncedSurvey> synced = new List<SyncedSurvey>();
            foreach (Survey s in unsyncedSurvey)
            {
                //First update the DistrictF
            }

            return synced;
        }
    }
}
