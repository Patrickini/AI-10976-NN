using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuron : NN {

    protected int Layer;
    protected float ID;
    protected float x;
    protected float w;
    protected float Treshold;
    protected float Output;
    protected List<float> inputList = new List<float>();
    protected List<float> weightList = new List<float>();

    public void Activate(float X, float B)
    {
        this.Output = this.x + this.Bias;
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
    }
    public Neuron(float X, float W)
    {
        x = X;
        w = W;
    }
}
