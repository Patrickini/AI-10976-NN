using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perceptron : Neuron {

    public void operation()
    {
        if(inputList.Count == weightList.Count)
        {
            foreach(float i in inputList)
            {
                x += i * weightList.IndexOf(i);
            }
        }
        else
        {
            Debug.Log("ERROR: Input.Length != Weight.Length en:" + this.Layer );

        }
        Activate(this.x, this.Bias);
    }
}
