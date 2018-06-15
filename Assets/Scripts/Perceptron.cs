using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perceptron : Neuron {

    public override void operation()
    {
        if(inputList.Count == weightList.Count)
        {
            foreach(float i in inputList)
            {
                this.x += i * weightList.IndexOf(i);
            }
        }
        else
        {
            Debug.Log("ERROR: Input.Length != Weight.Length en:" + this.Layer );

        }
        Activate(this.x, this.Bias);
    }

    public override string report()
    {
        return base.report();
    }
    public Perceptron() : base()
    {

    }
    public Perceptron(List<float> X, List<float> W, float T, float B) : base(X, W, T, B)
    {
        
    }
    public Perceptron(List<Neuron> Prev, List<float> W, float T, float B) : base(Prev, W, T, B)
    {

    }
}
