using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostInfo 
{
    // Start is called before the first frame update
    public string id { get; set; }
    public string Name { get; set; }
    public string text { get; set; }
    public string image { get; set; }
    void Start()
    {
        
    }
    public PostInfo(string id,string name,string text,string image)
    {
        this.id = id;
        this.Name = name;
        this.text = text;
        this.image = image;
    }
}
