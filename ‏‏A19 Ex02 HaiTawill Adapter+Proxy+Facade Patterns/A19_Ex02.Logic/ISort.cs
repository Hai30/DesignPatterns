using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A19_Ex02.Logic
{
	public interface ISort
	{ 
		List <object> sortObjectList(List<object> list,List<string> key);

		List<object> sortObjectList(List<object> list, List<int> key);
	}
}
