using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Video;




public class video : MonoBehaviour {

    public RawImage rawImage;
    public VideoPlayer videoPlayer;
    private AudioSource audio;
	// Use this for initialization
	void Start () {
        StartCoroutine(PlayVideo());
	}
	
	// Update is called once per frame
	void Update () {

		
	}
    IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while(!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();

    }
}

