namespace shifr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hackedWordsCaeser = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.keyCaeser = new System.Windows.Forms.TextBox();
            this.hackCaeser = new System.Windows.Forms.Button();
            this.buttonEncrypteCaeser = new System.Windows.Forms.Button();
            this.encCaesar = new System.Windows.Forms.TextBox();
            this.NeedEncrCaesar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hackWordsVisinere = new System.Windows.Forms.ListBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.hackVisineretxt = new System.Windows.Forms.TextBox();
            this.hackVisinere = new System.Windows.Forms.Button();
            this.deEncVisinere = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.deEncryptedVisinere = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.VisinereFinishKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.keyVisinere = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.encVisinere = new System.Windows.Forms.TextBox();
            this.needEncryptVisinere = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.hackedWordsCaeser);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.keyCaeser);
            this.panel1.Controls.Add(this.hackCaeser);
            this.panel1.Controls.Add(this.buttonEncrypteCaeser);
            this.panel1.Controls.Add(this.encCaesar);
            this.panel1.Controls.Add(this.NeedEncrCaesar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 615);
            this.panel1.TabIndex = 0;
            // 
            // hackedWordsCaeser
            // 
            this.hackedWordsCaeser.FormattingEnabled = true;
            this.hackedWordsCaeser.ItemHeight = 15;
            this.hackedWordsCaeser.Location = new System.Drawing.Point(201, 175);
            this.hackedWordsCaeser.Name = "hackedWordsCaeser";
            this.hackedWordsCaeser.Size = new System.Drawing.Size(155, 214);
            this.hackedWordsCaeser.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ключ";
            // 
            // keyCaeser
            // 
            this.keyCaeser.Location = new System.Drawing.Point(201, 87);
            this.keyCaeser.Name = "keyCaeser";
            this.keyCaeser.Size = new System.Drawing.Size(135, 23);
            this.keyCaeser.TabIndex = 9;
            // 
            // hackCaeser
            // 
            this.hackCaeser.Location = new System.Drawing.Point(13, 322);
            this.hackCaeser.Name = "hackCaeser";
            this.hackCaeser.Size = new System.Drawing.Size(99, 23);
            this.hackCaeser.TabIndex = 8;
            this.hackCaeser.Text = "Взлом";
            this.hackCaeser.UseVisualStyleBackColor = true;
            this.hackCaeser.Click += new System.EventHandler(this.hackCaeser_Click);
            // 
            // buttonEncrypteCaeser
            // 
            this.buttonEncrypteCaeser.Location = new System.Drawing.Point(13, 221);
            this.buttonEncrypteCaeser.Name = "buttonEncrypteCaeser";
            this.buttonEncrypteCaeser.Size = new System.Drawing.Size(99, 23);
            this.buttonEncrypteCaeser.TabIndex = 7;
            this.buttonEncrypteCaeser.Text = "Зашифровать";
            this.buttonEncrypteCaeser.UseVisualStyleBackColor = true;
            this.buttonEncrypteCaeser.Click += new System.EventHandler(this.button1_Click);
            // 
            // encCaesar
            // 
            this.encCaesar.Location = new System.Drawing.Point(13, 162);
            this.encCaesar.Name = "encCaesar";
            this.encCaesar.Size = new System.Drawing.Size(135, 23);
            this.encCaesar.TabIndex = 5;
            // 
            // NeedEncrCaesar
            // 
            this.NeedEncrCaesar.Location = new System.Drawing.Point(13, 87);
            this.NeedEncrCaesar.Name = "NeedEncrCaesar";
            this.NeedEncrCaesar.Size = new System.Drawing.Size(135, 23);
            this.NeedEncrCaesar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Расшифрованный текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Зашифрованный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(127, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шифр Цезаря";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.hackWordsVisinere);
            this.panel2.Controls.Add(this.dataGrid);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.hackVisineretxt);
            this.panel2.Controls.Add(this.hackVisinere);
            this.panel2.Controls.Add(this.deEncVisinere);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.deEncryptedVisinere);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.VisinereFinishKey);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.keyVisinere);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.encVisinere);
            this.panel2.Controls.Add(this.needEncryptVisinere);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(381, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 615);
            this.panel2.TabIndex = 1;
            // 
            // hackWordsVisinere
            // 
            this.hackWordsVisinere.FormattingEnabled = true;
            this.hackWordsVisinere.ItemHeight = 15;
            this.hackWordsVisinere.Location = new System.Drawing.Point(165, 373);
            this.hackWordsVisinere.Name = "hackWordsVisinere";
            this.hackWordsVisinere.Size = new System.Drawing.Size(187, 229);
            this.hackWordsVisinere.TabIndex = 20;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(25, 373);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(130, 229);
            this.dataGrid.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Длинна ключа";
            // 
            // hackVisineretxt
            // 
            this.hackVisineretxt.Location = new System.Drawing.Point(165, 326);
            this.hackVisineretxt.Name = "hackVisineretxt";
            this.hackVisineretxt.Size = new System.Drawing.Size(135, 23);
            this.hackVisineretxt.TabIndex = 17;
            // 
            // hackVisinere
            // 
            this.hackVisinere.Location = new System.Drawing.Point(28, 323);
            this.hackVisinere.Name = "hackVisinere";
            this.hackVisinere.Size = new System.Drawing.Size(96, 26);
            this.hackVisinere.TabIndex = 16;
            this.hackVisinere.Text = "Взлом";
            this.hackVisinere.UseVisualStyleBackColor = true;
            this.hackVisinere.Click += new System.EventHandler(this.hackVisinere_Click);
            // 
            // deEncVisinere
            // 
            this.deEncVisinere.Location = new System.Drawing.Point(25, 269);
            this.deEncVisinere.Name = "deEncVisinere";
            this.deEncVisinere.Size = new System.Drawing.Size(99, 23);
            this.deEncVisinere.TabIndex = 12;
            this.deEncVisinere.Text = "Расшифровать";
            this.deEncVisinere.UseVisualStyleBackColor = true;
            this.deEncVisinere.Click += new System.EventHandler(this.deEncVisinere_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Расшифрованный текст";
            // 
            // deEncryptedVisinere
            // 
            this.deEncryptedVisinere.Location = new System.Drawing.Point(200, 247);
            this.deEncryptedVisinere.Name = "deEncryptedVisinere";
            this.deEncryptedVisinere.Size = new System.Drawing.Size(130, 23);
            this.deEncryptedVisinere.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ключ";
            // 
            // VisinereFinishKey
            // 
            this.VisinereFinishKey.Location = new System.Drawing.Point(200, 162);
            this.VisinereFinishKey.Name = "VisinereFinishKey";
            this.VisinereFinishKey.Size = new System.Drawing.Size(135, 23);
            this.VisinereFinishKey.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ключ слово";
            // 
            // keyVisinere
            // 
            this.keyVisinere.Location = new System.Drawing.Point(200, 87);
            this.keyVisinere.Name = "keyVisinere";
            this.keyVisinere.Size = new System.Drawing.Size(135, 23);
            this.keyVisinere.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Зашифровать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // encVisinere
            // 
            this.encVisinere.Location = new System.Drawing.Point(25, 162);
            this.encVisinere.Name = "encVisinere";
            this.encVisinere.Size = new System.Drawing.Size(130, 23);
            this.encVisinere.TabIndex = 8;
            // 
            // needEncryptVisinere
            // 
            this.needEncryptVisinere.Location = new System.Drawing.Point(25, 87);
            this.needEncryptVisinere.Name = "needEncryptVisinere";
            this.needEncryptVisinere.Size = new System.Drawing.Size(130, 23);
            this.needEncryptVisinere.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Зашифрованный текст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Текст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Шифр Виженера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 642);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Шифры ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button hackCaeser;
        private Button buttonEncrypteCaeser;
        private TextBox encCaesar;
        private TextBox NeedEncrCaesar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private TextBox encVisinere;
        private TextBox needEncryptVisinere;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox keyCaeser;
        private Label label9;
        private Label label10;
        private TextBox keyVisinere;
        private Label label11;
        private TextBox VisinereFinishKey;
        private ListBox hackedWordsCaeser;
        private Button deEncVisinere;
        private Label label8;
        private TextBox deEncryptedVisinere;
        private Label label12;
        private TextBox hackVisineretxt;
        private Button hackVisinere;
        private DataGridView dataGrid;
        private ListBox hackWordsVisinere;
    }
}