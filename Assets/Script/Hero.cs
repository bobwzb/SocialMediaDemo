using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class Hero
{
    public string name;
    public int power;
}

public class Heros
{
    public Hero[] heros;
}

public class LitJson_Gary : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        func1();
    }

    void func1()
    {
        //创建Json
        //{'heros':[{'name':'Gary','power':90},{'name':'Gary2','power':80}]}

        Hero hero1 = new Hero();
        hero1.name = "Gary";
        hero1.power = 90;
        Hero hero2 = new Hero();
        hero2.name = "Gary2";
        hero2.power = 80;

        Heros heros = new Heros();
        heros.heros = new Hero[] { hero1, hero2 };

        string jsonStr = JsonMapper.ToJson(heros);
        Debug.Log(jsonStr);

        //解析Json
        Heros newHeros = JsonMapper.ToObject<Heros>(jsonStr);
        Debug.Log(newHeros.heros[0].name);

    }
}
