using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour
{
    public Galaxy_CSV_reader reader; // instantiating the reader that already contains the data

    public int index;

    public float lastContact = 0f;

    public int[] window = new int[] { 1, 2, 3, 4, 5 };
    public int windowStart = 1;
    public static int windowSize = 5;

    public int ri = 1;

    public Text ID;
   // public Text RADIUS;
   // public Text MASS;
   // public Text MR;



    // Start is called before the first frame update
    void Start()
    {
        ID.text = "default ID";
        //RADIUS.text = "default radius";
        //MASS.text = "default mass";
        //MR.text = "default Mr";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision hit)
    {
        Debug.Log(hit.gameObject.name);
        if (hit.gameObject.name.Contains("star_") && lastContact < Time.realtimeSinceStartup - 3)
        {
            lastContact = Time.realtimeSinceStartup;
            string[] tokens = hit.gameObject.name.Split('_');
            int i;
            // Converts the string representation of a number to its 32-bit signed integer equivalent
            Int32.TryParse(tokens[1], out i);

            // spits out name and sequence
            //Debug.Log(reader.dataSet[i].location);
            ID.text = reader.dataSet[i].id;

            //Debug.Log(reader.dataSet[i].period);
            //RADIUS.text = reader.dataSet[i].radius.ToString();

            //Debug.Log(reader.dataSet[i].tooltip);
            //MASS.text = reader.dataSet[i].mass.ToString();

            //Debug.Log(reader.dataSet[i].period);
            //MR.text = reader.dataSet[i].Mr.ToString();


        }

    }
}
