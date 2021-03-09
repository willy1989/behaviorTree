using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour
{
    private Node parentNode;

    [SerializeField] private NodeStatus status;

    public abstract void doAction();

    public abstract void checkStatus();

    public abstract void directFlow();

    public abstract void resetNode();
}
