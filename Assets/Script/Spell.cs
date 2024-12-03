using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public void Cast()
    {

    }
    public void Cast(string Gonlin , string Slime)
    {
        Debug.Log($"{IceSpell}Freeze the enemy");
        Debug.Log($"spell on target{Gonlin}");
        Debug.Log($"spell on ")
    }    
    public void Cast(string Gonlin , string Slime , int power)
    {

    }
}
