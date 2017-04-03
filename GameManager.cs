using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    [SerializeField]
    Text VisitorText;
    [SerializeField]
    Text Revenue;

    Zoo zoo;
    public float timer = 10;
	// Use this for initialization
	void Start () {
        zoo = GameObject.FindObjectOfType<Zoo>();
        
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            zoo.SetZooState();
            zoo.CheckZooState();
            zoo.VisNum -= zoo.visitorDecline;
            timer = 10;
        }
        VisitorText.text = "Vistiors: " + zoo.VisNum;
        Revenue.text = "Current Revenue: " + zoo.CurrentRevenue;
	}
}
