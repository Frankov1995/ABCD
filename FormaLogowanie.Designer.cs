namespace ProjektProgramowanie
{
    partial class FormLogowanie
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
            this.Button2Kierownik = new System.Windows.Forms.Button();
            this.Button1Pracownik = new System.Windows.Forms.Button();
            this.PanelLogowanie = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxHaslo = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.ButtonZamknij = new System.Windows.Forms.Button();
            this.PanelTask = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelLacznosc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelBładLogowania = new System.Windows.Forms.Label();
            this.PanelLogowanie.SuspendLayout();
            this.PanelTask.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button2Kierownik
            // 
            this.Button2Kierownik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button2Kierownik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2Kierownik.FlatAppearance.BorderSize = 0;
            this.Button2Kierownik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.Button2Kierownik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2Kierownik.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button2Kierownik.Location = new System.Drawing.Point(0, 240);
            this.Button2Kierownik.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Button2Kierownik.Name = "Button2Kierownik";
            this.Button2Kierownik.Size = new System.Drawing.Size(213, 70);
            this.Button2Kierownik.TabIndex = 1;
            this.Button2Kierownik.Text = "Kierownik";
            this.Button2Kierownik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2Kierownik.UseVisualStyleBackColor = false;
            this.Button2Kierownik.Click += new System.EventHandler(this.Button2Kierownik_Click);
            // 
            // Button1Pracownik
            // 
            this.Button1Pracownik.BackColor = System.Drawing.Color.AliceBlue;
            this.Button1Pracownik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1Pracownik.FlatAppearance.BorderSize = 0;
            this.Button1Pracownik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.Button1Pracownik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1Pracownik.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button1Pracownik.Location = new System.Drawing.Point(0, 170);
            this.Button1Pracownik.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Button1Pracownik.Name = "Button1Pracownik";
            this.Button1Pracownik.Size = new System.Drawing.Size(213, 70);
            this.Button1Pracownik.TabIndex = 0;
            this.Button1Pracownik.Text = "Pracownik";
            this.Button1Pracownik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1Pracownik.UseVisualStyleBackColor = false;
            this.Button1Pracownik.Click += new System.EventHandler(this.Button1Pracownik_Click);
            // 
            // PanelLogowanie
            // 
            this.PanelLogowanie.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelLogowanie.Controls.Add(this.label2);
            this.PanelLogowanie.Controls.Add(this.label1);
            this.PanelLogowanie.Controls.Add(this.TextBoxHaslo);
            this.PanelLogowanie.Controls.Add(this.TextBoxLogin);
            this.PanelLogowanie.Location = new System.Drawing.Point(73, 186);
            this.PanelLogowanie.Name = "PanelLogowanie";
            this.PanelLogowanie.Size = new System.Drawing.Size(300, 124);
            this.PanelLogowanie.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // TextBoxHaslo
            // 
            this.TextBoxHaslo.AcceptsTab = true;
            this.TextBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxHaslo.Location = new System.Drawing.Point(90, 70);
            this.TextBoxHaslo.MaxLength = 10;
            this.TextBoxHaslo.Name = "TextBoxHaslo";
            this.TextBoxHaslo.Size = new System.Drawing.Size(182, 27);
            this.TextBoxHaslo.TabIndex = 2;
            this.TextBoxHaslo.UseSystemPasswordChar = true;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.AcceptsTab = true;
            this.TextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxLogin.Location = new System.Drawing.Point(90, 20);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(182, 27);
            this.TextBoxLogin.TabIndex = 0;
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
            // 
            // PanelTask
            // 
            this.PanelTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelTask.Controls.Add(this.button1);
            this.PanelTask.Controls.Add(this.label3);
            this.PanelTask.Controls.Add(this.ButtonZamknij);
            this.PanelTask.Location = new System.Drawing.Point(0, 0);
            this.PanelTask.Name = "PanelTask";
            this.PanelTask.Size = new System.Drawing.Size(700, 25);
            this.PanelTask.TabIndex = 11;
            this.PanelTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTask_MouseDown);
            this.PanelTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTask_MouseMove);
            this.PanelTask.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTask_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(656, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 25);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonZamknij_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Logowanie do sytemu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelBładLogowania);
            this.panel1.Controls.Add(this.PanelLogowanie);
            this.panel1.Location = new System.Drawing.Point(216, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 575);
            this.panel1.TabIndex = 12;
            // 
            // LabelLacznosc
            // 
            this.LabelLacznosc.AutoSize = true;
            this.LabelLacznosc.Font = new System.Drawing.Font("Consolas", 10F);
            this.LabelLacznosc.Location = new System.Drawing.Point(5, 10);
            this.LabelLacznosc.Name = "LabelLacznosc";
            this.LabelLacznosc.Size = new System.Drawing.Size(208, 17);
            this.LabelLacznosc.TabIndex = 2;
            this.LabelLacznosc.Text = "Połączenie z bazą danych:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.Button1Pracownik);
            this.panel2.Controls.Add(this.Button2Kierownik);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 546);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.LabelLacznosc);
            this.panel3.Location = new System.Drawing.Point(0, 564);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 36);
            this.panel3.TabIndex = 3;
            // 
            // LabelBładLogowania
            // 
            this.LabelBładLogowania.AutoSize = true;
            this.LabelBładLogowania.BackColor = System.Drawing.Color.Transparent;
            this.LabelBładLogowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelBładLogowania.ForeColor = System.Drawing.Color.DarkOrange;
            this.LabelBładLogowania.Location = new System.Drawing.Point(91, 313);
            this.LabelBładLogowania.Name = "LabelBładLogowania";
            this.LabelBładLogowania.Size = new System.Drawing.Size(135, 20);
            this.LabelBładLogowania.TabIndex = 2;
            this.LabelBładLogowania.Text = "Zły login lub hasło";
            this.LabelBładLogowania.Visible = false;
            // 
            // FormLogowanie
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelTask);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogowanie";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.PanelLogowanie.ResumeLayout(false);
            this.PanelLogowanie.PerformLayout();
            this.PanelTask.ResumeLayout(false);
            this.PanelTask.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button2Kierownik;
        private System.Windows.Forms.Button Button1Pracownik;
        private System.Windows.Forms.Panel PanelLogowanie;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxHaslo;
        private System.Windows.Forms.Button ButtonZamknij;
        private System.Windows.Forms.Panel PanelTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelLacznosc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelBładLogowania;
    }
}

