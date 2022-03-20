using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
/*
 Lotniskowiec ma pokład o pojemności N samolotów oraz jeden pas startowy. Z pasa może korzystać tylko jeden samolot w danej 
 chwili. W rejsie jest M samolotów (M<=N). Gdy liczba samolotów jest mniejsza niż K (K<N), to priorytet  mają  samoloty  lądujące, 
w przeciwnym  razie  startujące.  Samolot  może  znajdować  się  w  jednym  z czterech stanów: postój, start, lot, lądowanie.
 
- każdy samolot stanowi odzielny wątek wykonujące swoje funkcjie(przemieszczenie) 
- operacje niemożliwe do wykonania zostają pominięte 
- operacje do wykonania umieszczane zostają w jednej z dwóch kolejek 
- położenie samolotu jest rozpoznawane na podstawie 4 list, każda z nich odpowiada za inny stan 
- nowe operacje mogą być planowane od momentu zadeklarowania parametrów układu przez użytkownika, aż do momentu zakończenia
    działania programu

#Problem śpiącego golibrody#

 */
namespace Lotniskowie1
{
    public partial class Form1 : Form
    {
        static SemaphoreSlim[] Semafory;
        static SemaphoreSlim ST = new SemaphoreSlim(0,1);
        static SemaphoreSlim SW = new SemaphoreSlim(0, 1);
 
        static List<Thread> Poklad = new List<Thread>();
        static List<Thread> Lot = new List<Thread>();
        static List<Thread> Start = new List<Thread>();
        static List<Thread> Ladowanie = new List<Thread>();

        static Queue<int> Startoj = new Queue<int>();
        static Queue<int> Laduj = new Queue<int>();

        static int K = -1; // współczynnik
        static int N = 0; // pojemnosc lotniskowca
        static int M = -1; // liczba samolotów  w rejsie 
        // zmienne pomocnicze
        static int X = 0; 
        static int Y = 0;
        static int Index;
        static void Printel(List<Thread> L,TextBox T)
        {
            T.Clear();
            for (int i = 0; i < L.Count; i++)
            {
                T.AppendText(L[i].Name + " ");
            }
        }

        static void Split()
        {
            Semafory = new SemaphoreSlim[M+1];

            Random rnd = new Random();   
            X = rnd.Next(1, 3);
            for (int i = 1; i <= M; i++)
            {
                Przestrzeń tws = new Przestrzeń(i, X,Semafory,ST,SW,Poklad,Lot,Start,Ladowanie);
                Thread t = new Thread(new ThreadStart(tws.Plane));
                t.IsBackground = true;
                t.Name = i.ToString();
                t.Start();
                if (X == 1)
                { Poklad.Add(t); }
                else
                { Lot.Add(t); }

                X = rnd.Next(1, 3);
            }
        }
       
        private void Tabs()
        {        
            Printel(Ladowanie, T_Ladowanie);
            Printel(Start, T_Start);
            Printel(Lot, T_Lot);
            Printel(Poklad, T_Postoj);
        }
        static void Pas()
        {
            Semafory[0] = new SemaphoreSlim(0, 1);
            while (true)
            {
                lock (Laduj)
                {
                    lock (Startoj)
                    {                    
                        if ((Poklad.Count < K && Laduj.Count != 0) || (Startoj.Count == 0 && Laduj.Count != 0)) // ma co ladowac i ma priorytet ma co ladawac a nie ma co startowac 
                        {
                            //  Pierwszy z kolejki sprawdza czy może wykonać przejście jeżeli tak to  obudź odpowiedni watek
                            int Temp = Laduj.Dequeue();

                            Index = Lot.FindIndex(x => x.Name == Temp.ToString());

                            if (Index >= 0)
                            {
                                // semafor zwolnij 
                                Semafory[Temp].Release();
                                // śpij aż wykona
                                Semafory[0].Wait();
                                // Semafory [0]
                            }
                            // zaczekaj chwilę 
                            Thread.Sleep(5);
                        }
                        else if ((Poklad.Count >= K && Startoj.Count != 0) || (Startoj.Count != 0 && Laduj.Count == 0)) // ma co startowac i ma priorytet .. ma co startowac nie ma co ladowac
                        {
                            //  Pierwszy z kolejki sprawdza czy może wykonać przejście jeżeli tak to  obudź odpowiedni watek
                            int Temp = Startoj.Dequeue();

                            Index = Poklad.FindIndex(x => x.Name == Temp.ToString());

                            if (Index >= 0)
                            {
                                // semafor zwolnij 
                                Semafory[Temp].Release();
                                // śpij aż wykona
                                Semafory[0].Wait();
                                // Semafory [0]
                                // śpij aż wykona
                            }
                        }
                    }
                }
            Thread.Sleep(50);
            }
        }


        public Form1()
        {
            InitializeComponent();        
        }

        private void Pojemnosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int.TryParse(Pojemnosc.Text, out N);
      
