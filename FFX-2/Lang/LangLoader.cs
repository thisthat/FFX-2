using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace FFX_2.Lang
{
    class LangLoader
    {
        Dictionary<string, string> Labels = new Dictionary<string, string>();

        public const string WndTitle = "WndTitle";
        public const string LoadBtn = "LoadBtn";
        public const string SaveBtn = "SaveBtn";
        public const string Campains = "Campains";
        public const string Guil = "Guil";
        public const string Time = "Time";
        public const string Item = "Item";
        public const string Accessories = "Accessories";
        public const string RunYuna = "RunYuna";
        public const string RunRikku = "RunRikku";
        public const string RunPaine = "RunPaine";
        public const string Percentual = "Percentual";
        public const string AllDress = "AllDress";
        public const string SelectAll = "SelectAll";
        public const string Stat = "Stat";
        public const string Gunner = "Gunner";
        public const string Thief = "Thief";
        public const string Warrior = "Warrior";
        public const string Songstress = "Songstress";
        public const string BlackMage = "BlackMage";
        public const string WhiteMage = "WhiteMage";
        public const string GunMage = "GunMage";
        public const string Alchemist = "Alchemist";
        public const string DarkKnight = "DarkKnight";
        public const string Samurai = "Samurai";
        public const string LadyLuck = "LadyLuck";
        public const string Berserker = "Berserker";
        public const string Trainer = "Trainer";
        public const string Mascot = "Mascot";
        public const string Festivalist = "Festivalist";
        public const string Psychic = "Psychic";
        public const string Freelancer = "Freelancer";
        public const string FloralFallal = "FloralFallal";
        public const string MachinaMaw = "MachinaMaw";
        public const string FullThrottle = "FullThrottle";
        //CALM LAND TAB
        public const string Point = "Point";
        public const string OpenAir = "OpenAir";
        public const string Argent = "Argent";
        public const string WifeHunt = "WifeHunt";
        public const string PointOpenAir = "PointOpenAir";
        public const string PointSilver = "PointSilver";
        public const string PointWife = "PointWife";

        public string get(string key)
        {
            if(!Labels.Keys.Contains(key)) return "";
            return Labels[key];
        }

        public LangLoader(string lang)
        {
            string path = "";
            switch (lang)
            {
                case "en-US": path = "./Lang/en-US.xml"; break;
                case "it-IT": path = "./Lang/it-IT.xml"; break;
                default: path = "./Lang/en-US.xml"; break;
            }
            XmlTextReader reader = new XmlTextReader(path);
            int i = 0;
            string k = "";
            while (reader.Read())
            {
                switch (reader.NodeType)
                {

                    case XmlNodeType.Text: //Display the text in each element.
                        if (i++ % 2 == 0)
                        {
                            k = reader.Value;
                            //Console.WriteLine("public const string " + k + " = \"" + k + "\";");
                        }
                        else
                        {
                            Labels.Add(k, reader.Value);
                        }
                        break;

                }
            }
        }
    }
}
