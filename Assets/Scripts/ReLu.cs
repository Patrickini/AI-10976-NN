using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReLu : Neuron {

    public void operation()
    {
        float temp;
        if (inputList.Count == weightList.Count)
        {
            foreach (float i in inputList)
            {
                temp = i;
                temp = temp < 0 ? 0 : temp *= 1;
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
