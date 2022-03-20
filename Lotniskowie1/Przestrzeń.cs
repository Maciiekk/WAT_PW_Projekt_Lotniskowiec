using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Lotniskowie1
{
    internal class Przestrzeń
    {

        private SemaphoreSlim[] Semafory;
        private SemaphoreSlim ST ;
        private SemaphoreSlim SW;

        private List<Thread> Poklad;
        private List<Thread> Lot ;
        private List<Thread> Start;
        private List<Thread> Ladowanie;

        public int nr;
        private int stan;
        public void Plane()
        {
            int nr1 = nr;
            int stan1 = stan;

            Semafory[nr1] = new SemaphoreSlim(0, 1);
            while (true)
            {
                Semafory[nr1].Wait();

                int temp;
                if (this.stan == 1) // poklad -> lot
                {
                    temp = Poklad.FindIndex(x => x.Name == nr1.ToString());

                    Start.Add(Poklad[temp]);
                    Poklad.RemoveAt(temp);

                    SW.Release();
                    ST.Wait();
                    Thread.Sleep(1000);
                    //Wykonaj przejście   B->C
                    temp = Start.FindIndex(x => x.Name == nr1.ToString());
                    Lot.Add(Start[temp]);
                    Start.RemoveAt(temp);
                    this.stan = 2;
                }
                else if (this.stan == 2)// lot -> poklad
                {
                    //  lot - ladowanie - poklad 
                    temp = Lot.FindIndex(x => x.Name == nr1.ToString());
                    Ladowanie.Add(Lot[temp]);
                    Lot.RemoveAt(temp);

                    //Wyświetl sytuację 
                    SW.Release();
                    ST.Wait();
                    // zaczekaj chwilę  
                    Thread.Sleep(1000);

                    //Wykonaj przejście   B->C
                    temp = Ladowanie.FindIndex(x => x.Name == nr1.ToString());
                    Poklad.Add(Ladowanie[temp]);
                    Ladowanie.RemoveAt(temp);
                    this.stan = 1;
                }
                SW.Release();
                ST.Wait();
                // obudź pas
                Semafory[0].Release();
            }

        }
        public Przestrzeń(int nr, int stan, SemaphoreSlim[] Semafory, SemaphoreSlim ST, SemaphoreSlim SW, List<Thread> Poklad, List<Thread> Lot, List<Thread> Start, List<Thread> Ladowanie)
        {
            this.nr = nr;
            this.stan = stan;
            this.Semafory = Semafory;
            this.ST = ST;
            this.SW = SW;
            this.Poklad = Poklad;
            this.Lot = Lot;
            this.Start = Start;
            this.Ladowanie = Ladowanie;

        }  // kreator
    }
}
