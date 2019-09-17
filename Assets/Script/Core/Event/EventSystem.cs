using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventCallBack {
    /** 参数 */
    protected System.Object[] arguments;

    /** 事件类型 */
    protected int eventType;

    /** 发送者 */
    protected System.Object sender;

    public int Type {
        get {return this.eventType;}
        set {this.eventType = value;}
    }

    public System.Object[] Param {
        get {return this.arguments;}
        set {arguments = value;}
    }
    public System.Object Sender {
        get {return this.sender;}
        set {sender = value;}
    }

    //常用函数
    public override string ToString() {
        return this.eventType + "[" + ((this.sender == null) ? "null" : this.sender.ToString()) + "]";
    }

    public EventCallBack Clone() {
        return new EventCallBack(this.eventType, this.arguments, this.sender);
    }

    public EventCallBack(int _type){
        this.eventType = _type;
    }

    public EventCallBack(int _type, System.Object _sender){
        this.eventType = _type;
        this.sender = _sender;
    }

    public EventCallBack(int _type, System.Object[] _args, System.Object _sender){
        this.eventType = _type;
        this.arguments = _args;
        this.sender = _sender;
    }
}

public delegate void EventListenerDelegate(EventCallBack ecb);

public class EventSystem
{
   static Dictionary<int, EventListenerDelegate> notifications = new Dictionary<int, EventListenerDelegate>();
   public void On(int _type, EventListenerDelegate _listener){
       if(_listener == null){
           Debug.Debug.LogError("listener不能为空");
           return;
       }

       EventListenerDelegate myListener = null;
       this.notifications.TryGetValue(_type, out myListener);
       this.notifications[_type] = (EventListenerDelegate)Delegate.Combine(myListener, _listener);
   }

    public void RemoveListener(int _type, EventListenerDelegate _listener){
        if(_listener == null){
           Debug.Debug.LogError("listener不能为空");
           return;
        }
        this.notifications[_type] = (EventListenerDelegate)Delegate.Remove(this.notifications[_type], _listener);
    }

    public void RemoveAllListener(){
        this.notifications.Clear();
    }

    public void Emit(EventCallBack ecb){
        EventListenerDelegate listenerDelegate;
        if(this.notifications.TryGetValue(ecb.Type, listenerDelegate)){
            try{
                if(listenerDelegate != null){
                    listenerDelegate(ecb);
                }
            }catch(System.Exception err){
                throw new System.Exception(string.Concat(new string[] {"error emit event", ecb.Type.ToString(), ":", err.Message, " ", err.StackTrace}), err);
            }
        }
    }
}
