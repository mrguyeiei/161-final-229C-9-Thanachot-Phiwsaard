using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Xml.Serialization;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;
    
    public string void lnit()
    {
        
    }

    public abstract float CalcualteArea()
    {
        Behaviour;
    }
    public void Resize(float width, float height)
    {
        Debug.Log($"Resizing{shapeName}");

    }
    public void Draw()
    {
        
    }
}
