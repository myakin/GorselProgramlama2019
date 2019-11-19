using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DataManager : MonoBehaviour
{
    

    public void Save() {
        UIManagerDers4 myUIManager = GetComponent<UIManagerDers4>();
        
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/kisiBilgileri.botednm");

        bf.Serialize(file, myUIManager.programVerileri);
        file.Close();

        Debug.Log("Veriler kaydedildi");

    }
    public void Load() {
        if (File.Exists(Application.persistentDataPath + "/kisiBilgileri.botednm")) {
            UIManagerDers4 myUIManager = GetComponent<UIManagerDers4>();

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/kisiBilgileri.botednm", FileMode.Open);
            
            myUIManager.programVerileri = (List<DataUnit>)bf.Deserialize(file);
            file.Close();

            Debug.Log("Kayitlar yuklendi");

        } else {
            Debug.Log("Bir kayit dosyasi bulunamadi.");
        }
    }
}
