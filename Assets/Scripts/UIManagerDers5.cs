using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManagerDers5 : MonoBehaviour
{
    public InputField adInputField, soyadInputField, yasInputField, meslekInputField, adresInputField;
    public InputField kayitNoInputField;
    public Button gonderButton, onayButton, kaydiYukleButton, kaydetButton, yukleButton;
    public Text adText, soyadText, yasText, meslekText, adresText;
    public Transform bilgiKontrolPanel;
    public GameObject girdiPrefabi, kayitYuklePaneli;


    public List<DataUnit> programVerileri = new List<DataUnit>();

    private void Start() {
        onayButton.onClick.AddListener(OnaylanmisBilgileriKaydet);
        gonderButton.onClick.AddListener(BilgileriGonder);
        //kaydiYukleButton.onClick.AddListener(BilgileriEkranaYukle);
        kaydetButton.onClick.AddListener(VerileriDiskeKaydet);
        yukleButton.onClick.AddListener(VerileriDisktenGeriYukle);
        bilgiKontrolPanel.gameObject.SetActive(false);
    }

    private void VerileriDisktenGeriYukle() {
        GetComponent<DataManager>().Load();
    }
    private void VerileriDiskeKaydet() {
        GetComponent<DataManager>().Save();
    }

    public void BilgileriEkranaYukle(DataUnit birDataUnit, bool istekYeniGirdidenGeliyor=true) {
        bilgiKontrolPanel.gameObject.SetActive(true);
        // if (istekYeniGirdidenGeliyor) {
        //     onayButton.gameObject.SetActive(true);
        // } else {
        //     onayButton.gameObject.SetActive(false);
        // }
        // yukaridaki 5 satir inline olarak su sekilde de yazilabilir:
        // istekYeniGirdidenGeliyor ? true : false
        // istekYeniGirdidenGeliyor ise true degilse false
        // ? = ise, : = degilse
        // setEtmekIstedigimBirDeger = ... ? ... : ...;
        onayButton.gameObject.SetActive(istekYeniGirdidenGeliyor ? true : false);
        // int kayitNo = int.Parse(kayitNoInputField.text) - 1;
        adText.text = birDataUnit.ad;
        soyadText.text = birDataUnit.soyad;
        yasText.text = birDataUnit.yas;
        meslekText.text = birDataUnit.meslek;
        adresText.text = birDataUnit.adres;
    }


    private void BilgileriGonder() {
        DataUnit yeniGirdiBirimi = new DataUnit(adInputField.text, soyadInputField.text, yasInputField.text, meslekInputField.text, adresInputField.text);
        BilgileriEkranaYukle(yeniGirdiBirimi);
    }

    private void OnaylanmisBilgileriKaydet() {
        DataUnit yeniVeriGirdisi = new DataUnit(adText.text, soyadText.text, yasText.text, meslekText.text, adresText.text);
        programVerileri.Add(yeniVeriGirdisi);
    }

    public void YuklenenVerileriEkranaIsle(List<DataUnit> birDataListesi) {
        YuklenenVerilerButonlariAlaniniTemizle();
        programVerileri = birDataListesi;
        for (int i=0; i<birDataListesi.Count; i++) {
            GameObject girdiBirimiObjesi = Instantiate(girdiPrefabi, kayitYuklePaneli.transform);
            girdiBirimiObjesi.GetComponent<DataUnitPrefabManager>().BirimiBaslat(birDataListesi[i], GetComponent<UIManagerDers5>());
        }
    }

    public void YuklenenVerilerButonlariAlaniniTemizle() {
        for(int i=0; i<kayitYuklePaneli.transform.childCount; i++) {
            Destroy(kayitYuklePaneli.transform.GetChild(i).gameObject);
        }
    }

    
}
