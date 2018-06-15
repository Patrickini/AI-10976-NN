using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuron : NN {

    public int Layer;
    public float ID;
    protected float x;
    protected float w;
    protected float Treshold;
    protected float Output;
    public List<float> inputList = new List<float>();
    public List<float> weightList = new List<float>();

    public void Activate(float X, float B)
    {
        this.Output = this.x + this.Bias;
    }

    public virtual void operation(){}
    public virtual string report()
    {
        //Debug.Log("[Layer]:" + this.Layer + "Operation Activated" + this.x);
        return ("[Layer]:" + this.Layer + "Operation Activated" + this.x);
    }
    public Neuron()
    {

    }
    public Neuron(List<float> X, List<float> W, float T, float B)
    {
        this.inputList = X;
        this.weightList = W;
        this.Treshold = T;
        this.Bias = B;
        Debug.Log("Constructor");
    }
    public Neuron(List<Neuron> Prev, List<float> W, float T, float B)
    {
        foreach(Neuron n in Prev)
        {
            this.inputList.Add(n.x);
        }
        this.weightList = W;
        this.Treshold = T;
        this.Bias = B;
        Debug.Log("Constructor");
    }
    public Neuron(float X, float W)
    {
        x = X;
        w = W;
    }
}
