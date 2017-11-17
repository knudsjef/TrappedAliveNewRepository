using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LastLightFlicker : MonoBehaviour {

    [SerializeField]
    GameObject SilhouetteDude;

    [SerializeField]
    GameObject Player;

    [SerializeField]
    TilemapRenderer BackgroundRenderer;

    [SerializeField]
    Material Default;

    [SerializeField]
    [Range(1, 10)]
    int possibilityToTurnOnOff = 7;

    [SerializeField]
    [Range(1, 10)]
    int lengthOfVisibility = 2;

    [SerializeField]
    float lengthOfOffTime = 1;

    float flickerTime = 0;
    float offTime = 0;
    bool isVisible;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isVisible)
        {
            flickerTime += Time.deltaTime;
            if(Mathf.RoundToInt(Random.Range(0, 100)) % possibilityToTurnOnOff == 0)
            {
                transform.GetChild(0).GetComponent<Light>().enabled = !transform.GetChild(0).GetComponent<Light>().enabled;
            }
        }

        if(flickerTime >= lengthOfVisibility)
        {
            offTime += Time.deltaTime;
            foreach(GameObject light in Player.GetComponent<LightFlicks>().Lights)
            {
                light.transform.GetChild(3).transform.GetChild(0).GetComponent<Light>().enabled = false;
            }
            this.transform.GetChild(0).GetComponent<Light>().enabled = false;
            SilhouetteDude.SetActive(false);

            if(offTime > lengthOfOffTime)
            {
                BackgroundRenderer.material = Default;
            }
        }
	}

    private void OnBecameVisible()
    {
        isVisible = true;
    }

    private void OnBecameInvisible()
    {
        isVisible = false;
    }
}
