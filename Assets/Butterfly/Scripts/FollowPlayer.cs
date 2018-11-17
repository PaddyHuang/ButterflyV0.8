using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform follower;
	public Transform spectator;
	public float smoothing = 3;
    private Transform followerTrasnform;
    private Transform spectatorTransform;
    private Transform myTransform;
		// 相机缓冲速度
	
	void Start(){
        followerTrasnform = follower;
        spectatorTransform = spectator;
        myTransform=transform;
	}
	
	void Update(){
        transform.position = Vector3.Lerp(myTransform.position, followerTrasnform.position, smoothing * Time.deltaTime);
        transform.LookAt(spectatorTransform.position);

	}
		





}

