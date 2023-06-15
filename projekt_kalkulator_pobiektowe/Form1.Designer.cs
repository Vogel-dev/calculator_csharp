namespace projekt_kalkulator_pobiektowe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWynik = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPrzecinek = new System.Windows.Forms.Button();
            this.btnWynik = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDodawanie = new System.Windows.Forms.Button();
            this.btnOdejmowanie = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMnozenie = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDzielenie = new System.Windows.Forms.Button();
            this.lblHistoria = new System.Windows.Forms.Label();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWynik
            // 
            this.lblWynik.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWynik.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWynik.Location = new System.Drawing.Point(11, 38);
            this.lblWynik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(321, 45);
            this.lblWynik.TabIndex = 0;
            this.lblWynik.Text = "0";
            this.lblWynik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift Condensed", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(14, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(318, 47);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.AutoSize = true;
            this.btnPlusMinus.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlusMinus.Location = new System.Drawing.Point(14, 307);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(75, 50);
            this.btnPlusMinus.TabIndex = 2;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.Font = new System.Drawing.Font("Bahnschrift Condensed", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn0.Location = new System.Drawing.Point(95, 307);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 50);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnPrzecinek
            // 
            this.btnPrzecinek.AutoSize = true;
            this.btnPrzecinek.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzecinek.Location = new System.Drawing.Point(176, 307);
            this.btnPrzecinek.Name = "btnPrzecinek";
            this.btnPrzecinek.Size = new System.Drawing.Size(75, 50);
            this.btnPrzecinek.TabIndex = 4;
            this.btnPrzecinek.Text = ",";
            this.btnPrzecinek.UseVisualStyleBackColor = true;
            this.btnPrzecinek.Click += new System.EventHandler(this.btnPrzecinek_Click);
            // 
            // btnWynik
            // 
            this.btnWynik.AutoSize = true;
            this.btnWynik.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnWynik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWynik.Font = new System.Drawing.Font("Bahnschrift Condensed", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWynik.Location = new System.Drawing.Point(14, 363);
            this.btnWynik.Name = "btnWynik";
            this.btnWynik.Size = new System.Drawing.Size(318, 50);
            this.btnWynik.TabIndex = 5;
            this.btnWynik.Text = "=";
            this.btnWynik.UseVisualStyleBackColor = false;
            this.btnWynik.Click += new System.EventHandler(this.btnWynik_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Font = new System.Drawing.Font("Bahnschrift Condensed", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn3.Location = new System.Drawing.Point(176, 251);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 50);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Font = new System.Drawing.Font("Bahnschrift Condensed", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn2.Location = new System.Drawing.Point(95, 251);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 50);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Font = new System.Drawing.Font("Bahnschrift Condensed", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn1.Location = new System.Drawing.Point(14, 251);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 50);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnDodawanie
            // 
            this.btnDodawanie.AutoSize = true;
            this.btnDodawanie.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodawanie.Location = new System.Drawing.Point(257, 307);
            this.btnDodawanie.Name = "btnDodawanie";
            this.btnDodawanie.Size = new System.Drawing.Size(75, 50);
            this.btnDodawanie.TabIndex = 9;
            this.btnDodawanie.Text = "+";
            this.btnDodawanie.UseVisualStyleBackColor = true;
            this.btnDodawanie.Click += new System.EventHandler(this.btnDodawanie_Click);
            // 
            // btnOdejmowanie
            // 
            this.btnOdejmowanie.AutoSize = true;
            this.btnOdejmowanie.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdejmowanie.Location = new System.Drawing.Point(257, 251);
            this.btnOdejmowanie.Name = "btnOdejmowanie";
            this.btnOdejmowanie.Size = new System.Drawing.Size(75, 50);
            this.btnOdejmowanie.TabIndex = 13;
            this.btnOdejmowanie.Text = "-";
            this.btnOdejmowanie.UseVisualStyleBackColor = true;
            this.btnOdejmowanie.Click += new System.EventHandler(this.btnOdejmowanie_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.Font = new System.Drawing.Font("Bahnschrift Condensed", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn6.Location = new System.Drawing.Point(176, 195);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 50);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.Font = new System.Drawing.Font("Bahnschrift Condensed", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn5.Location = new System.Drawing.Point(95, 195);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 50);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.Font = new System.Drawing.Font("Bahnschrift Condensed", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn4.Location = new System.Drawing.Point(14, 195);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 50);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btnMnozenie
            // 
            this.btnMnozenie.AutoSize = true;
            this.btnMnozenie.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMnozenie.Location = new System.Drawing.Point(257, 195);
            this.btnMnozenie.Name = "btnMnozenie";
            this.btnMnozenie.Size = new System.Drawing.Size(75, 50);
            this.btnMnozenie.TabIndex = 17;
            this.btnMnozenie.Text = "*";
            this.btnMnozenie.UseVisualStyleBackColor = true;
            this.btnMnozenie.Click += new System.EventHandler(this.btnMnozenie_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.Font = new System.Drawing.Font("Bahnschrift Condensed", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn9.Location = new System.Drawing.Point(176, 139);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 50);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.Font = new System.Drawing.Font("Bahnschrift Condensed", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn8.Location = new System.Drawing.Point(95, 139);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 50);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.Font = new System.Drawing.Font("Bahnschrift Condensed", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn7.Location = new System.Drawing.Point(14, 139);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 50);
            this.btn7.TabIndex = 14;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btnDzielenie
            // 
            this.btnDzielenie.AutoSize = true;
            this.btnDzielenie.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzielenie.Location = new System.Drawing.Point(257, 139);
            this.btnDzielenie.Name = "btnDzielenie";
            this.btnDzielenie.Size = new System.Drawing.Size(75, 50);
            this.btnDzielenie.TabIndex = 18;
            this.btnDzielenie.Text = "/";
            this.btnDzielenie.UseVisualStyleBackColor = true;
            this.btnDzielenie.Click += new System.EventHandler(this.btnDzielenie_Click);
            // 
            // lblHistoria
            // 
            this.lblHistoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHistoria.Enabled = false;
            this.lblHistoria.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHistoria.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHistoria.Location = new System.Drawing.Point(13, 0);
            this.lblHistoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistoria.Name = "lblHistoria";
            this.lblHistoria.Size = new System.Drawing.Size(321, 38);
            this.lblHistoria.TabIndex = 19;
            this.lblHistoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBackspace
            // 
            this.btnBackspace.AutoSize = true;
            this.btnBackspace.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBackspace.Location = new System.Drawing.Point(12, 12);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(6, 6);
            this.btnBackspace.TabIndex = 20;
            this.btnBackspace.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(343, 420);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.lblHistoria);
            this.Controls.Add(this.btnDzielenie);
            this.Controls.Add(this.btnMnozenie);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnOdejmowanie);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDodawanie);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnWynik);
            this.Controls.Add(this.btnPrzecinek);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblWynik);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();
            btn0.Click += btnNumber_Click;
            btn1.Click += btnNumber_Click;
            btn2.Click += btnNumber_Click;
            btn3.Click += btnNumber_Click;
            btn4.Click += btnNumber_Click;
            btn5.Click += btnNumber_Click;
            btn6.Click += btnNumber_Click;
            btn7.Click += btnNumber_Click;
            btn8.Click += btnNumber_Click;
            btn9.Click += btnNumber_Click;

        }

        #endregion

        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPrzecinek;
        private System.Windows.Forms.Button btnWynik;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDodawanie;
        private System.Windows.Forms.Button btnOdejmowanie;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMnozenie;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDzielenie;
        private System.Windows.Forms.Label lblHistoria;
        private System.Windows.Forms.Button btnBackspace;
    }
}

