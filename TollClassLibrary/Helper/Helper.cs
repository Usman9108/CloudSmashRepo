namespace TollClassLibrary.Helper
{
    public static class Helper
    {
        public static bool isEvenNumberPlate(string numberPlate)
        {
            var parts = numberPlate.Split('-');
            return int.TryParse(parts[1], out int num) && num % 2 == 0;
        }
        public static DayOfWeek GetDayOfWeek(DateTime dateTime)
        {
            return dateTime.DayOfWeek;
        }
        
        public static int CalculateDistance( int entryPointDist, int exitPointDist)
        {
            return Math.Abs(exitPointDist - entryPointDist);
        }
    }
}
