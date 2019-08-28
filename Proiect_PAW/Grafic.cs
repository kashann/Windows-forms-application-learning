using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Grafic : Form
    { int nrElem = 0;
        double[] vect = new double[100];

        const int marg = 10;

        bool readSuccess = false; //spune daca am citit datele cu succes

        Font font = new Font(FontFamily.GenericSansSerif,10, FontStyle.Bold);

        Color culoare = Color.Indigo;
    
        public Grafic()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Grafic_DragEnter);
            this.DragDrop += new DragEventHandler(Grafic_DragDrop);
        }

        void Grafic_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop,false)==true) e.Effect = DragDropEffects.All;
        }

        void Grafic_DragDrop(object sender, DragEventArgs e)
        {

            string[] droppedfiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach(string file in droppedfiles)
            {
                pictureBox1.Image = Image.FromFile(file);
            }
        }
        private void enterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(op.FileName);
                readSuccess = true;
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    vect[nrElem] = Convert.ToDouble(linie);
                    nrElem++;
                }
            }
            pictureBox1.Invalidate();
        }
      

        double Maxim()
        {
            double max = vect[0];
            for (int i = 1; i < nrElem; i++)
                if (vect[i] > max)
                    max = vect[i];
            return max;
        }



        private void pd_print(object sender, PrintPageEventArgs e)
        {
            if (readSuccess == true)
            {
                Graphics gr = e.Graphics;

                Pen stilou = new Pen(Color.GreenYellow, 5);
                Rectangle drep = new Rectangle(e.PageBounds.X + marg,
                    e.PageBounds.Y + 4 * marg,
                    e.PageBounds.Width - 2 * marg,
                    e.PageBounds.Height - 5 * marg);
                gr.DrawRectangle(stilou, drep);

                Rectangle[] dreptunghiuri = new Rectangle[nrElem];
                gr.DrawRectangles(stilou, dreptunghiuri);

                double latime = (drep.Width) / 3 / nrElem;

                double distanta = (drep.Width - latime * nrElem) / (nrElem + 1);

                double vmax = Maxim();
                Brush br = new SolidBrush(culoare);

                for (int i = 0; i < nrElem; i++)
                {
                    dreptunghiuri[i] = new Rectangle(
                        (int)(drep.Left + (i + 1) * distanta + i * latime),

                        (int)(drep.Bottom - vect[i] / vmax * drep.Height),

                        (int)latime,

                        (int)(vect[i] / vmax * (drep.Bottom - drep.Top)));

                    gr.DrawString(Convert.ToString(vect[i]), font, br,

                        (int)(drep.Left + (i + 1) * distanta + i * latime + latime / 2),

                        (int)(drep.Bottom - vect[i] / vmax * (drep.Bottom - drep.Top) - font.Height - 5));
                }
                for (int i = 0; i < nrElem - 1; i++)
                    gr.DrawLine(stilou, dreptunghiuri[i].Location, dreptunghiuri[i + 1].Location);  //porneste din coltul din stanga
                //gr.DrawLine(stilou, new Point((int)dreptunghiuri[i].Location.X + (latime / 2)), dreptunghiuri[i].Location.Y,   //porneste din mijloc
                //new Point((int)dreptunghiuri[i + 1].Location.X + (latime / 2)), dreptunghiuri[i + 1].Location.Y);

                gr.FillRectangles(br, dreptunghiuri);
            }
            Invalidate();
        }

        private void printDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.pd_print);  //pd_print e o metoda
            PrintPreviewDialog pdlg = new PrintPreviewDialog();
            pdlg.Document = pd;
            pdlg.ShowDialog();
        }
        public void frm_print(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);
            this.DrawToBitmap(bmp, rec);
            g.DrawImage(bmp, 0, 0);

        }


        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                culoare = dlg.Color;
            panel1.Invalidate();
        }

         private void saveDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
             save(panel1, "imagine.bmp");
             MessageBox.Show("Imagine salvata cu succes!");
        }

        public void save(Control control, string fisier)
        {  
            Graphics g = control.CreateGraphics();
            Bitmap bmp = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bmp, new
                Rectangle(0, 0, control.Width, control.Height));
            bmp.Save(fisier);
            bmp.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //if (vb == true)
            //{
            //    Graphics gr = e.Graphics;
            //    //Graphics gr = panel1.CreateGraphics();
            //    //Graphics gr = Graphics.FromHwnd(panel1.Handle);

            //    Pen stilou = new Pen(Color.Red, 3);
            //    Rectangle drep = new Rectangle(panel1.Location.X + marg,
            //        panel1.Location.Y + 4 * marg,  //mergem mai jos pe form sa nu se suprapuna cu meniul
            //        panel1.Width - 2 * marg,  //acestea dau forma desenului.. 
            //        panel1.Height - 5 * marg);
            //    gr.DrawRectangle(stilou, drep);

            //    Rectangle[] dreptunghiuri = new Rectangle[nrElem];
            //    gr.DrawRectangles(stilou, dreptunghiuri);  //nu deseneaza nimic aici, e doar de forma

            //    //double latime = (drep.Right - drep.Left) / 3/ nrobs;
            //    double latime = (drep.Width) / 3 / nrElem;  //latimea unui dreptunghi albastru/un element -> noi alegem

            //    double distanta = (drep.Width - latime * nrElem) / (nrElem + 1);  //distanta dintre elemente

            //    double vmax = Maxim();
            //    Brush br = new SolidBrush(culoare);

            //    for (int i = 0; i < nrElem; i++)
            //    {
            //        dreptunghiuri[i] = new Rectangle(
            //            (int)(drep.Left + (i + 1) * distanta + i * latime),  //x, drep.Left = X la dreptunghiul mare

            //            (int)(drep.Bottom - vect[i] / vmax * drep.Height), // (drep.Bottom - drep.Top)),  //y

            //            (int)latime,  //width

            //            (int)(vect[i] / vmax * (drep.Bottom - drep.Top))); //height

            //        gr.DrawString(Convert.ToString(vect[i]), font, br,

            //            (int)(drep.Left + (i + 1) * distanta + i * latime + latime / 2),

            //            (int)(drep.Bottom - vect[i] / vmax * (drep.Bottom - drep.Top) - font.Height - 5));
            //    }
            //    for (int i = 0; i < nrElem - 1; i++)
            //        gr.DrawLine(stilou, dreptunghiuri[i].Location, dreptunghiuri[i + 1].Location);  //porneste din coltul din stanga
            //    //gr.DrawLine(stilou, new Point((int)dreptunghiuri[i].Location.X + (latime / 2)), dreptunghiuri[i].Location.Y,   //porneste din mijloc
            //    //new Point((int)dreptunghiuri[i + 1].Location.X + (latime / 2)), dreptunghiuri[i + 1].Location.Y);

            //    gr.FillRectangles(br, dreptunghiuri);
            //}
            //Invalidate(); 
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (readSuccess == true)
            {
                Graphics gr = e.Graphics;
                //Graphics gr = panel1.CreateGraphics();
                //Graphics gr = Graphics.FromHwnd(panel1.Handle);

                Pen stilou = new Pen(Color.Red, 3);
                Rectangle drep = new Rectangle(panel1.Location.X + marg,
                    panel1.Location.Y + 4 * marg,  //mergem mai jos pe form sa nu se suprapuna cu meniul
                    panel1.Width - 2 * marg,  //acestea dau forma desenului.. 
                    panel1.Height - 5 * marg);
                gr.DrawRectangle(stilou, drep);

                Rectangle[] dreptunghiuri = new Rectangle[nrElem];
                gr.DrawRectangles(stilou, dreptunghiuri);  //nu deseneaza nimic aici, e doar de forma

                //double latime = (drep.Right - drep.Left) / 3/ nrobs;
                double latime = (drep.Width) / 3 / nrElem;  //latimea unui dreptunghi albastru/un element -> noi alegem

                double distanta = (drep.Width - latime * nrElem) / (nrElem + 1);  //distanta dintre elemente

                double vmax = Maxim();
                Brush br = new SolidBrush(culoare);

                for (int i = 0; i < nrElem; i++)
                {
                    dreptunghiuri[i] = new Rectangle(
                        (int)(drep.Left + (i + 1) * distanta + i * latime),  //x, drep.Left = X la dreptunghiul mare

                        (int)(drep.Bottom - vect[i] / vmax * drep.Height), // (drep.Bottom - drep.Top)),  //y

                        (int)latime,  //width

                        (int)(vect[i] / vmax * (drep.Bottom - drep.Top))); //height

                    gr.DrawString(Convert.ToString(vect[i]), font, br,

                        (int)(drep.Left + (i + 1) * distanta + i * latime + latime / 2),

                        (int)(drep.Bottom - vect[i] / vmax * (drep.Bottom - drep.Top) - font.Height - 5));
                }
                for (int i = 0; i < nrElem - 1; i++)
                    gr.DrawLine(stilou, dreptunghiuri[i].Location, dreptunghiuri[i + 1].Location);  //porneste din coltul din stanga
                //gr.DrawLine(stilou, new Point((int)dreptunghiuri[i].Location.X + (latime / 2)), dreptunghiuri[i].Location.Y,   //porneste din mijloc
                //new Point((int)dreptunghiuri[i + 1].Location.X + (latime / 2)), dreptunghiuri[i + 1].Location.Y);

                gr.FillRectangles(br, dreptunghiuri);
            }
            Invalidate(); 
        }

       
        

     
      


      

    }
    }


