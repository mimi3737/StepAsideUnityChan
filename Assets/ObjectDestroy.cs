using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;
    //Unity�����ƃJ�����̋���
    private float difference;

    


    // Use this for initialization
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {

        this.unitychan = GameObject.Find("unitychan");
        this.difference = this.transform.position.z - unitychan.transform.position.z;
        if (this.difference <  -10)
            

        {
            Destroy(this.gameObject);
        }
    }
}