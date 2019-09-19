using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameLaunch : MonoBehaviour
{
    /** 摄像机 */
    public Camera mainCamera;

    /** 2D画布 */
    public Canvas canvas2D;
    // Start is called before the first frame update
    void Start()
    {
        UIManager.GetInstance().open("Prefabs/2d/MainUIView");
        // GameObject main = AssetsManager.GetInstance().LoadPrefab("Prefabs/2d/MainUIView");
        // GameObject view = GameObject.Instantiate(main);
        // view.transform.SetParent(this.canvas2D.transform, false);
        // Debug.Log(view.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
