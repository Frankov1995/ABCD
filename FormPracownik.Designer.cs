namespace ProjektProgramowanie
{
    partial class FormPracownik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalaPanel = new System.Windows.Forms.Panel();
            this.LabelEkran = new System.Windows.Forms.Label();
            this.ButtonRezerwacja = new System.Windows.Forms.Button();
            this.Zakup = new System.Windows.Forms.Button();
            this.LabelZalogowany = new System.Windows.Forms.Label();
            this.PanelWybor = new System.Windows.Forms.Panel();
            this.Label_Informacja = new System.Windows.Forms.Label();
            this.LabelNapisWyborFilmu = new System.Windows.Forms.Label();
            this.Label_IleWybranychMiejsc = new System.Windows.Forms.Label();
            this.PanelTask = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonZamknij = new System.Windows.Forms.Button();
            this.Button_OK_Token = new System.Windows.Forms.Button();
            this.TexBoxToken = new System.Windows.Forms.TextBox();
            this.SalaPanel.SuspendLayout();
            this.PanelTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalaPanel
            // 
            this.SalaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.SalaPanel.Controls.Add(this.LabelEkran);
            this.SalaPanel.Location = new System.Drawing.Point(35, 73);
            this.SalaPanel.Name = "SalaPanel";
            this.SalaPanel.Size = new System.Drawing.Size(850, 356);
            this.SalaPanel.TabIndex = 0;
            // 
            // LabelEkran
            // 
            this.LabelEkran.AutoSize = true;
            this.LabelEkran.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LabelEkran.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEkran.Location = new System.Drawing.Point(162, 0);
            this.LabelEkran.MinimumSize = new System.Drawing.Size(500, 0);
            this.LabelEkran.Name = "LabelEkran";
            this.LabelEkran.Size = new System.Drawing.Size(500, 21);
            this.LabelEkran.TabIndex = 0;
            this.LabelEkran.Text = "Ekran";
            this.LabelEkran.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonRezerwacja
            // 
            this.ButtonRezerwacja.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonRezerwacja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRezerwacja.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRezerwacja.Location = new System.Drawing.Point(171, 484);
            this.ButtonRezerwacja.Name = "ButtonRezerwacja";
            this.ButtonRezerwacja.Size = new System.Drawing.Size(130, 100);
            this.ButtonRezerwacja.TabIndex = 1;
            this.ButtonRezerwacja.Text = "Rezerwacja";
            this.ButtonRezerwacja.UseVisualStyleBackColor = false;
            this.ButtonRezerwacja.Click += new System.EventHandler(this.ButtonRezerwacja_Click);
            // 
            // Zakup
            // 
            this.Zakup.BackColor = System.Drawing.Color.DarkOrange;
            this.Zakup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zakup.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zakup.Location = new System.Drawing.Point(35, 484);
            this.Zakup.Name = "Zakup";
            this.Zakup.Size = new System.Drawing.Size(130, 101);
            this.Zakup.TabIndex = 3;
            this.Zakup.Text = "Zakup";
            this.Zakup.UseVisualStyleBackColor = false;
            this.Zakup.Click += new System.EventHandler(this.Zakup_Click);
            // 
            // LabelZalogowany
            // 
            this.LabelZalogowany.AutoSize = true;
            this.LabelZalogowany.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelZalogowany.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LabelZalogowany.Location = new System.Drawing.Point(12, 588);
            this.LabelZalogowany.Name = "LabelZalogowany";
            this.LabelZalogowany.Size = new System.Drawing.Size(110, 18);
            this.LabelZalogowany.TabIndex = 5;
            this.LabelZalogowany.Text = "Zalogowany : ";
            // 
            // PanelWybor
            // 
            this.PanelWybor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PanelWybor.AutoScroll = true;
            this.PanelWybor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.PanelWybor.Location = new System.Drawing.Point(922, 73);
            this.PanelWybor.Name = "PanelWybor";
            this.PanelWybor.Size = new System.Drawing.Size(320, 467);
            this.PanelWybor.TabIndex = 6;
            // 
            // Label_Informacja
            // 
            this.Label_Informacja.AutoSize = true;
            this.Label_Informacja.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Informacja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.Label_Informacja.Location = new System.Drawing.Point(31, 38);
            this.Label_Informacja.Name = "Label_Informacja";
            this.Label_Informacja.Size = new System.Drawing.Size(60, 23);
            this.Label_Informacja.TabIndex = 7;
            this.Label_Informacja.Text = "Tytuł";
            // 
            // LabelNapisWyborFilmu
            // 
            this.LabelNapisWyborFilmu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(120)))), ((int)(((byte)(168)))));
            this.LabelNapisWyborFilmu.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNapisWyborFilmu.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNapisWyborFilmu.Location = new System.Drawing.Point(941, 53);
            this.LabelNapisWyborFilmu.Name = "LabelNapisWyborFilmu";
            this.LabelNapisWyborFilmu.Size = new System.Drawing.Size(262, 31);
            this.LabelNapisWyborFilmu.TabIndex = 8;
            this.LabelNapisWyborFilmu.Text = "Wybór filmu";
            this.LabelNapisWyborFilmu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_IleWybranychMiejsc
            // 
            this.Label_IleWybranychMiejsc.AutoSize = true;
            this.Label_IleWybranychMiejsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label_IleWybranychMiejsc.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_IleWybranychMiejsc.ForeColor = System.Drawing.Color.Black;
            this.Label_IleWybranychMiejsc.Location = new System.Drawing.Point(35, 432);
            this.Label_IleWybranychMiejsc.MinimumSize = new System.Drawing.Size(850, 50);
            this.Label_IleWybranychMiejsc.Name = "Label_IleWybranychMiejsc";
            this.Label_IleWybranychMiejsc.Size = new System.Drawing.Size(850, 50);
            this.Label_IleWybranychMiejsc.TabIndex = 9;
            this.Label_IleWybranychMiejsc.Text = "Wybrano miejsce:";
            this.Label_IleWybranychMiejsc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTask
            // 
            this.PanelTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelTask.Controls.Add(this.label2);
            this.PanelTask.Controls.Add(this.ButtonZamknij);
            this.PanelTask.Location = new System.Drawing.Point(0, 0);
            this.PanelTask.Name = "PanelTask";
            this.PanelTask.Size = new System.Drawing.Size(1272, 25);
            this.PanelTask.TabIndex = 10;
            this.PanelTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTask_MouseDown);
            this.PanelTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTask_MouseMove);
            this.PanelTask.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTask_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rezerwacja i zakup biletów";
            // 
            // ButtonZamknij
            // 
            this.ButtonZamknij.BackColor = System.Drawing.Color.OrangeRed;
            this.ButtonZamknij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonZamknij.FlatAppearance.BorderSize = 0;
            this.ButtonZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZamknij.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonZamknij.ForeColor = System.Drawing.Color.White;
            this.ButtonZamknij.Location = new System.Drawing.Point(1225, 0);
            this.ButtonZamknij.Name = "ButtonZamknij";
            this.ButtonZamknij.Size = new System.Drawing.Size(44, 25);
            this.ButtonZamknij.TabIndex = 0;
            this.ButtonZamknij.TabStop = false;
            this.ButtonZamknij.Text = "X";
            this.ButtonZamknij.UseMnemonic = false;
            this.ButtonZamknij.UseVisualStyleBackColor = false;
            this.ButtonZamknij.Click += new System.EventHandler(this.ButtonZamknij_Click);
            // 
            // Button_OK_Token
            // 
            this.Button_OK_Token.BackColor = System.Drawing.Color.OliveDrab;
            this.Button_OK_Token.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_OK_Token.Location = new System.Drawing.Point(520, 546);
            this.Button_OK_Token.Name = "Button_OK_Token";
            this.Button_OK_Token.Size = new System.Drawing.Size(160, 23);
            this.Button_OK_Token.TabIndex = 12;
            this.Button_OK_Token.Text = "Akcpetuj";
            this.Button_OK_Token.UseVisualStyleBackColor = false;
            this.Button_OK_Token.Click += new System.EventHandler(this.button1_Click);
            // 
            // TexBoxToken
            // 
            this.TexBoxToken.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TexBoxToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TexBoxToken.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TexBoxToken.Location = new System.Drawing.Point(452, 504);
            this.TexBoxToken.Name = "TexBoxToken";
            this.TexBoxToken.Size = new System.Drawing.Size(304, 36);
            this.TexBoxToken.TabIndex = 13;
            // 
            // FormPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1268, 615);
            this.ControlBox = false;
            this.Controls.Add(this.TexBoxToken);
            this.Controls.Add(this.Button_OK_Token);
            this.Controls.Add(this.LabelNapisWyborFilmu);
            this.Controls.Add(this.PanelTask);
            this.Controls.Add(this.Label_IleWybranychMiejsc);
            this.Controls.Add(this.Label_Informacja);
            this.Controls.Add(this.PanelWybor);
            this.Controls.Add(this.LabelZalogowany);
            this.Controls.Add(this.Zakup);
            this.Controls.Add(this.ButtonRezerwacja);
            this.Controls.Add(this.SalaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPracownik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.SalaPanel.ResumeLayout(false);
            this.SalaPanel.PerformLayout();
            this.PanelTask.ResumeLayout(false);
            this.PanelTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SalaPanel;
        private System.Windows.Forms.Label LabelEkran;
        private System.Windows.Forms.Button ButtonRezerwacja;
        private System.Windows.Forms.Button Zakup;
        private System.Windows.Forms.Label LabelZalogowany;
        private System.Windows.Forms.Panel PanelWybor;
        private System.Windows.Forms.Label Label_Informacja;
        private System.Windows.Forms.Label LabelNapisWyborFilmu;
        private System.Windows.Forms.Label Label_IleWybranychMiejsc;
        private System.Windows.Forms.Panel PanelTask;
        private System.Windows.Forms.Button ButtonZamknij;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_OK_Token;
        private System.Windows.Forms.TextBox TexBoxToken;
    }
}