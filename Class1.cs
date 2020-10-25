using MelonLoader;
using UnityEngine;
namespace kittys_anti_blackscreen{
    public class Class1:MelonMod{
        public override void VRChat_OnUiManagerInit(){
            GameObject.Find("UserInterface/PlayerDisplay/BlackFade/inverted_sphere").SetActive(false);
        }
    }
}
