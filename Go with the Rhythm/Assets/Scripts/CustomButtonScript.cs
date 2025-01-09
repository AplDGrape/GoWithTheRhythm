using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Get image component and set border hit value to 0.1f
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
    }
}
