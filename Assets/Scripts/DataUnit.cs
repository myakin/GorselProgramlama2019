using System.Collections; // normalde burada bunlara da gerek yok
using System.Collections.Generic; // normalde burada bunlara da gerek yok
using UnityEngine; // normalde bunlara burada da gerek yok

[System.Serializable]
public class DataUnit
{
    public string ad;
    public string soyad;
    public string yas;
    public string meslek;
    public string adres;

    public DataUnit() {}

    public DataUnit(string birAd, string birSoyad, string birYas, string birMeslek, string birAdres) {
        this.ad = birAd;
        this.soyad = birSoyad;
        this.yas = birYas;
        this.meslek = birMeslek;
        this.adres = birAdres;
    }

}
