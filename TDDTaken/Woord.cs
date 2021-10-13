using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTaken
{
    public class Woord
    {
        public string OmTeZettenWoord { get; set; }

        public Woord(string woord)
        {
            OmTeZettenWoord = woord;
        }

        public bool IsPalindroom()
        {
            char[] karakterReeks = OmTeZettenWoord.ToCharArray();
            Array.Reverse(karakterReeks);
            string omgekeerd = new string(karakterReeks);
            return OmTeZettenWoord == omgekeerd;
        }
    }
}
