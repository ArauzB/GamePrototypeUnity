using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    
    
    public bool Generate;
    public bool GenerateTexture;
    public bool GenerateMFDOOM;




    private void Update()
    { 
        Generate = Input.GetKey("g");
        GenerateTexture = Input.GetKey("t");
        GenerateMFDOOM = Input.GetKey("f");
    }

}