using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NN : MonoBehaviour {
    [SerializeField] Sprite Img;
    protected float Bias = 1;
    protected float Alpha;
    Color[] colores;
    List<float> imgInput = new List<float>();
    List<float> initWeights = new List<float>();
    StreamWriter writer;
    StreamReader reader;


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


    }
}
