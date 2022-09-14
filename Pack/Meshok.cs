using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pack
{
    class Meshok
    {
        public int _maxCount { get; }
        public double _maxWeight { get; }
        public double _maxVolume { get; }

        public int _currentCount { get; private set; }
        public double _currentWeight { get; private set; }
        public double _currentVolume { get; private set; }

        public readonly InventoryItem[] _itemsArray;

      

        public Meshok(int maxCount, double maxWeight, double maxVolume)
        {
            _maxCount = maxCount;
            _maxVolume = maxVolume;
            _maxWeight = maxWeight;

            _itemsArray = new InventoryItem[maxCount];
        }

        public bool additem(InventoryItem item)

        {
            if (_currentCount >= _maxCount || (_currentVolume + item._volume) > _maxVolume || (_currentWeight + item._weight) > _maxWeight)
            { return false; }
            _itemsArray[_currentCount] = item;
            _currentCount++;
            _currentWeight = item._weight + _currentWeight;
            _currentVolume = item._volume + _currentVolume;
            return true;
        }
    }
}
