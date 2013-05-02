using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvHelper.Configuration;

namespace IVAP.Syncer
{
    public class Survey
    {

        [CsvField(Name = "start")]
        public string start { get; set; }

        [CsvField(Name = "end")]
        public string end { get; set; }

        [CsvField(Name = "today")]
        public string today { get; set; }

        [CsvField(Name = "IO1")]
        public string IO1 { get; set; }

        [CsvField(Name = "IDP:IO2")]
        public string IO2 { get; set; }

        [CsvField(Name = "IDP:IO:DistrictF")]
        public string DistrictF { get; set; }

        [CsvField(Name = "IDP:IO:TehsilF")]
        public string TehsilF { get; set; }

        [CsvField(Name = "IDP:IO:IO3b")]
        public string IO3b { get; set; }

        [CsvField(Name = "IDP:IO:IO3c")]
        public string IO3c { get; set; }

        [CsvField(Name = "IDP:IO:IO3cOther")]
        public string IO3cOther { get; set; }

        [CsvField(Name = "IDP:IO:IO4")]
        public string IO4 { get; set; }

        [CsvField(Name = "IDP:IO:GI:GI4")]
        public string GI4 { get; set; }

        [CsvField(Name = "IDP:IO:GI:GI5")]
        public string GI5 { get; set; }

        [CsvField(Name = "IDP:IO:GI:loc")]
        public string loc { get; set; }

        [CsvField(Name = "IDP:IO:GI:District")]
        public string District { get; set; }

        [CsvField(Name = "IDP:IO:GI:Tehsil")]
        public string Tehsil { get; set; }

        [CsvField(Name = "IDP:IO:GI:UC")]
        public string UC { get; set; }

        [CsvField(Name = "IDP:IO:GI:GI8")]
        public string GI8 { get; set; }

        [CsvField(Name = "IDP:IO:GI:GI9")]
        public string GI9 { get; set; }

        [CsvField(Name = "IDP:IO:GI:Fdist")]
        public string Fdist { get; set; }

        [CsvField(Name = "IDP:IO:GI:FtheK")]
        public string FtheK { get; set; }

        [CsvField(Name = "IDP:IO:GI:FtheO")]
        public string FtheO { get; set; }

        [CsvField(Name = "IDP:IO:GI:GI10")]
        public string GI10 { get; set; }

        [CsvField(Name = "IDP:IO:GI:GI13")]
        public string GI13 { get; set; }

        [CsvField(Name = "IDP:IO:GI:GI14")]
        public string GI14 { get; set; }


