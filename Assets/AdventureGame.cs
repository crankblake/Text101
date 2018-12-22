using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
        //textComponent.text = "AMERICA used to be great but now is super shitty. You are a 71-year-old reality TV star named Donald Trump. What do you do? \r\n\n1. Run for president.\r\n2. Enjoy the rest of your life.You are a celebrity.";
        textComponent.text = "this was created by a script";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
