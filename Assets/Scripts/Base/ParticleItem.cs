using System.Threading.Tasks;
using UnityEngine;

public class ParticleItem : PoolItem
{
    private ParticleSystem _particleSystem;
    private void Awake() {
        _particleSystem = GetComponent<ParticleSystem>();
    }

    private void Start() {
         _particleSystem.Play();
    }

    public async void DelayPlay(float delay)
    {
        _particleSystem.Stop();
        _particleSystem.Clear(); 

        await Task.Delay((int)(delay * 1000));

        _particleSystem.Play();
    }

    public void Stop()
    {
        _particleSystem.Stop();
    }
}
