// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class MenuController : MonoBehaviour
{
    public AudioClip gene_audio_clip;
    public AudioClip sexo_audio_clip;
    public AudioClip identidade_audio_clip;
    public AudioClip orientacao_audio_clip;

    private GameObject text;
    private GameObject bar;
    private GameObject bar_text;
    private GameObject bar_volume;
    private GameObject confirmar;
    private GameObject confirmar_text;
    
    private GameObject identidade;
    private GameObject sexo;
    private GameObject orientacao;

    private GameObject boneco;
    private Animator boneco_animator;
    private AudioSource boneco_audio_source;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.transform.Find("Text").gameObject;
        bar = gameObject.transform.Find("Bar").gameObject;
        bar_text = bar.transform.Find("BarText").gameObject;
        bar_volume = bar.transform.Find("RawImage").gameObject;
        confirmar = gameObject.transform.Find("Confirmar").gameObject;
        confirmar_text = confirmar.transform.Find("Text").gameObject;

        identidade = GameObject.Find("Identity").gameObject;
        sexo = GameObject.Find("Sex").gameObject;
        orientacao = GameObject.Find("Orientation").gameObject;

    }

    public void Confirmar() {
        confirmar.GetComponent<Image>().enabled = false;
        confirmar.GetComponent<Button>().enabled = false;
        confirmar_text.GetComponent<TextMeshProUGUI>().enabled = false;

        bar_text.GetComponent<Text>().text = "Gene";
        text.GetComponent<TextMeshProUGUI>().text = "Oi, eu sou Gene! Selecione uma das partes de meu corpo para saber mais sobre gênero!";
        // text.GetComponent<RectTransform>().offsetMin = new Vector2 (0, 0);

        identidade.GetComponent<RawImage>().enabled = true;
        sexo.GetComponent<RawImage>().enabled = true;
        orientacao.GetComponent<RawImage>().enabled = true;
        boneco = GameObject.FindWithTag("boneco");
        boneco_animator = boneco.GetComponent<Animator>();
        boneco_audio_source = boneco.transform.Find("Audio Source").gameObject.GetComponent<AudioSource>();

        boneco_audio_source.Stop();
        boneco_audio_source.clip = gene_audio_clip;
        boneco_audio_source.Play();
    }

    public void Reset() {
        confirmar.GetComponent<Image>().enabled = true;
        confirmar.GetComponent<Button>().enabled = true;
        confirmar_text.GetComponent<TextMeshProUGUI>().enabled = true;

        bar_text.GetComponent<Text>().text = "Posicione o Boneco";
        text.GetComponent<TextMeshProUGUI>().text = "Aponte a câmera para uma superfície plana e posicicione o boneco em uma área laranja!";
        // text.GetComponent<RectTransform>().offsetMin = new Vector2 (0, 0);

        identidade.GetComponent<RawImage>().enabled = false;
        sexo.GetComponent<RawImage>().enabled = false;
        orientacao.GetComponent<RawImage>().enabled = false;

        boneco_animator.ResetTrigger("heart_trigger");
        boneco_animator.ResetTrigger("head_trigger");
        boneco_animator.SetTrigger("idle_trigger");
        
        boneco_audio_source.Stop();
    }

    public void Identidade() {
        bar_text.GetComponent<Text>().text = "Identidade de Gênero";
        text.GetComponent<TextMeshProUGUI>().text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        boneco_animator.ResetTrigger("heart_trigger");
        boneco_animator.SetTrigger("head_trigger");
        boneco_animator.ResetTrigger("idle_trigger");

        boneco_audio_source.Stop();
        boneco_audio_source.clip = identidade_audio_clip;
        boneco_audio_source.Play();
    }

    public void Orientacao() {
        bar_text.GetComponent<Text>().text = "Orientação Sexual";
        text.GetComponent<TextMeshProUGUI>().text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        boneco_animator.SetTrigger("heart_trigger");
        boneco_animator.ResetTrigger("head_trigger");
        boneco_animator.ResetTrigger("idle_trigger");
        
        boneco_audio_source.Stop();
        boneco_audio_source.clip = orientacao_audio_clip;
        boneco_audio_source.Play();
    }

    public void Sexo() {
        bar_text.GetComponent<Text>().text = "Sexo";
        text.GetComponent<TextMeshProUGUI>().text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        boneco_animator.ResetTrigger("heart_trigger");
        boneco_animator.ResetTrigger("head_trigger");
        boneco_animator.SetTrigger("idle_trigger");
        
        boneco_audio_source.Stop();
        boneco_audio_source.clip = sexo_audio_clip;
        boneco_audio_source.Play();
    }

    public void Expressao() {
        bar_text.GetComponent<Text>().text = "Expressão de Gênero";
        text.GetComponent<TextMeshProUGUI>().text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        boneco_animator.ResetTrigger("heart_trigger");
        boneco_animator.ResetTrigger("head_trigger");
        boneco_animator.SetTrigger("idle_trigger");
    }

    // Update is called once per frame
    // void Update()
    // {
    //     //Check for mouse click 
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         RaycastHit raycastHit;
    //         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //         if (Physics.Raycast(ray, out raycastHit, 100f))
    //         {
    //             if (raycastHit.transform != null)
    //             {
    //                //Our custom method. 
    //                 CurrentClickedGameObject(raycastHit.transform.gameObject);
    //             }
    //         }
    //     }

    //     if (Input.GetKey(KeyCode.Escape))
    //     {
    //         // Desabilita trigger coracao_on e habilita coracao_off 
    //         m_Animator.ResetTrigger("trigger_coracao_on");
    //         m_Animator.SetTrigger("trigger_coracao_off");
    //         Debug.Log("desliga coracaum");
    //     }
    // }

    // public void CurrentClickedGameObject(GameObject gameObject)
    // {
    // if(gameObject.tag=="heart")
    // {
    //     Debug.Log("coracaum");
    //     // Desabilita trigger coracao_off e habilita coracao_on
    //     m_Animator.SetTrigger("trigger_coracao_on");
    //     m_Animator.ResetTrigger("trigger_coracao_off");
    // }
    // }

}
