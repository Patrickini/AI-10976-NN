using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReLu : Neuron {

    public override void operation()
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
    public override string report()
    {
        return base.report();
    }
    public ReLu(List<float> X, List<float> W, float T, float B) : base(X, W, T, B)
    {

    }
    public ReLu(List<Neuron> Prev, List<float> W, float T, float B) : base(Prev, W, T, B)
    {

    }
}
