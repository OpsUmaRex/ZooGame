using UnityEngine;
using System.Collections;
using System;

public class Zoo : MonoBehaviour {

    public enum ZooState { Failing, Poor, Stable, Prosperous}
    private ZooState zstate;

    public ZooState Zstate
    {
        get {
            return zstate;
        }
        set {
            zstate = value;
        }

    }

    public int VisNum;
    public int CurrentRevenue;

    public int visitorDecline;

	// Use this for initialization
	void Start () {
        VisNum = 100;
        CurrentRevenue = 1000;
        SetZooState();
        CheckZooState();
	}
	
	// Update is called once per frame
	void Update () {
 
        
	}

    public void CheckZooState()
    {
        switch (Zstate)
        {
            case ZooState.Failing:
                visitorDecline = 10;
                break;
            case ZooState.Poor:
                visitorDecline = 15;
                break;
            case ZooState.Stable:
                visitorDecline = 20;
                break;
            case ZooState.Prosperous:
                visitorDecline = 25;
                break;
            default:
                break;
        }
    }

    public void SetZooState()
    {
        if (VisNum <= 100 && VisNum > 50)
        {
            Zstate = ZooState.Poor;
        }
        if (VisNum < 200 && VisNum > 100)
        {
            Zstate = ZooState.Stable;
        }
        if (VisNum >= 200)
        {
            Zstate = ZooState.Prosperous;
        }
        if (VisNum <= 50)
        {
            Zstate = ZooState.Failing;
        }
    }
}
