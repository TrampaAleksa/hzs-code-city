using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unosPodataka : MonoBehaviour
{
    [System.Serializable]
    class Osoba {
       public int score;
       public string name;
    }
    class Osobe
    {
        public List<Osoba> ljudi;
    }

    public void Unesi() {
        Osoba nova = new Osoba();
        nova.name = "marko";
        nova.score = 10000;
        Osobe skor = new Osobe();
        skor.ljudi.Add(nova);
        JsonUtility.ToJson(skor);

    }

    public void HZSSajt()
    {
        Application.OpenURL("http://hzs.fonis.rs");
    }
}
