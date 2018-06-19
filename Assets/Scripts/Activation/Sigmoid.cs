using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sigmoid : Neuron {
    //return 1.0f / (1.0f + (float) Math.Exp(-value));

    public float GError;
    public override void operation()
    {
        float temp;
        if (inputList.Count == weightList.Count)
        {
            //foreach (float i in inputList)
            //{
            //    temp = 1.0f / (1.0f + (float)Mathf.Exp(-i));
            //    x += temp * weightList.IndexOf(i);
            //}
            x = 0;
            for(int i = 0; i < inputList.Count; ++i)
            {
                temp = 1.0f / (1.0f + (float)Mathf.Exp(-inputList[i]));
                x += temp * weightList[i];
            }
        }
        else
        {
            Debug.Log("ERROR: Input.Length != Weight.Length en:" + this.Layer);

        }

        Activate(this.x, this.Bias);
    }
    public override void operation2()
    {
        float temp = 0;
        
        for (int i = 0; i < inputList.Count; ++i)
        {
            temp += inputList[i];

        }
        temp = 1.0f / (1.0f + (float)Mathf.Exp(-temp));
        x = temp;
        Output = temp * (1 - temp);
        
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
