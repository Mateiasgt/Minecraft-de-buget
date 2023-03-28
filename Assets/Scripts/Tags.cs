using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tags : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private List<Tag> _tags;
    

    public List<Tag> All => _tags;

    public bool HasTag(Tag t)
    {
        return _tags.Contains(t);
    }
        public bool HasTag(string tagName){
     return _tags.Exists(match:t => t.Name == tagName );
    }

    
}
