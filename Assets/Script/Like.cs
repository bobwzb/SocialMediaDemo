using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Like : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject heart;
    bool isShow = false;
    Vector4 oringinalColor;
    public Vector4 aimColor;
    void Start()
    {
        oringinalColor = heart.GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        if (isShow == false)
        {
            heart.GetComponent<Image>().color = Vector4.Lerp(oringinalColor, aimColor, 0.00001f);
        }
        else
        {
            heart.GetComponent<Image>().color = Vector4.Lerp(aimColor, oringinalColor, 0.00001f);
        }
    }
    public void click()
    {
        if (isShow == false)
        {
            isShow = true;
        }
        else
        {
            isShow = false;
        }
    }
}
