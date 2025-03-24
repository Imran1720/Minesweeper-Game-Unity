using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridGenerator : MonoBehaviour
{
    public int numberOfRows;
    public int numberOfColumns;

    public float gridWidth;
    public float gridHeight;



    public GridLayoutGroup layoutGroup;

    public GameObject cellPrefab;


    private void Start()
    {
        CalculateGridDimensions();
        CalculateCellDimensions();
        GenerateGrid();
    }

    private void CalculateCellDimensions()
    {
        float cellWidth = gridWidth / numberOfColumns;
        float cellHeight = gridHeight / numberOfRows;

        layoutGroup.cellSize = new Vector2(cellWidth, cellHeight);

    }

    private void CalculateGridDimensions()
    {
        RectTransform gridTransform = GetComponent<RectTransform>();
        gridWidth = gridTransform.rect.width;
        gridHeight = gridTransform.rect.height;
    }

    private void GenerateGrid()
    {
        for (int i = 0; i < numberOfRows * numberOfColumns; i++)
        {
            GameObject cell = Instantiate(cellPrefab);
            cell.transform.SetParent(transform, false);
        }
    }
}