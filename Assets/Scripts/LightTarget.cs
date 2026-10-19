
using UnityEngine;

public class LightTarget : MonoBehaviour
{
    public Light pointLight;

    public void HitTarget()
    {
        pointLight.enabled = !pointLight.enabled;

        Debug.Log("Light toggled!");
    }
}
