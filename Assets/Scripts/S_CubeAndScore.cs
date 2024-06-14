using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CubeAndScore : MonoBehaviour
{
    //Manages movement of the cube by detecting whether it collided with something
    //Manages the Score (should've been in a different script for oder but why make life complicated?)
    [SerializeField] private TMPro.TMP_Text score;
    private Rigidbody rg;
    private void Start()
    {
        score = GameObject.Find("ScoreText").GetComponent<TMPro.TMP_Text>();
        rg = gameObject.GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        this.transform.position = new Vector3(Random.Range(-7, 7), 4, 0);
        if(collision.transform.tag == "Border") score.text = "0";
        else score.text = (System.Convert.ToInt32(score.text) + 1).ToString();
        rg.velocity = Vector3.zero;
    }
}
