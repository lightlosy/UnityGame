using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player {
    public Player (GameLaunch g){
        g.cusEvent += new EventHandler(this.onTest);
    }

    void onTest(System.Object sender, EventArgs e){
        Debug.Log("100110" + ((NotificationArgs.GameEventArgs)e).msgName);
    }
}

public class GameLaunch : MonoBehaviour
{
    public event EventHandler cusEvent;

    // Start is called before the first frame update
    void Start()
    {
        Player p = new Player(this);
        this.Emit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Emit(){
        if(this.cusEvent != null){
            this.cusEvent(this, new NotificationArgs.GameEventArgs("A"));
        }
    }
}
