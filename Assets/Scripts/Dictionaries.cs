using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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

        // Print out value of given key, but only if it exists
        if(characterDict.TryGetValue("Edwin", out int value)){
            print(value);
        }

        // Print each key value pair
        foreach(KeyValuePair<string,int> row in characterDict)
        {
            print(row);
        }

        // Print each key /value
        foreach (KeyValuePair<string, int> row in characterDict)
        {
            print(row.Key); //row.Value
        }

        // Removing key value pair by key
        characterDict.Remove("Minsc");

        // Check if specified key/value exists
        if (characterDict.ContainsKey("Edwin")) //ContainsValue(...)
            print("Edwin found!");

        // Copy dictionary to another dictionary
        Dictionary<string, int> secondDictionary = new Dictionary<string, int>(characterDict);
                     


        // Clear dictionary
        characterDict.Clear();
        print(characterDict.Count); //0
        print($"secondDictionary has {secondDictionary.Count} values");


        // Convert array to dictionary with LINQ
        string[] simpsons = new string[] { "Homer", "Bart", "Marge" };
        Dictionary<string,string>dictSimpsons = simpsons.ToDictionary(item => item, item => "Simpson");

        //var dictSimpsons = simpsons.ToDictionary(item => item, item => "Simpson");

        foreach ( var name in dictSimpsons)
        {
            print(name);
            //print(name.Key);
            //print(name.Value);
        }


    }
}
