namespace TollClassLibrary.Helper
{
    public static class StringConstants
    {
        /// <summary>
        /// //Rates
        /// </summary>
        public const string BaseRate = "BaseRate";
        public const string DistanceRate = "DistanceRate";
        public const string WeekendRate = "WeekEndDate";
        public const string NationHolidayDiscountRate = "NationHolidayDiscountRate";
        public const string NumberPlateDiscountRate = "NumberPlateDiscountRate";

        /////////Point Names
        public const string ZeroPoint = "Zero Point";
        public const string NSInterchange = "NS Interchange";
        public const string Ph4Interchange = "Ph4 Interchange";
        public const string FerozpurInterchange = "Ferozpur Interchange";
        public const string LakeCityInterchange = "Lake City Interchange";
        public const string RaiwandInterchange = "Raiwand Interchange";
        public const string BahriaInterchange = "Bahria Interchange";

        ///////URLs
        public const string GetInterchangeUrl = "/EntryPoint/GetEntryPoints";
        public const string TollEntryUrl = "/Toll/EnterToll";
        public const string TollExitUrl = "/Toll/ExitToll";

        //////API Header
        public const string APIKEY = "APIKEY";
    }
}
