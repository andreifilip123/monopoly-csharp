namespace Monopoly
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
            this.startJoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numeJucator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pozitieJucator = new System.Windows.Forms.Label();
            this.daCuZarul = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.baniJucator = new System.Windows.Forms.Label();
            this.incheieTura = new System.Windows.Forms.Button();
            this.pionJucator = new System.Windows.Forms.PictureBox();
            this.zar2 = new System.Windows.Forms.PictureBox();
            this.zar1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.impozit = new Monopoly.Celula();
            this.taxa_de_lux = new Monopoly.Celula();
            this.mergi_la_inchisoare = new Monopoly.Celula();
            this.parcare_gratuita = new Monopoly.Celula();
            this.inchisoare = new Monopoly.Inchisoare();
            this.go = new Monopoly.Celula();
            this.cutia_comunitatii3 = new Monopoly.CarteSpeciala();
            this.cutia_comunitatii2 = new Monopoly.CarteSpeciala();
            this.sansa3 = new Monopoly.CarteSpeciala();
            this.sansa2 = new Monopoly.CarteSpeciala();
            this.sansa1 = new Monopoly.CarteSpeciala();
            this.cutia_comunitatii1 = new Monopoly.CarteSpeciala();
            this.water_works = new Monopoly.Utilitate();
            this.electric_company = new Monopoly.Utilitate();
            this.pennsylvania_railroad = new Monopoly.Gara();
            this.short_line = new Monopoly.Gara();
            this.b_and_o_railroad = new Monopoly.Gara();
            this.reading_railroad = new Monopoly.Gara();
            this.new_york_avenue = new Monopoly.Strada();
            this.tennessee_avenue = new Monopoly.Strada();
            this.st_james_place = new Monopoly.Strada();
            this.virginia_avenue = new Monopoly.Strada();
            this.states_avenue = new Monopoly.Strada();
            this.st_charles_place = new Monopoly.Strada();
            this.boardwalk = new Monopoly.Strada();
            this.park_place = new Monopoly.Strada();
            this.pennsylvania_avenue = new Monopoly.Strada();
            this.north_carolina_avenue = new Monopoly.Strada();
            this.pacific_avenue = new Monopoly.Strada();
            this.marvin_gardens = new Monopoly.Strada();
            this.ventnor_avenue = new Monopoly.Strada();
            this.atlantic_avenue = new Monopoly.Strada();
            this.illinois_avenue = new Monopoly.Strada();
            this.indiana_avenue = new Monopoly.Strada();
            this.kentucky_avenue = new Monopoly.Strada();
            this.connecticut_avenue = new Monopoly.Strada();
            this.vermont_avenue = new Monopoly.Strada();
            this.oriental_avenue = new Monopoly.Strada();
            this.baltic_avenue = new Monopoly.Strada();
            this.mediterranean_avenue = new Monopoly.Strada();
            ((System.ComponentModel.ISupportInitialize)(this.pionJucator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startJoc
            // 
            this.startJoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startJoc.AutoSize = true;
            this.startJoc.BackColor = System.Drawing.Color.Transparent;
            this.startJoc.Location = new System.Drawing.Point(691, 12);
            this.startJoc.Name = "startJoc";
            this.startJoc.Size = new System.Drawing.Size(104, 53);
            this.startJoc.TabIndex = 1;
            this.startJoc.Text = "Start Joc";
            this.startJoc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.startJoc.UseVisualStyleBackColor = false;
            this.startJoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume jucator:";
            // 
            // numeJucator
            // 
            this.numeJucator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeJucator.AutoSize = true;
            this.numeJucator.Location = new System.Drawing.Point(915, 14);
            this.numeJucator.Name = "numeJucator";
            this.numeJucator.Size = new System.Drawing.Size(35, 13);
            this.numeJucator.TabIndex = 7;
            this.numeJucator.Text = "label2";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(835, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pion jucator:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(838, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pozitie jucator:";
            // 
            // pozitieJucator
            // 
            this.pozitieJucator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pozitieJucator.AutoSize = true;
            this.pozitieJucator.Location = new System.Drawing.Point(920, 95);
            this.pozitieJucator.Name = "pozitieJucator";
            this.pozitieJucator.Size = new System.Drawing.Size(35, 13);
            this.pozitieJucator.TabIndex = 12;
            this.pozitieJucator.Text = "label5";
            // 
            // daCuZarul
            // 
            this.daCuZarul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.daCuZarul.Location = new System.Drawing.Point(1028, 13);
            this.daCuZarul.Name = "daCuZarul";
            this.daCuZarul.Size = new System.Drawing.Size(104, 53);
            this.daCuZarul.TabIndex = 13;
            this.daCuZarul.Text = "Da cu zarul";
            this.daCuZarul.UseVisualStyleBackColor = true;
            this.daCuZarul.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(841, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bani jucator:";
            // 
            // baniJucator
            // 
            this.baniJucator.AutoSize = true;
            this.baniJucator.Location = new System.Drawing.Point(915, 133);
            this.baniJucator.Name = "baniJucator";
            this.baniJucator.Size = new System.Drawing.Size(0, 13);
            this.baniJucator.TabIndex = 15;
            // 
            // incheieTura
            // 
            this.incheieTura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incheieTura.Location = new System.Drawing.Point(1028, 134);
            this.incheieTura.Name = "incheieTura";
            this.incheieTura.Size = new System.Drawing.Size(104, 35);
            this.incheieTura.TabIndex = 16;
            this.incheieTura.Text = "Incheie tura";
            this.incheieTura.UseVisualStyleBackColor = true;
            this.incheieTura.Click += new System.EventHandler(this.incheieTura_Click);
            // 
            // pionJucator
            // 
            this.pionJucator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pionJucator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pionJucator.Location = new System.Drawing.Point(918, 33);
            this.pionJucator.Name = "pionJucator";
            this.pionJucator.Size = new System.Drawing.Size(49, 50);
            this.pionJucator.TabIndex = 9;
            this.pionJucator.TabStop = false;
            // 
            // zar2
            // 
            this.zar2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zar2.Location = new System.Drawing.Point(1083, 72);
            this.zar2.Name = "zar2";
            this.zar2.Size = new System.Drawing.Size(49, 50);
            this.zar2.TabIndex = 5;
            this.zar2.TabStop = false;
            // 
            // zar1
            // 
            this.zar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zar1.Location = new System.Drawing.Point(1028, 72);
            this.zar1.Name = "zar1";
            this.zar1.Size = new System.Drawing.Size(49, 50);
            this.zar1.TabIndex = 2;
            this.zar1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Monopoly.Properties.Resources.board;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.impozit);
            this.panel1.Controls.Add(this.taxa_de_lux);
            this.panel1.Controls.Add(this.mergi_la_inchisoare);
            this.panel1.Controls.Add(this.parcare_gratuita);
            this.panel1.Controls.Add(this.inchisoare);
            this.panel1.Controls.Add(this.go);
            this.panel1.Controls.Add(this.cutia_comunitatii3);
            this.panel1.Controls.Add(this.cutia_comunitatii2);
            this.panel1.Controls.Add(this.sansa3);
            this.panel1.Controls.Add(this.sansa2);
            this.panel1.Controls.Add(this.sansa1);
            this.panel1.Controls.Add(this.cutia_comunitatii1);
            this.panel1.Controls.Add(this.water_works);
            this.panel1.Controls.Add(this.electric_company);
            this.panel1.Controls.Add(this.pennsylvania_railroad);
            this.panel1.Controls.Add(this.short_line);
            this.panel1.Controls.Add(this.b_and_o_railroad);
            this.panel1.Controls.Add(this.reading_railroad);
            this.panel1.Controls.Add(this.new_york_avenue);
            this.panel1.Controls.Add(this.tennessee_avenue);
            this.panel1.Controls.Add(this.st_james_place);
            this.panel1.Controls.Add(this.virginia_avenue);
            this.panel1.Controls.Add(this.states_avenue);
            this.panel1.Controls.Add(this.st_charles_place);
            this.panel1.Controls.Add(this.boardwalk);
            this.panel1.Controls.Add(this.park_place);
            this.panel1.Controls.Add(this.pennsylvania_avenue);
            this.panel1.Controls.Add(this.north_carolina_avenue);
            this.panel1.Controls.Add(this.pacific_avenue);
            this.panel1.Controls.Add(this.marvin_gardens);
            this.panel1.Controls.Add(this.ventnor_avenue);
            this.panel1.Controls.Add(this.atlantic_avenue);
            this.panel1.Controls.Add(this.illinois_avenue);
            this.panel1.Controls.Add(this.indiana_avenue);
            this.panel1.Controls.Add(this.kentucky_avenue);
            this.panel1.Controls.Add(this.connecticut_avenue);
            this.panel1.Controls.Add(this.vermont_avenue);
            this.panel1.Controls.Add(this.oriental_avenue);
            this.panel1.Controls.Add(this.baltic_avenue);
            this.panel1.Controls.Add(this.mediterranean_avenue);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 673);
            this.panel1.TabIndex = 17;
            // 
            // impozit
            // 
            this.impozit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impozit.ID = 4;
            this.impozit.imagine = null;
            this.impozit.Location = new System.Drawing.Point(364, 585);
            this.impozit.Name = "impozit";
            this.impozit.nume = "impozit";
            this.impozit.Size = new System.Drawing.Size(55, 85);
            this.impozit.TabIndex = 18;
            this.impozit.UseVisualStyleBackColor = true;
            // 
            // taxa_de_lux
            // 
            this.taxa_de_lux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taxa_de_lux.ID = 38;
            this.taxa_de_lux.imagine = null;
            this.taxa_de_lux.Location = new System.Drawing.Point(586, 475);
            this.taxa_de_lux.Name = "taxa_de_lux";
            this.taxa_de_lux.nume = "taxa_de_lux";
            this.taxa_de_lux.Size = new System.Drawing.Size(84, 54);
            this.taxa_de_lux.TabIndex = 18;
            this.taxa_de_lux.UseVisualStyleBackColor = true;
            // 
            // mergi_la_inchisoare
            // 
            this.mergi_la_inchisoare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mergi_la_inchisoare.ID = 30;
            this.mergi_la_inchisoare.imagine = null;
            this.mergi_la_inchisoare.Location = new System.Drawing.Point(586, 2);
            this.mergi_la_inchisoare.Name = "mergi_la_inchisoare";
            this.mergi_la_inchisoare.nume = "mergi_la_inchisoare";
            this.mergi_la_inchisoare.Size = new System.Drawing.Size(85, 85);
            this.mergi_la_inchisoare.TabIndex = 43;
            this.mergi_la_inchisoare.UseVisualStyleBackColor = true;
            // 
            // parcare_gratuita
            // 
            this.parcare_gratuita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parcare_gratuita.ID = 20;
            this.parcare_gratuita.imagine = null;
            this.parcare_gratuita.Location = new System.Drawing.Point(4, 3);
            this.parcare_gratuita.Name = "parcare_gratuita";
            this.parcare_gratuita.nume = "parcare_gratuita";
            this.parcare_gratuita.Size = new System.Drawing.Size(85, 85);
            this.parcare_gratuita.TabIndex = 18;
            this.parcare_gratuita.UseVisualStyleBackColor = true;
            // 
            // inchisoare
            // 
            this.inchisoare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inchisoare.ID = 10;
            this.inchisoare.imagine = null;
            this.inchisoare.Location = new System.Drawing.Point(4, 585);
            this.inchisoare.Name = "inchisoare";
            this.inchisoare.nume = "inchisoare";
            this.inchisoare.Size = new System.Drawing.Size(85, 85);
            this.inchisoare.TabIndex = 18;
            this.inchisoare.UseVisualStyleBackColor = true;
            // 
            // go
            // 
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go.ID = 0;
            this.go.imagine = null;
            this.go.Location = new System.Drawing.Point(585, 585);
            this.go.Name = "go";
            this.go.nume = "go";
            this.go.Size = new System.Drawing.Size(85, 85);
            this.go.TabIndex = 18;
            this.go.UseVisualStyleBackColor = true;
            // 
            // cutia_comunitatii3
            // 
            this.cutia_comunitatii3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cutia_comunitatii3.ID = 0;
            this.cutia_comunitatii3.imagine = null;
            this.cutia_comunitatii3.Location = new System.Drawing.Point(585, 199);
            this.cutia_comunitatii3.Name = "cutia_comunitatii3";
            this.cutia_comunitatii3.nume = null;
            this.cutia_comunitatii3.Size = new System.Drawing.Size(85, 54);
            this.cutia_comunitatii3.TabIndex = 42;
            this.cutia_comunitatii3.UseVisualStyleBackColor = true;
            // 
            // cutia_comunitatii2
            // 
            this.cutia_comunitatii2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cutia_comunitatii2.ID = 0;
            this.cutia_comunitatii2.imagine = null;
            this.cutia_comunitatii2.Location = new System.Drawing.Point(3, 199);
            this.cutia_comunitatii2.Name = "cutia_comunitatii2";
            this.cutia_comunitatii2.nume = null;
            this.cutia_comunitatii2.Size = new System.Drawing.Size(85, 54);
            this.cutia_comunitatii2.TabIndex = 41;
            this.cutia_comunitatii2.UseVisualStyleBackColor = true;
            // 
            // sansa3
            // 
            this.sansa3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sansa3.ID = 0;
            this.sansa3.imagine = null;
            this.sansa3.Location = new System.Drawing.Point(585, 365);
            this.sansa3.Name = "sansa3";
            this.sansa3.nume = null;
            this.sansa3.Size = new System.Drawing.Size(85, 54);
            this.sansa3.TabIndex = 18;
            this.sansa3.UseVisualStyleBackColor = true;
            // 
            // sansa2
            // 
            this.sansa2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sansa2.ID = 0;
            this.sansa2.imagine = null;
            this.sansa2.Location = new System.Drawing.Point(143, 1);
            this.sansa2.Name = "sansa2";
            this.sansa2.nume = null;
            this.sansa2.Size = new System.Drawing.Size(54, 85);
            this.sansa2.TabIndex = 19;
            this.sansa2.UseVisualStyleBackColor = true;
            // 
            // sansa1
            // 
            this.sansa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sansa1.ID = 0;
            this.sansa1.imagine = null;
            this.sansa1.Location = new System.Drawing.Point(199, 585);
            this.sansa1.Name = "sansa1";
            this.sansa1.nume = null;
            this.sansa1.Size = new System.Drawing.Size(54, 85);
            this.sansa1.TabIndex = 40;
            this.sansa1.UseVisualStyleBackColor = true;
            // 
            // cutia_comunitatii1
            // 
            this.cutia_comunitatii1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cutia_comunitatii1.ID = 2;
            this.cutia_comunitatii1.imagine = global::Monopoly.Properties.Resources.cutia_comunitatii;
            this.cutia_comunitatii1.Location = new System.Drawing.Point(475, 585);
            this.cutia_comunitatii1.Name = "cutia_comunitatii1";
            this.cutia_comunitatii1.nume = "cutia_comunitatii1";
            this.cutia_comunitatii1.Size = new System.Drawing.Size(54, 85);
            this.cutia_comunitatii1.TabIndex = 18;
            this.cutia_comunitatii1.UseVisualStyleBackColor = true;
            // 
            // water_works
            // 
            this.water_works.culoare = null;
            this.water_works.esteIpotecata = false;
            this.water_works.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.water_works.ID = 0;
            this.water_works.imagine = null;
            this.water_works.Location = new System.Drawing.Point(475, 1);
            this.water_works.Name = "water_works";
            this.water_works.nume = null;
            this.water_works.proprietar = null;
            this.water_works.Size = new System.Drawing.Size(55, 85);
            this.water_works.TabIndex = 39;
            this.water_works.UseVisualStyleBackColor = true;
            this.water_works.valoareaProprietatii = 0;
            // 
            // electric_company
            // 
            this.electric_company.culoare = null;
            this.electric_company.esteIpotecata = false;
            this.electric_company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.electric_company.ID = 0;
            this.electric_company.imagine = null;
            this.electric_company.Location = new System.Drawing.Point(3, 475);
            this.electric_company.Name = "electric_company";
            this.electric_company.nume = null;
            this.electric_company.proprietar = null;
            this.electric_company.Size = new System.Drawing.Size(85, 54);
            this.electric_company.TabIndex = 18;
            this.electric_company.UseVisualStyleBackColor = true;
            this.electric_company.valoareaProprietatii = 0;
            // 
            // pennsylvania_railroad
            // 
            this.pennsylvania_railroad.culoare = null;
            this.pennsylvania_railroad.esteIpotecata = false;
            this.pennsylvania_railroad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pennsylvania_railroad.ID = 15;
            this.pennsylvania_railroad.imagine = global::Monopoly.Properties.Resources.pennsylvania_railroad;
            this.pennsylvania_railroad.Location = new System.Drawing.Point(3, 310);
            this.pennsylvania_railroad.Name = "pennsylvania_railroad";
            this.pennsylvania_railroad.nume = null;
            this.pennsylvania_railroad.proprietar = null;
            this.pennsylvania_railroad.Size = new System.Drawing.Size(85, 54);
            this.pennsylvania_railroad.TabIndex = 38;
            this.pennsylvania_railroad.UseVisualStyleBackColor = true;
            this.pennsylvania_railroad.valoareaProprietatii = 0;
            // 
            // short_line
            // 
            this.short_line.culoare = null;
            this.short_line.esteIpotecata = false;
            this.short_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.short_line.ID = 35;
            this.short_line.imagine = global::Monopoly.Properties.Resources.short_line;
            this.short_line.Location = new System.Drawing.Point(585, 310);
            this.short_line.Name = "short_line";
            this.short_line.nume = null;
            this.short_line.proprietar = null;
            this.short_line.Size = new System.Drawing.Size(85, 54);
            this.short_line.TabIndex = 37;
            this.short_line.UseVisualStyleBackColor = true;
            this.short_line.valoareaProprietatii = 0;
            // 
            // b_and_o_railroad
            // 
            this.b_and_o_railroad.culoare = null;
            this.b_and_o_railroad.esteIpotecata = false;
            this.b_and_o_railroad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_and_o_railroad.ID = 25;
            this.b_and_o_railroad.imagine = global::Monopoly.Properties.Resources.b_and_o_railroad;
            this.b_and_o_railroad.Location = new System.Drawing.Point(309, 1);
            this.b_and_o_railroad.Name = "b_and_o_railroad";
            this.b_and_o_railroad.nume = null;
            this.b_and_o_railroad.proprietar = null;
            this.b_and_o_railroad.Size = new System.Drawing.Size(55, 85);
            this.b_and_o_railroad.TabIndex = 36;
            this.b_and_o_railroad.UseVisualStyleBackColor = true;
            this.b_and_o_railroad.valoareaProprietatii = 0;
            // 
            // reading_railroad
            // 
            this.reading_railroad.culoare = null;
            this.reading_railroad.esteIpotecata = false;
            this.reading_railroad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reading_railroad.ID = 5;
            this.reading_railroad.imagine = global::Monopoly.Properties.Resources.reading_railroad;
            this.reading_railroad.Location = new System.Drawing.Point(309, 585);
            this.reading_railroad.Name = "reading_railroad";
            this.reading_railroad.nume = null;
            this.reading_railroad.proprietar = null;
            this.reading_railroad.Size = new System.Drawing.Size(55, 85);
            this.reading_railroad.TabIndex = 18;
            this.reading_railroad.UseVisualStyleBackColor = true;
            this.reading_railroad.valoareaProprietatii = 0;
            // 
            // new_york_avenue
            // 
            this.new_york_avenue.chirii = null;
            this.new_york_avenue.culoare = null;
            this.new_york_avenue.esteIpotecata = false;
            this.new_york_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_york_avenue.ID = 0;
            this.new_york_avenue.imagine = null;
            this.new_york_avenue.Location = new System.Drawing.Point(3, 89);
            this.new_york_avenue.Name = "new_york_avenue";
            this.new_york_avenue.nume = null;
            this.new_york_avenue.pretPerCasa = 0;
            this.new_york_avenue.proprietar = null;
            this.new_york_avenue.Size = new System.Drawing.Size(85, 54);
            this.new_york_avenue.TabIndex = 35;
            this.new_york_avenue.UseVisualStyleBackColor = true;
            this.new_york_avenue.valoareaProprietatii = 0;
            // 
            // tennessee_avenue
            // 
            this.tennessee_avenue.chirii = null;
            this.tennessee_avenue.culoare = null;
            this.tennessee_avenue.esteIpotecata = false;
            this.tennessee_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tennessee_avenue.ID = 0;
            this.tennessee_avenue.imagine = null;
            this.tennessee_avenue.Location = new System.Drawing.Point(3, 144);
            this.tennessee_avenue.Name = "tennessee_avenue";
            this.tennessee_avenue.nume = null;
            this.tennessee_avenue.pretPerCasa = 0;
            this.tennessee_avenue.proprietar = null;
            this.tennessee_avenue.Size = new System.Drawing.Size(85, 54);
            this.tennessee_avenue.TabIndex = 34;
            this.tennessee_avenue.UseVisualStyleBackColor = true;
            this.tennessee_avenue.valoareaProprietatii = 0;
            // 
            // st_james_place
            // 
            this.st_james_place.chirii = null;
            this.st_james_place.culoare = null;
            this.st_james_place.esteIpotecata = false;
            this.st_james_place.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.st_james_place.ID = 0;
            this.st_james_place.imagine = null;
            this.st_james_place.Location = new System.Drawing.Point(3, 254);
            this.st_james_place.Name = "st_james_place";
            this.st_james_place.nume = null;
            this.st_james_place.pretPerCasa = 0;
            this.st_james_place.proprietar = null;
            this.st_james_place.Size = new System.Drawing.Size(85, 54);
            this.st_james_place.TabIndex = 33;
            this.st_james_place.UseVisualStyleBackColor = true;
            this.st_james_place.valoareaProprietatii = 0;
            // 
            // virginia_avenue
            // 
            this.virginia_avenue.chirii = null;
            this.virginia_avenue.culoare = null;
            this.virginia_avenue.esteIpotecata = false;
            this.virginia_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.virginia_avenue.ID = 0;
            this.virginia_avenue.imagine = null;
            this.virginia_avenue.Location = new System.Drawing.Point(3, 365);
            this.virginia_avenue.Name = "virginia_avenue";
            this.virginia_avenue.nume = null;
            this.virginia_avenue.pretPerCasa = 0;
            this.virginia_avenue.proprietar = null;
            this.virginia_avenue.Size = new System.Drawing.Size(85, 54);
            this.virginia_avenue.TabIndex = 32;
            this.virginia_avenue.UseVisualStyleBackColor = true;
            this.virginia_avenue.valoareaProprietatii = 0;
            // 
            // states_avenue
            // 
            this.states_avenue.chirii = null;
            this.states_avenue.culoare = null;
            this.states_avenue.esteIpotecata = false;
            this.states_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.states_avenue.ID = 0;
            this.states_avenue.imagine = null;
            this.states_avenue.Location = new System.Drawing.Point(3, 421);
            this.states_avenue.Name = "states_avenue";
            this.states_avenue.nume = null;
            this.states_avenue.pretPerCasa = 0;
            this.states_avenue.proprietar = null;
            this.states_avenue.Size = new System.Drawing.Size(85, 54);
            this.states_avenue.TabIndex = 31;
            this.states_avenue.UseVisualStyleBackColor = true;
            this.states_avenue.valoareaProprietatii = 0;
            // 
            // st_charles_place
            // 
            this.st_charles_place.chirii = null;
            this.st_charles_place.culoare = null;
            this.st_charles_place.esteIpotecata = false;
            this.st_charles_place.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.st_charles_place.ID = 0;
            this.st_charles_place.imagine = null;
            this.st_charles_place.Location = new System.Drawing.Point(3, 531);
            this.st_charles_place.Name = "st_charles_place";
            this.st_charles_place.nume = null;
            this.st_charles_place.pretPerCasa = 0;
            this.st_charles_place.proprietar = null;
            this.st_charles_place.Size = new System.Drawing.Size(85, 54);
            this.st_charles_place.TabIndex = 30;
            this.st_charles_place.UseVisualStyleBackColor = true;
            this.st_charles_place.valoareaProprietatii = 0;
            // 
            // boardwalk
            // 
            this.boardwalk.chirii = null;
            this.boardwalk.culoare = null;
            this.boardwalk.esteIpotecata = false;
            this.boardwalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardwalk.ID = 0;
            this.boardwalk.imagine = null;
            this.boardwalk.Location = new System.Drawing.Point(585, 531);
            this.boardwalk.Name = "boardwalk";
            this.boardwalk.nume = null;
            this.boardwalk.pretPerCasa = 0;
            this.boardwalk.proprietar = null;
            this.boardwalk.Size = new System.Drawing.Size(85, 54);
            this.boardwalk.TabIndex = 27;
            this.boardwalk.UseVisualStyleBackColor = true;
            this.boardwalk.valoareaProprietatii = 0;
            // 
            // park_place
            // 
            this.park_place.chirii = null;
            this.park_place.culoare = null;
            this.park_place.esteIpotecata = false;
            this.park_place.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.park_place.ID = 0;
            this.park_place.imagine = null;
            this.park_place.Location = new System.Drawing.Point(585, 421);
            this.park_place.Name = "park_place";
            this.park_place.nume = null;
            this.park_place.pretPerCasa = 0;
            this.park_place.proprietar = null;
            this.park_place.Size = new System.Drawing.Size(85, 54);
            this.park_place.TabIndex = 29;
            this.park_place.UseVisualStyleBackColor = true;
            this.park_place.valoareaProprietatii = 0;
            // 
            // pennsylvania_avenue
            // 
            this.pennsylvania_avenue.chirii = null;
            this.pennsylvania_avenue.culoare = null;
            this.pennsylvania_avenue.esteIpotecata = false;
            this.pennsylvania_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pennsylvania_avenue.ID = 0;
            this.pennsylvania_avenue.imagine = null;
            this.pennsylvania_avenue.Location = new System.Drawing.Point(585, 254);
            this.pennsylvania_avenue.Name = "pennsylvania_avenue";
            this.pennsylvania_avenue.nume = null;
            this.pennsylvania_avenue.pretPerCasa = 0;
            this.pennsylvania_avenue.proprietar = null;
            this.pennsylvania_avenue.Size = new System.Drawing.Size(85, 54);
            this.pennsylvania_avenue.TabIndex = 28;
            this.pennsylvania_avenue.UseVisualStyleBackColor = true;
            this.pennsylvania_avenue.valoareaProprietatii = 0;
            // 
            // north_carolina_avenue
            // 
            this.north_carolina_avenue.chirii = null;
            this.north_carolina_avenue.culoare = null;
            this.north_carolina_avenue.esteIpotecata = false;
            this.north_carolina_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.north_carolina_avenue.ID = 0;
            this.north_carolina_avenue.imagine = null;
            this.north_carolina_avenue.Location = new System.Drawing.Point(585, 144);
            this.north_carolina_avenue.Name = "north_carolina_avenue";
            this.north_carolina_avenue.nume = null;
            this.north_carolina_avenue.pretPerCasa = 0;
            this.north_carolina_avenue.proprietar = null;
            this.north_carolina_avenue.Size = new System.Drawing.Size(85, 54);
            this.north_carolina_avenue.TabIndex = 27;
            this.north_carolina_avenue.UseVisualStyleBackColor = true;
            this.north_carolina_avenue.valoareaProprietatii = 0;
            // 
            // pacific_avenue
            // 
            this.pacific_avenue.chirii = null;
            this.pacific_avenue.culoare = null;
            this.pacific_avenue.esteIpotecata = false;
            this.pacific_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pacific_avenue.ID = 0;
            this.pacific_avenue.imagine = null;
            this.pacific_avenue.Location = new System.Drawing.Point(585, 89);
            this.pacific_avenue.Name = "pacific_avenue";
            this.pacific_avenue.nume = null;
            this.pacific_avenue.pretPerCasa = 0;
            this.pacific_avenue.proprietar = null;
            this.pacific_avenue.Size = new System.Drawing.Size(85, 54);
            this.pacific_avenue.TabIndex = 26;
            this.pacific_avenue.UseVisualStyleBackColor = true;
            this.pacific_avenue.valoareaProprietatii = 0;
            // 
            // marvin_gardens
            // 
            this.marvin_gardens.chirii = null;
            this.marvin_gardens.culoare = null;
            this.marvin_gardens.esteIpotecata = false;
            this.marvin_gardens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marvin_gardens.ID = 0;
            this.marvin_gardens.imagine = null;
            this.marvin_gardens.Location = new System.Drawing.Point(528, 0);
            this.marvin_gardens.Name = "marvin_gardens";
            this.marvin_gardens.nume = null;
            this.marvin_gardens.pretPerCasa = 0;
            this.marvin_gardens.proprietar = null;
            this.marvin_gardens.Size = new System.Drawing.Size(55, 85);
            this.marvin_gardens.TabIndex = 25;
            this.marvin_gardens.UseVisualStyleBackColor = true;
            this.marvin_gardens.valoareaProprietatii = 0;
            // 
            // ventnor_avenue
            // 
            this.ventnor_avenue.chirii = null;
            this.ventnor_avenue.culoare = null;
            this.ventnor_avenue.esteIpotecata = false;
            this.ventnor_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventnor_avenue.ID = 0;
            this.ventnor_avenue.imagine = null;
            this.ventnor_avenue.Location = new System.Drawing.Point(419, 1);
            this.ventnor_avenue.Name = "ventnor_avenue";
            this.ventnor_avenue.nume = null;
            this.ventnor_avenue.pretPerCasa = 0;
            this.ventnor_avenue.proprietar = null;
            this.ventnor_avenue.Size = new System.Drawing.Size(55, 85);
            this.ventnor_avenue.TabIndex = 24;
            this.ventnor_avenue.UseVisualStyleBackColor = true;
            this.ventnor_avenue.valoareaProprietatii = 0;
            // 
            // atlantic_avenue
            // 
            this.atlantic_avenue.chirii = null;
            this.atlantic_avenue.culoare = null;
            this.atlantic_avenue.esteIpotecata = false;
            this.atlantic_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atlantic_avenue.ID = 0;
            this.atlantic_avenue.imagine = null;
            this.atlantic_avenue.Location = new System.Drawing.Point(364, 1);
            this.atlantic_avenue.Name = "atlantic_avenue";
            this.atlantic_avenue.nume = null;
            this.atlantic_avenue.pretPerCasa = 0;
            this.atlantic_avenue.proprietar = null;
            this.atlantic_avenue.Size = new System.Drawing.Size(55, 85);
            this.atlantic_avenue.TabIndex = 23;
            this.atlantic_avenue.UseVisualStyleBackColor = true;
            this.atlantic_avenue.valoareaProprietatii = 0;
            // 
            // illinois_avenue
            // 
            this.illinois_avenue.chirii = null;
            this.illinois_avenue.culoare = null;
            this.illinois_avenue.esteIpotecata = false;
            this.illinois_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.illinois_avenue.ID = 0;
            this.illinois_avenue.imagine = null;
            this.illinois_avenue.Location = new System.Drawing.Point(253, 1);
            this.illinois_avenue.Name = "illinois_avenue";
            this.illinois_avenue.nume = null;
            this.illinois_avenue.pretPerCasa = 0;
            this.illinois_avenue.proprietar = null;
            this.illinois_avenue.Size = new System.Drawing.Size(55, 85);
            this.illinois_avenue.TabIndex = 22;
            this.illinois_avenue.UseVisualStyleBackColor = true;
            this.illinois_avenue.valoareaProprietatii = 0;
            // 
            // indiana_avenue
            // 
            this.indiana_avenue.chirii = null;
            this.indiana_avenue.culoare = null;
            this.indiana_avenue.esteIpotecata = false;
            this.indiana_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indiana_avenue.ID = 0;
            this.indiana_avenue.imagine = null;
            this.indiana_avenue.Location = new System.Drawing.Point(198, 1);
            this.indiana_avenue.Name = "indiana_avenue";
            this.indiana_avenue.nume = null;
            this.indiana_avenue.pretPerCasa = 0;
            this.indiana_avenue.proprietar = null;
            this.indiana_avenue.Size = new System.Drawing.Size(55, 85);
            this.indiana_avenue.TabIndex = 21;
            this.indiana_avenue.UseVisualStyleBackColor = true;
            this.indiana_avenue.valoareaProprietatii = 0;
            // 
            // kentucky_avenue
            // 
            this.kentucky_avenue.chirii = null;
            this.kentucky_avenue.culoare = null;
            this.kentucky_avenue.esteIpotecata = false;
            this.kentucky_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kentucky_avenue.ID = 0;
            this.kentucky_avenue.imagine = null;
            this.kentucky_avenue.Location = new System.Drawing.Point(88, 1);
            this.kentucky_avenue.Name = "kentucky_avenue";
            this.kentucky_avenue.nume = null;
            this.kentucky_avenue.pretPerCasa = 0;
            this.kentucky_avenue.proprietar = null;
            this.kentucky_avenue.Size = new System.Drawing.Size(55, 85);
            this.kentucky_avenue.TabIndex = 19;
            this.kentucky_avenue.UseVisualStyleBackColor = true;
            this.kentucky_avenue.valoareaProprietatii = 0;
            // 
            // connecticut_avenue
            // 
            this.connecticut_avenue.chirii = null;
            this.connecticut_avenue.culoare = null;
            this.connecticut_avenue.esteIpotecata = false;
            this.connecticut_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connecticut_avenue.ID = 0;
            this.connecticut_avenue.imagine = null;
            this.connecticut_avenue.Location = new System.Drawing.Point(88, 585);
            this.connecticut_avenue.Name = "connecticut_avenue";
            this.connecticut_avenue.nume = null;
            this.connecticut_avenue.pretPerCasa = 0;
            this.connecticut_avenue.proprietar = null;
            this.connecticut_avenue.Size = new System.Drawing.Size(55, 85);
            this.connecticut_avenue.TabIndex = 20;
            this.connecticut_avenue.UseVisualStyleBackColor = true;
            this.connecticut_avenue.valoareaProprietatii = 0;
            // 
            // vermont_avenue
            // 
            this.vermont_avenue.chirii = null;
            this.vermont_avenue.culoare = null;
            this.vermont_avenue.esteIpotecata = false;
            this.vermont_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vermont_avenue.ID = 0;
            this.vermont_avenue.imagine = null;
            this.vermont_avenue.Location = new System.Drawing.Point(142, 585);
            this.vermont_avenue.Name = "vermont_avenue";
            this.vermont_avenue.nume = null;
            this.vermont_avenue.pretPerCasa = 0;
            this.vermont_avenue.proprietar = null;
            this.vermont_avenue.Size = new System.Drawing.Size(55, 85);
            this.vermont_avenue.TabIndex = 19;
            this.vermont_avenue.UseVisualStyleBackColor = true;
            this.vermont_avenue.valoareaProprietatii = 0;
            // 
            // oriental_avenue
            // 
            this.oriental_avenue.chirii = null;
            this.oriental_avenue.culoare = null;
            this.oriental_avenue.esteIpotecata = false;
            this.oriental_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oriental_avenue.ID = 0;
            this.oriental_avenue.imagine = null;
            this.oriental_avenue.Location = new System.Drawing.Point(253, 585);
            this.oriental_avenue.Name = "oriental_avenue";
            this.oriental_avenue.nume = null;
            this.oriental_avenue.pretPerCasa = 0;
            this.oriental_avenue.proprietar = null;
            this.oriental_avenue.Size = new System.Drawing.Size(55, 85);
            this.oriental_avenue.TabIndex = 19;
            this.oriental_avenue.UseVisualStyleBackColor = true;
            this.oriental_avenue.valoareaProprietatii = 0;
            // 
            // baltic_avenue
            // 
            this.baltic_avenue.chirii = null;
            this.baltic_avenue.culoare = null;
            this.baltic_avenue.esteIpotecata = false;
            this.baltic_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baltic_avenue.ID = 0;
            this.baltic_avenue.imagine = null;
            this.baltic_avenue.Location = new System.Drawing.Point(418, 585);
            this.baltic_avenue.Name = "baltic_avenue";
            this.baltic_avenue.nume = null;
            this.baltic_avenue.pretPerCasa = 0;
            this.baltic_avenue.proprietar = null;
            this.baltic_avenue.Size = new System.Drawing.Size(55, 85);
            this.baltic_avenue.TabIndex = 19;
            this.baltic_avenue.UseVisualStyleBackColor = true;
            this.baltic_avenue.valoareaProprietatii = 0;
            // 
            // mediterranean_avenue
            // 
            this.mediterranean_avenue.chirii = null;
            this.mediterranean_avenue.culoare = null;
            this.mediterranean_avenue.esteIpotecata = false;
            this.mediterranean_avenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediterranean_avenue.ID = 0;
            this.mediterranean_avenue.imagine = global::Monopoly.Properties.Resources.mediterranean_avenue;
            this.mediterranean_avenue.Location = new System.Drawing.Point(528, 585);
            this.mediterranean_avenue.Name = "mediterranean_avenue";
            this.mediterranean_avenue.nume = null;
            this.mediterranean_avenue.pretPerCasa = 0;
            this.mediterranean_avenue.proprietar = null;
            this.mediterranean_avenue.Size = new System.Drawing.Size(55, 85);
            this.mediterranean_avenue.TabIndex = 18;
            this.mediterranean_avenue.UseVisualStyleBackColor = true;
            this.mediterranean_avenue.valoareaProprietatii = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.incheieTura);
            this.Controls.Add(this.baniJucator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.daCuZarul);
            this.Controls.Add(this.pozitieJucator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pionJucator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeJucator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zar2);
            this.Controls.Add(this.zar1);
            this.Controls.Add(this.startJoc);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Monopoly";
            ((System.ComponentModel.ISupportInitialize)(this.pionJucator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startJoc;
        private System.Windows.Forms.PictureBox zar1;
        private System.Windows.Forms.PictureBox zar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numeJucator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pionJucator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pozitieJucator;
        private System.Windows.Forms.Button daCuZarul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label baniJucator;
        private System.Windows.Forms.Button incheieTura;
        private System.Windows.Forms.Panel panel1;
        private Utilitate water_works;
        private Utilitate electric_company;
        private Gara pennsylvania_railroad;
        private Gara short_line;
        private Gara b_and_o_railroad;
        private Gara reading_railroad;
        private Strada new_york_avenue;
        private Strada tennessee_avenue;
        private Strada st_james_place;
        private Strada virginia_avenue;
        private Strada states_avenue;
        private Strada st_charles_place;
        private Strada boardwalk;
        private Strada park_place;
        private Strada pennsylvania_avenue;
        private Strada north_carolina_avenue;
        private Strada pacific_avenue;
        private Strada marvin_gardens;
        private Strada ventnor_avenue;
        private Strada atlantic_avenue;
        private Strada illinois_avenue;
        private Strada indiana_avenue;
        private Strada kentucky_avenue;
        private Strada connecticut_avenue;
        private Strada vermont_avenue;
        private Strada oriental_avenue;
        private Strada baltic_avenue;
        private Strada mediterranean_avenue;
        private CarteSpeciala cutia_comunitatii3;
        private CarteSpeciala cutia_comunitatii2;
        private CarteSpeciala sansa3;
        private CarteSpeciala sansa2;
        private CarteSpeciala sansa1;
        private CarteSpeciala cutia_comunitatii1;
        private Celula impozit;
        private Celula taxa_de_lux;
        private Celula mergi_la_inchisoare;
        private Celula parcare_gratuita;
        private Inchisoare inchisoare;
        private Celula go;
    }
}

