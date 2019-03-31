using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;


namespace A19_Ex02.Logic
{
	public class DoSortAdapter :ISort
	{
		private ISortByKey IsortByKey = new SortByKeyAdaptee();
		private List<KeyValuePair<object,int>> newListByInt = new List<KeyValuePair<object, int>>();
		private List<KeyValuePair<object, string>> newListByString = new List<KeyValuePair<object,string>>();

		private List<KeyValuePair<object, int>> sortedByIntList = new List<KeyValuePair<object, int>>();
		private List<KeyValuePair<object, string>> sortedByStringList = new List<KeyValuePair<object, string>>();

		public List<object> sortObjectList(List<object> lst,List<string> sList)
		{
			int count = 0;
			foreach (object item in lst)
			{
				KeyValuePair<object,string> Item = new KeyValuePair<object, string>(item,sList[count]);
				newListByString.Add(Item);
				count++;
			}
			sortedByStringList = IsortByKey.SortByString(newListByString);
			lst.Clear();
			foreach (var item in sortedByStringList)
			{
				lst.Add(item.Key);
			}

			return lst;

		}
		public List<object> sortObjectList(List<object> lst, List<int> intList)
		{
			int count = 0;
			foreach (object item in lst)
			{
				KeyValuePair<object, int> Item = new KeyValuePair<object, int>(item, intList[count]);
				newListByInt.Add(Item);
				count++;
			}
			sortedByIntList = IsortByKey.SortByInt(newListByInt);
			lst.Clear();
			foreach (var item in sortedByIntList)
			{
				lst.Add(item.Key);
			}

			return lst;

		}
	}
}
