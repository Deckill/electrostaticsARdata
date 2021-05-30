using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;

public class Spine_Plotter : MonoBehaviour
{

    public int scale = 1;


    public GameObject sphere;

    public Spine_CSV_Reader reader; // instantiating the reader that already contains the data

    public int index;

    public float lastContact = 0f;

    public int distance = 0;

    public float lastTime;
    public int[] window = new int[] { 1, 2, 3, 4, 5 };
    public int windowStart = 1;
    public static int windowSize = 5;

    public int ri = 1;

    //public GameObject[] point = new GameObject[windowSize];


    //public Text textObject;

    void Start()
    {
        //if (reader == null)
        //{
        //    Debug.LogError("i have no object");
        //}

        //// 'i' references row associated with game object
        //for (int i = 0; i < reader.dataSet1.Length; i++)
        //{
        //    GameObject clone;
        //    //Text text;


        //    Vector3 pointLocation = new Vector3(reader.dataSet1[i].SGX * scale,
        //                                         reader.dataSet1[i].SGY * scale,
        //                                         reader.dataSet1[i].SGZ * scale);
        //    //float scaleFactor = reader.dataSet1[ri].SGY * .05f;  // you can modify the numberical value to change the scale of the isntantiated objects 
        //    //sphere.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);

        //    //Vector3 textLocation = new Vector3(reader.dataSet[i].sepalLength * scale,
        //    //                                   reader.dataSet[i].sepalWidth * scale,
        //    //                                   reader.dataSet[i].petalLength * scale);

        //    clone = Instantiate(sphere, pointLocation, Quaternion.identity);
        //    clone.name = "sphere_" + i.ToString();

        //    //text = Instantiate(textObject, textLocation, Quaternion.identity);
        //    //text.name = reader.dataSet[i].species.ToString();

        //}


    }

    void Update()
    {
        // For plotting points over time
        if ((Time.fixedTime - lastTime) >= .01) // you can modify the numerical value to change the speed
        {
            // sets the last time we ran the loop
            lastTime = Time.fixedTime;
            Debug.Log(Time.fixedTime);

            GameObject point;
            Vector3 pointLocation = new Vector3(reader.dataSet1[ri].SGX * scale,
                                                 reader.dataSet1[ri].SGY * scale,
                                                 reader.dataSet1[ri].SGZ * scale);
            point = Instantiate(sphere, pointLocation, Quaternion.identity);
            float scaleFactor = reader.dataSet1[ri].SGY * .05f;  // you can modify the numberical value to change the scale of the isntantiated objects 
            point.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
            Destroy(point, 1);

            // safeguard to prevent going past data set
            if (ri >= reader.dataSet1.Length - 1)
            {
                ri = 1;

            }
            else
            {
                ri++;
            }


            //Debug.Log(windowStart);

            //    int n = 0;
            //    for (int i = windowStart; i < windowStart + windowSize; i++)
            //    {

            //        Vector3 flowerLocation = new Vector3(reader.dataSet[i].sepalLength * scale,
            //                             (reader.dataSet[i].sepalWidth * scale) + translateY,
            //                             reader.dataSet[i].petalLength * scale);
            //        flowers[n] = Instantiate(flowersObject, flowerLocation, Quaternion.identity);
            //        Destroy(flowers[n], 1);
            //        n++;
            //        Debug.Log("Sepal Length: " + reader.dataSet[i].sepalLength);
            //        Debug.Log(reader.dataSet[i].species);
            //    }
            //    if (windowStart + windowSize > reader.dataSet.Length - 1)
            //    {
            //        windowStart = 1;
            //    }
            //    else
            //    {
            //        windowStart++;

            //    }
            //}

        }
    }
}