using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Testing : MonoBehaviour
{
    Grid _grid;
    // Start is called before the first frame update
    void Start()
    {
        _grid = new Grid(4, 2, 10, new Vector3(20,10,0));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _grid.SetValue(worldPosition, 15);
        }

        if(Input.GetMouseButtonDown(1))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("Clicked grid value: " + _grid.GetValue(worldPosition));
        }
    }
}
