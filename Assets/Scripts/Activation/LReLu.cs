using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LReLu : Neuron {

    public override void operation()
    {
        float temp;
        if (inputList.Count == weightList.Count)
        {
            foreach (float i in inputList)
            {
                temp = i;
                temp = temp < 0 ? (temp *= 0.01f) : temp *= 1;
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
    public LReLu(List<float> X, List<float> W, float T, float B) : base(X, W, T, B)
    {

    }
    public LReLu(List<Neuron> Prev, List<float> W, float T, float B) : base(Prev, W, T, B)
    {

    }
}