                textBox10.AppendText("N="+Pojemnosc.Text);
                textBox10.AppendText(Environment.NewLine);
                Samoloty.Maximum = N;
                Samoloty.Enabled = true;
                Samoloty.Focus();
                Prio.Maximum = N - 1;
            }
        }

        private void Samoloty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (M != Decimal.ToInt32(Samoloty.Value)) {
                    M = Decimal.ToInt32(Samoloty.Value);
                    textBox10.AppendText("M=" + Samoloty.Value.ToString());
                    textBox10.AppendText(Environment.NewLine);

                }

                Prio.Enabled = true;
                Prio.Focus();
              

            }
        }

        private void Ustaw_Click(object sender, EventArgs e)
        {
            textBox10.AppendText("----------------------------");
            textBox10.AppendText(Environment.NewLine);
            textBox10.AppendText("N="+ N + " M="+ M + " K="+K);
            textBox10.AppendText(Environment.NewLine);
            Pojemnosc.Enabled = false;
            Samoloty.Enabled = false;
            Prio.Enabled = false;

            Split();

            T_Ladowanie.Enabled = true;
            T_Lot.Enabled = true;
            T_Postoj.Enabled = true;
            T_Start.Enabled = true;

            Tabs();

            B_Laduj.Enabled = true;
            B_Startuj.Enabled = true;
            Operation.Enabled = true;
            Sym.Enabled = true;
            Ustaw.Enabled = false;
            B_Los.Enabled = true;
        }

        private void B_Laduj_Click(object sender, EventArgs e)
        {

            Int32.TryParse(Operation.Text, out Y);

            if (Y <= M && Y != 0)
            {
                // LOCK NA CZAS DODAWNIA
                lock (Laduj)
                {
                    lock (Startoj)
                    {
                        Laduj.Enqueue(Y);
                    }
                }
                textBox10.AppendText("nr: "+Y+ " Polecenie Lądowania");
                textBox10.AppendText(Environment.NewLine);
            }
            else
            {
                textBox10.AppendText("niepoprawny numer samolotu");
                textBox10.AppendText(Environment.NewLine);
            }
            Operation.Text = "";
            Operation.Focus();
        }

        private void B_Startuj_Click(object sender, EventArgs e)
        {
            Int32.TryParse(Operation.Text, out Y);

            if (Y <= M && Y!= 0)
            {
                lock (Laduj)
                {
                    lock (Startoj)
                    {
                        Startoj.Enqueue(Y);

                    }
                }
                textBox10.AppendText("nr: " + Y + " Polecenie Startu");
                textBox10.AppendText(Environment.NewLine);
            }
            else 
            {
                textBox10.AppendText("niepoprawny numer samolotu");
                textBox10.AppendText(Environment.NewLine);
            }
            Operation.Text = "";
            Operation.Focus();
        }

        private void Sym_Click(object sender, EventArgs e)
        {
            Thread PAS = new Thread(Pas);
            PAS.IsBackground = true;
            PAS.Start();
            Sym.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabs();      
        }

        private void Samoloty_ValueChanged(object sender, EventArgs e)
        {
            textBox10.AppendText("M=" + Samoloty.Value.ToString());
            textBox10.AppendText(Environment.NewLine);
            M = Decimal.ToInt32(Samoloty.Value);

            Prio.Maximum = N - 1;
            Prio.Enabled = true;
        }

        private void Prio_ValueChanged(object sender, EventArgs e)
        {
            K = Decimal.ToInt32(Prio.Value);
            textBox10.AppendText("K=" + Prio.Value.ToString());
            textBox10.AppendText(Environment.NewLine);
            
            Ustaw.Enabled = true;
        }

        private void Prio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (K != Decimal.ToInt32(Prio.Value))
                {
                    K = Decimal.ToInt32(Prio.Value);
                    textBox10.AppendText("K=" + Prio.Value.ToString());
                    textBox10.AppendText(Environment.NewLine);
                    Ustaw.Enabled = true;
                }           
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int t = 0;
            while(true)
            {
                t++;
                SW.Wait();
                backgroundWorker1.ReportProgress(t);
                ST.Release();
            }    
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Tabs();
            if(Ladowanie.Count !=0)
            { 
            textBox1.AppendText(Ladowanie[0].Name +" - ląduje");
            textBox1.AppendText(Environment.NewLine);
            }
            else if(Start.Count != 0)
            {
                textBox1.AppendText(Start[0].Name + " - startuje");
                textBox1.AppendText(Environment.NewLine);
            }          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int K;
            for ( int i =0;i<20;i++)
            {
                K = rnd.Next(1, 30)%2;
                if( K == 1)
                {
                    K = rnd.Next(1, M + 1);
                    lock (Laduj)
                    {
                        lock (Startoj)
                        {
           
                            Laduj.Enqueue(K);
                        }
                    }
                    textBox10.AppendText("nr: " + K + " Polecenie Lądowania");
                    textBox10.AppendText(Environment.NewLine);
                }
                else
                {
                    K = rnd.Next(1, M + 1);
                    lock (Laduj)
                    {
                        lock (Startoj)
                        {
                            Startoj.Enqueue(K);

                        }
                    }
                    textBox10.AppendText("nr: " + K + " Polecenie Startu");
                    textBox10.AppendText(Environment.NewLine);

                }
            }
           

           
        }
    }
}
