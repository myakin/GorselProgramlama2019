using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerDers2 : MonoBehaviour
{
    public Button doktor1Button, doktor2Button, doktor3Button;
    public Text uzmanlikAlaniText;
    public Text mezuniyetYiliText;
    public Text hastaneyeGirisTarihiText;
    public Text hastaSayisiText;
    public Text emekliligineKalanYilText;


    private void Start() {
        doktor1Button.onClick.AddListener(DoktorBilgisiniYazdir);
        doktor2Button.onClick.AddListener(DoktorBilgisiniYazdir2);
        doktor3Button.onClick.AddListener(DoktorBilgisiniYazdir3);
    }

    private void DoktorBilgisiniYazdir() {
        uzmanlikAlaniText.text = "Kardiyoloji";
        mezuniyetYiliText.text = "1991";
        hastaneyeGirisTarihiText.text = "1992";
        hastaSayisiText.text = "5";
        emekliligineKalanYilText.text = "30";
    }

    private void DoktorBilgisiniYazdir2() {
        uzmanlikAlaniText.text = "Endokrinoloji";
        mezuniyetYiliText.text = "2001";
        hastaneyeGirisTarihiText.text = "2005";
        hastaSayisiText.text = "30";
        emekliligineKalanYilText.text = "40";
    }
    private void DoktorBilgisiniYazdir3() {
        uzmanlikAlaniText.text = "Dermatoloji";
        mezuniyetYiliText.text = "2016";
        hastaneyeGirisTarihiText.text = "2016";
        hastaSayisiText.text = "60";
        emekliligineKalanYilText.text = "50";
    }
}
