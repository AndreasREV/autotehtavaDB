namespace Autokauppa.view
{
    partial class MainMenu
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
            this.Hintabox = new System.Windows.Forms.TextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Merkkibox = new System.Windows.Forms.ComboBox();
            this.Motorbox = new System.Windows.Forms.TextBox();
            this.Lukemabox = new System.Windows.Forms.TextBox();
            this.nextbtn = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Mallibox = new System.Windows.Forms.ComboBox();
            this.Fuelbox = new System.Windows.Forms.ComboBox();
            this.prvbtn = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaYhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hintabox
            // 
            this.Hintabox.Location = new System.Drawing.Point(12, 355);
            this.Hintabox.Name = "Hintabox";
            this.Hintabox.Size = new System.Drawing.Size(100, 20);
            this.Hintabox.TabIndex = 1;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(469, 433);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(466, 23);
            this.Deletebtn.TabIndex = 4;
            this.Deletebtn.Text = "Poista auto";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hinta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // Merkkibox
            // 
            this.Merkkibox.FormattingEnabled = true;
            this.Merkkibox.Location = new System.Drawing.Point(330, 356);
            this.Merkkibox.Name = "Merkkibox";
            this.Merkkibox.Size = new System.Drawing.Size(121, 21);
            this.Merkkibox.TabIndex = 8;
            this.Merkkibox.SelectedIndexChanged += new System.EventHandler(this.LisaaMallit);
            // 
            // Motorbox
            // 
            this.Motorbox.Location = new System.Drawing.Point(118, 356);
            this.Motorbox.Name = "Motorbox";
            this.Motorbox.Size = new System.Drawing.Size(100, 20);
            this.Motorbox.TabIndex = 10;
            // 
            // Lukemabox
            // 
            this.Lukemabox.Location = new System.Drawing.Point(224, 357);
            this.Lukemabox.Name = "Lukemabox";
            this.Lukemabox.Size = new System.Drawing.Size(100, 20);
            this.Lukemabox.TabIndex = 11;
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(469, 462);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(466, 23);
            this.nextbtn.TabIndex = 16;
            this.nextbtn.Text = "Seuraava";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(201, 77);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(278, 20);
            this.textBox9.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Moottorin Tilavuus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mittarilukema";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Autonmerkki";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Malli";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(708, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Polttoaine";
            // 
            // Mallibox
            // 
            this.Mallibox.FormattingEnabled = true;
            this.Mallibox.Location = new System.Drawing.Point(457, 356);
            this.Mallibox.Name = "Mallibox";
            this.Mallibox.Size = new System.Drawing.Size(121, 21);
            this.Mallibox.TabIndex = 24;
            // 
            // Fuelbox
            // 
            this.Fuelbox.FormattingEnabled = true;
            this.Fuelbox.Location = new System.Drawing.Point(711, 356);
            this.Fuelbox.Name = "Fuelbox";
            this.Fuelbox.Size = new System.Drawing.Size(121, 21);
            this.Fuelbox.TabIndex = 25;
            // 
            // prvbtn
            // 
            this.prvbtn.Location = new System.Drawing.Point(12, 462);
            this.prvbtn.Name = "prvbtn";
            this.prvbtn.Size = new System.Drawing.Size(430, 23);
            this.prvbtn.TabIndex = 26;
            this.prvbtn.Text = "Edellinen";
            this.prvbtn.UseVisualStyleBackColor = true;
            this.prvbtn.Click += new System.EventHandler(this.prvbtn_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(12, 433);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(430, 23);
            this.Savebutton.TabIndex = 27;
            this.Savebutton.Text = "Tallena";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaYhteyttäToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // testaaYhteyttäToolStripMenuItem
            // 
            this.testaaYhteyttäToolStripMenuItem.Name = "testaaYhteyttäToolStripMenuItem";
            this.testaaYhteyttäToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testaaYhteyttäToolStripMenuItem.Text = "Testaa yhteyttä";
            this.testaaYhteyttäToolStripMenuItem.Click += new System.EventHandler(this.testaaYhteyttäToolStripMenuItem_Click);
            // 
            // colorbox
            // 
            this.colorbox.FormattingEnabled = true;
            this.colorbox.Location = new System.Drawing.Point(584, 356);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(121, 21);
            this.colorbox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Väri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(923, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Tyhjää kentät";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 605);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.prvbtn);
            this.Controls.Add(this.Fuelbox);
            this.Controls.Add(this.Mallibox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.Lukemabox);
            this.Controls.Add(this.Motorbox);
            this.Controls.Add(this.Merkkibox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Hintabox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Hintabox;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox Merkkibox;
        private System.Windows.Forms.TextBox Motorbox;
        private System.Windows.Forms.TextBox Lukemabox;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Mallibox;
        private System.Windows.Forms.ComboBox Fuelbox;
        private System.Windows.Forms.Button prvbtn;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaYhteyttäToolStripMenuItem;
        private System.Windows.Forms.ComboBox colorbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}