using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_location
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string link = "https://www.google.pl/maps/place/54%C2%B011'11.1%22N+17%C2%B011'11.1%22E";

            Random r = new Random();

            int v = r.Next(10, 55);
            string v_s = v.ToString();
            link = link.Remove(33, 2).Insert(33, v_s);

            v = r.Next(10, 59);
            v_s = v.ToString();
            link = link.Remove(41, 2).Insert(41, v_s);

            v = r.Next(10, 59);
            v_s = v.ToString();
            link = link.Remove(44, 2).Insert(44, v_s);

            v = r.Next(0, 10);
            v_s = v.ToString();
            link = link.Remove(47, 1).Insert(47, v_s);

            v = r.Next(0, 2);
            if (v == 0)
                link = link.Remove(51, 1).Insert(51, "N");
            else
                link = link.Remove(51, 1).Insert(51, "S");
;

            v = r.Next(10, 59);
            v_s = v.ToString();
            link = link.Remove(61, 2).Insert(61, v_s);

            v = r.Next(10, 59);
            v_s = v.ToString();
            link = link.Remove(64, 2).Insert(64, v_s);

            v = r.Next(0, 9);
            v_s = v.ToString();
            link = link.Remove(67, 1).Insert(67, v_s);

            v = r.Next(0, 2);
            if (v == 0)
                link = link.Remove(71, 1).Insert(71, "W");
            else
                link = link.Remove(71, 1).Insert(71, "E");

            v = r.Next(0, 125);
            v_s = v.ToString();
            link = link.Remove(53, 2).Insert(53, v_s);


            System.Diagnostics.Process.Start(link);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string link = "https://www.google.pl/maps/place/54%C2%B011'11.1%22N+17%C2%B011'11.1%22E";

            Random r = new Random();

            int v = r.Next(10, 55);
            string v_s = v.ToString();
            link = link.Remove(33, 2).Insert(33, v_s);

            v = r.Next(10, 59);
            v_s = v.ToString();
            link = link.Remove(41, 2).Insert(41, v_s);

            v = r.Next(10, 59);
            v_s = v.ToString();
            link = link.Remove(44, 2).Insert(44, v_s);

            v = r.Next(0, 10);
            v_s = v.ToString();
            link = link.Remove(47, 1).Insert(47, v_s);

            v = r.Next(0, 2);
            if (v == 0)
                link = link.Remove(51, 1).Insert(51, "N");
            else
                link = link.Remove(51, 1).Insert(51, "S");
            ;

            v = r.Next(10, 59);
            v_s = v.ToString();
            link = link.Remove(61, 2).Insert(61, v_s);

            v = r.Next(10, 59);
            v_s = v.ToString();
            link = link.Remove(64, 2).Insert(64, v_s);

            v = r.Next(0, 9);
            v_s = v.ToString();
            link = link.Remove(67, 1).Insert(67, v_s);

            v = r.Next(0, 2);
            if (v == 0)
                link = link.Remove(71, 1).Insert(71, "W");
            else
                link = link.Remove(71, 1).Insert(71, "E");

            v = r.Next(0, 125);
            v_s = v.ToString();
            link = link.Remove(53, 2).Insert(53, v_s);


            System.Diagnostics.Process.Start(link);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The app takes you to a random place in the world. \nMade by Adam Pacek.");
        }
    }
}
