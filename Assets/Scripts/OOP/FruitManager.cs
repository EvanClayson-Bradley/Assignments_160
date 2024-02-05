using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public List<Fruit> fruitSalad;

    void Start()
    {
        fruitSalad = new List<Fruit>();

        Fruit fruit = new Fruit("apple", "green", 1.2f);
        fruitSalad.Add(fruit);

        CreateFruitSalad();

        DisplayFruitSalad();
    }

    private void CreateFruitSalad()
    {
        fruitSalad.Add(new Fruit());
        fruitSalad.Add(new Fruit("strawberry"));
        fruitSalad.Add(new Fruit(7.9f));
    }

    private void DisplayFruitSalad()
    {
        foreach (var fruit in fruitSalad)
        {
            print(fruit.toString() + "\n");
        }
    }
}
