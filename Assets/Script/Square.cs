using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Square : Shape
{
    private int side = 2;
      
    public abstract float CalcualteArea()
    {
        Debug.Log($"Squarearea{4}");
    }
    public void Resize()
    {
        
    }



}
