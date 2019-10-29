using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class highscore : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;

    void Awake()
    {
        Osobe osobe = new Osobe();
        osobe = ispisi();
        entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        float templateHeight = 22.62f;
        for (int i = 0; i < osobe.ljudi.Count; i++)
        {
            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTransform.gameObject.SetActive(true);
            int rank = i+1;
            string rankString;
            switch (rank) {
                default: rankString = rank+ "th"; break;
                case 1: rankString = "1st";break;
                case 2: rankString = "2st";break;
                case 3: rankString = "3st";break;
            }
            entryTransform.Find("posText").GetComponent<Text>().text = rankString;
            entryTransform.Find("nameText").GetComponent<Text>().text = osobe.ljudi[i].name;
            entryTransform.Find("scoreText").GetComponent<Text>().text = osobe.ljudi[i].score;
            if (i == 9)
                break;
        }
    }

    public Osobe ispisi()
    {
        Osobe osobe = new Osobe();
        StreamReader sr = new StreamReader("Assets/highscore.txt");
        string sve = sr.ReadToEnd();
        sr.Close();
        string[] nizovi = sve.Split(';');
        int br = nizovi.Length;
        for (int i = 0; i < br - 1; i++)
        {
            string[] privremeni = nizovi[i].Split('$');
            Osoba osoba = new Osoba();
            osoba.name = privremeni[0];
            osoba.score = privremeni[1];
            osobe.ljudi.Add(osoba);
        }
        sort(osobe.ljudi);
        return osobe;
    }

    void sort(List<Osoba> osobe)
    {
        for (int i = 0; i < osobe.Count - 1; i++)
        {
            for (int j = i + 1; j < osobe.Count; j++)
            {
                int broj1, broj2;
                int.TryParse(osobe[i].score, out broj1);
                int.TryParse(osobe[j].score, out broj2);
                if (broj1 < broj2)
                {
                    Osoba temp = new Osoba();
                    temp = osobe[i];
                    osobe[i] = osobe[j];
                    osobe[j] = temp;
                }
            }
        }
    }
    public class Osobe
    {
        public List<Osoba> ljudi = new List<Osoba>();

    }

    public void vratiUMM()
    {
        SceneManager.LoadScene(0);
    }

    public class Osoba
    {
        public string score;
        public string name;
    }
}
