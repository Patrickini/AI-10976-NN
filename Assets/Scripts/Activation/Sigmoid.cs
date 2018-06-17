using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sigmoid : Neuron {
    //return 1.0f / (1.0f + (float) Math.Exp(-value));
    public override void operation()
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
    public override string report()
    {
        return base.report();
    }
    public Sigmoid(List<float> X, List<float> W, float T, float B) : base(X, W, T, B)
    {

    }
    public Sigmoid(List<Neuron> Prev, List<float> W, float T, float B) : base(Prev, W, T, B)
    {

    }
}
