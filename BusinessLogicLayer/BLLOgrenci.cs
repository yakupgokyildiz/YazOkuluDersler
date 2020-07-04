using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad!=null && p.Soyad!=null && p.Numara!=null && p.Sifre!=null &&p.Fotograf!=null
                && p.Ad != "" && p.Soyad != "" && p.Numara != "" && p.Sifre != "" && p.Fotograf != "")
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int p)
        {
            if (p>0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            else
            {
                return false;
            }
        }

        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Fotograf != null && p.Id>0 &&
                p.Ad != "" && p.Soyad != "" && p.Numara != "" && p.Sifre != "" && p.Fotograf != "")
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
