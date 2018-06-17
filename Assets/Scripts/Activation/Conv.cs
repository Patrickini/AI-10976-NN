using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conv : Neuron {
    //Convolucional Filtros

    float[,] matrix = new float[5, 5];
    float[,] matrixOut = new float[5, 5];
    List<float[,]> Arry = new List<float[,]>();
    float[,] a =
    {
        {1.0f,0.0f,0.0f },
        {1.0f,0.0f,0.0f },
        {1.0f,0.0f,0.0f }
    };
    float[,] b =
    {
        {0.0f,0.0f,1.0f },
        {0.0f,0.0f,1.0f },
        {0.0f,0.0f,1.0f }
    };
    float[,] c =
    {
        {1.0f,1.0f,1.0f },
        {1.0f,0.0f,0.0f },
        {1.0f,0.0f,0.0f }
    };
    float[,] d =
    {
        {1.0f,0.0f,0.0f },
        {1.0f,0.0f,0.0f },
        {1.0f,1.0f,1.0f }
    };
    float[,] e =
    {
        {0.0f,0.0f,1.0f },
        {0.0f,0.0f,1.0f },
        {1.0f,1.0f,1.0f }
    };
    float[,] f =
    {
        {1.0f,1.0f,1.0f },
        {0.0f,0.0f,1.0f },
        {0.0f,0.0f,1.0f }
    };
    
    
    void build()
    {
        Arry.Add(a);
        Arry.Add(b);
        Arry.Add(c);
        Arry.Add(d);
        Arry.Add(e);
        Arry.Add(f);
        int count = 0;
        for(int i = 0; i <= 0; i++)
        {
            for (int j = 0; j <= 0; j++)
            {
                if (inputList[count] > 0)
                {
                    matrix[j, i] = 1.0f;
                }
                else
                {
                    matrix[j, i] = 0;
                }
                //matrix[j, i] = inputList[count];
                count++;
            }
        }
    }
    void check()
    {
        for (int i = 0; i < 5; ++i)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = i - 1; k <= i + 1; k++)
                {
                    for (int l = j - 1; l <= j + 1; l++)
                    {
                        if (k >= 0 && k < 5)
                        {
                            if (l >= 0 && l < 5)
                            {
                                if (!(k == i && l == j))
                                {
                                    foreach(float[,] m in Arry)
                                    {
                                        if (matrix[l, k] == m[k,l])
                                        {
                                            matrixOut[j, i] += 1;
                                        }
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}
