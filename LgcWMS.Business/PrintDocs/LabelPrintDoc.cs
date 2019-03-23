using LgcWMS.Data.Entities;
using Newtonsoft.Json.Linq;
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
        #region Attributes
        Graphics g;

        #endregion

        #region Properties
        public List<Image> Images { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public object DataToPrint { get; set; }
        public string PrinterName { get; set; }
        public TypeDoc TypeDocToPrint { get; set; }
        #endregion

        #region Constructor
        public LabelPrintDoc(int width, int height)
        {
            Width = width;
            Height = height;
            Images = new List<Image>();
        }
        #endregion

        #region Methods
        public void PrintDoc()
        {
            PrintDocument pd = new PrintDocument();
            PaperSize ps = new PaperSize("", int.Parse(Width.ToString()), int.Parse(Height.ToString()));


            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            pd.PrinterSettings.PrinterName = PrinterName;

            //pd.PrintController = new StandardPrintController();
            pd.DefaultPageSettings.Margins.Left = 0;
            pd.DefaultPageSettings.Margins.Right = 0;
            pd.DefaultPageSettings.Margins.Top = 0;
            pd.DefaultPageSettings.Margins.Bottom = 0;
            switch (TypeDocToPrint)
            {
                case TypeDoc.Label:
                    break;
                case TypeDoc.Guia:
                    //pd.DefaultPageSettings.Landscape = true;
                    break;
                default:
                    break;
            }

            pd.DefaultPageSettings.PaperSize = ps;
            pd.Print();
        }


        private Graphics GetGuiaGraphics(Graphics graphics)
        {


            return g;
        }
        #endregion

        #region Events
        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fBody;
            SolidBrush sb = new SolidBrush(Color.Black);
            switch (TypeDocToPrint)
            {
                case TypeDoc.Label:
                    #region Label
                    const float LEFT_TEXT_X = 19;
                    const float RIGHT_TEXT_X = 118;
                    float CURRENT_LINE = 70;
                    const float INTER_SPACE_Y = 20;
                    const float ONE_DOC_HEIGHT = 232;
                    const float LEFT_MARG = 7;
                    const float RIGHT_MARG = 7;

                    g.DrawImage(Images[0], 15, 31, 90, 31);
                    g.DrawImage(Images[0], 15, 255, 90, 31);
                    Font fBodyLabel = new Font("Lucida Console", 9, FontStyle.Bold);
                    fBody = new Font("Lucida Console", 9, FontStyle.Regular);

                    GUIA_LABEL_DUO Data = (GUIA_LABEL_DUO)DataToPrint;

                    Image x1 = (Bitmap)((new ImageConverter()).ConvertFrom(Data.BARCODE1));
                    g.DrawImage(x1, LEFT_TEXT_X, 204, 180, 27);
                    Image x2 = null;
                    if (Data.BARCODE2 != null && Data.BARCODE2.Length > 0)
                    {
                        x2 = (Bitmap)((new ImageConverter()).ConvertFrom(Data.BARCODE2));
                        g.DrawImage(x2, LEFT_TEXT_X, 204 + ONE_DOC_HEIGHT, 180, 27);
                    }


                    float _wTb = Width - RIGHT_TEXT_X - RIGHT_MARG;
                    int wTb = int.Parse(_wTb.ToString());
                    int RightTextX = int.Parse(RIGHT_TEXT_X.ToString());
                    int one_doc_height = int.Parse(ONE_DOC_HEIGHT.ToString());

                    g.DrawString("Nombre:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE);
                    g.DrawString("Nombre:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE + ONE_DOC_HEIGHT);
                    g.DrawString("Direccion:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE += INTER_SPACE_Y);
                    g.DrawString("Direccion:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE + ONE_DOC_HEIGHT);
                    g.DrawString("Telefono:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE += INTER_SPACE_Y);
                    g.DrawString("Telefono:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE + ONE_DOC_HEIGHT);
                    g.DrawString("Ciudad:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE += INTER_SPACE_Y);
                    g.DrawString("Ciudad:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE + ONE_DOC_HEIGHT);
                    g.DrawString("Referencia:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE += INTER_SPACE_Y);
                    g.DrawString("Referencia:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE + ONE_DOC_HEIGHT);
                    g.DrawString("Consec:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE += INTER_SPACE_Y);
                    g.DrawString("Consec:", fBodyLabel, sb, LEFT_TEXT_X, CURRENT_LINE + ONE_DOC_HEIGHT);

                    g.DrawString(Data.NOMBRE1, fBody, sb, new Rectangle(RightTextX, 70, wTb, 20));
                    g.DrawString(Data.NOMBRE2, fBody, sb, new Rectangle(RightTextX, 70 + one_doc_height, wTb, 20));
                    g.DrawString(Data.DIRECCION1, fBody, sb, new Rectangle(RightTextX, 90, wTb, 20));
                    g.DrawString(Data.DIRECCION2, fBody, sb, new Rectangle(RightTextX, 90 + one_doc_height, wTb, 20));
                    g.DrawString(Data.TELEFONO1, fBody, sb, new Rectangle(RightTextX, 110, wTb, 20));
                    g.DrawString(Data.TELEFONO2, fBody, sb, new Rectangle(RightTextX, 110 + one_doc_height, wTb, 20));
                    g.DrawString(Data.CIUDAD1, fBody, sb, new Rectangle(RightTextX, 130, wTb, 20));
                    g.DrawString(Data.CIUDAD2, fBody, sb, new Rectangle(RightTextX, 130 + one_doc_height, wTb, 20));
                    g.DrawString(Data.REFERENCIA1, fBody, sb, new Rectangle(RightTextX, 150, wTb, 20));
                    g.DrawString(Data.REFERENCIA2, fBody, sb, new Rectangle(RightTextX, 150 + one_doc_height, wTb, 20));
                    g.DrawString(Data.CONSECUTIVO_CLIENTE1, fBody, sb, new Rectangle(RightTextX, 170, wTb, 20));
                    g.DrawString(Data.CONSECUTIVO_CLIENTE2, fBody, sb, new Rectangle(RightTextX, 170 + one_doc_height, wTb, 20));

                    g.DrawLine(new Pen(Color.Black, 1), LEFT_MARG, ONE_DOC_HEIGHT + 10, Width - RIGHT_MARG, ONE_DOC_HEIGHT + 10);
                    #endregion
                    break;
                case TypeDoc.Guia:
                    #region Guia
                    fBody = new Font("Consolas", 10, FontStyle.Regular);


                    JObject DataG = (JObject)DataToPrint;

                    int wwTb = 330;
                    int smWTb = 70;
                    int hTb = 35;
                    int firstField = 95;
                    int LeftTextX = 39;
                    int RTextX = 393;
                    int curField = firstField;

                    g.DrawString(DataG["REMITENTE_NOMBRE"].ToString(), fBody, sb, new Rectangle(LeftTextX, curField, wwTb, hTb));
                    g.DrawString(DataG["ORIGEN_VAL"].ToString(), fBody, sb, new Rectangle(RTextX, curField, wwTb, hTb));
                    string dest = DataG["DESTINATARIO_NOMBRE"].ToString() + Environment.NewLine + DataG["DESTINATARIO_DIRECCION"].ToString() + Environment.NewLine + DataG["DESTINATARIO_TELEFONO"].ToString();
                    g.DrawString(dest, fBody, sb, new Rectangle(LeftTextX, curField += 62, wwTb, hTb));
                    g.DrawString(DataG["DESTINO_VAL"].ToString(), fBody, sb, new Rectangle(RTextX, curField, wwTb, hTb));
                    string date = string.Format("{0:dd/MM/yyyy}", DataG["FECHA_ENVIO"]);
                    g.DrawString(date, fBody, sb, new Rectangle(LeftTextX, curField += 78, wwTb / 2, hTb));
                    g.DrawString(DataG["UNIDADES"].ToString(), fBody, sb, new Rectangle(RTextX, curField, smWTb, hTb));
                    g.DrawString(DataG["PESO"].ToString() + "Kgs", fBody, sb, new Rectangle(RTextX + smWTb, curField, smWTb, hTb));
                    g.DrawString(DataG["PESO_VOL"].ToString() + "Kgs", fBody, sb, new Rectangle(RTextX + (smWTb * 2), curField, smWTb, hTb));
                    g.DrawString(DataG["PESO_LIQ"].ToString() + "Kgs", fBody, sb, new Rectangle(RTextX + (smWTb * 3), curField, smWTb, hTb));
                    string curr = string.Format("{0:C0}", DataG["VALOR_DECLARADO"].ToString());
                    g.DrawString(curr, fBody, sb, new Rectangle(RTextX + (smWTb * 4), curField, smWTb, hTb));
                    g.DrawString(DataG["DICE_CONTENER"].ToString(), fBody, sb, new Rectangle(LeftTextX, curField += 59, wwTb, hTb));
                    g.DrawString(DataG["OBSERVACIONES"].ToString(), fBody, sb, new Rectangle(RTextX, curField, wwTb, hTb));
                    g.DrawString(DataG["ELABORADO_POR_VAL"].ToString(), fBody, sb, new Rectangle(LeftTextX, curField += 43, wwTb, hTb));
                    #endregion
                    break;
                default:
                    break;
            }
            //g.DrawImage(Images[0], 15, 31, 90, 31);
            //g.DrawImage(Images[0], 15, 255, 90, 31);
            //Font fBodyLabel = new Font("Lucida Console", 9, FontStyle.Bold);
            //Font fBody = new Font("Lucida Console", 9, FontStyle.Regular);
            //SolidBrush sb = new SolidBrush(Color.Black);

            //GUIA_LABEL_DUO Data = (GUIA_LABEL_DUO)DataToPrint;

            //Image x1 = (Bitmap)((new ImageConverter()).ConvertFrom(Data.BARCODE1));
            //Image x2 = (Bitmap)((new ImageConverter()).ConvertFrom(Data.BARCODE2));

            //g.DrawImage(x1, LEFT_TEXT_X, 204, 180, 27);
            //g.DrawImage(x2, LEFT_TEXT_X, 204 + ONE_DOC_HEIGHT, 180, 27);

            //float _wTb = Width - RIGHT_TEXT_X - RIGHT_MARG;
            //int wTb = int.Parse(_wTb.ToString());
            //int RightTextX = int.Parse(RIGHT_TEXT_X.ToString());
            //int one_doc_height = int.Parse(ONE_DOC_HEIGHT.ToString());

            //g.DrawString("Nombre:", fBodyLabel, sb, LEFT_TEXT_X, 70);
            //g.DrawString("Nombre:", fBodyLabel, sb, LEFT_TEXT_X, 70 + ONE_DOC_HEIGHT);
            //g.DrawString("Direccion:", fBodyLabel, sb, LEFT_TEXT_X, 90);
            //g.DrawString("Direccion:", fBodyLabel, sb, LEFT_TEXT_X, 90 + ONE_DOC_HEIGHT);
            //g.DrawString("Telefono:", fBodyLabel, sb, LEFT_TEXT_X, 110);
            //g.DrawString("Telefono:", fBodyLabel, sb, LEFT_TEXT_X, 110 + ONE_DOC_HEIGHT);
            //g.DrawString("Ciudad:", fBodyLabel, sb, LEFT_TEXT_X, 130);
            //g.DrawString("Ciudad:", fBodyLabel, sb, LEFT_TEXT_X, 130 + ONE_DOC_HEIGHT);
            //g.DrawString("Referencia:", fBodyLabel, sb, LEFT_TEXT_X, 150);
            //g.DrawString("Referencia:", fBodyLabel, sb, LEFT_TEXT_X, 150 + ONE_DOC_HEIGHT);
            //g.DrawString("Consec:", fBodyLabel, sb, LEFT_TEXT_X, 170);
            //g.DrawString("Consec:", fBodyLabel, sb, LEFT_TEXT_X, 170 + ONE_DOC_HEIGHT);

            //g.DrawString(Data.NOMBRE1, fBody, sb, new Rectangle(RightTextX, 70, wTb, 20));
            //g.DrawString(Data.NOMBRE2, fBody, sb, new Rectangle(RightTextX, 70 + one_doc_height, wTb, 20));
            //g.DrawString(Data.DIRECCION1, fBody, sb, new Rectangle(RightTextX, 90, wTb, 20));
            //g.DrawString(Data.DIRECCION2, fBody, sb, new Rectangle(RightTextX, 90 + one_doc_height, wTb, 20));
            //g.DrawString(Data.TELEFONO1, fBody, sb, new Rectangle(RightTextX, 110, wTb, 20));
            //g.DrawString(Data.TELEFONO2, fBody, sb, new Rectangle(RightTextX, 110 + one_doc_height, wTb, 20));
            //g.DrawString(Data.CIUDAD1, fBody, sb, new Rectangle(RightTextX, 130, wTb, 20));
            //g.DrawString(Data.CIUDAD2, fBody, sb, new Rectangle(RightTextX, 130 + one_doc_height, wTb, 20));
            //g.DrawString(Data.REFERENCIA1, fBody, sb, new Rectangle(RightTextX, 150, wTb, 20));
            //g.DrawString(Data.REFERENCIA2, fBody, sb, new Rectangle(RightTextX, 150 + one_doc_height, wTb, 20));
            //g.DrawString(Data.CONSECUTIVO_CLIENTE1, fBody, sb, new Rectangle(RightTextX, 170, wTb, 20));
            //g.DrawString(Data.CONSECUTIVO_CLIENTE2, fBody, sb, new Rectangle(RightTextX, 170 + one_doc_height, wTb, 20));

            //g.DrawLine(new Pen(Color.Black, 1), LEFT_MARG, ONE_DOC_HEIGHT + 10, Width - RIGHT_MARG, ONE_DOC_HEIGHT + 10);

        }


        #endregion

        public enum TypeDoc
        {
            Label,
            Guia
        }



    }
}
