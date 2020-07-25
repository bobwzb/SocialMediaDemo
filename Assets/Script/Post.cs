using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Post : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject port;
    public GameObject Name;
    public GameObject image;
    public GameObject text;
    void Start()
    {
        
    }
    public void createContent(string id,string name,string image,string text)
    {
        Object sp = Resources.Load(id,typeof(Sprite));
        Sprite tmpsp = Instantiate(sp) as Sprite;
        this.port.GetComponent<Image>().sprite = tmpsp;
        Object im = Resources.Load(image, typeof(Sprite));
        Sprite tmpim = Instantiate(im) as Sprite;
        this.image.GetComponent<Image>().sprite = tmpim;
        this.Name.GetComponent<Text>().text = name;
        this.text.GetComponent<Text>().text = text;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
