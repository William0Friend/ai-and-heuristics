using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
public enum NodeType
{
    Open = 0,
    Closed = 1
}
public class Node 
{
    public NodeType nodeType = NodeType.Open;
    public int xIndex = -1;
    public int yIndex = -1;
    public Vector3 position;
    public List<Node> Neighbors = new List<Node>();
    public Node previous = null;
    public Node (int xIndex, int yIndex, NodeType nodeType)
    {
        this.xIndex = xIndex;
        this.yIndex = yIndex;
        this.nodeType = nodeType;
    }
}
