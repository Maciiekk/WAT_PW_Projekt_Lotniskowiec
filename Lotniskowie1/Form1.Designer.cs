
namespace Lotniskowie1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Pojemnosc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ustaw = new System.Windows.Forms.Button();
            this.B_Startuj = new System.Windows.Forms.Button();
            this.B_Laduj = new System.Windows.Forms.Button();
            this.Operation = new System.Windows.Forms.TextBox();
            this.T_Start = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.T_Postoj = new System.Windows.Forms.TextBox();
            this.T_Ladowanie = new System.Windows.Forms.TextBox();
            this.T_Lot = new System.Windows.Forms.TextBox();
            this.Samoloty = new System.Windows.Forms.NumericUpDown();
            this.Prio = new System.Windows.Forms.NumericUpDown();
            this.Sym = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.B_Los = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Samoloty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pojemność lotniskowca";
            // 
            // Pojemnosc
            // 
            this.Pojemnosc.Location = new System.Drawing.Point(12, 6);
            this.Pojemnosc.Name = "Pojemnosc";
            this.Pojemnosc.Size = new System.Drawing.Size(66, 27);
            this.Pojemnosc.TabIndex = 2;
            this.Pojemnosc.Text = "0";
            this.Pojemnosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pojemnosc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liczba dostępnych samolotów\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Współczynnik priorytetu";
            // 
            // Ustaw
            // 
            this.Ustaw.Enabled = false;
            this.Ustaw.Location = new System.Drawing.Point(312, 30);
            this.Ustaw.Name = "Ustaw";
            this.Ustaw.Size = new System.Drawing.Size(94, 29);
            this.Ustaw.TabIndex = 6;
            this.Ustaw.Text = "Start";
            this.Ustaw.UseVisualStyleBackColor = true;
            this.Ustaw.Click += new System.EventHandler(this.Ustaw_Click);
            // 
            // B_Startuj
            // 
            this.B_Startuj.Enabled = false;
            this.B_Startuj.Location = new System.Drawing.Point(638, 395);
            this.B_Startuj.Name = "B_Startuj";
            this.B_Startuj.Size = new System.Drawing.Size(94, 29);
            this.B_Startuj.TabIndex = 7;
            this.B_Startuj.Text = "startuj";
            this.B_Startuj.UseVisualStyleBackColor = true;
            this.B_Startuj.Click += new System.EventHandler(this.B_Startuj_Click);
            // 
            // B_Laduj
            // 
            this.B_Laduj.Enabled = false;
            this.B_Laduj.Location = new System.Drawing.Point(538, 395);
            this.B_Laduj.Name = "B_Laduj";
            this.B_Laduj.Size = new System.Drawing.Size(94, 29);
            this.B_Laduj.TabIndex = 8;
            this.B_Laduj.Text = "ląduj";
            this.B_Laduj.UseVisualStyleBackColor = true;
            this.B_Laduj.Click += new System.EventHandler(this.B_Laduj_Click);
            // 
            // Operation
            // 
            this.Operation.Enabled = false;
            this.Operation.Location = new System.Drawing.Point(538, 362);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(194, 27);
            this.Operation.TabIndex = 9;
            // 
            // T_Start
            // 
            this.T_Start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.T_Start.Enabled = false;
            this.T_Start.Location = new System.Drawing.Point(19, 453);
            this.T_Start.Multiline = true;
            this.T_Start.Name = "T_Start";
            this.T_Start.ReadOnly = true;
            this.T_Start.Size = new System.Drawing.Size(174, 36);
            this.T_Start.TabIndex = 13;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox10.Location = new System.Drawing.Point(537, 31);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox10.Size = new System.Drawing.Size(251, 155);
            this.textBox10.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Postój";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Lądowanie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Wprowadzone parametry";
            // 
            // T_Postoj
            // 
            this.T_Postoj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.T_Postoj.Enabled = false;
            this.T_Postoj.Location = new System.Drawing.Point(19, 128);
            this.T_Postoj.Multiline = true;
            this.T_Postoj.Name = "T_Postoj";
            this.T_Postoj.ReadOnly = true;
            this.T_Postoj.Size = new System.Drawing.Size(174, 299);
            this.T_Postoj.TabIndex = 21;
            // 
            // T_Ladowanie
            // 
            this.T_Ladowanie.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.T_Ladowanie.Enabled = false;
            this.T_Ladowanie.Location = new System.Drawing.Point(287, 453);
            this.T_Ladowanie.Multiline = true;
            this.T_Ladowanie.Name = "T_Ladowanie";
            this.T_Ladowanie.ReadOnly = true;
            this.T_Ladowanie.Size = new System.Drawing.Size(174, 36);
            this.T_Ladowanie.TabIndex = 22;
            // 
            // T_Lot
            // 
            this.T_Lot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.T_Lot.Enabled = false;
            this.T_Lot.Location = new System.Drawing.Point(287, 132);
            this.T_Lot.Multiline = true;
            this.T_Lot.Name = "T_Lot";
            this.T_Lot.ReadOnly = true;
            this.T_Lot.Size = new System.Drawing.Size(174, 295);
            this.T_Lot.TabIndex = 23;
            // 
            // Samoloty
            // 
            this.Samoloty.Enabled = false;
            this.Samoloty.Location = new System.Drawing.Point(12, 39);
            this.Samoloty.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Samoloty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Samoloty.Name = "Samoloty";
            this.Samoloty.Size = new System.Drawing.Size(66, 27);
            this.Samoloty.TabIndex = 27;
            this.Samoloty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Samoloty.ValueChanged += new System.EventHandler(this.Samoloty_ValueChanged);
            this.Samoloty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Samoloty_KeyPress);
            // 
            // Prio
            // 
            this.Prio.Enabled = false;
            this.Prio.Location = new System.Drawing.Point(12, 70);
            this.Prio.Name = "Prio";
            this.Prio.Size = new System.Drawing.Size(66, 27);
            this.Prio.TabIndex = 28;
            this.Prio.ValueChanged += new System.EventHandler(this.Prio_ValueChanged);
            this.Prio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prio_KeyPress);
            // 
            // Sym
            // 
            this.Sym.Enabled = false;
            this.Sym.Location = new System.Drawing.Point(537, 430);
            this.Sym.Name = "Sym";
            this.Sym.Size = new System.Drawing.Size(251, 54);
            this.Sym.TabIndex = 29;
            this.Sym.Text = "Rozpocznij symulację";
            this.Sym.UseVisualStyleBackColor = true;
            this.Sym.Click += new System.EventHandler(this.Sym_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(537, 212);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(251, 142);
            this.textBox1.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(620, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Pas startowy ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // B_Los
            // 
            this.B_Los.Enabled = false;
            this.B_Los.Location = new System.Drawing.Point(738, 360);
            this.B_Los.Name = "B_Los";
            this.B_Los.Size = new System.Drawing.Size(63, 29);
            this.B_Los.TabIndex = 32;
            this.B_Los.Text = "Losuj";
            this.B_Los.UseVisualStyleBackColor = true;
            this.B_Los.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 501);
            this.Controls.Add(this.B_Los);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sym);
            this.Controls.Add(this.Prio);
            this.Controls.Add(this.Samoloty);
            this.Controls.Add(this.T_Lot);
            this.Controls.Add(this.T_Ladowanie);
            this.Controls.Add(this.T_Postoj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.T_Start);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.B_Laduj);
            this.Controls.Add(this.B_Startuj);
            this.Controls.Add(this.Ustaw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pojemnosc);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Projekt lotniskowiec";
            ((System.ComponentModel.ISupportInitialize)(this.Samoloty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pojemnosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ustaw;
        private System.Windows.Forms.Button B_Startuj;
        private System.Windows.Forms.Button B_Laduj;
        private System.Windows.Forms.TextBox Operation;
        private System.Windows.Forms.TextBox T_Start;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox T_Postoj;
        private System.Windows.Forms.TextBox T_Ladowanie;
        private System.Windows.Forms.TextBox T_Lot;
        private System.Windows.Forms.NumericUpDown Samoloty;
        private System.Windows.Forms.NumericUpDown Prio;
        private System.Windows.Forms.Button Sym;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button B_Los;
    }
}

