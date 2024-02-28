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

        //Changing value of key value -pair
        characterDict["Edwin"] = 11;

        characterDict["Max"] = 12; // NOTE: no error thrown if key doesn't exist!

        // Adding key only if it doesn't already exist
        characterDict.TryAdd("Edwin", 15); //won't be added, because Edwin already exists
        
    }

    private void Start()
    {
        print(characterDict.Count); // 3
    }
}
