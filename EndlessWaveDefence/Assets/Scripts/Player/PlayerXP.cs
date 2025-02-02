using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerXP : MonoBehaviour
{
    public float XP;
    public float XPNeeded;
    public float XpMulti;
    public float xpgained;
    public GameObject MenuUI;

    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;


    public Transform Spot1;
    public Transform Spot2;
    public Transform Spot3;
    //public GameObject[] UpgradesArray;
    public List<GameObject> UpgradeList;
    public List<GameObject> List2;
    
    int index;

    public bool MenuActive = false; 
    
    // Start is called before the first frame update
    void Start()
    {
        MenuActive = false;
        MenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(XP >= XPNeeded)
        {
            LevelUp();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "XP")
        {
            XP += xpgained;
            Destroy(collision.gameObject);
        }
    }


    void LevelUp()
    {
        
        MenuActive = true;
        Time.timeScale = 0f;
        XP = 0.0f;
        XPNeeded = XPNeeded * XpMulti;
        print("LevelUp!");

        MenuUI.SetActive(true);

        if(Slot1 == null)
        {
            index = Random.Range(0, UpgradeList.Count);
            Slot1 = UpgradeList[index];
            UpgradeList.RemoveAt(index);
        }

        if(Slot1 != null && Slot2 == null)
        {
            index = Random.Range(0, UpgradeList.Count);
            Slot2 = UpgradeList[index];
            UpgradeList.RemoveAt(index);
        }

        if (Slot1 != null && Slot2 != null && Slot3 == null)
        {
            index = Random.Range(0, UpgradeList.Count);
            Slot3 = UpgradeList[index];
            UpgradeList.RemoveAt(index);


            foreach (GameObject UpgradeUI in UpgradeList)
            {
                UpgradeUI.SetActive(false);
                List2.Add(UpgradeUI);
            }

            
            UpgradeList.Clear();
        }

        Slot1.transform.position = Spot1.position;
        Slot2.transform.position = Spot2.position;
        Slot3.transform.position = Spot3.position;

        print("ClearList");
        UpgradeList = new List<GameObject>();
        UpgradeList.AddRange(GameObject.FindGameObjectsWithTag("Upgrades"));
        UpgradeList.AddRange(List2);
        
    }

  public void PickUpgrade()
    {
        foreach (GameObject UpgradeCards in List2)
        {
            UpgradeCards.SetActive(true);
        }

        List2.Clear();
        Slot1 = null;
        Slot2 = null;
        Slot3 = null;
    }

}
