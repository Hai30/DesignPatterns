using System.Collections.Generic;

namespace A19_Ex02.Logic
{
	public interface ISortByKey
	{
		List<KeyValuePair<object, int>> SortByInt(List<KeyValuePair<object, int>> lst);
		List<KeyValuePair<object, string>> SortByString(List<KeyValuePair<object, string>> lst);
	}
}