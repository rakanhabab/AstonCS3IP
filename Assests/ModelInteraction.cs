using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ModelInteraction : MonoBehaviour
{
    public Button yourButton; 
    public int state;
    public GameObject trackedModel; 
    public GameObject cochlea;
    public GameObject BoneText;
    public GameObject bonesCyl;
    public GameObject earAnatomy;
    public GameObject earDrum;
    public GameObject earDrumCyl;
    public GameObject earDrumText;
    public GameObject facialAUD;
    public GameObject facialAUDText;
    public GameObject facialAUDCyl;
    public GameObject hair;
    public GameObject malleus;
    public GameObject stapes;
    public GameObject vestibular;

    void Start()
    {
        state = 0;
        yourButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        state++;

        if (state == 0){
            cochlea.SetActive(true);
            BoneText.SetActive(true);
            bonesCyl.SetActive(true);
            earAnatomy.SetActive(true);
            earDrum.SetActive(true);
            earDrumCyl.SetActive(true);
            earDrumText.SetActive(true);
            facialAUD.SetActive(true);
            facialAUDCyl.SetActive(true);
            facialAUDText.SetActive(true);
            hair.SetActive(true);
            malleus.SetActive(true);
            stapes.SetActive(true);            
            vestibular.SetActive(true);
            
        }else if (state == 1){
            cochlea.SetActive(true);
            BoneText.SetActive(true);
            bonesCyl.SetActive(true);
            earAnatomy.SetActive(false);
            earDrum.SetActive(false);
            earDrumCyl.SetActive(false);
            earDrumText.SetActive(false);
            facialAUD.SetActive(false);
            facialAUDCyl.SetActive(false);
            facialAUDText.SetActive(false);
            hair.SetActive(false);
            malleus.SetActive(true);
            stapes.SetActive(true);            
            vestibular.SetActive(true);
        }else if (state == 2){
            cochlea.SetActive(false);
            BoneText.SetActive(false);
            bonesCyl.SetActive(false);
            earAnatomy.SetActive(false);
            earDrum.SetActive(true);
            earDrumCyl.SetActive(true);
            earDrumText.SetActive(true);
            facialAUD.SetActive(false);
            facialAUDCyl.SetActive(false);
            facialAUDText.SetActive(false);
            hair.SetActive(false);
            malleus.SetActive(false);
            stapes.SetActive(false);            
            vestibular.SetActive(false);
        }else if (state == 3){
            cochlea.SetActive(false);
            BoneText.SetActive(false);
            bonesCyl.SetActive(false);
            earAnatomy.SetActive(false);
            earDrum.SetActive(false);
            earDrumCyl.SetActive(false);
            earDrumText.SetActive(false);
            facialAUD.SetActive(true);
            facialAUDCyl.SetActive(true);
            facialAUDText.SetActive(true);
            hair.SetActive(false);
            malleus.SetActive(false);
            stapes.SetActive(false);            
            vestibular.SetActive(false);
        }else if (state == 4){
            cochlea.SetActive(true);
            BoneText.SetActive(false);
            bonesCyl.SetActive(false);
            earAnatomy.SetActive(true);
            earDrum.SetActive(true);
            earDrumCyl.SetActive(false);
            earDrumText.SetActive(false);
            facialAUD.SetActive(true);
            facialAUDCyl.SetActive(false);
            facialAUDText.SetActive(false);
            hair.SetActive(true);
            malleus.SetActive(true);
            stapes.SetActive(true);            
            vestibular.SetActive(true);
        }
        else{
            state = 0;
            cochlea.SetActive(true);
            BoneText.SetActive(true);
            bonesCyl.SetActive(true);
            earAnatomy.SetActive(true);
            earDrum.SetActive(true);
            earDrumCyl.SetActive(true);
            earDrumText.SetActive(true);
            facialAUD.SetActive(true);
            facialAUDCyl.SetActive(true);
            facialAUDText.SetActive(true);
            hair.SetActive(true);
            malleus.SetActive(true);
            stapes.SetActive(true);            
            vestibular.SetActive(true);
        }
    }
}