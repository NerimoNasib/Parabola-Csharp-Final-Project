using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_akhir
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double q, eq, qq, qp, pp, ang;
                pp = double.Parse(this.textBox3.Text);
                ang = Math.PI * pp / 180;
                q = 900 * Math.Sin(ang);
                qq = 900 * Math.Cos(ang);
                eq = q * q / (2 * 9.81 * 1000);
                qp = q * qq / (9.81 * 1000);
                this.textBox1.Text = Convert.ToString(eq);
                this.textBox2.Text = Convert.ToString(qp);
            }
            if (radioButton2.Checked)
            {
                double q, eq, qq, qp, pp, ang;
                pp = double.Parse(this.textBox3.Text);
                ang = Math.PI * pp / 180;
                q = 1000 * Math.Sin(ang);
                qq = 1000 * Math.Cos(ang);
                eq = q * q / (2 * 9.81 * 1000);
                qp = q * qq / (9.81 * 1000);
                this.textBox1.Text = Convert.ToString(eq);
                this.textBox2.Text = Convert.ToString(qp);
            }
            if (radioButton3.Checked)
            {
                double q, eq, qq, qp, pp, ang;
                pp = double.Parse(this.textBox3.Text);
                ang = Math.PI * pp / 180;
                q = 680 * Math.Sin(ang);
                qq = 680 * Math.Cos(ang);
                eq = q * q / (2 * 9.81 * 1000);
                qp = q * qq / (9.81 * 1000);
                this.textBox1.Text = Convert.ToString(eq);
                this.textBox2.Text = Convert.ToString(qp);
            }
            if (radioButton4.Checked)
            {
                double q, eq, qq, qp, pp, ang;
                pp = double.Parse(this.textBox3.Text);
                ang = Math.PI * pp / 180;
                q = 685 * Math.Sin(ang);
                qq = 685 * Math.Cos(ang);
                eq = q * q / (2 * 9.81 * 1000);
                qp = q * qq / (9.81 * 1000);
                this.textBox1.Text = Convert.ToString(eq);
                this.textBox2.Text = Convert.ToString(qp);
            }
            if (radioButton5.Checked)
            {
                double q, eq, qq, qp, pp, ang;
                pp = double.Parse(this.textBox3.Text);
                ang = Math.PI * pp / 180;
                q = 700 * Math.Sin(ang);
                qq = 700 * Math.Cos(ang);
                eq = q * q / (2 * 9.81 * 1000);
                qp = q * qq / (9.81 * 1000);
                this.textBox1.Text = Convert.ToString(eq);
                this.textBox2.Text = Convert.ToString(qp);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] gun = { "AK47 \n\tAK-74 adalah senapan serbu yang merupakan modernisasi dari AKM. Senapan ini menggunakan peluru yang lebih kecil dengan kaliber 5.45 x 39 mm. pertama kali dibuat tahun 1974. Senapan ini mulai diproduksi massal pada tahun 1976. Varian terbaru senapan ini, AK-74M, adalah senapan serbu standar angkatan bersenjata Rusia sejak awal tahun 1976-an",
                "AR15 \n\tAR-15 (singkatan dari Armalite model 15) adalah senapan semi-otomatis, yang mirip dengan senapan otomatis M16 atau karabin M4, banyak dimiliki, dan dipasarkan untuk sipil. Senapan AR-15 sipil memiliki banyak pilihan modifikasi dan umumnya memiliki pegangan pistol, popor lipat atau teleskopik, laras melingkar, dan tempat bayonet. Senapan AR-15 original buatan ArmaLite/Colt awalnya merupakan senapan purwarupa yang diikutsertakan dalam tender senapan Amerika Serikat, yang akhirnya diadopsi menjadi senapan M16. ",
                "StG44\n\tSturmgewehr 44 (StG44) adalah senapan otomatis selective-fire yang dikembangkan oleh Jerman pada Perang Dunia II, dalam program Maschinenkarabiner (karabin mesin) mereka. Senapan ini dianggap sebagai senapan serbu pertama di dunia. ",
                "M1\n\tM1 Garand adalah senapan semi-otomatis pertama yang dijadikan senapan standar untuk infanteri. Senapan ini menggunakan peluru kaliber .30-06 Springfield. Senapan M1 Garand menggantikan senapan Springfield M1903 sebagai senapan standar militer Amerika Serikat pada tahun 1936. Kemudian senapan ini digantikan oleh senapan jenis M14 pada tahun 1957. ",
                "Arisaka\n\tSenapan Tipe 99 Arisaka atau Senapan pendek Tipe 99 (九九 式 短小 銃, Kyūkyū-shiki tan-shōjū) adalah senapan aksi baut desain Arisaka yang digunakan oleh Tentara Jepang Kekaisaran selama Perang Dunia II." };
            foreach (string i in gun)
            {
                MessageBox.Show(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Queue antrian = new Queue();
            Queue antrian2 = new Queue();
            double data, data2;
            data = double.Parse(textBox2.Text);
            data2 = double.Parse(textBox1.Text);
            antrian.Enqueue(data);
            antrian2.Enqueue(data2);
            MessageBox.Show("Data\n Jarak Terjauh\n" + antrian.Peek() + "\n\n" + "Ketinggian Maksimum\n" + antrian2.Peek());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
