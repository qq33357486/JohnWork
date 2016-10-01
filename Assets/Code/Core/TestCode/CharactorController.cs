using UnityEngine;
using System.Collections;

public class CharactorController : MonoBehaviour
{

    /// <summary>
    /// 目标
    /// </summary>
    public GameObject target;

    public NavMeshAgent agent;

    void OnGUI()
    {
        if (GUILayout.Button("寻路"))
        {
            agent.destination = target.transform.position;
        }
    }
}
