using System;

namespace GameLib
{
    public enum Seviye
    {
        Kolay,
        Orta,
        Zor
    }
    public class GameInfo
    {
        public GameInfo()
        {

        }
        public GameInfo(string ad, string soyad, Seviye level)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Level = level;
        }

        private string ad;
        private string soyad;
        private Seviye level;

        public string Ad { get => ad; set => ad = value.ToUpper(); }
        public string Soyad { get => soyad; set => soyad = value.ToUpper(); }
        public Seviye Level { get => level; set => level = value; }
    }
}
