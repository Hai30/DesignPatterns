using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A19_Ex02.Logic
{
	public class SortByKeyAdaptee : ISortByKey
	{
		public List<KeyValuePair<object, int>> SortByInt(List<KeyValuePair<object, int>> lst)
		{
			lst.Sort(CompareByInt);
			return lst;
		}
		public List<KeyValuePair<object, string>> SortByString(List<KeyValuePair<object, string>> lst)
		{
			lst.Sort(CompareByString);
			return lst;
		}
	
		
		private int CompareByInt(KeyValuePair<object, int> a, KeyValuePair<object, int> b)
		{
			return a.Value.CompareTo(b.Value);
		}
		private int CompareByString(KeyValuePair<object, string> a, KeyValuePair<object, string> b)
		{
			return a.Value.CompareTo(b.Value);
		}



	}
}
