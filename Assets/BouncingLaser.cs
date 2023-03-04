using System;
using UnityEngine;

public class BouncingLaser : MonoBehaviour
{
    int maxBounces = 10;
    
    public void OnDrawGizmos(){
        Vector2 origin = transform.position;
        Vector2 dir = transform.right; // x - axis
        Ray ray = new Ray(origin, dir);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(origin, origin + dir);

        for (int i = 0; i < maxBounces; i++)
        {
            if(Physics.Raycast(ray, out RaycastHit hit)){
                Gizmos.color = Color.red;
                Gizmos.DrawLine(ray.origin, hit.point);
                Vector2 reflected = Reflect(ray.direction, hit.normal);
                Gizmos.color = Color.white;
                Gizmos.DrawLine(hit.point, (Vector2)hit.point + reflected);

                ray.direction = reflected;
                ray.origin = hit.point;
            } else {
                break;
            }
 
        } 
    }

    Vector2 Reflect(Vector2 inDir, Vector2 normal){
        float projDistance = Vector2.Dot(inDir, normal);
        return inDir - 2 * projDistance * normal;
    }
}
