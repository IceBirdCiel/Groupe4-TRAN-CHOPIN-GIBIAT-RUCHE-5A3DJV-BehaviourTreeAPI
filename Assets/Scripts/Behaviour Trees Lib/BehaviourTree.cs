﻿using System;
using System.Collections.Generic;
using PGSauce.Core.PGDebugging;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ESGI.BehaviourTrees
{
    /// <summary>
    /// The class to derive from to create a Behaviour Tree. It is a MonoBehaviour.
    /// </summary>
    /// <typeparam name="TAgent">The type of the agent being controlled by the tree (Boss, Enemy etc.)</typeparam>
    public abstract class BehaviourTree<TAgent> : BehaviourTreeBase where TAgent : MonoBehaviour
    {
        [SerializeField] private Node<TAgent> startNode;
        [SerializeField] private TAgent agent; 
        
        private List<Node<TAgent>> _nodes;
        private bool Activated => State == NodeState.Running;

        /// <summary>
        /// A reference to the MonoBehaviour being controlled by this BT.
        /// </summary>
        public TAgent Agent => agent;

        [ShowInInspector, ReadOnly]
        private NodeState State { get; set; }

        /// <summary>
        /// Checks if the Agent is null, if not tries to get it. If still null, logs an
        /// error.
        /// </summary>
        protected void Awake()
        {
            if (Agent == null)
            {
                agent = GetComponentInChildren<TAgent>();
            }

            if (Agent == null)
            {
                PGDebug.Message($"No agent found in {name} !!").LogError();
            }
        }

        protected void Start()
        {
            ActivateBehaviourTree();
        }

        protected void OnDisable()
        {
            DeactivateBehaviourTree();
        }

        protected void OnEnable()
        {
            ActivateBehaviourTree();
        }

        protected void OnDestroy()
        {
            DeactivateBehaviourTree();
        }

        protected void Update()
        {
            if (startNode)
            {
                PGDebug.Message(PGDebug.Header($"TICK {Time.frameCount}")).Log();
                startNode.Update();
                if (startNode.IsRunningLastChild || startNode.State == NodeState.Failure || startNode.State == NodeState.Success)
                {
                    ResetTree();
                }
            }
        }

        private void ResetTree()
        {
            foreach (var node in _nodes)
            {
                if (node == startNode.LastChild)
                {
                    if (node.State == NodeState.Running)
                    {
                        continue;
                    }
                }
                
                node.State = NodeState.NotExecuted;
            }
        }

        protected void OnDrawGizmos()
        {
#if UNITY_EDITOR
            if (Application.isPlaying && _nodes != null)
            {
                foreach (var node in _nodes)
                {
                    node.DrawGizmos();
                }
            }
#endif
        }

        private void DeactivateBehaviourTree()
        {
        }

        private void ActivateBehaviourTree()
        {
            if (Activated)
            {
                return;
            }

            _nodes = new List<Node<TAgent>>();
            InitNodes(startNode);
            State = NodeState.Running;
        }

        private void InitNodes(Node<TAgent> root)
        {
            root.Init(this);
            _nodes.Add(root);
            foreach (var child in root.Children)
            {
                InitNodes(child);
            }
        }
    }
}