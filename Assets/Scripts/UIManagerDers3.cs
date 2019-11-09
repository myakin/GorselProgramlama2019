using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerDers3 : MonoBehaviour
{
    public Text goruntuleyiciText;
    public Button gonderButton;
    public InputField adGirisiInputField;

    private void Start() {
        gonderButton.onClick.AddListener(BilgileriGonder);
    }
    
    private void BilgileriGonder() {
        string adGirdisi = adGirisiInputField.text;
        goruntuleyiciText.text = adGirdisi;
    }

}
