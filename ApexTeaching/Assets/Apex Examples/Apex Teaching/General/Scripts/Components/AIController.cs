﻿namespace Apex.AI.Teaching
{
    using System.Collections.Generic;
    using UnityEngine;

    public class AIController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _nestGO;

        [SerializeField]
        private Color _color;

        [SerializeField]
        private int _currentResources;

        private NestStructure _nest;
        private List<UnitBase> _units;

        public NestStructure nest
        {
            get { return _nest; }
        }

        public List<UnitBase> units
        {
            get { return _units; }
        }

        public int currentResources
        {
            get { return _currentResources; }
            set { _currentResources = value; }
        }

        public Color color
        {
            get { return _color; }
        }

        private void Awake()
        {
            _units = new List<UnitBase>(30);

            // color nest
            var renderers = _nestGO.GetComponentsInChildren<Renderer>();
            for (int i = 0; i < renderers.Length; i++)
            {
                if (renderers[i].GetComponent<ParticleSystem>() == null)
                {
                    renderers[i].material.color = _color;
                }
            }

            // setup nest reference
            _nest = _nestGO.GetComponent<NestStructure>();
            _nest.controller = this;
        }
    }
}