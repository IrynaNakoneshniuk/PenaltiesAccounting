using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltiesAccounting
{
    internal class MenuEventHandler
    {
        public delegate void MenuDelegate(MainItems mainItems);
        public SortedList<int, MenuDelegate> _sortedEvents;
        public MenuEventHandler()
        {
            _sortedEvents = new SortedList<int, MenuDelegate>();
        }
        public event MenuDelegate menu
        {
            add
            {
                for (int key=1; ;key++)
                {
                    if (!_sortedEvents.ContainsKey(key))
                    {
                        _sortedEvents.Add(key, value);
                        break;
                    }
                }
            }
            remove
            {
                _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
            }
        }
    }
}
