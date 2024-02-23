using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamanhomenu : MonoBehaviour
{
    public RectTransform can;
    public RectTransform rtrans;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        rtrans = GetComponent<RectTransform>();
        x = 800;y = 480;


      
    }

    // Update is called once per frame
    void Update()
    {
        rtrans.localScale = new Vector2(can.rect.width/x, can.rect.height/y);
    }
}
