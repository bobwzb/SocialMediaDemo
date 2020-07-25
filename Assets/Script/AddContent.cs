using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class AddContent : MonoBehaviour
{
    // Start is called before the first frame update
    public string jsonData;
    public JsonData json;
    public List<PostInfo> postList;
    public List<GameObject> posts;
    void Start()
    {
        postList = new List<PostInfo>();
        ParseJson();
        createObject();
    }
    void ParseJson()
    {
        TextAsset itemText = Resources.Load<TextAsset>("Post");
        json = JsonMapper.ToObject(itemText.text);
        jsonData = JsonMapper.ToJson(json);
        foreach (JsonData tmp in json)
        {
            string id = "h" + tmp["id"].ToString();
            string name= tmp["Name"].ToString();
            string image = tmp["image"].ToString();
            string text= tmp["text"].ToString();
            PostInfo Info = new PostInfo(id, name, text, image);
            postList.Add(Info);
        }
    }
    void createObject()
    {
        for(int i = 0; i < posts.Count; i++)
        {
            posts[i].GetComponent<Post>().createContent(postList[i].id, postList[i].Name, postList[i].image, postList[i].text);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
