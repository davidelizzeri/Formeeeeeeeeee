using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Formeeeeeeeeee
{
    public partial class Figure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btn_R(object sender, EventArgs e)
        {
            tbl_LatoAlt.Visible = true;
            tbl_Figure.Visible = false;
            btn_Indietro.Visible = true;
        }
        protected void btn_T(object sender, EventArgs e)
        {
            lbl_tipoT.Visible = true;
            lbl_tipoT.Text = "Ogni triangolo è equilatero";
            tbl_T.Visible = true;
            tbl_Figure.Visible = false;
            btn_Indietro.Visible = true;
        }
        protected void btn_C(object sender, EventArgs e)
        {
            tbl_Raggio.Visible = true;
            tbl_Figure.Visible = false;
            btn_Indietro.Visible = true;
        }
        protected void btn_CalcoloPerT(object sender, EventArgs e) 
        {
            Trinagolo t = new Trinagolo();
            double perimetroT=t.Perimetro(Convert.ToDouble(txtLatoT.Text));
            lbl_PerT.Visible = true;
            lbl_PerT.Text = "Il perimetro è:" + perimetroT;
        }
        protected void btn_CalcoloAreaT(object sender, EventArgs e) 
        {
            Trinagolo t = new Trinagolo();
            double areaT = t.Area(Convert.ToDouble(txt_AltT.Text), Convert.ToDouble(txtLatoT.Text));
            lbl_AreaT.Visible = true;
            lbl_AreaT.Text = "L'Area è:" + areaT;
        }
        protected void btn_CalcoloPer(object sender, EventArgs e) 
        {
          if(txt_Lato.Text == txt_Altezza.Text)
            {
                lbl_TipoRett.Visible = true;
                lbl_TipoRett.Text = "Visto che lato ed altezza sono uguali abbiamo un quadrato";
                Quadrato q = new Quadrato();
                double perQ = q.Perimetro(Convert.ToDouble(txt_Lato.Text));
                lbl_Perimetro.Visible = true;
                lbl_Perimetro.Text = "il Perimetro è:" + perQ;
            }
            else 
            {
                Rettangolo r = new Rettangolo();
                double perR = r.Perimetro(Convert.ToDouble(txt_Lato.Text), Convert.ToDouble(txt_Altezza.Text));
                lbl_Perimetro.Visible = true;
                lbl_Perimetro.Text = "il perimetro è:" + perR;
            }      
        }
        protected void btn_CalcoloArea(object sender, EventArgs e)
        {
            if(txt_Lato.Text == txt_Altezza.Text)
            {
                lbl_TipoRett.Visible = true;
                lbl_TipoRett.Text = "Visto che lato ed altezza sono uguali abbiamo un quadrato";
                Quadrato q = new Quadrato();
                double areaQ = q.Area(Convert.ToDouble(txt_Lato.Text));
                lbl_Area.Visible = true;
                lbl_Area.Text = "l'area è:" + areaQ;
            }
            else
            {
                Rettangolo r = new Rettangolo();
                double areaR = r.Area(Convert.ToDouble(txt_Lato.Text), Convert.ToDouble(txt_Altezza.Text));
                lbl_Area.Visible = true;
                lbl_Area.Text = "l'area è:" + areaR;
            }
        }
        protected void btn_CalcoloCirc(object sender, EventArgs e)
        {
            Cerchio c = new Cerchio();
            double circonferenza = c.Perimetro(Convert.ToDouble(txt_Raggio.Text));
            lbl_Circ.Visible = true;
            lbl_Circ.Text = "la Circonferenza è:" + circonferenza;
        }
        protected void btn_CalcoloAreaC(object sender, EventArgs e) 
        {
            Cerchio c = new Cerchio();
            double areaC = c.Area(Convert.ToDouble(txt_Raggio.Text));
            lbl_Area2.Visible = true;
            lbl_Area2.Text = "la superficie è:" + areaC;
        }
        protected void btn_IndietroClick(object sender, EventArgs e)
        {
            tbl_Figure.Visible = true;
            tbl_LatoAlt.Visible = false;
            tbl_T.Visible = false;
            btn_Indietro.Visible = false;
            tbl_Raggio.Visible = false;
            lbl_TipoRett.Visible = false;
            lbl_tipoT.Visible = false;
        }

    }
}