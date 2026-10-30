using UnityEngine;

public class DiscoBallToMusic : MonoBehaviour
{
    public AudioSource music;
    public float bpm = 184f;
    public float beatsPerTurn = 4f;

    void LateUpdate()
    {
        if (music == null || !music.isPlaying)
            return;

        float secondsPerTurn = (60f / bpm) * beatsPerTurn;
        float angle = (music.time / secondsPerTurn) * 360f;
        transform.localEulerAngles = new Vector3(0f, 0f, angle);
    }
}
