using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelVisibilityTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void SetActive(bool enable)
	{
		gameObject.SetActive(enable);
	}

	void SetRenderer(bool enable)
	{
		GetComponent<Renderer>().enabled = enable;
	}

	void SetLayer(bool enable)
	{
		gameObject.layer = LayerMask.NameToLayer(enable ? "Default" : "Hidden");
	}

	void SetScale(bool enable)
	{
		transform.localScale = enable ? Vector3.one : Vector3.zero;
	}
}
