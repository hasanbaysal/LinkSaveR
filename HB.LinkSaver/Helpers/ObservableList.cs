namespace HB.LinkSaver.Helpers
{
    public class ObservableList
    {
        public List<string> Data { get => _data;}
        private List<string> _data;
        public event Action? ItemAdded;
        public event Action? ItemRemoved;
        public event Action? ListCleared;

        public ObservableList()
        {
                _data  = new List<string>();
        }
        public void Add(string item)
        {
            Data.Add(item);

            if(ItemAdded != null)
            ItemAdded?.Invoke(); 
        }

        public bool Remove(string item)
        {
            bool removed = Data.Remove(item);
             
            if(ItemRemoved != null)
                ItemRemoved?.Invoke(); 

            return removed;
        }

        public void Clear()
        {
            Data.Clear();

            if(ListCleared != null)
                ListCleared?.Invoke(); 
        }
    }

}
