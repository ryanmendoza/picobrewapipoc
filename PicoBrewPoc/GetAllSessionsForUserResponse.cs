using System;
using System.Collections.Generic;
using System.Text;

namespace PicoBrewPoc
{
    public class GetAllSessionsForUserResponse
    {
        public int ID { get; set; }
        public int ProfileID { get; set; }
        public string MachineType { get; set; }
        public string BrewType { get; set; }
        public object Firmware { get; set; }
        public int WortTemp { get; set; }
        public int BlockTemp { get; set; }
        public double TargetABV { get; set; }
        public int ABVTweak { get; set; }
        public double TargetIBU { get; set; }
        public int IBUTweak { get; set; }
        public double SRM { get; set; }
        public double OG { get; set; }
        public double FG { get; set; }
        public string StepName { get; set; }
        public string BeerName { get; set; }
        public string BrewerName { get; set; }
        public string BeerStyle { get; set; }
        public string GUID { get; set; }
        public string BeerGUID { get; set; }
        public string RecipeGUID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double CompletePercent { get; set; }
        public DateTime LastLogDate { get; set; }
        public int SecondsRemaining { get; set; }
        public object Review { get; set; }
        public bool Active { get; set; }
        public List<object> BrewLogs { get; set; }
        public object BrewNotes { get; set; }
        public int RecipeID { get; set; }
        public bool IsFreeStyle { get; set; }
        public string PicoPakRFID { get; set; }
        public string BannerImgSrc { get; set; }
        public string ImageLocation { get; set; }
    }
}
