using UnityEngine;
using System.Collections;

 public class Obstacle : MonoBehaviour {
     Vector3 pointA = new Vector3(-4.77f, -0.64f, -39.99f);
     Vector3 pointB = new Vector3(-24.2f, -0.64f, -31.7f);
     void Update()
     {
         transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
     }
 }