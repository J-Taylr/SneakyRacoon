using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JK : MonoBehaviour
{
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        image = GetComponent<Image>();
        var tempColor = image.color;
        tempColor.a = 0.3f;
        image.color = tempColor;
    }
}
