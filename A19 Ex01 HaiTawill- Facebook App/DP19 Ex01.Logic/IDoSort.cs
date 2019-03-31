using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP19_Ex01.Logic
{
	public class IDoSort
	{
		static int Compare2(KeyValuePair<object, int> a, KeyValuePair<object, int> b)
		{
			return a.Value.CompareTo(b.Value);
		}
		public static List<object> SortAlbums(List<object> lst,string sortType)
		{
			List<KeyValuePair<object, int>> newList = new List<KeyValuePair<object, int>>();
			if (sortType == "Album")
			{
				foreach (Album album in lst)
				{
					newList.Add(new KeyValuePair<object, int>(album, album.Photos.Count));
				}
			}
			if (sortType == "Post")
			{
				foreach (Post album in lst)
				{
					newList.Add(new KeyValuePair<object, int>(album, album.Comments.Count));
				}
			}
			if (sortType == "Checkin")
			{
				foreach (Checkin checkin in lst)
				{
					newList.Add(new KeyValuePair<object, int>(checkin, checkin.Comments.Count));
				}
			}
			newList.Sort(Compare2);
			lst.Clear();
			for(int i=0 ;i<newList.Count;i++)
			{
				lst.Add(newList[i].Key);
			}
			return lst;
		}
	}
}
