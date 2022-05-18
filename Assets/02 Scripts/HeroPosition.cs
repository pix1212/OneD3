using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPosition : MonoBehaviour
{
    static HeroPosition _instance;

    public static HeroPosition instance{ get { return _instance;}}

    void Awake()
    {
        if(_instance == null)
            _instance = this;
    }
    public Transform[] heroPos;

}
