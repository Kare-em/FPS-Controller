using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private List<Text> textCounters;
    [SerializeField] private MenuController menuController;
    public int ObjectsCount { get; set; }
    private List<float> counters;
    private void Start()
    {
        counters = new List<float>();
        float counter = 0;
        foreach (var item in textCounters)
        {
            counters.Add(counter);
        }
    }
    public void AddCount(string tag)
    {
        switch (tag)
        {
            case "Sphere":
                UpdateCounter(0, 1);
                break;
            case "Cube":
                UpdateCounter(1, 1);
                break;
            case "Capsule":
                UpdateCounter(2, 1);
                break;
            default:
                break;
        }
    }
    private void UpdateCounter(int index, int value)
    {
        counters[index] += value;
        textCounters[index].text = counters[index].ToString();

        ObjectsCount -= value;
        if (ObjectsCount < 1)
            menuController.ShowRetryMenu();
    }
}
