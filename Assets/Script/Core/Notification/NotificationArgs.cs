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
}
