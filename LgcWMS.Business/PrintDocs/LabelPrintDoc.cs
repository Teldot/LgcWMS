using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LgcWMS.Business.PrintDocs
{
    public class LabelPrintDoc
    {
        Graphics g;
        const float SPACE = 5;

        public List<Image> Images { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public LabelPrintDoc(int width, int height)
        {
            Width = width;
            Height = height;
        }

        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            int SPACE = 145;
            string title = "\\CBT_Title.png";
            string barcode = "\\code128bar.jpg";
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, 5, 5, Width, Height);

            string TType = "S";


            g.DrawImage(Images[0], 40, 8, 23, 8);
            g.DrawImage(Images[0], 40, 65, 23, 8);
            //Font fBody = new Font("Lucida Console", 15, FontStyle.Bold);
            //Font fBody1 = new Font("Lucida Console", 15, FontStyle.Regular);
            //Font rs = new Font("Stencil", 25, FontStyle.Bold);
            //Font fTType = new Font("", 150, FontStyle.Bold);
            //SolidBrush sb = new SolidBrush(Color.Black);


            //g.DrawString("-------------------------------", fBody1, sb, 10, 120);

            //g.DrawString("Date :", fBody, sb, 10, SPACE);
            //g.DrawString(DateTime.Now.ToShortDateString(), fBody1, sb, 90, SPACE);

            //g.DrawString("Time :", fBody, sb, 10, SPACE + 30);
            //g.DrawString(DateTime.Now.ToShortTimeString(), fBody1, sb, 90, SPACE + 30);

            //g.DrawString("TicketNo.:", fBody, sb, 10, SPACE + 60);
            //g.DrawString("", fBody1, sb, 120, SPACE + 60);

            //g.DrawString("BusNo.:", fBody, sb, 10, SPACE + 90);
            //g.DrawString("", fBody1, sb, 100, SPACE + 90);

            ////g.DrawString("DriverName:", fBody, sb, 10, SPACE+120);
            ////g.DrawString(txtDriveName.Text, fBody1, sb, 153, SPACE + 120);

            //g.DrawString("Route:", fBody, sb, 10, SPACE + 120);
            //g.DrawString("", fBody1, sb, 100, SPACE + 120);

            //g.DrawString("Full:", fBody, sb, 10, SPACE + 150);
            //g.DrawString("1 X 8.00 = 8.00", fBody1, sb, 80, SPACE + 150);

            //g.DrawString("Rs. 8.00", rs, sb, 10, SPACE + 180);

            //g.DrawString(TType, fTType, sb, 230, 120);

            //g.DrawImage(Image.FromFile(barcode), 10, SPACE + 240);
            //g.DrawString("Helpline No.: +91 9999999999", fBody, sb, 10, 465);

        }

        public void PrintDoc()
        {
            PrintDocument pd = new PrintDocument();
            PaperSize ps = new PaperSize("", 475, 550);

            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            pd.PrintController = new StandardPrintController();
            pd.DefaultPageSettings.Margins.Left = 0;
            pd.DefaultPageSettings.Margins.Right = 0;
            pd.DefaultPageSettings.Margins.Top = 0;
            pd.DefaultPageSettings.Margins.Bottom = 0;

            pd.DefaultPageSettings.PaperSize = ps;
            pd.Print();
        }



    }
}
