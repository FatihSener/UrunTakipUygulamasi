using _08_MDIForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MDIForm.Database
{
    public class Db_Context
    {
        public static ICollection<Urun> Urunler = new HashSet<Urun>();
    }
}
