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
            foreach (Survey us in unsyncedSurvey)
            {
                //Lets map the objest first so we dont have to fill every value by hand. This operation is supported by magical unicorns riding rainbows in the sunset.
                SyncedSurvey s = new SyncedSurvey();
                s = AutoMapper.Mapper.Map<SyncedSurvey>(us);

                //Begin Biohazard Syncing Operation
                //Syncing TehsilF
                switch (s.TehsilF)
                {
                    case "1":
                        s.TehsilF = "Upper Kurram";
                        break;
                    case "2":
                        s.TehsilF = "Central Kurram";
                        break;
                    case "3":
                        s.TehsilF = "Lower Kurram";
                        break;
                    case "4":
                        s.TehsilF = "Central Orakzai";
                        break;
                    case "5":
                        s.TehsilF = "Ismailzai";
                        break;
                    case "6":
                        s.TehsilF = "Lower Orakzai";
                        break;
                    case "7":
                        us.TehsilF = "Upper Orakzai";
                        break;
                    case "8":
                        s.TehsilF = "Bara";
                        break;
                    case "9":
                        s.TehsilF = "Jamrud";
                        break;
                    case "10":
                        s.TehsilF = "Landi Kotal";
                        break;
                    default:
                        s.TehsilF = "null";
                        break;
                }

                //Sync District
                switch (s.District)
                {
                    case "H":
                        s.District = "Hangu";
                        break;
                    case "Ko":
                        s.District = "Kohat";
                        break;
                    case "N":
                        s.District = "Nowshera";
                        break;
                    case "P":
                        s.District = "Peshawar";
                        break;
                    default:
                        s.District = "null";
                        break;
                }

                //Sync Tehsil
                switch (s.Tehsil)
                {
                    case "1":
                        s.Tehsil = "Hangu";
                        break;
                    case "2":
                        s.Tehsil = "Thall";
                        break;
                    case "3":
                        s.Tehsil = "Lachi";
                        break;
                    case "4":
                        s.Tehsil = "Kohat";
                        break;
                    case "5":
                        s.Tehsil = "Peshawar (Town-I)";
                        break;
                    case "6":
                        s.Tehsil = "Peshawar (Town-II)";
                        break;
                    case "7":
                        s.Tehsil = "Peshawar (Town-III)";
                        break;
                    case "8":
                        s.Tehsil = "Peshawar (Town-IV)";
                        break;
                    case "9":
                        s.Tehsil = "Nowshera";
                        break;
                    case "10":
                        s.Tehsil = "Pabbi";
                        break;
                    default:
                        s.Tehsil = "null";
                        break;
                }
            }

            return synced;
        }
    }
}
