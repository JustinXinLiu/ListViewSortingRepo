using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ListViewSortingRepo
{
    public static class ObservableCollectionExtensions
    {
        public static void Sort<TSource, TKey>(this ObservableCollection<TSource> source, Func<TSource, TKey> keySelector)
        {
            var sortedSource = source.OrderBy(keySelector).ToList();

            for (var i = 0; i < sortedSource.Count; i++)
            {
                var itemToSort = sortedSource[i];

                // If the item is already at the right position, leave it and continue.
                if (source.IndexOf(itemToSort) == i)
                {
                    continue;
                }

                source.Remove(itemToSort);
                source.Insert(i, itemToSort);
            }
        }
    }
}
