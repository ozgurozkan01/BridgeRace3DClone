using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlockCreatorController : MonoBehaviour
{
    /*private List<GameObject> _firstPlatformBlockPos;
    private List<GameObject> _redBlockPos;
    private List<GameObject> _blueBlockPos;
    private List<GameObject> _greenBlockPos;

    [SerializeField] private GameObject originalRedBlock;
    [SerializeField] private GameObject originalBlueBlock;
    [SerializeField] private GameObject originalGreenBlock;
    
    // Start is called before the first frame update
    private void Awake()
    {
        _firstPlatformBlockPos = new List<GameObject>();
    }

    void Start()
    {
        foreach (var pos in GameObject.FindGameObjectsWithTag("FirstPlatformBlockPos"))
            _firstPlatformBlockPos.Add(pos);
            
        Debug.Log(_firstPlatformBlockPos.Count);
    }

    // Update is called once per frame
    void Update()
    {
        AlingTheBlocksRandomly();
    }

    void AlingTheBlocksRandomly()
    {
        if (_firstPlatformBlockPos.Count != 0)
        {
            if (_blueBlockPos.Count < 20)
            {
                Transform bluePosition = _firstPlatformBlockPos[Random.Range(0, _firstPlatformBlockPos.Count)].transform;
                GameObject newBlueBlock = Instantiate(originalBlueBlock, bluePosition.position, transform.rotation);
                _firstPlatformBlockPos.Remove(bluePosition.gameObject);
                _blueBlockPos.Add(bluePosition.gameObject);
            }

            if (_redBlockPos.Count < 20)
            {
                Transform redPosition = _firstPlatformBlockPos[Random.Range(0, _firstPlatformBlockPos.Count)].transform;
                GameObject newRedBlock = Instantiate(originalBlueBlock, redPosition.position, transform.rotation);
                _firstPlatformBlockPos.Remove(redPosition.gameObject);
                _redBlockPos.Add(redPosition.gameObject);
            }

            if (_greenBlockPos.Count < 20)
            {
                Transform greenPosition = _firstPlatformBlockPos[Random.Range(0, _firstPlatformBlockPos.Count)].transform;
                GameObject newGreenBlock = Instantiate(originalBlueBlock, greenPosition.position, transform.rotation);
                _firstPlatformBlockPos.Remove(greenPosition.gameObject);
                _greenBlockPos.Add(greenPosition.gameObject);
            }
        }
    }*/
}
