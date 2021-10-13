using System;
using System.Linq;

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
            //min oplossing is niet fout, gewoon langer :)
            //char[] karakterReeks = OmTeZettenWoord.ToCharArray();
            //Array.Reverse(karakterReeks);
            //var omgekeerd = new string(karakterReeks);
            //return OmTeZettenWoord == omgekeerd;
            return OmTeZettenWoord == new string(OmTeZettenWoord.ToCharArray().Reverse().ToArray());
        }
    }
}
