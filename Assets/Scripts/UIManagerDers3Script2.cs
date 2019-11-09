using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// DERS 3 ODEVI:
// Bir kisisel gunluk uygulmasi yapiniz
// 1. Ekranin altinda bir adet boydan geisletilmis bit InputField olacak
// 2. Bu input fieldin altinda 1 adet Gonder butonu olcak
// 3. Gonder butonunun hizasinda saga dayali bir KAYDET butonu olacak
// 4. Gonder butonunu hizasinda sola dayali SIFIRLA butonu olacak
// 5. Ekranin geri kalani bir TEXT objesi olacak. 
// Bunun icinde paragraflarca yazi goruntuleyecegiz.
// 6. Gonder butonuna tiklandiginda InputField icindeki texti 5. maddedeki 
// TEXT objesinin icine ekleyecek ama onceden girilmis text varsa onu silmeden
// onceki metnin devamina ekleyecek
// 7. GONDER butonuna bastigimizda 5. maddedeki TEXT objesinin tum metnini bir 
// listeye (List<string>) ekleyecek
// 8. SIFIRLA butonuna bastigimizda 5. madedeki TEXT objesinin tum metni silinecek.


public class UIManagerDers3Script2 : MonoBehaviour
{
    public InputField adInputField, soyadInputField, yasInputField, meslekInputField, adresInputField;
    public Button gonderButton, onayButton;
    public Text adText, soyadText, yasText, meslekText, adresText;
    public Transform bilgiKontrolPanel;

    public List<string> programVerileri = new List<string>();

    private void Start() {
        bilgiKontrolPanel.gameObject.SetActive(false);
    }

    public void BilgileriGonder() {
        bilgiKontrolPanel.gameObject.SetActive(true);
        adText.text = adInputField.text;
        soyadText.text = soyadInputField.text;
        yasText.text = yasInputField.text;
        meslekText.text = meslekInputField.text;
        adresText.text = adresInputField.text;
    }

    public void OnaylanmisBilgileriKaydet() {
        programVerileri.Add(adText.text);
        programVerileri.Add(soyadText.text);
        programVerileri.Add(yasText.text);
        programVerileri.Add(meslekText.text);
        programVerileri.Add(adresText.text);
    }

}
