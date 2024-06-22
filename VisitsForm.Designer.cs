//using System.Data.Entity;
using System.Windows.Forms;
using System;
using System.Linq;

namespace WinForm
{
    partial class VisitsForm
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPatients = new TabPage();
            panel1 = new Panel();
            fldPatientCity = new TextBox();
            labelCity = new Label();
            fldParientHeight = new TextBox();
            labelPatientHeight = new Label();
            fldPatientAge = new TextBox();
            labelAge = new Label();
            fldPatientName = new TextBox();
            btnAddPatient = new Button();
            fldPatientSurname = new TextBox();
            labelPatientName = new Label();
            labelPatienSurname = new Label();
            fldSearchPatient = new TextBox();
            label5 = new Label();
            gridPatients = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            tabVisits = new TabPage();
            fldNakosaKolposkKontrole = new DateTimePicker();
            lbNakosaKolposkopijasKontrole = new Label();
            gbVizitePirmreizAtkartota = new GroupBox();
            rbViziteAtkartota = new RadioButton();
            rbVizitePirmreizeja = new RadioButton();
            cbM3 = new CheckBox();
            cbM2 = new CheckBox();
            cbM1 = new CheckBox();
            fldRezultati = new RichTextBox();
            lbRezultati = new Label();
            fldVizitesAtkartojums = new TextBox();
            lbVizitesAtkartojums = new Label();
            fldSledziens = new RichTextBox();
            lbSledziens = new Label();
            cbAlergijas = new CheckBox();
            cbP5 = new CheckBox();
            cbP4 = new CheckBox();
            cbP3 = new CheckBox();
            cbP2 = new CheckBox();
            cbP1 = new CheckBox();
            btnVisitSave = new Button();
            lbP5Text = new Label();
            lbP4Text = new Label();
            lbP3Text = new Label();
            lbP2Text = new Label();
            lbP1Text = new Label();
            fldTrnsformacijasZonasTips = new TextBox();
            tbKolposkopijaAdekvata = new TextBox();
            fldIeprkshVeiktaTerapija = new RichTextBox();
            fldIzmeklejumaDatums = new DateTimePicker();
            fldIzmeklejumaNr = new TextBox();
            fldSkriningaNummurs = new TextBox();
            fldPedejaCitologija = new RichTextBox();
            fldAnamneze = new RichTextBox();
            lbPacientsVecums = new Label();
            lbTransformacijasZonasTips = new Label();
            lbKolposkopijaAdekvata = new Label();
            lbIepriekshVeiktaaTerapija = new Label();
            lbPedejaCitologija = new Label();
            lbAnamneze = new Label();
            lbSkriningaNummurs = new Label();
            lbPatientName = new Label();
            lbIzmeklejumaDatums = new Label();
            lbIzmeklejumaNr = new Label();
            lbHeaderVisit = new Label();
            tabImages = new TabPage();
            btnRefreshImages = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            tabPage4 = new TabPage();
            cVisitBindingSource = new BindingSource(components);
            labelVisitFormPatientName = new Label();
            labelVisitFormPatientAge = new Label();
            tabControl1.SuspendLayout();
            tabPatients.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPatients).BeginInit();
            tabVisits.SuspendLayout();
            gbVizitePirmreizAtkartota.SuspendLayout();
            tabImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cVisitBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPatients);
            tabControl1.Controls.Add(tabVisits);
            tabControl1.Controls.Add(tabImages);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new System.Drawing.Point(12, 31);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1260, 960);
            tabControl1.TabIndex = 0;
            // 
            // tabPatients
            // 
            tabPatients.Controls.Add(panel1);
            tabPatients.Controls.Add(fldSearchPatient);
            tabPatients.Controls.Add(label5);
            tabPatients.Controls.Add(gridPatients);
            tabPatients.Controls.Add(label4);
            tabPatients.Controls.Add(label3);
            tabPatients.Location = new System.Drawing.Point(4, 29);
            tabPatients.Margin = new Padding(3, 4, 3, 4);
            tabPatients.Name = "tabPatients";
            tabPatients.Size = new System.Drawing.Size(1252, 927);
            tabPatients.TabIndex = 2;
            tabPatients.Text = "Patients";
            tabPatients.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(fldPatientCity);
            panel1.Controls.Add(labelCity);
            panel1.Controls.Add(fldParientHeight);
            panel1.Controls.Add(labelPatientHeight);
            panel1.Controls.Add(fldPatientAge);
            panel1.Controls.Add(labelAge);
            panel1.Controls.Add(fldPatientName);
            panel1.Controls.Add(btnAddPatient);
            panel1.Controls.Add(fldPatientSurname);
            panel1.Controls.Add(labelPatientName);
            panel1.Controls.Add(labelPatienSurname);
            panel1.Location = new System.Drawing.Point(930, 97);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(307, 526);
            panel1.TabIndex = 11;
            // 
            // fldPatientCity
            // 
            fldPatientCity.Location = new System.Drawing.Point(112, 228);
            fldPatientCity.Name = "fldPatientCity";
            fldPatientCity.Size = new System.Drawing.Size(191, 27);
            fldPatientCity.TabIndex = 13;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new System.Drawing.Point(13, 205);
            labelCity.Name = "labelCity";
            labelCity.Size = new System.Drawing.Size(155, 20);
            labelCity.TabIndex = 12;
            labelCity.Text = "Dzīvo (Pilsēta, adrese)";
            // 
            // fldParientHeight
            // 
            fldParientHeight.Location = new System.Drawing.Point(112, 162);
            fldParientHeight.Name = "fldParientHeight";
            fldParientHeight.Size = new System.Drawing.Size(191, 27);
            fldParientHeight.TabIndex = 13;
            // 
            // labelPatientHeight
            // 
            labelPatientHeight.AutoSize = true;
            labelPatientHeight.Location = new System.Drawing.Point(13, 165);
            labelPatientHeight.Name = "labelPatientHeight";
            labelPatientHeight.Size = new System.Drawing.Size(90, 20);
            labelPatientHeight.TabIndex = 12;
            labelPatientHeight.Text = "Augums (m)";
            // 
            // fldPatientAge
            // 
            fldPatientAge.Location = new System.Drawing.Point(112, 119);
            fldPatientAge.Name = "fldPatientAge";
            fldPatientAge.Size = new System.Drawing.Size(191, 27);
            fldPatientAge.TabIndex = 12;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new System.Drawing.Point(13, 122);
            labelAge.Name = "labelAge";
            labelAge.Size = new System.Drawing.Size(103, 20);
            labelAge.TabIndex = 11;
            labelAge.Text = "Gadi (vecums)";
            // 
            // fldPatientName
            // 
            fldPatientName.Location = new System.Drawing.Point(112, 27);
            fldPatientName.Name = "fldPatientName";
            fldPatientName.Size = new System.Drawing.Size(191, 27);
            fldPatientName.TabIndex = 8;
            // 
            // btnAddPatient
            // 
            btnAddPatient.Location = new System.Drawing.Point(13, 299);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new System.Drawing.Size(94, 29);
            btnAddPatient.TabIndex = 6;
            btnAddPatient.Text = "Add";
            btnAddPatient.UseVisualStyleBackColor = true;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // fldPatientSurname
            // 
            fldPatientSurname.Location = new System.Drawing.Point(112, 73);
            fldPatientSurname.Name = "fldPatientSurname";
            fldPatientSurname.Size = new System.Drawing.Size(191, 27);
            fldPatientSurname.TabIndex = 10;
            // 
            // labelPatientName
            // 
            labelPatientName.AutoSize = true;
            labelPatientName.Location = new System.Drawing.Point(13, 30);
            labelPatientName.Name = "labelPatientName";
            labelPatientName.Size = new System.Drawing.Size(45, 20);
            labelPatientName.TabIndex = 7;
            labelPatientName.Text = "Vārds";
            // 
            // labelPatienSurname
            // 
            labelPatienSurname.AutoSize = true;
            labelPatienSurname.Location = new System.Drawing.Point(13, 76);
            labelPatienSurname.Name = "labelPatienSurname";
            labelPatienSurname.Size = new System.Drawing.Size(61, 20);
            labelPatienSurname.TabIndex = 9;
            labelPatienSurname.Text = "Uzvards";
            // 
            // fldSearchPatient
            // 
            fldSearchPatient.Location = new System.Drawing.Point(255, 31);
            fldSearchPatient.Name = "fldSearchPatient";
            fldSearchPatient.Size = new System.Drawing.Size(319, 27);
            fldSearchPatient.TabIndex = 5;
            fldSearchPatient.TextChanged += fldSearchPatient_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            label5.Location = new System.Drawing.Point(46, 26);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(170, 32);
            label5.TabIndex = 4;
            label5.Text = "Pacienta izvēle";
            // 
            // gridPatients
            // 
            gridPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPatients.Location = new System.Drawing.Point(57, 97);
            gridPatients.Name = "gridPatients";
            gridPatients.RowHeadersWidth = 51;
            gridPatients.Size = new System.Drawing.Size(854, 526);
            gridPatients.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(109, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 46);
            label4.TabIndex = 2;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(509, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 46);
            label3.TabIndex = 0;
            label3.Click += label3_Click;
            // 
            // tabVisits
            // 
            tabVisits.Controls.Add(labelVisitFormPatientAge);
            tabVisits.Controls.Add(labelVisitFormPatientName);
            tabVisits.Controls.Add(fldNakosaKolposkKontrole);
            tabVisits.Controls.Add(lbNakosaKolposkopijasKontrole);
            tabVisits.Controls.Add(gbVizitePirmreizAtkartota);
            tabVisits.Controls.Add(cbM3);
            tabVisits.Controls.Add(cbM2);
            tabVisits.Controls.Add(cbM1);
            tabVisits.Controls.Add(fldRezultati);
            tabVisits.Controls.Add(lbRezultati);
            tabVisits.Controls.Add(fldVizitesAtkartojums);
            tabVisits.Controls.Add(lbVizitesAtkartojums);
            tabVisits.Controls.Add(fldSledziens);
            tabVisits.Controls.Add(lbSledziens);
            tabVisits.Controls.Add(cbAlergijas);
            tabVisits.Controls.Add(cbP5);
            tabVisits.Controls.Add(cbP4);
            tabVisits.Controls.Add(cbP3);
            tabVisits.Controls.Add(cbP2);
            tabVisits.Controls.Add(cbP1);
            tabVisits.Controls.Add(btnVisitSave);
            tabVisits.Controls.Add(lbP5Text);
            tabVisits.Controls.Add(lbP4Text);
            tabVisits.Controls.Add(lbP3Text);
            tabVisits.Controls.Add(lbP2Text);
            tabVisits.Controls.Add(lbP1Text);
            tabVisits.Controls.Add(fldTrnsformacijasZonasTips);
            tabVisits.Controls.Add(tbKolposkopijaAdekvata);
            tabVisits.Controls.Add(fldIeprkshVeiktaTerapija);
            tabVisits.Controls.Add(fldIzmeklejumaDatums);
            tabVisits.Controls.Add(fldIzmeklejumaNr);
            tabVisits.Controls.Add(fldSkriningaNummurs);
            tabVisits.Controls.Add(fldPedejaCitologija);
            tabVisits.Controls.Add(fldAnamneze);
            tabVisits.Controls.Add(lbPacientsVecums);
            tabVisits.Controls.Add(lbTransformacijasZonasTips);
            tabVisits.Controls.Add(lbKolposkopijaAdekvata);
            tabVisits.Controls.Add(lbIepriekshVeiktaaTerapija);
            tabVisits.Controls.Add(lbPedejaCitologija);
            tabVisits.Controls.Add(lbAnamneze);
            tabVisits.Controls.Add(lbSkriningaNummurs);
            tabVisits.Controls.Add(lbPatientName);
            tabVisits.Controls.Add(lbIzmeklejumaDatums);
            tabVisits.Controls.Add(lbIzmeklejumaNr);
            tabVisits.Controls.Add(lbHeaderVisit);
            tabVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabVisits.Location = new System.Drawing.Point(4, 29);
            tabVisits.Margin = new Padding(3, 4, 3, 4);
            tabVisits.Name = "tabVisits";
            tabVisits.Padding = new Padding(3, 4, 3, 4);
            tabVisits.RightToLeft = RightToLeft.Yes;
            tabVisits.Size = new System.Drawing.Size(1252, 927);
            tabVisits.TabIndex = 0;
            tabVisits.Text = "Visits";
            tabVisits.UseVisualStyleBackColor = true;
            // 
            // fldNakosaKolposkKontrole
            // 
            fldNakosaKolposkKontrole.Location = new System.Drawing.Point(869, 652);
            fldNakosaKolposkKontrole.Name = "fldNakosaKolposkKontrole";
            fldNakosaKolposkKontrole.Size = new System.Drawing.Size(344, 30);
            fldNakosaKolposkKontrole.TabIndex = 60;
            // 
            // lbNakosaKolposkopijasKontrole
            // 
            lbNakosaKolposkopijasKontrole.AutoSize = true;
            lbNakosaKolposkopijasKontrole.Location = new System.Drawing.Point(540, 652);
            lbNakosaKolposkopijasKontrole.Name = "lbNakosaKolposkopijasKontrole";
            lbNakosaKolposkopijasKontrole.Size = new System.Drawing.Size(284, 25);
            lbNakosaKolposkopijasKontrole.TabIndex = 59;
            lbNakosaKolposkopijasKontrole.Text = "Nakošā Kolposkopijas Kontrole";
            // 
            // gbVizitePirmreizAtkartota
            // 
            gbVizitePirmreizAtkartota.Controls.Add(rbViziteAtkartota);
            gbVizitePirmreizAtkartota.Controls.Add(rbVizitePirmreizeja);
            gbVizitePirmreizAtkartota.Location = new System.Drawing.Point(605, 162);
            gbVizitePirmreizAtkartota.Name = "gbVizitePirmreizAtkartota";
            gbVizitePirmreizAtkartota.RightToLeft = RightToLeft.No;
            gbVizitePirmreizAtkartota.Size = new System.Drawing.Size(409, 28);
            gbVizitePirmreizAtkartota.TabIndex = 58;
            gbVizitePirmreizAtkartota.TabStop = false;
            gbVizitePirmreizAtkartota.Text = "Vizīte";
            // 
            // rbViziteAtkartota
            // 
            rbViziteAtkartota.AutoSize = true;
            rbViziteAtkartota.Location = new System.Drawing.Point(225, 1);
            rbViziteAtkartota.Name = "rbViziteAtkartota";
            rbViziteAtkartota.Size = new System.Drawing.Size(111, 29);
            rbViziteAtkartota.TabIndex = 1;
            rbViziteAtkartota.TabStop = true;
            rbViziteAtkartota.Text = "Atkārtota";
            rbViziteAtkartota.UseVisualStyleBackColor = true;
            rbViziteAtkartota.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbVizitePirmreizeja
            // 
            rbVizitePirmreizeja.AutoSize = true;
            rbVizitePirmreizeja.Location = new System.Drawing.Point(76, 1);
            rbVizitePirmreizeja.Name = "rbVizitePirmreizeja";
            rbVizitePirmreizeja.Size = new System.Drawing.Size(129, 29);
            rbVizitePirmreizeja.TabIndex = 0;
            rbVizitePirmreizeja.TabStop = true;
            rbVizitePirmreizeja.Text = "Pirmreizēja";
            rbVizitePirmreizeja.UseVisualStyleBackColor = true;
            // 
            // cbM3
            // 
            cbM3.AutoSize = true;
            cbM3.Location = new System.Drawing.Point(22, 870);
            cbM3.Name = "cbM3";
            cbM3.RightToLeft = RightToLeft.No;
            cbM3.Size = new System.Drawing.Size(160, 29);
            cbM3.TabIndex = 56;
            cbM3.Text = "Mērķa biopsija";
            cbM3.UseVisualStyleBackColor = true;
            // 
            // cbM2
            // 
            cbM2.AutoSize = true;
            cbM2.Location = new System.Drawing.Point(22, 847);
            cbM2.Name = "cbM2";
            cbM2.RightToLeft = RightToLeft.No;
            cbM2.Size = new System.Drawing.Size(121, 29);
            cbM2.TabIndex = 55;
            cbM2.Text = "HPV tests";
            cbM2.UseVisualStyleBackColor = true;
            // 
            // cbM1
            // 
            cbM1.AutoSize = true;
            cbM1.FlatStyle = FlatStyle.Popup;
            cbM1.Location = new System.Drawing.Point(22, 824);
            cbM1.Name = "cbM1";
            cbM1.RightToLeft = RightToLeft.No;
            cbM1.Size = new System.Drawing.Size(272, 29);
            cbM1.TabIndex = 54;
            cbM1.Text = "Atkārtota citoloģiskā analīze";
            cbM1.UseVisualStyleBackColor = true;
            // 
            // fldRezultati
            // 
            fldRezultati.Location = new System.Drawing.Point(243, 521);
            fldRezultati.Name = "fldRezultati";
            fldRezultati.Size = new System.Drawing.Size(970, 40);
            fldRezultati.TabIndex = 53;
            fldRezultati.Text = "";
            // 
            // lbRezultati
            // 
            lbRezultati.AutoSize = true;
            lbRezultati.Location = new System.Drawing.Point(33, 521);
            lbRezultati.Name = "lbRezultati";
            lbRezultati.Size = new System.Drawing.Size(86, 25);
            lbRezultati.TabIndex = 52;
            lbRezultati.Text = "Rezultāti";
            // 
            // fldVizitesAtkartojums
            // 
            fldVizitesAtkartojums.Location = new System.Drawing.Point(830, 611);
            fldVizitesAtkartojums.Name = "fldVizitesAtkartojums";
            fldVizitesAtkartojums.Size = new System.Drawing.Size(387, 30);
            fldVizitesAtkartojums.TabIndex = 51;
            // 
            // lbVizitesAtkartojums
            // 
            lbVizitesAtkartojums.AutoSize = true;
            lbVizitesAtkartojums.Location = new System.Drawing.Point(540, 611);
            lbVizitesAtkartojums.Name = "lbVizitesAtkartojums";
            lbVizitesAtkartojums.Size = new System.Drawing.Size(178, 25);
            lbVizitesAtkartojums.TabIndex = 50;
            lbVizitesAtkartojums.Text = "Vizites Atkartojums";
            // 
            // fldSledziens
            // 
            fldSledziens.Location = new System.Drawing.Point(243, 465);
            fldSledziens.Name = "fldSledziens";
            fldSledziens.Size = new System.Drawing.Size(970, 40);
            fldSledziens.TabIndex = 49;
            fldSledziens.Text = "";
            // 
            // lbSledziens
            // 
            lbSledziens.AutoSize = true;
            lbSledziens.Location = new System.Drawing.Point(33, 465);
            lbSledziens.Name = "lbSledziens";
            lbSledziens.Size = new System.Drawing.Size(98, 25);
            lbSledziens.TabIndex = 48;
            lbSledziens.Text = "Slēdziens";
            // 
            // cbAlergijas
            // 
            cbAlergijas.AutoSize = true;
            cbAlergijas.Location = new System.Drawing.Point(540, 575);
            cbAlergijas.Name = "cbAlergijas";
            cbAlergijas.Size = new System.Drawing.Size(109, 29);
            cbAlergijas.TabIndex = 47;
            cbAlergijas.Text = "Alergijas";
            cbAlergijas.UseVisualStyleBackColor = true;
            // 
            // cbP5
            // 
            cbP5.AutoSize = true;
            cbP5.Location = new System.Drawing.Point(25, 789);
            cbP5.Name = "cbP5";
            cbP5.RightToLeft = RightToLeft.No;
            cbP5.Size = new System.Drawing.Size(58, 29);
            cbP5.TabIndex = 46;
            cbP5.Text = "P5";
            cbP5.UseVisualStyleBackColor = true;
            // 
            // cbP4
            // 
            cbP4.AutoSize = true;
            cbP4.Location = new System.Drawing.Point(25, 769);
            cbP4.Name = "cbP4";
            cbP4.RightToLeft = RightToLeft.No;
            cbP4.Size = new System.Drawing.Size(58, 29);
            cbP4.TabIndex = 45;
            cbP4.Text = "P4";
            cbP4.UseVisualStyleBackColor = true;
            // 
            // cbP3
            // 
            cbP3.AutoSize = true;
            cbP3.Location = new System.Drawing.Point(25, 745);
            cbP3.Name = "cbP3";
            cbP3.RightToLeft = RightToLeft.No;
            cbP3.Size = new System.Drawing.Size(58, 29);
            cbP3.TabIndex = 44;
            cbP3.Text = "P3";
            cbP3.UseVisualStyleBackColor = true;
            // 
            // cbP2
            // 
            cbP2.AutoSize = true;
            cbP2.Location = new System.Drawing.Point(28, 721);
            cbP2.Name = "cbP2";
            cbP2.RightToLeft = RightToLeft.No;
            cbP2.Size = new System.Drawing.Size(58, 29);
            cbP2.TabIndex = 43;
            cbP2.Text = "P2";
            cbP2.UseVisualStyleBackColor = true;
            // 
            // cbP1
            // 
            cbP1.AutoSize = true;
            cbP1.FlatStyle = FlatStyle.Popup;
            cbP1.Location = new System.Drawing.Point(28, 699);
            cbP1.Name = "cbP1";
            cbP1.RightToLeft = RightToLeft.No;
            cbP1.Size = new System.Drawing.Size(55, 29);
            cbP1.TabIndex = 42;
            cbP1.Text = "P1";
            cbP1.UseVisualStyleBackColor = true;
            // 
            // btnVisitSave
            // 
            btnVisitSave.Location = new System.Drawing.Point(994, 32);
            btnVisitSave.Name = "btnVisitSave";
            btnVisitSave.Size = new System.Drawing.Size(122, 46);
            btnVisitSave.TabIndex = 41;
            btnVisitSave.Text = "Saglabāt";
            btnVisitSave.UseVisualStyleBackColor = true;
            btnVisitSave.Click += btnVisitSave_Click;
            // 
            // lbP5Text
            // 
            lbP5Text.AutoSize = true;
            lbP5Text.Location = new System.Drawing.Point(289, 794);
            lbP5Text.Name = "lbP5Text";
            lbP5Text.RightToLeft = RightToLeft.No;
            lbP5Text.Size = new System.Drawing.Size(425, 25);
            lbP5Text.TabIndex = 40;
            lbP5Text.Text = "P5 Text                                                                     ";
            // 
            // lbP4Text
            // 
            lbP4Text.AutoSize = true;
            lbP4Text.Location = new System.Drawing.Point(288, 769);
            lbP4Text.Name = "lbP4Text";
            lbP4Text.RightToLeft = RightToLeft.No;
            lbP4Text.Size = new System.Drawing.Size(400, 25);
            lbP4Text.TabIndex = 39;
            lbP4Text.Text = "P4 Text                                                                ";
            // 
            // lbP3Text
            // 
            lbP3Text.AutoSize = true;
            lbP3Text.Location = new System.Drawing.Point(288, 745);
            lbP3Text.Name = "lbP3Text";
            lbP3Text.RightToLeft = RightToLeft.No;
            lbP3Text.Size = new System.Drawing.Size(425, 25);
            lbP3Text.TabIndex = 38;
            lbP3Text.Text = "P3 Text                                                                     ";
            // 
            // lbP2Text
            // 
            lbP2Text.AutoSize = true;
            lbP2Text.Location = new System.Drawing.Point(288, 722);
            lbP2Text.Name = "lbP2Text";
            lbP2Text.RightToLeft = RightToLeft.No;
            lbP2Text.Size = new System.Drawing.Size(405, 25);
            lbP2Text.TabIndex = 37;
            lbP2Text.Text = "P2 Text                                                                 ";
            // 
            // lbP1Text
            // 
            lbP1Text.AutoSize = true;
            lbP1Text.Location = new System.Drawing.Point(289, 703);
            lbP1Text.Name = "lbP1Text";
            lbP1Text.RightToLeft = RightToLeft.No;
            lbP1Text.Size = new System.Drawing.Size(400, 25);
            lbP1Text.TabIndex = 28;
            lbP1Text.Text = "P1 Text                                                                ";
            // 
            // fldTrnsformacijasZonasTips
            // 
            fldTrnsformacijasZonasTips.Location = new System.Drawing.Point(293, 616);
            fldTrnsformacijasZonasTips.Name = "fldTrnsformacijasZonasTips";
            fldTrnsformacijasZonasTips.Size = new System.Drawing.Size(199, 30);
            fldTrnsformacijasZonasTips.TabIndex = 26;
            // 
            // tbKolposkopijaAdekvata
            // 
            tbKolposkopijaAdekvata.Location = new System.Drawing.Point(243, 576);
            tbKolposkopijaAdekvata.Name = "tbKolposkopijaAdekvata";
            tbKolposkopijaAdekvata.Size = new System.Drawing.Size(198, 30);
            tbKolposkopijaAdekvata.TabIndex = 25;
            tbKolposkopijaAdekvata.Text = "Adekvāta";
            // 
            // fldIeprkshVeiktaTerapija
            // 
            fldIeprkshVeiktaTerapija.Location = new System.Drawing.Point(243, 406);
            fldIeprkshVeiktaTerapija.Name = "fldIeprkshVeiktaTerapija";
            fldIeprkshVeiktaTerapija.Size = new System.Drawing.Size(970, 40);
            fldIeprkshVeiktaTerapija.TabIndex = 20;
            fldIeprkshVeiktaTerapija.Text = "";
            // 
            // fldIzmeklejumaDatums
            // 
            fldIzmeklejumaDatums.Location = new System.Drawing.Point(227, 160);
            fldIzmeklejumaDatums.Name = "fldIzmeklejumaDatums";
            fldIzmeklejumaDatums.Size = new System.Drawing.Size(344, 30);
            fldIzmeklejumaDatums.TabIndex = 19;
            // 
            // fldIzmeklejumaNr
            // 
            fldIzmeklejumaNr.Location = new System.Drawing.Point(227, 119);
            fldIzmeklejumaNr.Name = "fldIzmeklejumaNr";
            fldIzmeklejumaNr.Size = new System.Drawing.Size(237, 30);
            fldIzmeklejumaNr.TabIndex = 18;
            // 
            // fldSkriningaNummurs
            // 
            fldSkriningaNummurs.Location = new System.Drawing.Point(803, 119);
            fldSkriningaNummurs.Name = "fldSkriningaNummurs";
            fldSkriningaNummurs.Size = new System.Drawing.Size(211, 30);
            fldSkriningaNummurs.TabIndex = 17;
            // 
            // fldPedejaCitologija
            // 
            fldPedejaCitologija.Location = new System.Drawing.Point(243, 341);
            fldPedejaCitologija.Name = "fldPedejaCitologija";
            fldPedejaCitologija.Size = new System.Drawing.Size(965, 46);
            fldPedejaCitologija.TabIndex = 16;
            fldPedejaCitologija.Text = "";
            // 
            // fldAnamneze
            // 
            fldAnamneze.Location = new System.Drawing.Point(243, 280);
            fldAnamneze.Name = "fldAnamneze";
            fldAnamneze.Size = new System.Drawing.Size(965, 42);
            fldAnamneze.TabIndex = 15;
            fldAnamneze.Text = "";
            // 
            // lbPacientsVecums
            // 
            lbPacientsVecums.AutoSize = true;
            lbPacientsVecums.Location = new System.Drawing.Point(629, 227);
            lbPacientsVecums.Name = "lbPacientsVecums";
            lbPacientsVecums.Size = new System.Drawing.Size(84, 25);
            lbPacientsVecums.TabIndex = 14;
            lbPacientsVecums.Text = "Vecums";
            lbPacientsVecums.Click += label6_Click;
            // 
            // lbTransformacijasZonasTips
            // 
            lbTransformacijasZonasTips.AutoSize = true;
            lbTransformacijasZonasTips.FlatStyle = FlatStyle.Flat;
            lbTransformacijasZonasTips.Location = new System.Drawing.Point(33, 616);
            lbTransformacijasZonasTips.Name = "lbTransformacijasZonasTips";
            lbTransformacijasZonasTips.Size = new System.Drawing.Size(254, 25);
            lbTransformacijasZonasTips.TabIndex = 13;
            lbTransformacijasZonasTips.Text = "Transformācijas Zonas Tips";
            // 
            // lbKolposkopijaAdekvata
            // 
            lbKolposkopijaAdekvata.AutoSize = true;
            lbKolposkopijaAdekvata.Location = new System.Drawing.Point(33, 579);
            lbKolposkopijaAdekvata.Name = "lbKolposkopijaAdekvata";
            lbKolposkopijaAdekvata.Size = new System.Drawing.Size(124, 25);
            lbKolposkopijaAdekvata.TabIndex = 12;
            lbKolposkopijaAdekvata.Text = "Kolposkopija";
            // 
            // lbIepriekshVeiktaaTerapija
            // 
            lbIepriekshVeiktaaTerapija.AutoSize = true;
            lbIepriekshVeiktaaTerapija.Location = new System.Drawing.Point(33, 406);
            lbIepriekshVeiktaaTerapija.Name = "lbIepriekshVeiktaaTerapija";
            lbIepriekshVeiktaaTerapija.Size = new System.Drawing.Size(204, 25);
            lbIepriekshVeiktaaTerapija.TabIndex = 10;
            lbIepriekshVeiktaaTerapija.Text = "Iepriekš veiktā terapija";
            // 
            // lbPedejaCitologija
            // 
            lbPedejaCitologija.AutoSize = true;
            lbPedejaCitologija.Location = new System.Drawing.Point(33, 343);
            lbPedejaCitologija.Name = "lbPedejaCitologija";
            lbPedejaCitologija.Size = new System.Drawing.Size(153, 25);
            lbPedejaCitologija.TabIndex = 9;
            lbPedejaCitologija.Text = "Pēdējā citoloģija";
            // 
            // lbAnamneze
            // 
            lbAnamneze.AutoSize = true;
            lbAnamneze.Location = new System.Drawing.Point(33, 280);
            lbAnamneze.Name = "lbAnamneze";
            lbAnamneze.Size = new System.Drawing.Size(107, 25);
            lbAnamneze.TabIndex = 6;
            lbAnamneze.Text = "Anamnēze";
            // 
            // lbSkriningaNummurs
            // 
            lbSkriningaNummurs.AutoSize = true;
            lbSkriningaNummurs.Location = new System.Drawing.Point(600, 119);
            lbSkriningaNummurs.Name = "lbSkriningaNummurs";
            lbSkriningaNummurs.Size = new System.Drawing.Size(183, 25);
            lbSkriningaNummurs.TabIndex = 5;
            lbSkriningaNummurs.Text = "Skrīninga Nummurs";
            // 
            // lbPatientName
            // 
            lbPatientName.AutoSize = true;
            lbPatientName.Location = new System.Drawing.Point(33, 227);
            lbPatientName.Name = "lbPatientName";
            lbPatientName.Size = new System.Drawing.Size(87, 25);
            lbPatientName.TabIndex = 3;
            lbPatientName.Text = "Pacients";
            // 
            // lbIzmeklejumaDatums
            // 
            lbIzmeklejumaDatums.AutoSize = true;
            lbIzmeklejumaDatums.Location = new System.Drawing.Point(28, 160);
            lbIzmeklejumaDatums.Name = "lbIzmeklejumaDatums";
            lbIzmeklejumaDatums.Size = new System.Drawing.Size(190, 25);
            lbIzmeklejumaDatums.TabIndex = 2;
            lbIzmeklejumaDatums.Text = "Izmeklējuma datums";
            // 
            // lbIzmeklejumaNr
            // 
            lbIzmeklejumaNr.AutoSize = true;
            lbIzmeklejumaNr.Location = new System.Drawing.Point(28, 119);
            lbIzmeklejumaNr.Name = "lbIzmeklejumaNr";
            lbIzmeklejumaNr.Size = new System.Drawing.Size(151, 25);
            lbIzmeklejumaNr.TabIndex = 1;
            lbIzmeklejumaNr.Text = "Izmeklejuma Nr.";
            // 
            // lbHeaderVisit
            // 
            lbHeaderVisit.AutoSize = true;
            lbHeaderVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbHeaderVisit.Location = new System.Drawing.Point(446, 13);
            lbHeaderVisit.Name = "lbHeaderVisit";
            lbHeaderVisit.Size = new System.Drawing.Size(378, 46);
            lbHeaderVisit.TabIndex = 0;
            lbHeaderVisit.Text = "Kolposkopijas Vizīte";
            lbHeaderVisit.Click += label1_Click;
            // 
            // tabImages
            // 
            tabImages.Controls.Add(btnRefreshImages);
            tabImages.Controls.Add(flowLayoutPanel1);
            tabImages.Controls.Add(label2);
            tabImages.Location = new System.Drawing.Point(4, 29);
            tabImages.Margin = new Padding(3, 4, 3, 4);
            tabImages.Name = "tabImages";
            tabImages.Padding = new Padding(3, 4, 3, 4);
            tabImages.Size = new System.Drawing.Size(1252, 927);
            tabImages.TabIndex = 1;
            tabImages.Text = "Images";
            tabImages.UseVisualStyleBackColor = true;
            // 
            // btnRefreshImages
            // 
            btnRefreshImages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRefreshImages.Location = new System.Drawing.Point(482, 18);
            btnRefreshImages.Name = "btnRefreshImages";
            btnRefreshImages.Size = new System.Drawing.Size(133, 51);
            btnRefreshImages.TabIndex = 2;
            btnRefreshImages.Text = "Refresh";
            btnRefreshImages.UseVisualStyleBackColor = true;
            btnRefreshImages.Click += btnRefreshImages_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new System.Drawing.Point(25, 90);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(590, 802);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(20, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(282, 29);
            label2.TabIndex = 0;
            label2.Text = "Kolposkopijas uzņēmumi";
            // 
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new System.Drawing.Size(1252, 927);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // cVisitBindingSource
            // 
            cVisitBindingSource.DataSource = typeof(VisioForge_SDK_Video_Capture_Demo.Models.CVisit);
            // 
            // labelVisitFormPatientName
            // 
            labelVisitFormPatientName.AutoSize = true;
            labelVisitFormPatientName.Location = new System.Drawing.Point(242, 227);
            labelVisitFormPatientName.Name = "labelVisitFormPatientName";
            labelVisitFormPatientName.Size = new System.Drawing.Size(177, 25);
            labelVisitFormPatientName.TabIndex = 61;
            labelVisitFormPatientName.Text = "value to be present";
            // 
            // labelVisitFormPatientAge
            // 
            labelVisitFormPatientAge.AutoSize = true;
            labelVisitFormPatientAge.Location = new System.Drawing.Point(746, 227);
            labelVisitFormPatientAge.Name = "labelVisitFormPatientAge";
            labelVisitFormPatientAge.Size = new System.Drawing.Size(177, 25);
            labelVisitFormPatientAge.TabIndex = 62;
            labelVisitFormPatientAge.Text = "value to be present";
            // 
            // VisitsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1284, 1006);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VisitsForm";
            Text = "VisitsForm";
            Load += VisitsForm_Load_1;
            tabControl1.ResumeLayout(false);
            tabPatients.ResumeLayout(false);
            tabPatients.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPatients).EndInit();
            tabVisits.ResumeLayout(false);
            tabVisits.PerformLayout();
            gbVizitePirmreizAtkartota.ResumeLayout(false);
            gbVizitePirmreizAtkartota.PerformLayout();
            tabImages.ResumeLayout(false);
            tabImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cVisitBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVisits;
        private System.Windows.Forms.TabPage tabImages;
        private System.Windows.Forms.Label lbHeaderVisit;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tabPage4;
        private Label label5;
        private DataGridView gridPatients;
        private TabPage tabPage3;
        private Button btnRefreshImages;
        private Label lbPatientName;
        private Label lbIzmeklejumaDatums;
        private Label lbIzmeklejumaNr;
        private Label lbIepriekshVeiktaaTerapija;
        private Label lbPedejaCitologija;
        private Label lbAnamneze;
        private Label lbSkriningaNummurs;
        private Label lbTransformacijasZonasTips;
        private Label lbKolposkopijaAdekvata;
        private Label lbPacientsVecums;
        private RichTextBox fldAnamneze;
        private DateTimePicker fldIzmeklejumaDatums;
        private TextBox fldIzmeklejumaNr;
        private TextBox fldSkriningaNummurs;
        private RichTextBox fldPedejaCitologija;
        private RichTextBox fldIeprkshVeiktaTerapija;
        private TextBox tbKolposkopijaAdekvata;
        private TextBox fldTrnsformacijasZonasTips;
        private Label lbSledziens;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label lbP1Text;
        private Label lbP5Text;
        private Label lbP4Text;
        private Label lbP3Text;
        private Label lbP2Text;
        private Button btnVisitSave;
        private BindingSource cVisitBindingSource;
        private CheckBox cbP5;
        private CheckBox cbP4;
        private CheckBox cbP3;
        private CheckBox cbP2;
        private CheckBox cbP1;
        private CheckBox cbAlergijas;
        private RichTextBox fldSledziens;
        private TextBox fldVizitesAtkartojums;
        private Label lbVizitesAtkartojums;
        private RichTextBox fldRezultati;
        private Label lbRezultati;
        private CheckBox cbM3;
        private CheckBox cbM2;
        private CheckBox cbM1;
        private GroupBox gbVizitePirmreizAtkartota;
        private RadioButton rbViziteAtkartota;
        private RadioButton rbVizitePirmreizeja;
        private DateTimePicker fldNakosaKolposkKontrole;
        private Label lbNakosaKolposkopijasKontrole;
        private TextBox fldSearchPatient;
        private Button btnAddPatient;
        private TextBox fldPatientName;
        private Label labelPatientName;
        private Panel panel1;
        private TextBox fldPatientSurname;
        private Label labelPatienSurname;
        private TextBox fldPatientCity;
        private Label labelCity;
        private TextBox fldParientHeight;
        private Label labelPatientHeight;
        private TextBox fldPatientAge;
        private Label labelAge;
        private Label labelVisitFormPatientName;
        private Label labelVisitFormPatientAge;
    }
}