using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class BtnClick : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject playBtn = GameObject.Find("Canvas/Plane/Play");
        GameObject skipBtn = GameObject.Find("Canvas/Plane/Skip");
        Button play = (Button) playBtn.GetComponent<Button>();
        Button skip = (Button) skipBtn.GetComponent<Button>();
        play.onClick.AddListener(()=> {
            OnClick(playBtn);
            OnShowAds();
        });
        skip.onClick.AddListener(()=>{
            OnClick(skipBtn);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnClick(Object bt)
    {
        Debug.Log(bt.name);
    }
    public void OnShowAds()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}
