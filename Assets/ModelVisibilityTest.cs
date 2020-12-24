using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelVisibilityTest : MonoBehaviour
{
	[SerializeField]
	Button activeButton;

	[SerializeField]
	Button rendererButton;

	[SerializeField]
	Button layerButton;

	[SerializeField]
	Button alphaButton;

	[SerializeField]
	Button scaleButton;

	bool activeToggle = true;
	bool rendererToggle = true;
	bool layerToggle = true;
	bool scaleToggle = true;
	bool alphaToggle = true;

	Color defaultColor;

    // Start is called before the first frame update
    void Awake()
    {
		activeButton.onClick.AddListener(() =>
		{
			activeToggle = !activeToggle;
			SetActive(activeToggle);
		});

		rendererButton.onClick.AddListener(() =>
		{
			rendererToggle = !rendererToggle;
			SetRenderer(rendererToggle);
		});

		layerButton.onClick.AddListener(() =>
		{
			layerToggle = !layerToggle;
			SetLayer(layerToggle);
		});

		alphaButton.onClick.AddListener(() =>
		{
			alphaToggle = !alphaToggle;
			SetAlpha(alphaToggle);
		});

		scaleButton.onClick.AddListener(() =>
		{
			scaleToggle = !scaleToggle;
			SetScale(scaleToggle);
		});

		defaultColor = GetComponent<Renderer>().material.color;
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

	void SetAlpha(bool enable)
	{
		GetComponent<Renderer>().material.color = enable ? defaultColor : Color.clear;
	}
}
