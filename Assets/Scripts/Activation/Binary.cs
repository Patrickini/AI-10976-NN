using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Binary : Neuron {

    public override void operation()
    {
        float temp;
        if (inputList.Count == weightList.Count)
        {
            foreach (float i in inputList)
            {
                temp = i < 0 ? 0 : 1;
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
    public Binary() : base()
    {

    }
    public Binary(List<float> X, List<float> W, float T, float B) : base(X, W, T, B)
    {

    }
    public Binary(List<Neuron> Prev, List<float> W, float T, float B) : base(Prev, W, T, B)
    {

    }
}
