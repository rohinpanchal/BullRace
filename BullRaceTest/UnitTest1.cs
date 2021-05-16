using BullRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BullRaceTest
{
    [TestClass]
    public class UnitTest1
    {
        PunterFactory objFactory = new PunterFactory();
        Punter Hartej;
        Bull[] Bulls = new Bull[2];

        [TestMethod]
        public void TestWinnerOutcome()
        {
            Bull.StartingPosition1 = 0;
            Bull.RacetrackLength1 = 50;
            int BettingAmount = 50;
            int BullNumber = 1;
            int expectedWin = 100;
            int expectedLose = 0;
            Bulls[0] = new Bull() { BullPictureBox = null };
            Bulls[1] = new Bull() { BullPictureBox = null };
            Hartej = objFactory.getPunter("Hartej", null, null);
            Hartej.money = BettingAmount;
            Hartej.PlaceBet((int)BettingAmount, BullNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < Bulls.Length; i++)
                {
                    if (Bull.Run(Bulls[i]))
                    {
                        win = i + 1;
                        Hartej.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Hartej.gamble.BullNum == win)
            {
                Assert.AreEqual(expectedWin, Hartej.money, "Account not credited correctly");
            }
            if (Hartej.gamble.BullNum != win)
            {
                Assert.AreEqual(expectedLose, Hartej.money, "Account not debited correctly");

            }
        }
    }

}
