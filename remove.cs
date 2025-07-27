using MelonLoader;
using UnityEngine;
using System.Collections;

namespace DisableNewGameButton
{
    public class Main : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            MelonLogger.Msg($"Scene loaded: {sceneName}");

            MelonCoroutines.Start(DisableNewGameButtonCoroutine());
        }

        private IEnumerator DisableNewGameButtonCoroutine()
        {
            yield return new WaitForSeconds(1f);

            var buttonObj = GameObject.Find("/Main Menu/Canvas/Main Menu/Panel/Title Panel/Title Buttons/New Game Button");

            if (buttonObj != null)
            {
                buttonObj.SetActive(false);
                MelonLogger.Msg("new file button just got EPICLY NUKED");
            }
            else
            {
                MelonLogger.Warning("couldnt nuke new file button :( (not found)");
            }
        }
    }
}
