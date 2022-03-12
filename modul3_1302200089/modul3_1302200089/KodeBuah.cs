using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200089
{
    internal class KodeBuah
    {
        private string A00;
        private string B00;
        private string C00;
        private string D00;
        private string E00;
        private string F00;
        private string H00;
        private string I00;
        private string J00;
        private string K00;
        private string L00;
        private string M00;
        private string N00;
        private string O00;

        //public int A00 { get; private set; }
        //public int B00 { get; private set; }
        //public int C00 { get; private set; }
        //public int D00 { get; private set; }
        //public int E00 { get; private set; }
        //public int F00 { get; private set; }
        //public int H00 { get; private set; }
        //public int I00 { get; private set; }
        //public int J00 { get; private set; }
        //public int K00 { get; private set; }
        //public int L00 { get; private set; }
        //public int M00 { get; private set; }
        //public int N00 { get; private set; }
        //public int O00 { get; private set; }

        public enum buah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, 
            Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka};

        public string getKodeBuah(buah Buah)
        {
            string[] arrayKode = { A00, B00, C00, D00, E00, F00, H00,
                I00, J00, K00, L00, M00, N00, O00};

            return arrayKode[(int)Buah];
        }
    }

}
