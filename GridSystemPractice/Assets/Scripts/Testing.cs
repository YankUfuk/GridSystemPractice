using UnityEngine;

public class Testing : MonoBehaviour
{
    private Grid grid;
    
    void Start()
    {
        grid = new Grid(4, 2, 10f, new Vector3(-20, 0));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(GridWorldTextUtils.GetMouseWorldPosition(), 56);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(GridWorldTextUtils.GetMouseWorldPosition()));
        }
    }
}
