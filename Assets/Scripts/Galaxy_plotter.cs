using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Galaxy_plotter : MonoBehaviour
{

    public int scale = 10;

    //public GameObject groundPlane;
    //public float translateYspeed = 10;


    public GameObject star;

    public Galaxy_CSV_reader reader; // instantiating the reader that already contains the data

    public int index;

    public float lastContact = 0f;

    public int distance = 0;

    public float lastTime;
    public int[] window = new int[] { 1, 2, 3, 4, 5 };
    public int windowStart = 1;
    public static int windowSize = 5;

    public int ri = 1;

    public GameObject[] stars = new GameObject[windowSize];

    //public Text ID;
    //public Text RADIUS;
    //public Text MASS;
    //public Text MR;

    //public Material starMaterial;


    //public Text textObject;

    void Start()
    {
        if (reader == null)
        {
            Debug.LogError("i have no object");
        }

        //ID.text = "default ID";
        //RADIUS.text = "default radius";
        //MASS.text = "default mass";
        //MR.text = "default Mr";

        // 'i' references row associated with game object
        for (int i = 0; i < reader.dataSet.Length; i++)
        {
            GameObject clone;
            //Text text;
            Vector3 starLocation = new Vector3(reader.dataSet[i].xPos * scale,
                                                 reader.dataSet[i].yPos * scale,
                                                 reader.dataSet[i].zPos * scale);
            float scaleFactor = reader.dataSet[i].radius * .05f;  // you can modify the numberical value to change the scale of the isntantiated objects 
            star.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);

            float brightFactor = reader.dataSet[i].Mr * .05f;

            //starMaterial.SetVector("_EmissionColor", new Vector4(0.8196f, 0.783f, 0) * brightFactor);

            //Vector3 textLocation = new Vector3(reader.dataSet[i].sepalLength * scale,
            //                                   reader.dataSet[i].sepalWidth * scale,
            //                                   reader.dataSet[i].petalLength * scale);

            clone = Instantiate(star, starLocation, Quaternion.identity);
            clone.name = "star_" + i.ToString();

            //text = Instantiate(textObject, textLocation, Quaternion.identity);
            //text.name = reader.dataSet[i].species.ToString();

        }
    }

    //void Update()
    //    {
    //     groundPlane.transform.position += Vector3.up * Time.deltaTime * translateYspeed;

    //        if (Input.GetKey("q"))
    //        {
    //            //print("q key was pressed");
    //            //groundPlane.transform.Translate(Vector3.up * Time.deltaTime * translateYspeed, Space.Self);
    //            Debug.Log(Vector3.up);
    //        }


    //        if (Input.GetKey("e"))
    //        {
    //        //print("e key was pressed");
    //            groundPlane.transform.Translate(Vector3.down * Time.deltaTime * translateYspeed, Space.World);
    //        }

    //    }

    //private void OnCollisionEnter(Collision hit)
    //{
    //    Debug.Log(hit.gameObject.name);
    //    if (hit.gameObject.name.Contains("star_") && lastContact < Time.realtimeSinceStartup - 3)
    //    {
    //        lastContact = Time.realtimeSinceStartup;
    //        string[] tokens = hit.gameObject.name.Split('_');
    //        int i;
    //        // Converts the string representation of a number to its 32-bit signed integer equivalent
    //        Int32.TryParse(tokens[1], out i);

    //        // spits out name and sequence
    //        //Debug.Log(reader.dataSet[i].location);
    //        ID.text = reader.dataSet[i].id;

    //        //Debug.Log(reader.dataSet[i].period);
    //        RADIUS.text = reader.dataSet[i].radius.ToString();

    //        //Debug.Log(reader.dataSet[i].tooltip);
    //        MASS.text = reader.dataSet[i].mass.ToString();

    //        //Debug.Log(reader.dataSet[i].period);
    //        MR.text = reader.dataSet[i].Mr.ToString();


    //    }

    }


