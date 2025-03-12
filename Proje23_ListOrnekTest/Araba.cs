using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje23_ListOrnekTest
{
    class Araba
    {
        private string marka;
        private string model;
        private int yil;
        private string renk;
        private string vitesTuru;
        private string yakitTuru;
        private double motorHacmi;
        private int beygirGucu;
        private int maksimumHiz;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Yil { get => yil; set => yil = value; }
        public string Renk { get => renk; set => renk = value; }
        public string VitesTuru { get => vitesTuru; set => vitesTuru = value; }
        public string YakitTuru { get => yakitTuru; set => yakitTuru = value; }
        public double MotorHacmi { get => motorHacmi; set => motorHacmi = value; }
        public int BeygirGucu { get => beygirGucu; set => beygirGucu = value; }
        public int MaksimumHiz { get => maksimumHiz; set => maksimumHiz = value; }
    }
}
