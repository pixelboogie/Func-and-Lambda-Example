using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


// a program that takes a string and returns the lenght of it 
// public delegate int CharacterLength(string, text)

public class Main : MonoBehaviour
{
    public Func<string, int> CharacterLength;

    void Start()
    {
        CharacterLength = (name) => name.Length;;
        int count = CharacterLength("Shane");
        Debug.Log("Count: " + count);
    }

    // int GetCharacters(string name)
    // {
    //     return name.Length;
    // }
}
