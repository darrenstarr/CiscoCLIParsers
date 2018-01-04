using System;
using CiscoCLIParsers.Model;
using CiscoCLIParsers.Parsers;
using System.Collections.Generic;

namespace CiscoCLIParsers
{
    public static class CiscoParser
    {
        public static List<ShowCDPEntryItem> ParseShowCDPEntries(string text)
        {
            try
            {
                var parser = new CiscoShowCDPEntry();
                return parser.Parse(text);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            return null;
        }
    }
}
