using System;

namespace IsItChristmasAlready.Core
{
    public class ChristmasService
    {
        public bool IsItChristmasToday(DateTime checkDateTime)
        {
            return checkDateTime.Day == 25 && checkDateTime.Month == 12;
        }
    }
}
