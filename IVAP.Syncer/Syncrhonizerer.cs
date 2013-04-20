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

                //Start Syncing UCs
                switch (s.UC)
                {


                    case "1":
                        s.UC = "Hangu";
                        break;
                }
                //2	Thall
                //3	Lachi
                //4	Kohat
                //5	Peshawar (Town-I)
                //6	Peshawar (Town-II)
                //7	Peshawar (Town-III)
                //8	Peshawar (Town-IV)
                //9	Nowshera
                //10	Pabbi
                //1	Darband
                //2	Balyamina
                //3	Ganjiano Kali (MC)
                //4	Kahi
                //5	Kech Banda
                //6	Khan Bari
                //7	Kotki
                //8	Muhammad Khawja
                //9	Raisan
                //10	Toghserai
                //11	Dallan
                //12	Darsamand
                //13	Doaba (Tc)
                //14	Doaba (Uc)
                //15	Karbogha
                //16	Naryab-II
                //17	Naryabi-I
                //18	Thall (Rural)
                //19	Thall (Urban)
                //20	Tora Warai
                //21	Jarma
                //22	Lachi (Rural)
                //23	Lachi (Urban)
                //24	Mandoori
                //25	Shah Pur
                //26	Shakardara Rural-I
                //27	Shakardara Rural-II
                //28	Shakardara Urban
                //29	Sudal
                //30	Summari
                //31	Surgul
                //32	Ali Zai
                //33	Bahadar Kot
                //34	Bilitang
                //35	Chorlaki
                //36	Dhoda
                //37	Gumbat
                //38	Kharmatoo
                //39	Khushal Garh
                //40	Kohat Urban-I
                //41	Kohat Urban-II
                //42	Kohat Urban-III
                //43	Kohat Urban-IV
                //44	Kohat Urban-V
                //45	Kohat Urban-VI
                //46	Muhammadzai
                //47	Nusrat Khel
                //48	Sher Kot
                //49	Togh Bala-I
                //50	Togh Bala-II
                //51	Usterzai
                //52	Ziarat Sheikh Allabad
                //53	Khalsa-I
                //54	Khalsa-II
                //55	Lahori
                //56	Mahal Terai-I
                //57	Mahal Terai-II
                //58	Shaheen Muslim Town-I
                //59	Karimpura
                //60	Shaheen Muslim Town-II
                //61	Shahi Bagh
                //62	Sheikh Junaid Abad
                //63	Akhun Abad
                //64	Andher Shehar
                //65	Asia
                //66	Bana Mari
                //67	Faqir Abad
                //68	Gul Bahar
                //69	Gunj
                //70	Jehangira Pura
                //71	Kakshal-I
                //72	Kakshal-II
                //73	Sikandar Town
                //74	Wazir Bagh
                //75	Yakatoot-I
                //76	Yakatoot-II
                //77	Yakatoot-III
                //78	Shahi Bagh
                //79	Sheikh Junaid Abad
                //80	Sikandar Town
                //81	Wazir Bagh
                //82	Yakatoot-I
                //83	Yakatoot-II
                //84	Yakatoot-III
                //85	Bhudhni
                //86	Chaghar Matti
                //87	Chamkani
                //88	Dag
                //89	Ghari Sherdad
                //90	Gulbela
                //91	Hassan Ghari-I
                //92	Hassan Ghari-II
                //93	Hayana Payan
                //94	Jogani
                //95	Kafoor Dheri
                //96	Kaniza
                //97	Kankola
                //98	Khazana
                //99	Lala
                //100	Larama
                //101	Mathra
                //102	Nahqi
                //103	Pajjagi
                //104	Pakha Ghulam
                //105	Panam Dheri
                //106	Shahi Bala
                //107	Takhtabad
                //108	Wadpagga
                //109	Achini Bala
                //110	Bazid Khel
                //111	Deh Bahadar
                //112	Dheri Baghbanan
                //113	Hayatabad-I
                //114	Hayatabad-II
                //115	Landi Arbab
                //116	Malkandheri
                //117	Nothia
                //118	Nothia Jadeed
                //119	Palosi
                //120	Pawaka
                //121	Pishtakhara Payan
                //122	Regi
                //123	Sarband
                //124	Shaheen Town
                //125	Sufaid Dheri
                //126	Tehkal Bala
                //127	Tehkal Payan-I
                //128	Tehkal Payan-II
                //129	University Town
                //130	Adezai
                //131	Aza Khel
                //132	Badabare Harizai
                //133	Badabare Maryamzai
                //134	Hazar Khwani-I
                //135	Hazar Khwani-II
                //136	Maira Kachori
                //137	Maira Surizai Payan
                //138	Maryamzai
                //139	Mashoogagar
                //140	Mathani
                //141	Musazai
                //142	Sheikh Muhammadii
                //143	Sheikhan
                //144	Shirkira
                //145	Suleman Khel
                //146	Surizai Bala
                //147	Surizai Payan
                //148	Urmar Bala
                //149	Urmar Miana
                //150	Urmar Payan
                //151	Adamzai
                //152	Akora Khattak M.c
                //153	Azakhel Bala
                //154	Badrashi
                //155	Dheri Katti Khel
                //156	Gandiri
                //157	Inzari
                //158	Kahi
                //159	Khairabad
                //160	Khaishki Bala
                //161	Khaishki Payan
                //162	Pabbi
                //163	Jehangira-I
                //164	Mandori
                //165	Manki Sharif
                //166	Maira Akora Khattak
                //167	Misri Banda
                //168	Mohib Banda
                //169	Mughalki
                //170	Nizampur
                //171	Nowshera City
                //172	Nowshera Kalan
                //173	Nowshera Cantt
                //174	Pahari Kati Khel
                //175	Pir Piai
                //176	Pir Sabak
                //177	Rashakai
                //178	Risalpur
                //179	Saleh Khana
                //180	Shaidu
                //181	Aman Garh
                //182	Tarkha
                //183	Jalozai
                //184	Ziarat Kaka Sahib
                //185	Chowkai Town
                //186	Azakhel Payan
                //187	Bara Banda
                //188	Kabul River
                //189	Nawan Killi
                //190	Zara Miana
                //191	Akbar Pura
                //192	Aman Kot
                //193	Chowkai Mamraiz
                //194	Dag Behsud
                //195	Dag Ismail Khel
                //196	Shah Kot
                //197	Taru Jabba
                //198	Daggai
                //199	Dag Ismail Khel Chapri

            }

            return synced;
        }
    }
}
