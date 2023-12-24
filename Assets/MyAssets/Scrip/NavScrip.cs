using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NavScrip : MonoBehaviour
{
    public UnityEvent onAnswerGiven;

    public bool HasKey{
        get {return hasKey;}
        set {hasKey = value;}
    }

    private bool hasKey;



    [SerializeField]
    private UnityEngine.AI.NavMeshAgent player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray target = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(target, out var hitInfo))
            {
                player.SetDestination(hitInfo.point);
            }
        }

        this.GetComponent<Animator>().SetFloat("Speed", this.player.velocity.magnitude);

    }

    public void ReSet()
    {
        this.transform.position = new Vector3(0.0f,0.0f,0.0f);
        hasKey = false;
        player.SetDestination(this.transform.position);
    }

}
