using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Globalization;

public class NN : MonoBehaviour {
    [SerializeField] Sprite Img;
    protected float Bias = 1;
    protected float Alpha;
    Color[] colores;
    List<float> imgInput = new List<float>();
    List<float> initWeights = new List<float>();
    StreamWriter writer;
    StreamWriter Report;
    StreamReader reader;

    int count = 0;

    List<Neuron> uno = new List<Neuron>();
    List<Neuron> dos = new List<Neuron>();
    List<Neuron> tres = new List<Neuron>();
    List<Neuron> cuatro = new List<Neuron>();

    private void Start()
    {
        colores = Img.texture.GetPixels();
        for(int i =0; i < colores.Length; ++i)
        {
            imgInput.Add(colores[i].grayscale);
            //Debug.Log(imgInput[i]);
        }
        if (!File.Exists("Assets/Resources/Weights.txt"))
        {
            writer = new StreamWriter("Assets/Resources/Weights.txt", true);
            for (int i = 0; i < colores.Length; ++i)
            {
                float temp = Random.Range(0.0f, 1.0f);
                //Debug.Log(temp);
                writer.WriteLine(temp.ToString());
                initWeights.Add(temp);
                //Debug.Log(initWeights[i]);
            }
            writer.Close();
        }
        else
        {
            string line;
            reader = new StreamReader("Assets/Resources/Weights.txt");
            while ((line = reader.ReadLine()) != null)
            {
                initWeights.Add(float.Parse(line));
            }
        }

        
        string repPath = "Assets/Resources/Report.txt";
        Report = new StreamWriter(repPath, true);

        foreach (float n in imgInput)
        {
            uno.Add(new Perceptron(imgInput, initWeights, 0, Bias));
            uno[imgInput.IndexOf(n)].Layer = 1;
            uno[imgInput.IndexOf(n)].ID = count;
            uno[imgInput.IndexOf(n)].operation();
            Report.WriteLine(uno[imgInput.IndexOf(n)].report());
            count++;
        }
        foreach (float n in imgInput)
        {
            dos.Add(new ReLu(uno, initWeights, 0, Bias));
            dos[imgInput.IndexOf(n)].Layer = 2;
            dos[imgInput.IndexOf(n)].ID = count;
            dos[imgInput.IndexOf(n)].operation();
            Report.WriteLine(dos[imgInput.IndexOf(n)].report());
            count++;
        }
        foreach (float n in imgInput)
        {
            tres.Add(new Sigmoid(dos, initWeights, 0, Bias));
            tres[imgInput.IndexOf(n)].Layer = 3;
            tres[imgInput.IndexOf(n)].ID = count;
            tres[imgInput.IndexOf(n)].operation();
            Report.WriteLine(tres[imgInput.IndexOf(n)].report());
            count++;
        }
        foreach (float n in imgInput)
        {
            cuatro.Add(new softMax(tres, initWeights, 0, Bias));
            cuatro[imgInput.IndexOf(n)].Layer = 4;
            cuatro[imgInput.IndexOf(n)].ID = count;
            //cuatro[imgInput.IndexOf(n)].inputList = cuatro[imgInput.IndexOf(n)].finput(tres);
            cuatro[imgInput.IndexOf(n)].operation();
            Report.WriteLine(cuatro[imgInput.IndexOf(n)].report());
            count++;
        }



        Report.Close();
        AssetDatabase.RenameAsset(repPath,( "Report_" + System.DateTime.Now.ToUniversalTime() + ".txt"));
    }
}
