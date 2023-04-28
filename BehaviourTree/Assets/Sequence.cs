using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : Node
{
   public Sequence(string n)
    {
        name = n;
    }

    public override Status Process()
    {
        // A kind of going through each child and process children
        Status childStatus = children[currentChild].Process();
        if(childStatus == Status.RUNNING)
        {
            return Status.RUNNING;
        }
        if(childStatus == Status.FAILURE)
        {
            return childStatus;
        }
        currentChild++;
        // At end
        if(currentChild >= children.Count)
        {
            currentChild = 0;
            return Status.SUCCESS;
        }

        return Status.RUNNING;
    }
}
