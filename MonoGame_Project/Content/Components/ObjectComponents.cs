using System;
using System.Collections.Generic;

namespace MonoGame_Project.Content.Components
{
    class ObjectComponents
    {
        public GameObject _owner;
        private Dictionary<string, Component> _components = new Dictionary<string, Component>();

        public ObjectComponents(GameObject owner)
        {
            _owner = owner;
            Add<Transform>();
        }
        public T Add<T>() where T : Component, new()
        {
            var tString = typeof(T).Name;
            if (!_components.ContainsKey(tString))
            {
                T newComponent = new T();
                newComponent.Owner = _owner;
                _components.Add(tString, newComponent);
                return newComponent;
            }

            return null;
        }

        public T GetComponent<T>() where T : Component
        {
            var tString = typeof(T).Name;
            if (_components.ContainsKey(tString))
            {
                return (T)_components[tString];
            }

            return null;
        }
    }
}
