namespace Zadaca1
{
    partial class StudentForma
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Profil");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Aktivni");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Položeni");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Svi");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Predmeti", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Meni", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.upisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ispisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.polozeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listaktivni = new System.Windows.Forms.ListBox();
            this.nazadPoloz = new System.Windows.Forms.Button();
            this.pocpolozeni = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.nazadppolozeni = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listaupis = new System.Windows.Forms.ListBox();
            this.grupaupis = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dobrodosli = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.profil = new System.Windows.Forms.GroupBox();
            this.polozeni = new System.Windows.Forms.Label();
            this.aktivni = new System.Windows.Forms.Label();
            this.nazadprofil = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mb = new System.Windows.Forms.Label();
            this.datr = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.Label();
            this.listapolozeni = new System.Windows.Forms.ListBox();
            this.nazadSvi = new System.Windows.Forms.Button();
            this.grupaPolozeni = new System.Windows.Forms.GroupBox();
            this.grupaSvi = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.grupaAktivni = new System.Windows.Forms.GroupBox();
            this.ispisiAkt = new System.Windows.Forms.Button();
            this.nazadAkt = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusObavijest = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pocpolozeni.SuspendLayout();
            this.grupaupis.SuspendLayout();
            this.profil.SuspendLayout();
            this.grupaPolozeni.SuspendLayout();
            this.grupaSvi.SuspendLayout();
            this.grupaAktivni.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(392, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // upisToolStripMenuItem
            // 
            this.upisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upisToolStripMenuItem1,
            this.ispisToolStripMenuItem1,
            this.polozeniToolStripMenuItem});
            this.upisToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upisToolStripMenuItem.Name = "upisToolStripMenuItem";
            this.upisToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.upisToolStripMenuItem.Text = "Predmeti";
            // 
            // upisToolStripMenuItem1
            // 
            this.upisToolStripMenuItem1.Name = "upisToolStripMenuItem1";
            this.upisToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.upisToolStripMenuItem1.Text = "Upis";
            this.upisToolStripMenuItem1.Click += new System.EventHandler(this.upisToolStripMenuItem1_Click);
            // 
            // ispisToolStripMenuItem1
            // 
            this.ispisToolStripMenuItem1.Name = "ispisToolStripMenuItem1";
            this.ispisToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.ispisToolStripMenuItem1.Text = "Ispis";
            this.ispisToolStripMenuItem1.Click += new System.EventHandler(this.ispisToolStripMenuItem1_Click);
            // 
            // polozeniToolStripMenuItem
            // 
            this.polozeniToolStripMenuItem.Name = "polozeniToolStripMenuItem";
            this.polozeniToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.polozeniToolStripMenuItem.Text = "Polozeni";
            this.polozeniToolStripMenuItem.Click += new System.EventHandler(this.polozeniToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Menu;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.HideSelection = false;
            this.treeView1.LineColor = System.Drawing.Color.DimGray;
            this.treeView1.Location = new System.Drawing.Point(6, 56);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Profil";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Aktivni";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Položeni";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Svi";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Predmeti";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Meni";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(140, 160);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(168, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obavještenja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nema novih obavještenja!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "text";
            this.label3.Visible = false;
            // 
            // listaktivni
            // 
            this.listaktivni.BackColor = System.Drawing.SystemColors.Menu;
            this.listaktivni.FormattingEnabled = true;
            this.listaktivni.ItemHeight = 14;
            this.listaktivni.Location = new System.Drawing.Point(17, 28);
            this.listaktivni.Name = "listaktivni";
            this.listaktivni.Size = new System.Drawing.Size(152, 158);
            this.listaktivni.TabIndex = 0;
            this.listaktivni.Visible = false;
            // 
            // nazadPoloz
            // 
            this.nazadPoloz.Location = new System.Drawing.Point(202, 159);
            this.nazadPoloz.Name = "nazadPoloz";
            this.nazadPoloz.Size = new System.Drawing.Size(94, 23);
            this.nazadPoloz.TabIndex = 7;
            this.nazadPoloz.Text = "Nazad";
            this.nazadPoloz.UseVisualStyleBackColor = true;
            this.nazadPoloz.Visible = false;
            this.nazadPoloz.Click += new System.EventHandler(this.nazadPoloz_Click);
            // 
            // pocpolozeni
            // 
            this.pocpolozeni.Controls.Add(this.listBox2);
            this.pocpolozeni.Controls.Add(this.nazadppolozeni);
            this.pocpolozeni.Location = new System.Drawing.Point(15, 25);
            this.pocpolozeni.Name = "pocpolozeni";
            this.pocpolozeni.Size = new System.Drawing.Size(331, 193);
            this.pocpolozeni.TabIndex = 14;
            this.pocpolozeni.TabStop = false;
            this.pocpolozeni.Text = "Položeni predmeti";
            this.pocpolozeni.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 14;
            this.listBox2.Location = new System.Drawing.Point(17, 28);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(152, 158);
            this.listBox2.TabIndex = 5;
            this.listBox2.Visible = false;
            // 
            // nazadppolozeni
            // 
            this.nazadppolozeni.Location = new System.Drawing.Point(202, 159);
            this.nazadppolozeni.Name = "nazadppolozeni";
            this.nazadppolozeni.Size = new System.Drawing.Size(97, 23);
            this.nazadppolozeni.TabIndex = 7;
            this.nazadppolozeni.Text = "Nazad";
            this.nazadppolozeni.UseVisualStyleBackColor = true;
            this.nazadppolozeni.Visible = false;
            this.nazadppolozeni.Click += new System.EventHandler(this.nazadppolozeni_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 147);
            this.listBox1.TabIndex = 4;
            this.listBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // listaupis
            // 
            this.listaupis.BackColor = System.Drawing.SystemColors.Menu;
            this.listaupis.FormattingEnabled = true;
            this.listaupis.ItemHeight = 14;
            this.listaupis.Location = new System.Drawing.Point(17, 28);
            this.listaupis.Name = "listaupis";
            this.listaupis.Size = new System.Drawing.Size(152, 158);
            this.listaupis.TabIndex = 0;
            this.listaupis.Visible = false;
            // 
            // grupaupis
            // 
            this.grupaupis.Controls.Add(this.listaupis);
            this.grupaupis.Controls.Add(this.button3);
            this.grupaupis.Controls.Add(this.button2);
            this.grupaupis.Location = new System.Drawing.Point(15, 25);
            this.grupaupis.Name = "grupaupis";
            this.grupaupis.Size = new System.Drawing.Size(331, 193);
            this.grupaupis.TabIndex = 14;
            this.grupaupis.TabStop = false;
            this.grupaupis.Text = "Položeni predmeti";
            this.grupaupis.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Upiši";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Nazad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dobrodosli
            // 
            this.dobrodosli.Location = new System.Drawing.Point(6, 29);
            this.dobrodosli.Name = "dobrodosli";
            this.dobrodosli.Size = new System.Drawing.Size(90, 25);
            this.dobrodosli.TabIndex = 1;
            this.dobrodosli.Text = "Dobrodošli!";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Nazad";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // profil
            // 
            this.profil.Controls.Add(this.button4);
            this.profil.Controls.Add(this.polozeni);
            this.profil.Controls.Add(this.aktivni);
            this.profil.Controls.Add(this.nazadprofil);
            this.profil.Controls.Add(this.richTextBox2);
            this.profil.Controls.Add(this.richTextBox1);
            this.profil.Controls.Add(this.mb);
            this.profil.Controls.Add(this.datr);
            this.profil.Controls.Add(this.index);
            this.profil.Controls.Add(this.prezime);
            this.profil.Controls.Add(this.ime);
            this.profil.Location = new System.Drawing.Point(5, 25);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(340, 220);
            this.profil.TabIndex = 14;
            this.profil.TabStop = false;
            this.profil.Text = "Profil";
            this.profil.Visible = false;
            // 
            // polozeni
            // 
            this.polozeni.AutoSize = true;
            this.polozeni.Location = new System.Drawing.Point(199, 114);
            this.polozeni.Name = "polozeni";
            this.polozeni.Size = new System.Drawing.Size(133, 14);
            this.polozeni.TabIndex = 8;
            this.polozeni.Text = "Položeni predmeti:";
            // 
            // aktivni
            // 
            this.aktivni.AutoSize = true;
            this.aktivni.Location = new System.Drawing.Point(199, 23);
            this.aktivni.Name = "aktivni";
            this.aktivni.Size = new System.Drawing.Size(126, 14);
            this.aktivni.TabIndex = 7;
            this.aktivni.Text = "Aktivni predmeti:";
            // 
            // nazadprofil
            // 
            this.nazadprofil.Location = new System.Drawing.Point(13, 190);
            this.nazadprofil.Name = "nazadprofil";
            this.nazadprofil.Size = new System.Drawing.Size(75, 23);
            this.nazadprofil.TabIndex = 16;
            this.nazadprofil.Text = "Nazad";
            this.nazadprofil.UseVisualStyleBackColor = true;
            this.nazadprofil.Visible = false;
            this.nazadprofil.Click += new System.EventHandler(this.nazadprofil_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(199, 40);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(133, 52);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(199, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(133, 52);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // mb
            // 
            this.mb.AutoSize = true;
            this.mb.Location = new System.Drawing.Point(6, 154);
            this.mb.Name = "mb";
            this.mb.Size = new System.Drawing.Size(98, 14);
            this.mb.TabIndex = 4;
            this.mb.Text = "Matični broj:";
            // 
            // datr
            // 
            this.datr.AutoSize = true;
            this.datr.Location = new System.Drawing.Point(6, 120);
            this.datr.Name = "datr";
            this.datr.Size = new System.Drawing.Size(105, 14);
            this.datr.TabIndex = 3;
            this.datr.Text = "Datum rođenja:";
            // 
            // index
            // 
            this.index.AutoSize = true;
            this.index.Location = new System.Drawing.Point(6, 89);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(98, 14);
            this.index.TabIndex = 2;
            this.index.Text = "Broj indexa: ";
            // 
            // prezime
            // 
            this.prezime.AutoSize = true;
            this.prezime.Location = new System.Drawing.Point(6, 55);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(70, 14);
            this.prezime.TabIndex = 1;
            this.prezime.Text = "Prezime: ";
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Location = new System.Drawing.Point(6, 26);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(35, 14);
            this.ime.TabIndex = 0;
            this.ime.Text = "Ime:";
            // 
            // listapolozeni
            // 
            this.listapolozeni.BackColor = System.Drawing.SystemColors.Menu;
            this.listapolozeni.FormattingEnabled = true;
            this.listapolozeni.ItemHeight = 14;
            this.listapolozeni.Location = new System.Drawing.Point(17, 28);
            this.listapolozeni.Name = "listapolozeni";
            this.listapolozeni.Size = new System.Drawing.Size(152, 158);
            this.listapolozeni.TabIndex = 4;
            this.listapolozeni.Visible = false;
            // 
            // nazadSvi
            // 
            this.nazadSvi.Location = new System.Drawing.Point(202, 159);
            this.nazadSvi.Name = "nazadSvi";
            this.nazadSvi.Size = new System.Drawing.Size(94, 23);
            this.nazadSvi.TabIndex = 7;
            this.nazadSvi.Text = "Nazad";
            this.nazadSvi.UseVisualStyleBackColor = true;
            this.nazadSvi.Visible = false;
            this.nazadSvi.Click += new System.EventHandler(this.nazadSvi_Click);
            // 
            // grupaPolozeni
            // 
            this.grupaPolozeni.Controls.Add(this.listapolozeni);
            this.grupaPolozeni.Controls.Add(this.nazadPoloz);
            this.grupaPolozeni.Location = new System.Drawing.Point(15, 25);
            this.grupaPolozeni.Name = "grupaPolozeni";
            this.grupaPolozeni.Size = new System.Drawing.Size(331, 193);
            this.grupaPolozeni.TabIndex = 14;
            this.grupaPolozeni.TabStop = false;
            this.grupaPolozeni.Text = "Položeni predmeti";
            this.grupaPolozeni.Visible = false;
            // 
            // grupaSvi
            // 
            this.grupaSvi.Controls.Add(this.nazadSvi);
            this.grupaSvi.Controls.Add(this.listBox3);
            this.grupaSvi.Location = new System.Drawing.Point(15, 25);
            this.grupaSvi.Name = "grupaSvi";
            this.grupaSvi.Size = new System.Drawing.Size(331, 193);
            this.grupaSvi.TabIndex = 14;
            this.grupaSvi.TabStop = false;
            this.grupaSvi.Text = "Svi predmeti";
            this.grupaSvi.Visible = false;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 14;
            this.listBox3.Location = new System.Drawing.Point(17, 28);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(152, 158);
            this.listBox3.TabIndex = 0;
            this.listBox3.Visible = false;
            // 
            // grupaAktivni
            // 
            this.grupaAktivni.Controls.Add(this.ispisiAkt);
            this.grupaAktivni.Controls.Add(this.nazadAkt);
            this.grupaAktivni.Controls.Add(this.listaktivni);
            this.grupaAktivni.Location = new System.Drawing.Point(17, 26);
            this.grupaAktivni.Name = "grupaAktivni";
            this.grupaAktivni.Size = new System.Drawing.Size(331, 195);
            this.grupaAktivni.TabIndex = 7;
            this.grupaAktivni.TabStop = false;
            this.grupaAktivni.Text = "Aktivni predmeti";
            this.grupaAktivni.Visible = false;
            // 
            // ispisiAkt
            // 
            this.ispisiAkt.Location = new System.Drawing.Point(202, 120);
            this.ispisiAkt.Name = "ispisiAkt";
            this.ispisiAkt.Size = new System.Drawing.Size(97, 23);
            this.ispisiAkt.TabIndex = 6;
            this.ispisiAkt.Text = "Ispiši";
            this.ispisiAkt.UseVisualStyleBackColor = true;
            this.ispisiAkt.Click += new System.EventHandler(this.ispisiAkt_Click);
            // 
            // nazadAkt
            // 
            this.nazadAkt.Location = new System.Drawing.Point(202, 159);
            this.nazadAkt.Name = "nazadAkt";
            this.nazadAkt.Size = new System.Drawing.Size(97, 23);
            this.nazadAkt.TabIndex = 5;
            this.nazadAkt.Text = "Nazad";
            this.nazadAkt.UseVisualStyleBackColor = true;
            this.nazadAkt.Visible = false;
            this.nazadAkt.Click += new System.EventHandler(this.nazadAkt_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusObavijest,
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 264);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(392, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusObavijest
            // 
            this.statusObavijest.Name = "statusObavijest";
            this.statusObavijest.Size = new System.Drawing.Size(0, 17);
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // StudentForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(392, 286);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grupaPolozeni);
            this.Controls.Add(this.grupaAktivni);
            this.Controls.Add(this.pocpolozeni);
            this.Controls.Add(this.grupaSvi);
            this.Controls.Add(this.profil);
            this.Controls.Add(this.dobrodosli);
            this.Controls.Add(this.grupaupis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETF-student";
            this.TransparencyKey = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pocpolozeni.ResumeLayout(false);
            this.grupaupis.ResumeLayout(false);
            this.profil.ResumeLayout(false);
            this.profil.PerformLayout();
            this.grupaPolozeni.ResumeLayout(false);
            this.grupaSvi.ResumeLayout(false);
            this.grupaAktivni.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem upisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polozeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ispisToolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox pocpolozeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listaupis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grupaupis;
        private System.Windows.Forms.ListBox listaktivni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox profil;
        private System.Windows.Forms.Label dobrodosli;
        private System.Windows.Forms.Label index;
        private System.Windows.Forms.ListBox listapolozeni;
        private System.Windows.Forms.Label prezime;
        private System.Windows.Forms.Label ime;
        private System.Windows.Forms.Label mb;
        private System.Windows.Forms.Label datr;
        private System.Windows.Forms.Button nazadppolozeni;
        private System.Windows.Forms.Label polozeni;
        private System.Windows.Forms.Label aktivni;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox grupaAktivni;
        private System.Windows.Forms.Button ispisiAkt;
        private System.Windows.Forms.Button nazadAkt;
        private System.Windows.Forms.GroupBox grupaPolozeni;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button nazadPoloz;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusObavijest;
        private System.Windows.Forms.Button nazadprofil;
        private System.Windows.Forms.Button nazadSvi;
        private System.Windows.Forms.GroupBox grupaSvi;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
    }
}