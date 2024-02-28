using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour
{
    Dictionary<string, int> characterDict = new Dictionary<string, int>();

    private void Awake()
    {
        // Adding key value -pairs to dictionary with Add()
        characterDict.Add("Edwin", 10);
        characterDict.Add("Minsc", 18);

        
    }

    private void Start()
    {
        print(characterDict.Count); // 2
    }
}
