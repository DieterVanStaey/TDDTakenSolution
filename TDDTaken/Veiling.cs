namespace TDDTaken
{
    public class Veiling
    {
        private decimal hoogsteBod;
        public void DoeBod(decimal bedrag)
        {
            if (bedrag >= HoogsteBod)
                hoogsteBod = bedrag;
        }

        public decimal HoogsteBod
        {
            get
            {
                return hoogsteBod;
            }
        }
    }
}
