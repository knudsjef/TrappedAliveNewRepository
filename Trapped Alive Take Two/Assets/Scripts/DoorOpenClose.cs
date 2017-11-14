using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenClose : MonoBehaviour
{
    private const float SPEED_MULTIPLIER = 2f;
    [SerializeField]
    GameObject Control;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Control.GetComponent<Lever>().On)
        {
            
            if (this.transform.localScale.y > 0)
            {
                this.transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y - SPEED_MULTIPLIER * Time.deltaTime);
            }
            else
            {
                this.transform.localScale = new Vector2(transform.localScale.x, 0);
            }
        }
        else
        {
            Debug.Log("Off");
            if (this.transform.localScale.y < 1)
            {
                this.transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y + SPEED_MULTIPLIER * Time.deltaTime);
            }
            else
            {
                this.transform.localScale = new Vector2(transform.localScale.x, 1);
            }
        }
    }
}
