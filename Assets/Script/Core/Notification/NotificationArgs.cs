using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace NotificationArgs {
    public class GameEventArgs : EventArgs {
        private string _msgName;
        public string msgName {
            get { return this._msgName; }
            set { this._msgName = value; }
        }
        public GameEventArgs(string s){
            this._msgName = s;
        }
    }

    public class GameAssetArgs : EventArgs {
        private GameObject _asset;
        public GameObject asset {
            get { return this._asset; }
            set { this._asset = value; }
        }
        public GameAssetArgs(GameObject obj){
            this._asset = obj;
        }
    }
}
