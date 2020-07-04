using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var x = Convert.ToInt32(Request.QueryString["OGRID"]);
        Txtid.Text = x.ToString();
        Txtid.Enabled = false;
        if (Page.IsPostBack==false)
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
            TxtAd.Text = OgrList[0].Ad.ToString();
            TxtSoyad.Text = OgrList[0].Soyad.ToString();
            TxtSifre.Text = OgrList[0].Sifre.ToString();
            TxtNumara.Text = OgrList[0].Numara.ToString();
            TxtFoto.Text = OgrList[0].Fotograf.ToString();
        }
        
        


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = TxtAd.Text;
        ent.Soyad = TxtSoyad.Text;
        ent.Sifre = TxtSifre.Text;
        ent.Numara = TxtNumara.Text;
        ent.Fotograf = TxtFoto.Text;
        ent.Id = Convert.ToInt32(Txtid.Text);
        BLLOgrenci.OgrenciGuncelleBLL(ent);
        Response.Redirect("OgrenciListesi.aspx");

    }
}