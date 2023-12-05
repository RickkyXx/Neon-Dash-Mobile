using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondManager : MonoBehaviour
{
    public static DiamondManager instance;
    private int totalDiamonds;
    [SerializeField] private TMP_Text diamondsDisplay;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    private void OnGUI()
    {
        diamondsDisplay.text = totalDiamonds.ToString();
    }

    public void AddDiamonds(int amount)
    {
        totalDiamonds += amount;
        UpdateDiamondDisplay();
    }

    private void UpdateDiamondDisplay()
    {
        diamondsDisplay.text = totalDiamonds.ToString();
    }
}

