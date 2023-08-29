using Projects.Script.Manager;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.MenuScripts
{
    public class SettingGame : MonoBehaviour
    {
        [Header("ImageOff")] 
        [SerializeField] private GameObject imageMusic;
        [SerializeField] private GameObject imageVfx;


        

        void Update()
        {
            ShowImageMusic();
            ShowImageVfx();
        }
        private void ShowImageMusic()
        {
            if (SoundManager.Instance.themeSource.enabled)
            {
                imageMusic.SetActive(false);
            }
            else if (!SoundManager.Instance.themeSource.enabled)
            {
                imageMusic.SetActive(true);
            }
        }
        private void ShowImageVfx()
        {
            if (SoundManager.Instance.vfxSource.enabled)
            {
                imageVfx.SetActive(false);
            }
            else if (!SoundManager.Instance.vfxSource.enabled)
            {
                imageVfx.SetActive(true);
            }
        }
        public void ChangeMusicSetting()
        {
            if (SoundManager.Instance.themeSource.isActiveAndEnabled)
            {
                SoundManager.Instance.themeSource.enabled = false;

                imageMusic.SetActive(true);
            }
            else
            {
                SoundManager.Instance.themeSource.enabled = true;

                imageMusic.SetActive(false);
            }
        }
        public void ChangeVfxSetting()
        {
            if (SoundManager.Instance.vfxSource.isActiveAndEnabled)
            {
                SoundManager.Instance.vfxSource.enabled = false;
                imageVfx.SetActive(true);
            }
            else
            {
                SoundManager.Instance.vfxSource.enabled = true;
                imageVfx.SetActive(false);
            }
        }
        
        


    }
}
