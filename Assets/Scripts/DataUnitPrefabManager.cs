using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataUnitPrefabManager : MonoBehaviour {
    public Text butonMetinAlaniText;
    private DataUnit benimDataUnitim;
    private UIManagerDers5 benimBeraberIsYaptigimScript;

    public void BirimiBaslat(DataUnit birDataUnit, UIManagerDers5 birUIMaagerScripti) {
        this.benimDataUnitim = birDataUnit;
        this.benimBeraberIsYaptigimScript = birUIMaagerScripti;
        butonMetinAlaniText.text = this.benimDataUnitim.ad + " " + this.benimDataUnitim.soyad;

        GetComponent<Button>().onClick.AddListener(ButonaTiklayincaBilgilerimiYazdir);
    }

    private void ButonaTiklayincaBilgilerimiYazdir() {
        benimBeraberIsYaptigimScript.BilgileriEkranaYukle(benimDataUnitim, false);
    }
}
