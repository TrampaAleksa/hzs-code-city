using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeSegmentsList : MonoBehaviour
{
    public CodeSegmentHolder[] allSegments;
    CodeSegment[] codes;
    private string[] initialCodes;
    public GameObject[] dropDownAreas;
    
    public Text[] codeHolders;
    // Start is called before the first frame update
    void Start()
    {
        codes = allSegments[0].codeSegments;

        initialCodes = new string[codes.Length];
        for (int j = 0; j < codes.Length; j++)
        {
            initialCodes[j] = codes[j].getCode();
        }
        RandomizeArray.randomize(codes, 3);
        int i = 0;
        
      foreach(var code in codeHolders) {
            code.text = codes[i].getCode();
            i++;
      }
        print("call");
        dropdownCodeSameAsInitial();
    }

    public bool dropdownCodeSameAsInitial()
    {
        if (codes == null) return false;
        string[] codesFromDropdown = new string[codes.Length];
        int i = 0;
        foreach(var dropdownArea in dropDownAreas)
        {
            codesFromDropdown[i] = dropdownArea.GetComponentInChildren<Text>().text;
            i++;
        }
        for( i=0; i<initialCodes.Length; i++)
        {
            if (initialCodes[i] != codesFromDropdown[i]) return false;
        }
        print("Same");
        return true;
    }



}
