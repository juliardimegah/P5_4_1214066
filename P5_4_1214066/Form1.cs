using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_1214066
{
    public partial class FormPendaftaran : Form
    {
        public FormPendaftaran()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void PilihGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void TanggalLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxBiola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxGitar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxSaxophone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxKonduktor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxPiano_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxDrum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxVokal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxKomposer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Jadwal1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Jadwal2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Jadwal3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Jadwal4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tampilkan_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            if (CheckBoxBiola.Checked)
            {
                kelas = kelas + "Biola, ";
            }
            if (CheckBoxGitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }
            if (CheckBoxSaxophone.Checked)
            {
                kelas = kelas + "Saxophone, ";
            }
            if (CheckBoxKonduktor.Checked)
            {
                kelas = kelas + "Konduktor, ";
            }
            if (CheckBoxPiano.Checked)
            {
                kelas = kelas + "Piano, ";
            }
            if (CheckBoxDrum.Checked)
            {
                kelas = kelas + "Drum, ";
            }
            if (CheckBoxVokal.Checked)
            {
                kelas = kelas + "Vokal, ";
            }
            if (CheckBoxKomposer.Checked)
            {
                kelas = kelas + "Komposer, ";
            }
            /*
            if (kelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

            var again = true;

            if (Jadwal1.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (Jadwal2.Checked)
            {
                jadwal = "Senin & Kamis, 14.00 - 16.00";
            }
            else if (Jadwal3.Checked)
            {
                jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (Jadwal4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
            else
            {
                again = false;
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            while (again)
            {
                if (CheckBoxBiola.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + textnama.Text +
                    "\nJenis Kelamin : " + PilihGender.Text +
                    "\nTanggal Lahir : " + TanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (CheckBoxGitar.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + textnama.Text +
                    "\nJenis Kelamin : " + PilihGender.Text +
                    "\nTanggal Lahir : " + TanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (CheckBoxSaxophone.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + textnama.Text +
                    "\nJenis Kelamin : " + PilihGender.Text +
                    "\nTanggal Lahir : " + TanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (CheckBoxKonduktor.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + textnama.Text +
                    "\nJenis Kelamin : " + PilihGender.Text +
                    "\nTanggal Lahir : " + TanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (CheckBoxPiano.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + textnama.Text +
                    "\nJenis Kelamin : " + PilihGender.Text +
                    "\nTanggal Lahir : " + TanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (CheckBoxDrum.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + textnama.Text +
                    "\nJenis Kelamin : " + PilihGender.Text +
                    "\nTanggal Lahir : " + TanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (CheckBoxVokal.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + textnama.Text +
                    "\nJenis Kelamin : " + PilihGender.Text +
                    "\nTanggal Lahir : " + TanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (CheckBoxKomposer.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + textnama.Text +
                    "\nJenis Kelamin : " + PilihGender.Text +
                    "\nTanggal Lahir : " + TanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else
                {
                    MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    again = false;
                }
            }
        }

        private void Selesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
