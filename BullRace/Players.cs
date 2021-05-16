using System.Windows.Forms;

namespace BullRace
{
    public class Hartej : Punter
    {
        public Hartej(Bet MyBet, Label MaximumBet, int Money, Label MyLabel) : base(MyBet, MaximumBet, Money, MyLabel)
        {
        }

        public override void setPunterName()
        {
            Title = "Hartej";
        }
    }

    public class Sachin : Punter
    {
        public Sachin(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
        {
        }

        public override void setPunterName()
        {
            Title = "Sachin";
        }
    }

    public class Kumar : Punter
    {
        public Kumar(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
        {
        }

        public override void setPunterName()
        {
            Title = "Kumar";
        }
    }
}
