﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("onLoadScene", 2.0f);
    }

    void onLoadScene(){
        SceneManager.LoadScene("BScene");
    }
}
