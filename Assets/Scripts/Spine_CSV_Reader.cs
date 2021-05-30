using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using System;



public class Spine_CSV_Reader : MonoBehaviour
{
    public TextAsset csvFile;

    public spineData[] dataSet1;


    // Use this for initialization
    void Awake()
    {
        ParseData(csvFile);
        //Debug.Log("Hello there!");
    }

    // Parse the CSV Text file into a usable format
    void ParseData(TextAsset csvTxt)
    {
        // declare a string object named 's'
        string s = csvTxt.text;

        // declare string array which splits from line zero
        string[] sequenceLines = s.Split("\n"[0]);
        //Debug.Log("the data length is: " + sequenceLines.Length);

        // inherits data lines from the string array
        dataSet1 = new spineData[sequenceLines.Length];

        // parses the data table by column
        for (int i = 0; i < dataSet1.Length; i++)
        {
            // splitting the data by comma
            string[] column = sequenceLines[i].Split(","[0]);
            // Debug.Log("columns = " + column.Length + " count;" + i);

            // place the parsed into the array
            spineData sequenceEntry = new spineData();

            sequenceEntry.SGY = float.Parse(column[0]);

            sequenceEntry.SGX = float.Parse(column[1]);

            sequenceEntry.SGZ = float.Parse(column[2]);

            sequenceEntry.PA = float.Parse(column[3]);

            sequenceEntry.ra = float.Parse(column[4]);

            sequenceEntry.dec = float.Parse(column[5]);

            dataSet1[i] = sequenceEntry;

        }

        PrintSpineData(dataSet1);
    }

    void PrintSpineData(spineData[] myData)
    {
        for (int i = 0; i < myData.Length; i++)
        {
            //Debug.Log("Spine SGY: " + myData[i].SGY);
            //Debug.Log("Spine SGX: " + myData[i].SGX);
            //Debug.Log("Spine SGZ: " + myData[i].SGZ);
            //Debug.Log("Spine PA: " + myData[i].yPos);
            //Debug.Log("Z position: " + myData[i].zPos);
            //Debug.Log("Mass: " + myData[i].mass);
            //Debug.Log("Absolute Magnitude: " + myData[i].Mr);
            //Debug.Log("Distance from filament: " + myData[i].dist);
        }
    }
}

public class spineData
{
    public float SGY = 0;
    public float SGX = 0;
    public float SGZ = 0;
    public float PA = 0;
    public float ra = 0;
    public float dec = 0;
}

