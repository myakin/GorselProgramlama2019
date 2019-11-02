using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public Text baslikText;
    public Text solKolonOrtaText;
    private int sayim;

    private void Start() {
        baslikText.text = "Merhaba";
    }

    private void Update() {
        sayim++;
        solKolonOrtaText.text = "Sayim: " + sayim;
    }


}
