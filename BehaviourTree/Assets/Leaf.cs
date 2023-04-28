using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Leaf : Node
{
    // Tick is like a frame for a behaviour tree
    public delegate Status Tick();
    public Tick ProcessMethod;

    public Leaf() { }

    public Leaf(string n, Tick pm)
    {
        name = n;
        ProcessMethod = pm;
    }

    public override Status Process()
    {
        if (ProcessMethod != null) 
            return ProcessMethod();
        return Status.FAILURE;
    }
}
