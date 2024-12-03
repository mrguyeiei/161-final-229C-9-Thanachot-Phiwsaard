using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Circle : Shape
{
    private readonly float radius = 2;

    protected Circle(float radius)
    {
        this.radius = radius;
    }

}
