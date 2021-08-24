namespace MonoGame_Project.Content.Components
{ 
    abstract class Component
    {
        private GameObject _owner;
        public GameObject Owner 
        { 
            get { return _owner; } 
            set { _owner = value; OnOwnerSet(); } 
        }
        public Component()
        { 
            
        }

        protected virtual void OnOwnerSet() { }
    }
}
