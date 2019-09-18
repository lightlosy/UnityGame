using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameLoading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("onLoadScene", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onLoadScene(){
        SceneManager.LoadScene("GameScene");
    }
}
