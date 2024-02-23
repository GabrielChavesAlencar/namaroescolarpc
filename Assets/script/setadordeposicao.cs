using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setadordeposicao : MonoBehaviour
{
    public RectTransform canv;
    public RectTransform rtrans;
    public float x, y;
    public bool cima;
    // Start is called before the first frame update
    void Start()
    {
        rtrans = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!cima) { rtrans.anchoredPosition = new Vector2(x, canv.rect.width / y); }
        else { rtrans.anchoredPosition = new Vector2(x, canv.rect.width *y); }

    }
}
