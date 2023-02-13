using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GepteremProjekt
{
    public partial class Form1 : Form
    {
        PetrikLajosSzg kell = new PetrikLajosSzg(new List<Gepterem>());
        string keput = @"..//../Kepek/";
        int oldalszama = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void kepekbetoltese(PictureBox pictureBox, int i, int j)
        {
            string kep = @"";
            if (kell.terem[oldalszama].Ertekeles[i, j] == 1)
            {
                kep = keput + "Pont1" + ".jpg";
            }
            else if (kell.terem[oldalszama].Ertekeles[i, j] == 2)
            {
                kep = keput + "Pont2" + ".jpg";
            }
            else if (kell.terem[oldalszama].Ertekeles[i, j] == 3)
            {
                kep = keput + "Pont3" + ".jpg";
            }
            else { kep = keput + "Pont0" + ".jpg"; }

            pictureBox.ImageLocation = kep;

        }
        private void valtas()
        {

            panel1.Controls.Clear();
            int picturesize = 40;
            kep.ImageLocation = keput + kell.terem[oldalszama].Nev.Split(' ')[0] + ".jpg";
            this.Text = kell.terem[oldalszama].Nev;

            for (int i = 0; i < kell.terem[oldalszama].HelyDb; i++)
            {
                for (int j = 0; j < kell.terem[oldalszama].SorDb; j++)
                {
                    PictureBox picturebox = new PictureBox();

                    picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picturebox.SetBounds(j * picturesize, i * picturesize, picturesize, picturesize);
                    picturebox.Name = $"{i};{j}";
                    kepekbetoltese(picturebox, i, j);
                    picturebox.Click += (o, ev) =>
                    {
                        PictureBox picture = (PictureBox)o;
                        int[] pont = Array.ConvertAll(picture.Name.Split(';'), int.Parse);

                        int koordinata_i = pont[0];
                        int koordinata_j = pont[1];
                        if (kell.terem[oldalszama].Ertekeles[koordinata_i, koordinata_j] + 1 > 3)
                        {
                            kell.terem[oldalszama].Ertekeles[koordinata_i, koordinata_j] = 0;
                        }
                        else
                        {
                            kell.terem[oldalszama].Ertekeles[koordinata_i, koordinata_j] += 1;
                        }
                        kepekbetoltese(picturebox, pont[0], pont[1]);
                    };
                    panel1.Controls.Add(picturebox);
                }
            }
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            string lines = File.ReadAllText(@"..//../petrikgepek.txt");
            string[] lines1 = Regex.Split(lines, Environment.NewLine + Environment.NewLine);

            for (int i = 0; i < lines1.Length; i++)
            {

                string[] cod = Regex.Split(lines1[i], Environment.NewLine);
                string[] asd = cod[1].Split(';');
                int[,] szamok = new int[Convert.ToInt32(asd[0]), Convert.ToInt32(asd[1])];
                for (int j = 2; j < cod.Length; j++)
                {
                    try
                    {
                        int[] temp = Array.ConvertAll(cod[j].Split(';'), int.Parse);
                        for (int k = 0; k < temp.Length; k++)
                        {
                            szamok[j - 2, k] = temp[k];
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                kell.terem.Add(new Gepterem(cod[0], szamok, Convert.ToInt32(asd[0]), Convert.ToInt32(asd[1])));
            }
            valtas();
        }

        private void nyilak()
        {
            if (oldalszama > 0)
            {
                bal.ImageLocation = keput + @"bal.jpg";
            }
            else
            {
                jobb.ImageLocation = @"";
            }
            if (oldalszama < 3)
            {
                jobb.ImageLocation = keput + @"jobb.jpg";
            }
            else
            {
                jobb.ImageLocation = @"";
            }
        }

        private void bal_Click(object sender, EventArgs e)
        {
            if (oldalszama + 1 < 4)
            {
                oldalszama++;
            }
            valtas();
            nyilak();
        }

        private void jobb_Click(object sender, EventArgs e)
        {
            if (oldalszama - 1 > -1)
            {
                oldalszama--;
            }
            valtas();
            nyilak();
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            string[] datum = Regex.Split(DateTime.Now.ToString(), ". ");
            File.Move(@"..//../petrikgepek.txt", $"..//../petrikgepek_{datum[0]}{datum[1]}{datum[2]}{datum[3].Replace(":", "")}.txt");
            string filesave = "";
            int count = 0;
            foreach (Gepterem lp in kell.terem)
            {
                count++;
                filesave += $"{lp.Nev}{Environment.NewLine}{lp.SorDb};{lp.HelyDb}{Environment.NewLine}";
                for (int x = 0; x < lp.Ertekeles.GetLength(0); x++)
                {
                    string temp = "";
                    for (int y = 0; y < lp.Ertekeles.GetLength(1); y++)
                    {
                        temp += lp.Ertekeles[x, y];
                        if (y != lp.Ertekeles.GetLength(1)-1)
                        {
                            temp += ";";
                        }
                    }
                    filesave += temp + Environment.NewLine;
                }
                if (count != 4)
                {
                    filesave += Environment.NewLine;
                }

            }
            File.WriteAllText(@"..//../petrikgepek.txt", filesave);
        }
    }
}
