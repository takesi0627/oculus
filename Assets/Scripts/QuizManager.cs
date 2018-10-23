using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour {
	[SerializeField] Texture2D correctImage;
	[SerializeField] Texture2D wrongImage;

	[SerializeField] RawImage answerImage;
	[SerializeField] float fadeOutTime = 1.0f;
	[SerializeField] float fadeInTime = 0.5f;

	static QuizManager _instance;

    public static QuizManager instance
    {
        get
        {
            return _instance;
        }
    }

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		if (_instance == null) {
			_instance = this;
		}
		else if (_instance != this) {
			// enforce singleton
			Destroy(gameObject);
		}
	}
    public void Answer (bool correct) {
		// if (!answerImage.gameObject.activeSelf) {
			answerImage.gameObject.SetActive(true);
		// }
		if (correct) {
			answerImage.texture = correctImage;
		}
		else {
			answerImage.texture = wrongImage;
		}
		// answerImage.CrossFadeAlpha(1.0f, fadeInTime, true);
		// answerImage.CrossFadeAlpha(0.0f, fadeOutTime, true);
	}
}
