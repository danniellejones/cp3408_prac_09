using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateWorld : MonoBehaviour
{

    public Text states;
    
    // Update is called once per frame
    void Update()
    {
        Dictionary<string, int> worldSates = GWorld.Instance.GetWorld().GetStates();
        states.text = "";
        foreach(KeyValuePair<string, int> s in worldSates)
        {
            states.text += s.Key + ", " + s.Value + "\n";
        }
    }
}