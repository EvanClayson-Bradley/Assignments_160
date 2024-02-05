using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fruit
{
    private string name;
    public string color;
    public float weight;

    public Fruit(string name, string color, float weight)
    {
        this.name = name;
        this.color = color;
        this.weight = weight;
    }
    public Fruit(string name)
    {
        this.name = name;
        color = "red";
        weight = 1.0f;
    }
    public Fruit(float weight)
    {
        name = "banana";
        color = "yellow";
        this.weight = weight;
        
    }
    public Fruit()
    {
        name = "blueberry";
        color = "blue";
        weight = 0.1f;
    }


    public string GetName()
    {
        return name;
    }
    public string SetName(string name)
    {
        this.name = name;
        return name;
    }

    public string GetColor()
    {
        return color;
    }
    public string SetColor(string color)
    {
        this.color = color;
        return color;
    }

    public string toString()
    {
        return color + " " + name + ", weighing " + weight + " pounds.";
    }
}
