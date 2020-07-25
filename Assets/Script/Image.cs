using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class image : MonoBehaviour
{
    // Start is called before the first frame update
    bool isShow = false;
    public GameObject canvas;
    public GameObject oringalFather;
    private Vector3 oringnalPos;
    public GameObject panel;
    void Start()
    {
        oringnalPos= this.GetComponent<RectTransform>().localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.GetComponent<RectTransform>().localPosition;
        this.GetComponent<RectTransform>().localPosition = Vector3.MoveTowards(pos, new Vector3(0, 0, 0), 4);
    }
    public void click()
    {
        if (isShow == false)
        {
            InvokeRepeating("Show", 0, 0.01f);
            isShow = true;
        }
        else
        {
            InvokeRepeating("Hide", 0, 0.01f);
            isShow = false;
        }
    }
    void Show()
    {
        panel.gameObject.SetActive(true);
        this.transform.SetParent(canvas.transform);
        Vector3 tmp = this.GetComponent<RectTransform>().localScale;
        this.GetComponent<RectTransform>().localScale = new Vector3(tmp.x + 0.16f, tmp.y + 0.16f, tmp.z);
        if (tmp.x + 0.01f >= 6.7f) { CancelInvoke(); panel.gameObject.SetActive(true); }
        }
    void Hide()
    {
        panel.gameObject.SetActive(false);
        this.transform.SetParent(oringalFather.transform);
        Vector3 tmp = this.GetComponent<RectTransform>().localScale;
        this.GetComponent<RectTransform>().localScale = new Vector3(tmp.x - 0.16f, tmp.y - 0.16f, tmp.z);
        if (tmp.x - 0.01f <= 2.6f) { CancelInvoke(); panel.gameObject.SetActive(false); }
    }
}
