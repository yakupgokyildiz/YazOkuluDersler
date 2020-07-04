using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        }
        public static int talepEkleBLL(EntityBasvuruForm p)
        {
            if (p.Basvuruogrid>0 && p.Basvurudersid>0)
            {
                return DALDers.TalepEkle(p);
            }
            else
            {
                return -1;
            }
        }
    }
}
