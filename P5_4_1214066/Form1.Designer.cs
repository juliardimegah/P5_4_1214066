namespace P5_4_1214066
{
    partial class FormPendaftaran
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
            this.Judul = new System.Windows.Forms.Label();
            this.LabelNama = new System.Windows.Forms.Label();
            this.LabelGender = new System.Windows.Forms.Label();
            this.LabelLahir = new System.Windows.Forms.Label();
            this.textnama = new System.Windows.Forms.TextBox();
            this.PilihGender = new System.Windows.Forms.ComboBox();
            this.TanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.Opsimapel = new System.Windows.Forms.GroupBox();
            this.OpsiJadwal = new System.Windows.Forms.GroupBox();
            this.CheckBoxBiola = new System.Windows.Forms.CheckBox();
            this.CheckBoxGitar = new System.Windows.Forms.CheckBox();
            this.CheckBoxSaxophone = new System.Windows.Forms.CheckBox();
            this.CheckBoxKonduktor = new System.Windows.Forms.CheckBox();
            this.CheckBoxPiano = new System.Windows.Forms.CheckBox();
            this.CheckBoxDrum = new System.Windows.Forms.CheckBox();
            this.CheckBoxVokal = new System.Windows.Forms.CheckBox();
            this.CheckBoxKomposer = new System.Windows.Forms.CheckBox();
            this.Jadwal1 = new System.Windows.Forms.RadioButton();
            this.Jadwal2 = new System.Windows.Forms.RadioButton();
            this.Jadwal3 = new System.Windows.Forms.RadioButton();
            this.Jadwal4 = new System.Windows.Forms.RadioButton();
            this.Tampilkan = new System.Windows.Forms.Button();
            this.Selesai = new System.Windows.Forms.Button();
            this.Opsimapel.SuspendLayout();
            this.OpsiJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Font = new System.Drawing.Font("Trebuchet MS", 40F);
            this.Judul.Location = new System.Drawing.Point(65, 18);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(670, 67);
            this.Judul.TabIndex = 0;
            this.Judul.Text = "Pendaftaran Sekolah Musik";
            this.Judul.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelNama
            // 
            this.LabelNama.AutoSize = true;
            this.LabelNama.Location = new System.Drawing.Point(243, 113);
            this.LabelNama.Name = "LabelNama";
            this.LabelNama.Size = new System.Drawing.Size(35, 13);
            this.LabelNama.TabIndex = 1;
            this.LabelNama.Text = "Nama";
            // 
            // LabelGender
            // 
            this.LabelGender.AutoSize = true;
            this.LabelGender.Location = new System.Drawing.Point(243, 144);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(71, 13);
            this.LabelGender.TabIndex = 2;
            this.LabelGender.Text = "Jenis Kelamin";
            // 
            // LabelLahir
            // 
            this.LabelLahir.AutoSize = true;
            this.LabelLahir.Location = new System.Drawing.Point(243, 174);
            this.LabelLahir.Name = "LabelLahir";
            this.LabelLahir.Size = new System.Drawing.Size(72, 13);
            this.LabelLahir.TabIndex = 3;
            this.LabelLahir.Text = "Tanggal Lahir";
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(357, 113);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(200, 20);
            this.textnama.TabIndex = 4;
            this.textnama.TextChanged += new System.EventHandler(this.textnama_TextChanged);
            // 
            // PilihGender
            // 
            this.PilihGender.FormattingEnabled = true;
            this.PilihGender.Items.AddRange(new object[] {
            "Laki Laki",
            "Perempuan"});
            this.PilihGender.Location = new System.Drawing.Point(357, 144);
            this.PilihGender.Name = "PilihGender";
            this.PilihGender.Size = new System.Drawing.Size(200, 21);
            this.PilihGender.TabIndex = 5;
            this.PilihGender.Text = "----------- Pilih Jenis Kelamin ----------";
            this.PilihGender.SelectedIndexChanged += new System.EventHandler(this.PilihGender_SelectedIndexChanged);
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.Location = new System.Drawing.Point(357, 174);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(200, 20);
            this.TanggalLahir.TabIndex = 6;
            this.TanggalLahir.ValueChanged += new System.EventHandler(this.TanggalLahir_ValueChanged);
            // 
            // Opsimapel
            // 
            this.Opsimapel.Controls.Add(this.CheckBoxKomposer);
            this.Opsimapel.Controls.Add(this.CheckBoxVokal);
            this.Opsimapel.Controls.Add(this.CheckBoxDrum);
            this.Opsimapel.Controls.Add(this.CheckBoxPiano);
            this.Opsimapel.Controls.Add(this.CheckBoxKonduktor);
            this.Opsimapel.Controls.Add(this.CheckBoxSaxophone);
            this.Opsimapel.Controls.Add(this.CheckBoxGitar);
            this.Opsimapel.Controls.Add(this.CheckBoxBiola);
            this.Opsimapel.Location = new System.Drawing.Point(144, 223);
            this.Opsimapel.Name = "Opsimapel";
            this.Opsimapel.Size = new System.Drawing.Size(200, 118);
            this.Opsimapel.TabIndex = 7;
            this.Opsimapel.TabStop = false;
            this.Opsimapel.Text = "Pilih Mata Pelajaran";
            // 
            // OpsiJadwal
            // 
            this.OpsiJadwal.Controls.Add(this.Jadwal4);
            this.OpsiJadwal.Controls.Add(this.Jadwal3);
            this.OpsiJadwal.Controls.Add(this.Jadwal2);
            this.OpsiJadwal.Controls.Add(this.Jadwal1);
            this.OpsiJadwal.Location = new System.Drawing.Point(457, 223);
            this.OpsiJadwal.Name = "OpsiJadwal";
            this.OpsiJadwal.Size = new System.Drawing.Size(200, 118);
            this.OpsiJadwal.TabIndex = 8;
            this.OpsiJadwal.TabStop = false;
            this.OpsiJadwal.Text = "Pilih Jadwal";
            // 
            // CheckBoxBiola
            // 
            this.CheckBoxBiola.AutoSize = true;
            this.CheckBoxBiola.Location = new System.Drawing.Point(6, 19);
            this.CheckBoxBiola.Name = "CheckBoxBiola";
            this.CheckBoxBiola.Size = new System.Drawing.Size(49, 17);
            this.CheckBoxBiola.TabIndex = 9;
            this.CheckBoxBiola.Text = "Biola";
            this.CheckBoxBiola.UseVisualStyleBackColor = true;
            this.CheckBoxBiola.CheckedChanged += new System.EventHandler(this.CheckBoxBiola_CheckedChanged);
            // 
            // CheckBoxGitar
            // 
            this.CheckBoxGitar.AutoSize = true;
            this.CheckBoxGitar.Location = new System.Drawing.Point(6, 42);
            this.CheckBoxGitar.Name = "CheckBoxGitar";
            this.CheckBoxGitar.Size = new System.Drawing.Size(48, 17);
            this.CheckBoxGitar.TabIndex = 10;
            this.CheckBoxGitar.Text = "Gitar";
            this.CheckBoxGitar.UseVisualStyleBackColor = true;
            this.CheckBoxGitar.CheckedChanged += new System.EventHandler(this.CheckBoxGitar_CheckedChanged);
            // 
            // CheckBoxSaxophone
            // 
            this.CheckBoxSaxophone.AutoSize = true;
            this.CheckBoxSaxophone.Location = new System.Drawing.Point(6, 65);
            this.CheckBoxSaxophone.Name = "CheckBoxSaxophone";
            this.CheckBoxSaxophone.Size = new System.Drawing.Size(80, 17);
            this.CheckBoxSaxophone.TabIndex = 11;
            this.CheckBoxSaxophone.Text = "Saxophone";
            this.CheckBoxSaxophone.UseVisualStyleBackColor = true;
            this.CheckBoxSaxophone.CheckedChanged += new System.EventHandler(this.CheckBoxSaxophone_CheckedChanged);
            // 
            // CheckBoxKonduktor
            // 
            this.CheckBoxKonduktor.AutoSize = true;
            this.CheckBoxKonduktor.Location = new System.Drawing.Point(6, 88);
            this.CheckBoxKonduktor.Name = "CheckBoxKonduktor";
            this.CheckBoxKonduktor.Size = new System.Drawing.Size(75, 17);
            this.CheckBoxKonduktor.TabIndex = 12;
            this.CheckBoxKonduktor.Text = "Konduktor";
            this.CheckBoxKonduktor.UseVisualStyleBackColor = true;
            this.CheckBoxKonduktor.CheckedChanged += new System.EventHandler(this.CheckBoxKonduktor_CheckedChanged);
            // 
            // CheckBoxPiano
            // 
            this.CheckBoxPiano.AutoSize = true;
            this.CheckBoxPiano.Location = new System.Drawing.Point(103, 19);
            this.CheckBoxPiano.Name = "CheckBoxPiano";
            this.CheckBoxPiano.Size = new System.Drawing.Size(53, 17);
            this.CheckBoxPiano.TabIndex = 13;
            this.CheckBoxPiano.Text = "Piano";
            this.CheckBoxPiano.UseVisualStyleBackColor = true;
            this.CheckBoxPiano.CheckedChanged += new System.EventHandler(this.CheckBoxPiano_CheckedChanged);
            // 
            // CheckBoxDrum
            // 
            this.CheckBoxDrum.AutoSize = true;
            this.CheckBoxDrum.Location = new System.Drawing.Point(103, 42);
            this.CheckBoxDrum.Name = "CheckBoxDrum";
            this.CheckBoxDrum.Size = new System.Drawing.Size(51, 17);
            this.CheckBoxDrum.TabIndex = 14;
            this.CheckBoxDrum.Text = "Drum";
            this.CheckBoxDrum.UseVisualStyleBackColor = true;
            this.CheckBoxDrum.CheckedChanged += new System.EventHandler(this.CheckBoxDrum_CheckedChanged);
            // 
            // CheckBoxVokal
            // 
            this.CheckBoxVokal.AutoSize = true;
            this.CheckBoxVokal.Location = new System.Drawing.Point(103, 65);
            this.CheckBoxVokal.Name = "CheckBoxVokal";
            this.CheckBoxVokal.Size = new System.Drawing.Size(53, 17);
            this.CheckBoxVokal.TabIndex = 15;
            this.CheckBoxVokal.Text = "Vokal";
            this.CheckBoxVokal.UseVisualStyleBackColor = true;
            this.CheckBoxVokal.CheckedChanged += new System.EventHandler(this.CheckBoxVokal_CheckedChanged);
            // 
            // CheckBoxKomposer
            // 
            this.CheckBoxKomposer.AutoSize = true;
            this.CheckBoxKomposer.Location = new System.Drawing.Point(103, 88);
            this.CheckBoxKomposer.Name = "CheckBoxKomposer";
            this.CheckBoxKomposer.Size = new System.Drawing.Size(73, 17);
            this.CheckBoxKomposer.TabIndex = 16;
            this.CheckBoxKomposer.Text = "Komposer";
            this.CheckBoxKomposer.UseVisualStyleBackColor = true;
            this.CheckBoxKomposer.CheckedChanged += new System.EventHandler(this.CheckBoxKomposer_CheckedChanged);
            // 
            // Jadwal1
            // 
            this.Jadwal1.AutoSize = true;
            this.Jadwal1.Location = new System.Drawing.Point(6, 19);
            this.Jadwal1.Name = "Jadwal1";
            this.Jadwal1.Size = new System.Drawing.Size(153, 17);
            this.Jadwal1.TabIndex = 9;
            this.Jadwal1.TabStop = true;
            this.Jadwal1.Text = "Senin & Rabu, 14.00-16.00";
            this.Jadwal1.UseMnemonic = false;
            this.Jadwal1.UseVisualStyleBackColor = true;
            this.Jadwal1.CheckedChanged += new System.EventHandler(this.Jadwal1_CheckedChanged);
            // 
            // Jadwal2
            // 
            this.Jadwal2.AutoSize = true;
            this.Jadwal2.Location = new System.Drawing.Point(6, 41);
            this.Jadwal2.Name = "Jadwal2";
            this.Jadwal2.Size = new System.Drawing.Size(160, 17);
            this.Jadwal2.TabIndex = 10;
            this.Jadwal2.TabStop = true;
            this.Jadwal2.Text = "Selasa & Kamis, 14.00-16.00";
            this.Jadwal2.UseMnemonic = false;
            this.Jadwal2.UseVisualStyleBackColor = true;
            this.Jadwal2.CheckedChanged += new System.EventHandler(this.Jadwal2_CheckedChanged);
            // 
            // Jadwal3
            // 
            this.Jadwal3.AutoSize = true;
            this.Jadwal3.Location = new System.Drawing.Point(6, 64);
            this.Jadwal3.Name = "Jadwal3";
            this.Jadwal3.Size = new System.Drawing.Size(163, 17);
            this.Jadwal3.TabIndex = 11;
            this.Jadwal3.TabStop = true;
            this.Jadwal3.Text = "Sabtu & Minggu, 09.00-11.00";
            this.Jadwal3.UseMnemonic = false;
            this.Jadwal3.UseVisualStyleBackColor = true;
            this.Jadwal3.CheckedChanged += new System.EventHandler(this.Jadwal3_CheckedChanged);
            // 
            // Jadwal4
            // 
            this.Jadwal4.AutoSize = true;
            this.Jadwal4.Location = new System.Drawing.Point(6, 87);
            this.Jadwal4.Name = "Jadwal4";
            this.Jadwal4.Size = new System.Drawing.Size(123, 17);
            this.Jadwal4.TabIndex = 12;
            this.Jadwal4.TabStop = true;
            this.Jadwal4.Text = "Minggu, 13.00-17.00";
            this.Jadwal4.UseVisualStyleBackColor = true;
            this.Jadwal4.CheckedChanged += new System.EventHandler(this.Jadwal4_CheckedChanged);
            // 
            // Tampilkan
            // 
            this.Tampilkan.Location = new System.Drawing.Point(256, 371);
            this.Tampilkan.Name = "Tampilkan";
            this.Tampilkan.Size = new System.Drawing.Size(75, 23);
            this.Tampilkan.TabIndex = 9;
            this.Tampilkan.Text = "Tampilkan";
            this.Tampilkan.UseVisualStyleBackColor = true;
            this.Tampilkan.Click += new System.EventHandler(this.Tampilkan_Click);
            // 
            // Selesai
            // 
            this.Selesai.Location = new System.Drawing.Point(469, 371);
            this.Selesai.Name = "Selesai";
            this.Selesai.Size = new System.Drawing.Size(75, 23);
            this.Selesai.TabIndex = 10;
            this.Selesai.Text = "Selesai";
            this.Selesai.UseVisualStyleBackColor = true;
            this.Selesai.Click += new System.EventHandler(this.Selesai_Click);
            // 
            // FormPendaftaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Selesai);
            this.Controls.Add(this.Tampilkan);
            this.Controls.Add(this.OpsiJadwal);
            this.Controls.Add(this.Opsimapel);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.PilihGender);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.LabelLahir);
            this.Controls.Add(this.LabelGender);
            this.Controls.Add(this.LabelNama);
            this.Controls.Add(this.Judul);
            this.Name = "FormPendaftaran";
            this.Text = "Pendaftaran Sekolah Musik";
            this.Opsimapel.ResumeLayout(false);
            this.Opsimapel.PerformLayout();
            this.OpsiJadwal.ResumeLayout(false);
            this.OpsiJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Label LabelNama;
        private System.Windows.Forms.Label LabelGender;
        private System.Windows.Forms.Label LabelLahir;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.ComboBox PilihGender;
        private System.Windows.Forms.DateTimePicker TanggalLahir;
        private System.Windows.Forms.GroupBox Opsimapel;
        private System.Windows.Forms.GroupBox OpsiJadwal;
        private System.Windows.Forms.CheckBox CheckBoxKomposer;
        private System.Windows.Forms.CheckBox CheckBoxVokal;
        private System.Windows.Forms.CheckBox CheckBoxDrum;
        private System.Windows.Forms.CheckBox CheckBoxPiano;
        private System.Windows.Forms.CheckBox CheckBoxKonduktor;
        private System.Windows.Forms.CheckBox CheckBoxSaxophone;
        private System.Windows.Forms.CheckBox CheckBoxGitar;
        private System.Windows.Forms.CheckBox CheckBoxBiola;
        private System.Windows.Forms.RadioButton Jadwal4;
        private System.Windows.Forms.RadioButton Jadwal3;
        private System.Windows.Forms.RadioButton Jadwal2;
        private System.Windows.Forms.RadioButton Jadwal1;
        private System.Windows.Forms.Button Tampilkan;
        private System.Windows.Forms.Button Selesai;
    }
}

