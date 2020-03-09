using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ChunksPlacer : MonoBehaviour
{
    public Transform player;
    public Chunk[] ChunkPrefabs;
    public Chunk firstChunk;
    private List<int> indexOfPreviousChunk = new List<int>();

    private List<Chunk> spawnedChunks = new List<Chunk>();

    private int currentIndex;
    private int minDistanseToSpawn = 20;

    void Start()
    {
        spawnedChunks.Add(firstChunk);
    }
    
    void Update()
    {
        if (player)
        {
            if (player.position.x > spawnedChunks[spawnedChunks.Count - 1].end.position.x - minDistanseToSpawn)
            {
                SpawnChunk();
            }
        }
    }

    public void SpawnChunk()
    {
        int newChunkIndex = NextChunk();
        Chunk newChunk = Instantiate(ChunkPrefabs[newChunkIndex]);
        newChunk.transform.position = new Vector2(spawnedChunks[spawnedChunks.Count-1].end.position.x - newChunk.begin.localPosition.x,spawnedChunks[spawnedChunks.Count-1].end.position.y - newChunk.begin.localPosition.y);
        
        spawnedChunks.Add(newChunk);

        if (spawnedChunks.Count >= 6)
        {
            Destroy(spawnedChunks[0].gameObject);
            spawnedChunks.RemoveAt(0);
        }
    }

    private int NextChunk()
    {
        if (indexOfPreviousChunk.Count > 0)
        {
            currentIndex = Random.Range(0, ChunkPrefabs.Length);
            int i = 0;
            while (i < indexOfPreviousChunk.Count)
            {
                if (currentIndex == indexOfPreviousChunk[i])
                {
                    currentIndex = Random.Range(0, ChunkPrefabs.Length);
                    i = 0;
                }
                else
                    i++;
            }
                
            indexOfPreviousChunk.Add(currentIndex);
            if(indexOfPreviousChunk.Count > 20)
                indexOfPreviousChunk.RemoveAt(0);
            return currentIndex;
        }
        else
        {
            currentIndex = Random.Range(0, ChunkPrefabs.Length);
            indexOfPreviousChunk.Add(currentIndex);
            return currentIndex;
        }
    }
}
