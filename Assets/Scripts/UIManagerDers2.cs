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
    }

    private void DoktorBilgisiniYazdir() {
        uzmanlikAlaniText.text = "Kardiyoloji";
        mezuniyetYiliText.text = "1991";
        hastaneyeGirisTarihiText.text = "1992";
        hastaSayisiText.text = "5";
        emekliligineKalanYilText.text = "30";
    }

    private void DoktorBilgisiniYazdir2() {
    }
    private void DoktorBilgisiniYazdir3() {
    }
}
