using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class CodeController : MonoBehaviour
{
    public CodeSegmentHolder[] allSegments;
    private int[] randomIndexes;
    private CodeSegment[] codes;
    private string[] initialCodes;
    public Text[] codeHolders;
    public GameObject[] dropDownAreas;

    public GameObject quizPanel;
    public GameObject typewritterPanel;

    private int segmentHolderIndex = 0;

    private void Awake()
    {

        SetFirstNRandomIndexes(allSegments.Length);
    }

    void SetFirstNRandomIndexes(int numberOfSegments)
    {

        randomIndexes = new int[numberOfSegments];
        for(int i=0; i<numberOfSegments; i++)
        {
            randomIndexes[i] = i;
        }
       
        RandomizeArray.randomize(randomIndexes, numberOfSegments);
       
    }

    void OnEnable()
    {
        print(randomIndexes[segmentHolderIndex]);
        codes = allSegments[randomIndexes[segmentHolderIndex]].codeSegments;

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

        foreach (var code in codeHolders)
        {
            code.text = randomizedCodes[i];
            i++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
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
        segmentHolderIndex++;
    }

    public bool DropdownCodeSameAsInitial()
    {
        print(quizPanel.activeSelf);
        if (codes == null || !quizPanel.activeSelf)
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

    public string[] GetInitialCode()
    {
        return initialCodes;
    }

    public void TriggerQuiz()
    {
            quizPanel.SetActive(!quizPanel.activeSelf);
        print("triggered quiz!");
    }

}
