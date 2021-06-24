using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy_CSV_reader : MonoBehaviour
{
    public TextAsset csvFile;

    public galaxyData[] dataSet;


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
        dataSet = new galaxyData[sequenceLines.Length];

        // parses the data table by column
        for (int i = 0; i < dataSet.Length; i++)
        {
            // splitting the data by comma
            string[] column = sequenceLines[i].Split(","[0]);
           // Debug.Log("columns = " + column.Length + " count;" + i);

            // place the parsed into the array
            galaxyData sequenceEntry = new galaxyData();

            sequenceEntry.id = (column[0]);

            sequenceEntry.xPos = float.Parse(column[1]);

            sequenceEntry.yPos = float.Parse(column[2]);

            sequenceEntry.zPos = float.Parse(column[3]);

            sequenceEntry.pot = float.Parse(column[4]);


            dataSet[i] = sequenceEntry;

        }

        PrintGalaxyData(dataSet);
    }

    void PrintGalaxyData(galaxyData[] myData)
    {
        for (int i = 0; i < myData.Length; i++)
        {
            //Debug.Log("ID: " + myData[i].id);
            //Debug.Log("Radius: " + myData[i].radius);
            //Debug.Log("X position: " + myData[i].xPos);
            //Debug.Log("Y position: " + myData[i].yPos);
            //Debug.Log("Z position: " + myData[i].zPos);
            //Debug.Log("Mass: " + myData[i].mass);
            //Debug.Log("Absolute Magnitude: " + myData[i].Mr);
            //Debug.Log("Distance from filament: " + myData[i].dist);
        }
    }
}

public class galaxyData
{
    public string id = "default";
    public float xPos = 0;
    public float yPos = 0;
    public float zPos = 0;
    public float pot = 0;

}