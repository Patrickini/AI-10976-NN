using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sigmoid : Neuron {
    //return 1.0f / (1.0f + (float) Math.Exp(-value));
    public void operation()
    {
        float temp;
        if (inputList.Count == weightList.Count)
        {
            foreach (float i in inputList)
            {
                temp = 1.0f / (1.0f + (float)Mathf.Exp(-i));
                x += temp * weightList.IndexOf(i);
            }
        }
        else
        {
            Debug.Log("ERROR: Input.Length != Weight.Length en:" + this.Layer);

        }

        Activate(this.x, this.Bias);
    }
}
