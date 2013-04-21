using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IVAP.Syncer
{
    public class Syncrhonizerer
    {
        public List<SyncedSurvey> SyncSurveyWithMagicalUnicorns(List<Survey> unsyncedSurvey)
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
                        s.UC = "Darband";
                        break;

                    case "2":
                        s.UC = "Balyamina";
                        break;
                    case "3":
                        s.UC = "Ganjiano Kali (MC)";
                        break;
                    case "4":
                        s.UC = "Kahi";
                        break;
                    case "5":
                        s.UC = "Kech Banda";
                        break;
                    case "6":
                        s.UC = "Khan Bari";
                        break;
                    case "7":
                        s.UC = "Kotki";
                        break;
                    case "8":
                        s.UC = "Muhammad Khawja";
                        break;
                    case "9":
                        s.UC = "Raisan";
                        break;
                    case "10":
                        s.UC = "Toghserai";
                        break;
                    case "11":
                        s.UC = "Dallan";
                        break;
                    case "12":
                        s.UC = "Darsamand";
                        break;
                    case "13":
                        s.UC = "Doaba (Tc)";
                        break;
                    case "14":
                        s.UC = "Doaba (Uc)";
                        break;
                    case "15":
                        s.UC = "Karbogha";
                        break;
                    case "16":
                        s.UC = "Naryab-II";
                        break;
                    case "17":
                        s.UC = "Naryabi-I";
                        break;
                    case "18":
                        s.UC = "Thall (Rural)";
                        break;
                    case "19":
                        s.UC = "Thall (Urban)";
                        break;
                    case "20":
                        s.UC = "Tora Warai";
                        break;
                    case "21":
                        s.UC = "Jarma";
                        break;
                    case "22":
                        s.UC = "Lachi (Rural)";
                        break;
                    case "23":
                        s.UC = "Lachi (Urban)";
                        break;
                    case "24":
                        s.UC = "Mandoori";
                        break;
                    case "25":
                        s.UC = "Shah Pur";
                        break;
                    case "26":
                        s.UC = "Shakardara Rural-I";
                        break;
                    case "27":
                        s.UC = "Shakardara Rural-II";
                        break;
                    case "28":
                        s.UC = "Shakardara Urban";
                        break;
                    case "29":
                        s.UC = "Sudal";
                        break;
                    case "30":
                        s.UC = "Summari";
                        break;
                    case "31":
                        s.UC = "Surgul";
                        break;
                    case "32":
                        s.UC = "Ali Zai";
                        break;
                    case "33":
                        s.UC = "Bahadar Kot";
                        break;
                    case "34":
                        s.UC = "Bilitang";
                        break;
                    case "35":
                        s.UC = "Chorlaki";
                        break;
                    case "36":
                        s.UC = "Dhoda";
                        break;
                    case "37":
                        s.UC = "Gumbat";
                        break;
                    case "38":
                        s.UC = "Kharmatoo";
                        break;
                    case "39":
                        s.UC = "Khushal Garh";
                        break;
                    case "40":
                        s.UC = "Kohat Urban-I";
                        break;
                    case "41":
                        s.UC = "Kohat Urban-II";
                        break;
                    case "42":
                        s.UC = "Kohat Urban-III";
                        break;
                    case "43":
                        s.UC = "Kohat Urban-IV";
                        break;
                    case "44":
                        s.UC = "Kohat Urban-V";
                        break;
                    case "45":
                        s.UC = "Kohat Urban-VI";
                        break;
                    case "46":
                        s.UC = "Muhammadzai";
                        break;
                    case "47":
                        s.UC = "Nusrat Khel";
                        break;
                    case "48":
                        s.UC = "Sher Kot";
                        break;
                    case "49":
                        s.UC = "Togh Bala-I";
                        break;
                    case "50":
                        s.UC = "Togh Bala-II";
                        break;
                    case "51":
                        s.UC = "Usterzai";
                        break;
                    case "52":
                        s.UC = "Ziarat Sheikh Allabad";
                        break;
                    case "53":
                        s.UC = "Khalsa-I";
                        break;
                    case "54":
                        s.UC = "Khalsa-II";
                        break;
                    case "55":
                        s.UC = "Lahori";
                        break;
                    case "56":
                        s.UC = "Mahal Terai-I";
                        break;
                    case "57":
                        s.UC = "Mahal Terai-II";
                        break;
                    case "58":
                        s.UC = "Shaheen Muslim Town-I";
                        break;
                    case "59":
                        s.UC = "Karimpura";
                        break;
                    case "60":
                        s.UC = "Shaheen Muslim Town-II";
                        break;
                    case "61":
                        s.UC = "Shahi Bagh";
                        break;
                    case "62":
                        s.UC = "Sheikh Junaid Abad";
                        break;
                    case "63":
                        s.UC = "Akhun Abad";
                        break;
                    case "64":
                        s.UC = "Andher Shehar";
                        break;
                    case "65":
                        s.UC = "Asia";
                        break;
                    case "66":
                        s.UC = "Bana Mari";
                        break;
                    case "67":
                        s.UC = "Faqir Abad";
                        break;
                    case "68":
                        s.UC = "Gul Bahar";
                        break;
                    case "69":
                        s.UC = "Gunj";
                        break;
                    case "70":
                        s.UC = "Jehangira Pura";
                        break;
                    case "71":
                        s.UC = "Kakshal-I";
                        break;
                    case "72":
                        s.UC = "Kakshal-II";
                        break;
                    case "73":
                        s.UC = "Sikandar Town";
                        break;
                    case "74":
                        s.UC = "Wazir Bagh";
                        break;
                    case "75":
                        s.UC = "Yakatoot-I";
                        break;
                    case "76":
                        s.UC = "Yakatoot-II";
                        break;
                    case "77":
                        s.UC = "Yakatoot-III";
                        break;
                    case "78":
                        s.UC = "Shahi Bagh";
                        break;
                    case "79":
                        s.UC = "Sheikh Junaid Abad";
                        break;
                    case "80":
                        s.UC = "Sikandar Town";
                        break;
                    case "81":
                        s.UC = "Wazir Bagh";
                        break;
                    case "82":
                        s.UC = "Yakatoot-I";
                        break;
                    case "83":
                        s.UC = "Yakatoot-II";
                        break;
                    case "84":
                        s.UC = "Yakatoot-III";
                        break;
                    case "85":
                        s.UC = "Bhudhni";
                        break;
                    case "86":
                        s.UC = "Chaghar Matti";
                        break;
                    case "87":
                        s.UC = "Chamkani";
                        break;
                    case "88":
                        s.UC = "Dag";
                        break;
                    case "89":
                        s.UC = "Ghari Sherdad";
                        break;
                    case "90":
                        s.UC = "Gulbela";
                        break;
                    case "91":
                        s.UC = "Hassan Ghari-I";
                        break;
                    case "92":
                        s.UC = "Hassan Ghari-II";
                        break;
                    case "93":
                        s.UC = "Hayana Payan";
                        break;
                    case "94":
                        s.UC = "Jogani";
                        break;
                    case "95":
                        s.UC = "Kafoor Dheri";
                        break;
                    case "96":
                        s.UC = "Kaniza";
                        break;
                    case "97":
                        s.UC = "Kankola";
                        break;
                    case "98":
                        s.UC = "Khazana";
                        break;
                    case "99":
                        s.UC = "Lala";
                        break;
                    case "100":
                        s.UC = "Larama";
                        break;
                    case "101":
                        s.UC = "Mathra";
                        break;
                    case "102":
                        s.UC = "Nahqi";
                        break;
                    case "103":
                        s.UC = "Pajjagi";
                        break;
                    case "104":
                        s.UC = "Pakha Ghulam";
                        break;
                    case "105":
                        s.UC = "Panam Dheri";
                        break;
                    case "106":
                        s.UC = "Shahi Bala";
                        break;
                    case "107":
                        s.UC = "Takhtabad";
                        break;
                    case "108":
                        s.UC = "Wadpagga";
                        break;
                    case "109":
                        s.UC = "Achini Bala";
                        break;
                    case "110":
                        s.UC = "Bazid Khel";
                        break;
                    case "111":
                        s.UC = "Deh Bahadar";
                        break;
                    case "112":
                        s.UC = "Dheri Baghbanan";
                        break;
                    case "113":
                        s.UC = "Hayatabad-I";
                        break;
                    case "114":
                        s.UC = "Hayatabad-II";
                        break;
                    case "115":
                        s.UC = "Landi Arbab";
                        break;
                    case "116":
                        s.UC = "Malkandheri";
                        break;
                    case "117":
                        s.UC = "Nothia";
                        break;
                    case "118":
                        s.UC = "Nothia Jadeed";
                        break;
                    case "119":
                        s.UC = "Palosi";
                        break;
                    case "120":
                        s.UC = "Pawaka";
                        break;
                    case "121":
                        s.UC = "Pishtakhara Payan";
                        break;
                    case "122":
                        s.UC = "Regi";
                        break;
                    case "123":
                        s.UC = "Sarband";
                        break;
                    case "124":
                        s.UC = "Shaheen Town";
                        break;
                    case "125":
                        s.UC = "Sufaid Dheri";
                        break;
                    case "126":
                        s.UC = "Tehkal Bala";
                        break;
                    case "127":
                        s.UC = "Tehkal Payan-I";
                        break;
                    case "128":
                        s.UC = "Tehkal Payan-II";
                        break;
                    case "129":
                        s.UC = "University Town";
                        break;
                    case "130":
                        s.UC = "Adezai";
                        break;
                    case "131":
                        s.UC = "Aza Khel";
                        break;
                    case "132":
                        s.UC = "Badabare Harizai";
                        break;
                    case "133":
                        s.UC = "Badabare Maryamzai";
                        break;
                    case "134":
                        s.UC = "Hazar Khwani-I";
                        break;
                    case "135":
                        s.UC = "Hazar Khwani-II";
                        break;
                    case "136":
                        s.UC = "Maira Kachori";
                        break;
                    case "137":
                        s.UC = "Maira Surizai Payan";
                        break;
                    case "138":
                        s.UC = "Maryamzai";
                        break;
                    case "139":
                        s.UC = "Mashoogagar";
                        break;
                    case "140":
                        s.UC = "Mathani";
                        break;
                    case "141":
                        s.UC = "Musazai";
                        break;
                    case "142":
                        s.UC = "Sheikh Muhammadii";
                        break;
                    case "143":
                        s.UC = "Sheikhan";
                        break;
                    case "144":
                        s.UC = "Shirkira";
                        break;
                    case "145":
                        s.UC = "Suleman Khel";
                        break;
                    case "146":
                        s.UC = "Surizai Bala";
                        break;
                    case "147":
                        s.UC = "Surizai Payan";
                        break;
                    case "148":
                        s.UC = "Urmar Bala";
                        break;
                    case "149":
                        s.UC = "Urmar Miana";
                        break;
                    case "150":
                        s.UC = "Urmar Payan";
                        break;
                    case "151":
                        s.UC = "Adamzai";
                        break;
                    case "152":
                        s.UC = "Akora Khattak M.c";
                        break;
                    case "153":
                        s.UC = "Azakhel Bala";
                        break;
                    case "154":
                        s.UC = "Badrashi";
                        break;
                    case "155":
                        s.UC = "Dheri Katti Khel";
                        break;
                    case "156":
                        s.UC = "Gandiri";
                        break;
                    case "157":
                        s.UC = "Inzari";
                        break;
                    case "158":
                        s.UC = "Kahi";
                        break;
                    case "159":
                        s.UC = "Khairabad";
                        break;
                    case "160":
                        s.UC = "Khaishki Bala";
                        break;
                    case "161":
                        s.UC = "Khaishki Payan";
                        break;
                    case "162":
                        s.UC = "Pabbi";
                        break;
                    case "163":
                        s.UC = "Jehangira-I";
                        break;
                    case "164":
                        s.UC = "Mandori";
                        break;
                    case "165":
                        s.UC = "Manki Sharif";
                        break;
                    case "166":
                        s.UC = "Maira Akora Khattak";
                        break;
                    case "167":
                        s.UC = "Misri Banda";
                        break;
                    case "168":
                        s.UC = "Mohib Banda";
                        break;
                    case "169":
                        s.UC = "Mughalki";
                        break;
                    case "170":
                        s.UC = "Nizampur";
                        break;
                    case "171":
                        s.UC = "Nowshera City";
                        break;
                    case "172":
                        s.UC = "Nowshera Kalan";
                        break;
                    case "173":
                        s.UC = "Nowshera Cantt";
                        break;
                    case "174":
                        s.UC = "Pahari Kati Khel";
                        break;
                    case "175":
                        s.UC = "Pir Piai";
                        break;
                    case "176":
                        s.UC = "Pir Sabak";
                        break;
                    case "177":
                        s.UC = "Rashakai";
                        break;
                    case "178":
                        s.UC = "Risalpur";
                        break;
                    case "179":
                        s.UC = "Saleh Khana";
                        break;
                    case "180":
                        s.UC = "Shaidu";
                        break;
                    case "181":
                        s.UC = "Aman Garh";
                        break;
                    case "182":
                        s.UC = "Tarkha";
                        break;
                    case "183":
                        s.UC = "Jalozai";
                        break;
                    case "184":
                        s.UC = "Ziarat Kaka Sahib";
                        break;
                    case "185":
                        s.UC = "Chowkai Town";
                        break;
                    case "186":
                        s.UC = "Azakhel Payan";
                        break;
                    case "187":
                        s.UC = "Bara Banda";
                        break;
                    case "188":
                        s.UC = "Kabul River";
                        break;
                    case "189":
                        s.UC = "Nawan Killi";
                        break;
                    case "190":
                        s.UC = "Zara Miana";
                        break;
                    case "191":
                        s.UC = "Akbar Pura";
                        break;
                    case "192":
                        s.UC = "Aman Kot";
                        break;
                    case "193":
                        s.UC = "Chowkai Mamraiz";
                        break;
                    case "194":
                        s.UC = "Dag Behsud";
                        break;
                    case "195":
                        s.UC = "Dag Ismail Khel";
                        break;
                    case "196":
                        s.UC = "Shah Kot";
                        break;
                    case "197":
                        s.UC = "Taru Jabba";
                        break;
                    case "198":
                        s.UC = "Daggai";
                        break;
                    case "199":
                        s.UC = "Dag Ismail Khel Chapri";
                        break;
                    default:
                        s.UC = "null";
                        break;
                }
                switch (s.DS1)
                {
                    case "a":
                        s.DS1 = "Stay here in this UC";
                        break;
                    case "b":
                        s.DS1 = "Move to another UC";
                        break;
                    default:
                        s.DS1 = "null";
                        break;
                }

                //sync logic for P4
                if (s.P4.Contains("a"))
                {
                    s.P4a = "Feeling of being safe";
                }
                if (s.P4.Contains("b"))
                {
                    s.P4b = "Affordable rent";
                }
                if (s.P4.Contains("c"))
                {
                    s.P4c = "Availability of jobs";
                }
                if (s.P4.Contains("d"))
                {
                    s.P4d = "Access to assistance";
                }
                if (s.P4.Contains("e"))
                {
                    s.P4e = "Access to basic services";
                }
                if (s.P4.Contains("f"))
                {
                    s.P4f = "Others";
                }

                //Sync P1a
                if (s.P1a.Contains("a"))
                {
                    s.P1a1 = "Food";
                }
                if (s.P1a.Contains("b"))
                {
                    s.P1a2 = "Cash Assistance";
                }
                if (s.P1a.Contains("c"))
                {
                    s.P1a3 = "Shelter Assistance";
                }
                if (s.P1a.Contains("d"))
                {
                    s.P1a4 = "Non Food Items";
                }
                if (s.P1a.Contains("e"))
                {
                    s.P1a5 = "Other";
                }

                //Sync P1b
                if (s.P1b.Contains("a"))
                {
                    s.P1b1 = "Civil Authorities";
                }
                if (s.P1b.Contains("b"))
                {
                    s.P1b2 = "Military";
                }
                if (s.P1b.Contains("c"))
                {
                    s.P1b3 = "NGOs";
                }
                if (s.P1b.Contains("d"))
                {
                    s.P1b4 = "UN";
                }
                if (s.P1b.Contains("e"))
                {
                    s.P1b5 = "Other";
                }

                //SyncP2a
                if (s.P2a.Contains("a"))
                {
                    s.P2a1 = "Theft and Robbery";
                }
                if (s.P2a.Contains("b"))
                {
                    s.P2a2 = "Killing";
                }
                if (s.P2a.Contains("c"))
                {
                    s.P2a3 = "Injury/Physical Assault";
                }
                if (s.P2a.Contains("d"))
                {
                    s.P2a4 = "Threat/harassment by host communities";
                }
                if (s.P2a.Contains("e"))
                {
                    s.P2a5 = "Threat/harrassment by authorities";
                }
                if (s.P2a.Contains("f"))
                {
                    s.P2a6 = "Threat/harrassment by armed groups";
                }
                if (s.P2a.Contains("g"))
                {
                    s.P2a7 = "Violence against boys/girls";
                }
                if (s.P2a.Contains("h"))
                {
                    s.P2a8 = "Gender based violence";
                }
                if (s.P2a.Contains("i"))
                {
                    s.P2a9 = "Kidnapping and abductions";
                }
                if (s.P2a.Contains("j"))
                {
                    s.P2a10 = "Other";
                }

                //Sync P5
                if (s.P5.Contains("a"))
                {
                    s.P5a = "Children";
                }
                if (s.P5.Contains("b"))
                {
                    s.P5b = "Women";
                }
                if (s.P5.Contains("c"))
                {
                    s.P5c = "Men";
                }
                if (s.P5.Contains("d"))
                {
                    s.P5d = "Elderly";
                }
                if (s.P5.Contains("e"))
                {
                    s.P5e = "Disabled";
                }
                if (s.P5.Contains("a"))
                {
                    s.P5f = "None";
                }

                //Sync P7
                if (s.P7.Contains("a"))
                {
                    s.P7a = "Mobility aids";
                }
                if (s.P7.Contains("b"))
                {
                    s.P7b = "Hearing aids";
                }
                if (s.P7.Contains("c"))
                {
                    s.P7c = "Visual aids";
                }
                if (s.P7.Contains("d"))
                {
                    s.P7d = "Medical services";
                }
                if (s.P7.Contains("e"))
                {
                    s.P7e = "Others";
                }
                if (s.P7.Contains("f"))
                {
                    s.P7f = "None";
                }
                //Sync W1
                if (s.W1.Contains("a"))
                {
                    s.W1a = "Surface Water";
                }
                if (s.W1.Contains("b"))
                {
                    s.W1b = "Protected well/spring";
                }
                if (s.W1.Contains("c"))
                {
                    s.W1c = "Unprotected well/spring";
                }
                if (s.W1.Contains("d"))
                {
                    s.W1d = "Unprotected handpumps";
                }
                if (s.W1.Contains("e"))
                {
                    s.W1e = "Protected handpumps";
                }
                if (s.W1.Contains("f"))
                {
                    s.W1f = "Piped water supply";
                }
                if (s.W1.Contains("g"))
                {
                    s.W1g = "Tanker";
                }
                if (s.W1.Contains("h"))
                {
                    s.W1h = "Other";
                }
                if (s.W1.Contains("i"))
                {
                    s.W1i = "Don’t know";
                }

                //Sync W2
                if (s.W2.Contains("a"))
                {
                    s.W2a = "Chlorination";
                }
                if (s.W2.Contains("b"))
                {
                    s.W2b = "Boiling";
                }
                if (s.W2.Contains("c"))
                {
                    s.W2c = "Filter and Stand";
                }
                if (s.W2.Contains("d"))
                {
                    s.W2d = "Solar";
                }
                if (s.W2.Contains("e"))
                {
                    s.W2e = "Other";
                }
                if (s.W2.Contains("f"))
                {
                    s.W2f = "None";
                }

                //Sync W3
                if (s.W3.Contains("a"))
                {
                    s.W3a = "Open vessel";
                }
                if (s.W3.Contains("b"))
                {
                    s.W3b = "closed vessel";
                }
                if (s.W3.Contains("c"))
                {
                    s.W3c = "Jerry can";
                }
                if (s.W3.Contains("d"))
                {
                    s.W3d = "Ceramic pot";
                }
                if (s.W3.Contains("e"))
                {
                    s.W3e = "Dirty vessel";
                }


                //Sync L5
                if (s.L5.Contains("a"))
                {
                    s.L5a = "Feeds";
                }
                if (s.L5.Contains("b"))
                {
                    s.L5b = "Medication";
                }
                if (s.L5.Contains("c"))
                {
                    s.L5c = "Shelter";
                }
                if (s.L5.Contains("d"))
                {
                    s.L5a = "Milking kits";
                }
                if (s.L5.Contains("e"))
                {
                    s.L5a = "None";
                }


                //Sync L6
                if (s.L6.Contains("a"))
                {

                }
                if (s.L6.Contains("a"))
                {

                }
                if (s.L6.Contains("a"))
                {
                    s.L6a = "Borrow food, or rely on help from friends";
                }
                if (s.L6.Contains("b"))
                {
                    s.L6b = "Eat less preferred or cheaper food";
                }
                if (s.L6.Contains("c"))
                {
                    s.L6c = "Purchase food on debts";
                }
                if (s.L6.Contains("d"))
                {
                    s.L6d = "Limit portion size at meals";
                }
                if (s.L6.Contains("e"))
                {
                    s.L6e = "Selling  household items/ jewelleries";
                }
                if (s.L6.Contains("f"))
                {
                    s.L6f = "Decrease expenses on health care";
                }
                if (s.L6.Contains("g"))
                {
                    s.L6g = "Skipped entire day's meal";
                }
                if (s.L6.Contains("h"))
                {
                    s.L6h = "Women ate less food than men";
                }
                if (s.L6.Contains("i"))
                {
                    s.L6i = "Adults eat less in order to provide food for children";
                }
                if (s.L6.Contains("j"))
                {
                    s.L6j = "Send children to work";
                }
                if (s.L6.Contains("k"))
                {
                    s.L6k = "Sent family members to work abroad";
                }
                if (s.L6.Contains("l"))
                {
                    s.L6l = "Selling livestock";
                }
                if (s.L6.Contains("m"))
                {
                    s.L6m = "Other";
                }
                if (s.L6.Contains("n"))
                {
                    s.L6n = "None of these";
                }


                //Sync E3
                if (s.E3.Contains("a"))
                {
                    s.E3a = "Unavailability of schools";
                }
                if (s.E3.Contains("b"))
                {
                    s.E3b = "Not able to sit in exams";
                }
                if (s.E3.Contains("c"))
                {
                    s.E3c = "Lack of documentation";
                }
                if (s.E3.Contains("d"))
                {
                    s.E3d = "Lack of uniform/books";
                }
                if (s.E3.Contains("e"))
                {
                    s.E3e = "Lack of fees";
                }
                if (s.E3.Contains("f"))
                {
                    s.E3f = "Cultural constraints";
                }
                if (s.E3.Contains("g"))
                {
                    s.E3g = "Other";
                }

                //Sync N1
                switch (s.N1)
                {
                    case "a":
                        s.N1 = "More women breast-feeding";
                        break;
                    case "b":
                        s.N1 = "Less women breast feeding";
                        break;
                    case "c":
                        s.N1 = "No change, the same number are breast-feeding";
                        break;
                    case "d":
                        s.N1 = "Dont know";
                        break;



                }
                synced.Add(s);
            }
            return synced;
        }
    }
}
