using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGrid : MonoBehaviour
{
    private List<WorldNode> worldNodes = new List<WorldNode>();

    public List<WorldNode> WorldNodes => worldNodes;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            worldNodes.Add(child.GetComponent<WorldNode>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
