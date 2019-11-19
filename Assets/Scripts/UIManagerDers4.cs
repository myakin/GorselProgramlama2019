using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerDers4 : MonoBehaviour
{
    public InputField adInputField, soyadInputField, yasInputField, meslekInputField, adresInputField;
    public InputField kayitNoInputField;
    public Button gonderButton, onayButton, kaydiYukleButton, kaydetButton, yukleButton;
    public Text adText, soyadText, yasText, meslekText, adresText;
    public Transform bilgiKontrolPanel;

    public List<DataUnit> programVerileri = new List<DataUnit>();

    private void Start() {
        onayButton.onClick.AddListener(OnaylanmisBilgileriKaydet);
        gonderButton.onClick.AddListener(BilgileriGonder);
        kaydiYukleButton.onClick.AddListener(BilgileriEkranaYukle);
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

    private void BilgileriEkranaYukle() {
        int kayitNo = int.Parse(kayitNoInputField.text) - 1;
        adText.text = programVerileri[kayitNo].ad;
        soyadText.text = programVerileri[kayitNo].soyad;
        yasText.text = programVerileri[kayitNo].yas;
        meslekText.text = programVerileri[kayitNo].meslek;
        adresText.text = programVerileri[kayitNo].adres;
    }


    private void BilgileriGonder() {
        bilgiKontrolPanel.gameObject.SetActive(true);
        adText.text = adInputField.text;
        soyadText.text = soyadInputField.text;
        yasText.text = yasInputField.text;
        meslekText.text = meslekInputField.text;
        adresText.text = adresInputField.text;
    }

    private void OnaylanmisBilgileriKaydet() {
        DataUnit yeniVeriGirdisi = new DataUnit();
        yeniVeriGirdisi.ad = adText.text;
        yeniVeriGirdisi.soyad = soyadText.text;
        yeniVeriGirdisi.yas = yasText.text;
        yeniVeriGirdisi.meslek = meslekText.text;
        yeniVeriGirdisi.adres = adresText.text;

        programVerileri.Add(yeniVeriGirdisi);

    }
}
