using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayRandomVideo : MonoBehaviour
{
	
	[SerializeField] private VideoClip[] videoClipList;
	private VideoPlayer _videoPlayer;
	private Camera _cam;
	
	void Awake(){
		_videoPlayer = this.GetComponent<VideoPlayer>();
		_videoPlayer.Pause();
		_cam = Camera.main;
	}

	
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			RaycastHit hit;
        	Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
	        if (Physics.Raycast(ray, out hit))
	        {
		        if (hit.transform.name.Equals("play"))
		        {
			        _videoPlayer.clip = videoClipList[Random.Range(0, videoClipList.Length)];
			        _videoPlayer.Play();
		        }
		        if (hit.transform.name.Equals("pause"))
		        {
			        if (_videoPlayer.isPlaying){
				        _videoPlayer.Pause();
			        }
			        else
			        {
				        _videoPlayer.Play();
			        }
		        }
		        if (hit.transform.name.Equals("stop"))
		        {
			        _videoPlayer.Stop();
		        }
		        
	        }
		}
		
    }
}
