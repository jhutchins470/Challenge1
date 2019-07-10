using UnityEngine;
using System.Collections;

 public class Obstacle2 : MonoBehaviour {
     Vector3 pointA = new Vector3(-7f, -0f, -22.6f);
     Vector3 pointB = new Vector3(1.34f, 0f, -34.48f);
     void Update()
     {
         transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
     }
 }