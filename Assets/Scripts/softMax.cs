using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class softMax : Neuron {

    List<float> Expos = new List<float>();
    float scale = 0.0f;

    public void operation()
    {
        if (inputList.Count == weightList.Count)
        {
            foreach (float i in inputList)
            {

                Expos[Expos.IndexOf(i)] = Mathf.Exp(i) + Mathf.Exp(weightList.IndexOf(i));
                scale += Expos[Expos.IndexOf(i)];
            }
            foreach (float j in Expos)
            {

                Expos[Expos.IndexOf(j)] = j / scale;
                
            }
        }
        else
        {
            Debug.Log("ERROR: Input.Length != Weight.Length en:" + this.Layer);

        }

        //Activate(this.x, this.Bias);
    }
}
