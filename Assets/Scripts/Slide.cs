using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slide
{
    public static GameObject slidePrefab;
    public GameObject slide;
    public int id;

    public Slide(int id)
    {
        this.id = id;
    }

    public void display()
    {
        Debug.Log(slidePrefab);
        this.slide = GameObject.Instantiate(slidePrefab, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        setAllData();
    }

    private void setAllData()
    {
        setTitle();
        setText();
        setImage();
    }

    private void setImage()
    {
        Texture image = Resources.Load<Texture2D>("SlideData/Images/" + id);
        this.slide.transform.Find("Panel").transform.Find("Image").GetComponent<RawImage>().texture = image;
    }

    private void setText()
    {
        TextAsset text = Resources.Load<TextAsset>("SlideData/Writing/" + id);
        this.slide.transform.Find("Panel").transform.Find("Text").GetComponent<Text>().text = text.ToString();
    }

    private void setTitle()
    {
        TextAsset title = Resources.Load<TextAsset>("SlideData/Titles/" + id);
        this.slide.transform.Find("Panel").transform.Find("Title").GetComponent<Text>().text = title.ToString();
    }

    public void destroy()
    {
        GameObject.Destroy(slide);
    }
}
