using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartySystem : MonoBehaviour
{
    static PartySystem _instance;

    public static PartySystem instance{ get { return _instance;}}

    void Awake()
    {
        if(_instance == null)
            _instance = this;
    }

    public Jobs[] heros;

}
