using System.Collections;
using UnityEngine;

namespace EvansUnityLib
{
    public static class Projectile
    {
        public static Vector3 GetMovementVector(Vector3 direction, float speed) => direction * speed * Time.deltaTime;

        public static IEnumerator WaitThenDelete(float seconds, GameObject toDelete)
        {
            yield return new WaitForSeconds(seconds);
            Object.Destroy(toDelete);
        }
    }
}