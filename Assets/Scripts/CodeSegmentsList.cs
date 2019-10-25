using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class CodeSegmentsList : MonoBehaviour
{
    public CodeSegmentHolder[] allSegments;
    private CodeSegment[] codes;
    private string[] initialCodes;
    public Text[] codeHolders;
    public GameObject[] dropDownAreas;

    public GameObject quizPanel;
    public GameObject typewritterPanel;




    // Start is called before the first frame update
    void Start()
    {
        codes = allSegments[0].codeSegments;
        string[] randomizedCodes;

        initialCodes = new string[codes.Length];
        randomizedCodes = new string[codes.Length];
        for (int j = 0; j < codes.Length; j++)
        {
            initialCodes[j] = codes[j].getCode();
            randomizedCodes[j] = initialCodes[j];
        }
        
        RandomizeArray.randomize(randomizedCodes, randomizedCodes.Length);

        int i = 0;
        
      foreach(var code in codeHolders) {
            code.text = randomizedCodes[i];
            i++;
      }
    }

    public void QuizComplete()
    {
       if(DropdownCodeSameAsInitial())
        {
            quizPanel.SetActive(!quizPanel.activeSelf);
            typewritterPanel.SetActive(!typewritterPanel.activeSelf);
            Debug.Log("Congratz! Correct order");
        }
       else
        {
            quizPanel.SetActive(!quizPanel.activeSelf);
            Debug.Log("Shame,You failed!");
        }
    }

    public bool DropdownCodeSameAsInitial()
    {
        if (codes == null)
        {
            Debug.Log("Error, no codes provided");
            return false;
        }

        string[] codesFromDropdown = new string[codes.Length];

        for(int i=0; i<initialCodes.Length; i++)
        {
            codesFromDropdown[i] = dropDownAreas[i].GetComponentInChildren<Text>().text;

            if (initialCodes[i] != codesFromDropdown[i])
            {
                return false;
            }
        }
        return true;
    }



}
