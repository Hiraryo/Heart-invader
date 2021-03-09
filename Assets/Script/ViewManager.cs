using UnityEngine;
using UnityEngine.SceneManagement;

namespace App
{
    public abstract class ViewBase : MonoBehaviour
    {
        protected void ChangeScene(string path)
        {
            SceneManager.LoadScene(path);
        }
    }

    public class HogeView : ViewBase
    {
        private void Start()
        {
            //ViewBaseを継承することで、どんなViewからも画面遷移できるようになる
            ChangeScene("");
        }
    }
}