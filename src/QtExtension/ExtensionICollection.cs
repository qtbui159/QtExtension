using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qt
{
    public static class ExtensionICollection
    {
        /// <summary>
        /// 批量加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="e"></param>
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> e)
        {
            IEnumerator<T> etor = e.GetEnumerator();
            while (etor.MoveNext())
            {
                collection.Add(etor.Current);
            }
        }

        /// <summary>
        /// 如果不存在，则加入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="value"></param>
        public static void AddIfNotContains<T>(this ICollection<T> collection, T value)
        {
            if (!collection.Contains(value))
            {
                collection.Add(value);
            }
        }

        /// <summary>
        /// 移除满足条件的元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="predicate"></param>
        public static void RemoveWhere<T>(this ICollection<T> collection, Func<T, bool> predicate)
        {
            List<T> list = new List<T>();
            IEnumerator<T> etor = collection.GetEnumerator();

            while (etor.MoveNext())
            {
                if (predicate(etor.Current))
                {
                    list.Add(etor.Current);
                }
            }

            for (int i = 0, count = list.Count; i < count; ++i)
            {
                collection.Remove(list[i]);
            }
        }

        /// <summary>
        /// 根据key去重
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> Distinct<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            Dictionary<TKey, TSource> keyMapValue = new Dictionary<TKey, TSource>();

            foreach (TSource obj in source)
            {
                TKey key = keySelector(obj);
                if (!keyMapValue.ContainsKey(key))
                {
                    keyMapValue.Add(key, obj);
                }
            }

            return keyMapValue.Values;
        }
    }
}
