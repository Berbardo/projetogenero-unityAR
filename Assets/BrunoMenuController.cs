using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrunoMenuController : MonoBehaviour
{
    public Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Check for mouse click 
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null)
                {
                   //Our custom method. 
                    CurrentClickedGameObject(raycastHit.transform.gameObject);
                }
            }
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            // Desabilita trigger coracao_on e habilita coracao_off 
            m_Animator.ResetTrigger("trigger_coracao_on");
            m_Animator.SetTrigger("trigger_coracao_off");
            Debug.Log("desliga coracaum");
        }
    }

    public void CurrentClickedGameObject(GameObject gameObject)
    {
    if(gameObject.tag=="heart")
    {
        Debug.Log("coracaum");
        // Desabilita trigger coracao_off e habilita coracao_on
        m_Animator.SetTrigger("trigger_coracao_on");
        m_Animator.ResetTrigger("trigger_coracao_off");
    }
    }

}
