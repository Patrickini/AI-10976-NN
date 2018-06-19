using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackP {

    
	public float FErrorD(int k, float yj, float yi)
    {
        return (k * Mathf.Pow((yj - yi), 2)) / 2;
    }
    public float Weight(float w, float a, float x, float dx, float y,float yi)
    {
        return (w + a) * (y - yi) * dx * x;
    }
    public float InnerWeight(int k, float w, float a, float x, float dx, float y, float yi)
    {
        return w + a * dx * k * w * x;
    }
}
