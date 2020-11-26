using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aStar : MonoBehaviour
{
    private WorldGrid worldGrid;
    

    public List<WorldNode> FindPathAStar()
    {
        List<WorldNode> open = new List<WorldNode>();
        List<WorldNode> closed = new List<WorldNode>();
        List<WorldNode> path = new List<WorldNode>();

        closed = worldGrid.WorldNodes;


        return path;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        worldGrid = GameObject.FindWithTag("WorldGrid").GetComponent<WorldGrid>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
