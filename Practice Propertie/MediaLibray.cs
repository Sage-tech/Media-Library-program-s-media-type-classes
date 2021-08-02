namespace Treehouse.MediaLibrary
{
    class MediaLibrary
    {
        private MediaType[] _items;
        
        public int NumberOfItems => _items.Length;

        public MediaLibrary(MediaType[] items)
        {
            _items = items;
        }
        
public void DisplayItems()
{

for (int index = 0; index < _items.Length; index++) 
{


}

}

        public MediaType GetItemAt(int index)
        {
            if (index < _items.Length)
            {
                return _items[index];                
            }
            else
            {
                System.Console.WriteLine("An element at index " + index + " doesn't exist in the media library.");
                
                return null;
            }
        }
    }
}