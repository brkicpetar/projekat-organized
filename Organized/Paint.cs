using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organized
{
    internal class Paint
    {
        private Graphics platno;
        private int debljina;
        private bool solid;
        private Color boja;

        public Paint(Graphics platno)
        {
            this.platno = platno;
        }

        public void PostaviDebljinu(int debljina)
        {
            this.debljina = debljina;
        }
        public void PostaviPopunjenostOblika(bool solid)
        {
            this.solid = solid;
        }
        public void PostaviBoju(Color boja)
        {
            this.boja = boja;
        }

        public enum Oblik { linija, cetvorougao, elipsa, slobodnaRuka }

        public void Crtaj(Oblik oblik, Point A, Point B)
        {
            if (solid)
            {
                Brush brush = new SolidBrush(boja);
                switch (oblik)
                {
                    case Oblik.cetvorougao:
                        platno.FillRectangle(brush, A.X, A.Y, (float)Math.Abs(B.X - A.X), (float)Math.Abs(B.Y - A.Y));
                        break;
                    case Oblik.elipsa:
                        platno.FillEllipse(brush, A.X, A.Y, (float)Math.Abs(B.X - A.X), (float)Math.Abs(B.Y - A.Y));
                        break;
                    case Oblik.slobodnaRuka:
                        break;
                }
            }
            else
            {
                Pen pen = new Pen(boja, debljina);
                switch (oblik)
                {
                    case Oblik.linija:
                        platno.DrawLine(pen, A, B);
                        break;
                    case Oblik.cetvorougao:
                        platno.DrawRectangle(pen, A.X, A.Y, (float)Math.Abs(B.X - A.X), (float)Math.Abs(B.Y - A.Y));
                        break;
                    case Oblik.elipsa:
                        platno.DrawEllipse(pen, A.X, A.Y, (float)Math.Abs(B.X - A.X), (float)Math.Abs(B.Y - A.Y));
                        break;
                    case Oblik.slobodnaRuka:
                        break;
                }
            }

        }
    }
}