        [CsvField(Name = "IDP:IO:GI:GI15")]
        public string GI15 { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH1:HH1a")]
        public string HH1a { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH1:HH1b")]
        public string HH1b { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH1:HH1c")]
        public string HH1c { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH1:HH1d")]
        public string HH1d { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH2:HH2a")]
        public string HH2a { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH2:HH2b")]
        public string HH2b { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH2:HH2c")]
        public string HH2c { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH2:HH2d")]
        public string HH2d { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH2:HH2e")]
        public string HH2e { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH2:HH2f")]
        public string HH2f { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH2:HH2g")]
        public string HH2g { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH3")]
        public string HH3 { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH3a")]
        public string HH3a { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH4")]
        public string HH4 { get; set; }

        [CsvField(Name = "IDP:IO:GI:HH5")]
        public string HH5 { get; set; }

        [CsvField(Name = "IDP:IO:GI:DS1")]
        public string DS1 { get; set; }

        [CsvField(Name = "IDP:IO:GI:DS1a")]
        public string Ds1a { get; set; }

        [CsvField(Name = "IDP:IO:GI:P4")]
        public string P4 { get; set; }

        [CsvField(Name = "IDP:IO:GI:P4Other")]
        public string P4Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:DS2a")]
        public string DS2a { get; set; }

        [CsvField(Name = "IDP:IO:GI:DS2b")]
        public string Ds2b { get; set; }

        [CsvField(Name = "IDP:IO:GI:DS2c")]
        public string Ds2c { get; set; }

        [CsvField(Name = "IDP:IO:GI:DSOther")]
        public string DsOther { get; set; }

        [CsvField(Name = "IDP:IO:GI:P1")]
        public string P1 { get; set; }

        [CsvField(Name = "IDP:IO:GI:P1a")]
        public string P1a { get; set; }

        [CsvField(Name = "IDP:IO:GI:P1aOther")]
        public string P1aOther { get; set; }

        [CsvField(Name = "IDP:IO:GI:P1b")]
        public string P1b { get; set; }

        [CsvField(Name = "IDP:IO:GI:P1bOther")]
        public string P1bOther { get; set; }

        [CsvField(Name = "IDP:IO:GI:P2")]
        public string P2 { get; set; }

        [CsvField(Name = "IDP:IO:GI:P2a")]
        public string P2a { get; set; }

        [CsvField(Name = "IDP:IO:GI:P2aOther")]
        public string P2aOther { get; set; }

        [CsvField(Name = "IDP:IO:GI:P3")]
        public string P3 { get; set; }

        [CsvField(Name = "IDP:IO:GI:P3a")]
        public string P3a { get; set; }

        [CsvField(Name = "IDP:IO:GI:P8")]
        public string P8 { get; set; }

        [CsvField(Name = "IDP:IO:GI:P8a")]
        public string P8a { get; set; }

        [CsvField(Name = "IDP:IO:GI:P5")]
        public string P5 { get; set; }

        [CsvField(Name = "IDP:IO:GI:P6")]
        public string P6 { get; set; }

        [CsvField(Name = "IDP:IO:GI:P6a")]
        public string P6a { get; set; }

        [CsvField(Name = "IDP:IO:GI:P7")]
        public string P7 { get; set; }

        [CsvField(Name = "IDP:IO:GI:P7Other")]
        public string P7Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:W1")]
        public string W1 { get; set; }

        [CsvField(Name = "IDP:IO:GI:W1Other")]
        public string W1Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:W2")]
        public string W2 { get; set; }

        [CsvField(Name = "IDP:IO:GI:W2Other")]
        public string W2Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:W3")]
        public string W3 { get; set; }

        [CsvField(Name = "IDP:IO:GI:W4")]
        public string W4 { get; set; }

        [CsvField(Name = "IDP:IO:GI:W4Other")]
        public string W4Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:W5")]
        public string W5 { get; set; }

        [CsvField(Name = "IDP:IO:GI:W6")]
        public string W6 { get; set; }

        [CsvField(Name = "IDP:IO:GI:L1a")]
        public string L1a { get; set; }

        [CsvField(Name = "IDP:IO:GI:L1aOther")]
        public string L1aOther { get; set; }

        [CsvField(Name = "IDP:IO:GI:L1b")]
        public string L1b { get; set; }

        [CsvField(Name = "IDP:IO:GI:L1bOther")]
        public string L1bOther { get; set; }

        [CsvField(Name = "IDP:IO:GI:L2")]
        public string L2 { get; set; }

        [CsvField(Name = "IDP:IO:GI:L3:L3a")]
        public string L3a { get; set; }

        [CsvField(Name = "IDP:IO:GI:L3:L3b")]
        public string L3b { get; set; }

        [CsvField(Name = "IDP:IO:GI:L3:L3c")]
        public string L3c { get; set; }

        [CsvField(Name = "IDP:IO:GI:L3:L3d")]
        public string L3d { get; set; }

        [CsvField(Name = "IDP:IO:GI:L4:L4a")]
        public string L4a { get; set; }

        [CsvField(Name = "IDP:IO:GI:L4:L4b")]
        public string L4b { get; set; }

        [CsvField(Name = "IDP:IO:GI:L4:L4c")]
        public string L4c { get; set; }

        [CsvField(Name = "IDP:IO:GI:L4:L4d")]
        public string L4d { get; set; }

        [CsvField(Name = "IDP:IO:GI:L5")]
        public string L5 { get; set; }

        [CsvField(Name = "IDP:IO:GI:L6")]
        public string L6 { get; set; }

        [CsvField(Name = "IDP:IO:GI:L6Other")]
        public string L6Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:FS4_1")]
        public string FS4_1 { get; set; }

        [CsvField(Name = "IDP:IO:GI:FS4_2")]
        public string FS4_2 { get; set; }

        [CsvField(Name = "IDP:IO:GI:FS4_3")]
        public string FS4_3 { get; set; }

        [CsvField(Name = "IDP:IO:GI:FS4_4")]
        public string FS4_4 { get; set; }

        [CsvField(Name = "IDP:IO:GI:FS4_5")]
        public string FS4_5 { get; set; }

        [CsvField(Name = "IDP:IO:GI:FS4_6")]
        public string FS4_6 { get; set; }

        [CsvField(Name = "IDP:IO:GI:FS4_7")]
        public string FS4_7 { get; set; }

        [CsvField(Name = "IDP:IO:GI:FS4_8")]
        public string FS4_8 { get; set; }

        [CsvField(Name = "IDP:IO:GI:FS4_9")]
        public string FS4_9 { get; set; }

        [CsvField(Name = "IDP:IO:GI:FS4_10")]
        public string FS4_10 { get; set; }

        [CsvField(Name = "IDP:IO:GI:FS4_11")]
        public string FS4_11 { get; set; }

        [CsvField(Name = "IDP:IO:GI:F2:F2a")]
        public string F2a { get; set; }

        [CsvField(Name = "IDP:IO:GI:F2:F2b")]
        public string F2b { get; set; }

        [CsvField(Name = "IDP:IO:GI:F2:F2c")]
        public string F2c { get; set; }

        [CsvField(Name = "IDP:IO:GI:L7")]
        public string L7 { get; set; }

        [CsvField(Name = "IDP:IO:GI:L8")]
        public string L8 { get; set; }

        [CsvField(Name = "IDP:IO:GI:L9")]
        public string L9 { get; set; }

        [CsvField(Name = "IDP:IO:GI:L10:L10a")]
        public string L10a { get; set; }

        [CsvField(Name = "IDP:IO:GI:L10:L10b")]
        public string L10b { get; set; }

        [CsvField(Name = "IDP:IO:GI:L10:L10c")]
        public string L10c { get; set; }

        [CsvField(Name = "IDP:IO:GI:L10:L10d")]
        public string L10d { get; set; }

        [CsvField(Name = "IDP:IO:GI:L10:L10e")]
        public string L10e { get; set; }

        [CsvField(Name = "IDP:IO:GI:L10:L10f")]
        public string L10f { get; set; }

        [CsvField(Name = "IDP:IO:GI:L10:L10g")]
        public string L10g { get; set; }

        [CsvField(Name = "IDP:IO:GI:L11")]
        public string L11 { get; set; }

        [CsvField(Name = "IDP:IO:GI:E1")]
        public string E1 { get; set; }

        [CsvField(Name = "IDP:IO:GI:E1a:E1aBoys")]
        public string E1aBoys { get; set; }

        [CsvField(Name = "IDP:IO:GI:E1a:E1aGirls")]
        public string E1aGirls { get; set; }

        [CsvField(Name = "IDP:IO:GI:E1b:E1bBoys")]
        public string E1bBoys { get; set; }

        [CsvField(Name = "IDP:IO:GI:E1b:E1bGirls")]
        public string E1bGirls { get; set; }

        [CsvField(Name = "IDP:IO:GI:E2")]
        public string E2 { get; set; }

        [CsvField(Name = "IDP:IO:GI:E1c:E1cBoys")]
        public string E1cBoys { get; set; }

        [CsvField(Name = "IDP:IO:GI:E1c:E1dGirls")]
        public string E1dGirls { get; set; }

        [CsvField(Name = "IDP:IO:GI:E1d:E1dBoys")]
        public string E1dBoys { get; set; }

        [CsvField(Name = "IDP:IO:GI:E1d:E1eGirls")]
        public string E1eGirls { get; set; }

        [CsvField(Name = "IDP:IO:GI:E3")]
        public string E3 { get; set; }

        [CsvField(Name = "IDP:IO:GI:E3Other")]
        public string E3Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:N1")]
        public string N1 { get; set; }

        [CsvField(Name = "IDP:IO:GI:N2")]
        public string N2 { get; set; }

        [CsvField(Name = "IDP:IO:GI:N2Other")]
        public string N2Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:N3")]
        public string N3 { get; set; }

        [CsvField(Name = "IDP:IO:GI:N3Other")]
        public string N3Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:N4")]
        public string N4 {get; set;}

        [CsvField(Name = "IDP:IO:GI:N5")]
        public string N5 { get; set; }

        [CsvField(Name = "IDP:IO:GI:N5Other")]
        public string N5Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:N6")]
        public string N6 { get; set; }

        [CsvField(Name = "IDP:IO:GI:N6a")]
        public string N6a { get; set; }

        [CsvField(Name = "IDP:IO:GI:N6b")]
        public string N6b { get; set; }

        [CsvField(Name = "IDP:IO:GI:N6bother")]
        public string N6bother { get; set; }

        [CsvField(Name = "IDP:IO:GI:N7")]
        public string N7 { get; set; }

        [CsvField(Name = "IDP:IO:GI:N7Other")]
        public string N7Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:N8")]
        public string N8 { get; set; }

        [CsvField(Name = "IDP:IO:GI:S1")]
        public string S1 { get; set; }

        [CsvField(Name = "IDP:IO:GI:S1a")]
        public string S1a { get; set; }

        [CsvField(Name = "IDP:IO:GI:S2")]
        public string S2 { get; set; }

        [CsvField(Name = "IDP:IO:GI:S2Other")]
        public string S2Other { get; set; }

        [CsvField(Name = "IDP:IO:GI:Sa")]
        public string Sa { get; set; }

        [CsvField(Name = "IDP:IO:GI:SaOther")]
        public string SaOther { get; set; }

        [CsvField(Name = "IDP:IO:GI:S3")]
        public string S3 { get; set; }

        [CsvField(Name = "IDP:IO:GI:S4")]
        public string S4 { get; set; }

        [CsvField(Name = "IDP:IO:GI:S6a")]
        public string S6a { get; set; }

        [CsvField(Name = "IDP:IO:GI:S6b")]
        public string S6b { get; set; }

        [CsvField(Name = "IDP:IO:GI:S6c")]
        public string S6c { get; set; }

        [CsvField(Name = "IDP:IO:GI:S6cOther")]
        public string S6cOther { get; set; }

        [CsvField(Name = "IDP:IO:GI:S7")]
        public string S7 { get; set; }

        [CsvField(Name = "IDP:IO:GI:S8:S8a")]
        public string S8a { get; set; }

        [CsvField(Name = "IDP:IO:GI:S8:S8b")]
        public string S8b { get; set; }

        [CsvField(Name = "IDP:IO:GI:S8:S8c")]
        public string S8c { get; set; }

        [CsvField(Name = "IDP:IO:GI:S8:S8d")]
        public string S8d { get; set; }

        [CsvField(Name = "IDP:IO:GI:S8:S8e")]
        public string S8e { get; set; }

        [CsvField(Name = "IDP:IO:GI:S8:S8f")]
        public string S8g { get; set; }

        [CsvField(Name = "IDP:IO:GI:S10")]
        public string S10 { get; set; }

        [CsvField(Name = "IDP:IO:GI:S9:S9a")]
        public string S9a { get; set; }

        [CsvField(Name = "IDP:IO:GI:S9:S9b")]
        public string S9b { get; set; }

        [CsvField(Name = "IDP:IO:GI:S9:S9c")]
        public string S9c { get; set; }

        [CsvField(Name = "IDP:IO:GI:S9:S9d")]
        public string S9d { get; set; }

        [CsvField(Name = "IDP:IO:GI:S9:S9e")]
        public string S9e { get; set; }

        [CsvField(Name = "IDP:IO:GI:S11")]
        public string S11 { get; set; }

        [CsvField(Name = "IDP:IO:GI:S11Other")]
        public string S11Other { get; set; }

    }
}
