﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionEvent : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    public GameObject panel;

    void desactivarPanelEvent()
    {
        panel.SetActive(false);
    }


}
