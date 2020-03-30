using System;
using System.Collections.Generic;
using System.Text;

namespace Buyuk_Kucuk_Kontrol
{
    class KontrolMekanizmasi
    {
        #region TANIMLAMALAR
        string[] BuyukKalin ={ "a", "ý", "o", "u" };
        string[] BuyukInce ={ "e", "i", "ö", "ü" };
        string[] KucukDuz = { "a", "e", "ý", "i" };
        string[] KucukYuvarlak = { "o", "ö", "u", "ü" };
        string[] KucukYuvarlakDar = { "u", "ü" };
        string[] KucukYuvarlakDuzGenis ={ "a", "e" };
        bool kalinKon, inceKon, BuyukSnc;
        bool DuzKon = false, YuvKont = false, KckDuzSnc;
        bool Yuv1, Yuv2, KckYuvSnc, Kont_o, Kont_ö, SncKont;
        int ayir1, ayir2;
        string ayrilmis1, ayrilmis2;
        #endregion
        public bool BuyukKontrol(string kelime)
        {
            kalinKon = false;
            inceKon = false;
            // HATALI NOKTA 
            //1)"kalinKon = kelime.Contains(BuyukKalin[b]);"
            //2)"inceKon = kelime.Contains(BuyukInce[b]);"
            // yukarýdaki bölümleri DÜZ KONTROLDEKÝ gibi iflerle sýnýrlandýrmayý atlamýþým.
            
            for (int b = 0; b < 4; b++)
            {
                if (kalinKon==false)
                {
                    kalinKon = kelime.Contains(BuyukKalin[b]);
                }
                if (inceKon==false)
                {
                    inceKon = kelime.Contains(BuyukInce[b]);
                }
                
                if (kalinKon == true && inceKon == true)
                {
                    break;
                }
            }
            if (kalinKon == true && inceKon == true)
            {
                BuyukSnc = false;
            }
            else
            {
                BuyukSnc = true;
            }
            return BuyukSnc;
        }
        public bool KucukKontrol(string kelime)
        {
            #region DUZ KONTROL
            DuzKon = false;
            YuvKont = false;
            for (int m = 0; m < 4; m++)
            {
                if (DuzKon == false)
                {
                    DuzKon = kelime.Contains(KucukDuz[m]);
                }
                if (YuvKont == false)
                {
                    YuvKont = kelime.Contains(KucukYuvarlak[m]);
                }
                if (DuzKon == true && YuvKont == true)
                {
                    break;
                }
            }
            if (DuzKon == true && YuvKont == true)
            {
                KckDuzSnc = false;
            }
            else
            {
                KckDuzSnc = true;
            }
            #endregion
            #region YUVARLAK KONTROL
            if (kelime.Contains("o") || kelime.Contains("ö") || kelime.Contains("u") || kelime.Contains("ü"))
            {
                ayir1 = kelime.IndexOf("o");
                ayir2 = kelime.IndexOf("ö");
                if (ayir1 >= 0)
                {
                    ayrilmis1 = kelime.Substring(ayir1, kelime.Length);
                    Kont_o = ayrilmis1.Contains("o");
                }
                else if (ayir2 >= 0)
                {
                    ayrilmis2 = kelime.Substring(ayir2, kelime.Length);
                    Kont_ö = ayrilmis2.Contains("ö");
                }

                if (Kont_o == true || Kont_ö == true)
                {
                    Yuv2 = true;
                }
                else
                {
                    Yuv2 = false;
                }
                for (int y = 2; y < 4; y++)
                {
                    Yuv1 = kelime.Contains(KucukDuz[y]);
                    if (Yuv1 == true)
                    {
                        break;
                    }
                }
                if (Yuv1 == true || Yuv2 == true)
                {
                    SncKont = false;
                }
                else
                {
                    SncKont = true;
                }
                if (SncKont == false || KckDuzSnc == false)
                {
                    KckYuvSnc = false;
                }
                else
                {
                    KckYuvSnc = true;
                }
            }
            KckYuvSnc = KckDuzSnc;
            return KckYuvSnc;
            #endregion

        }
    }
}
