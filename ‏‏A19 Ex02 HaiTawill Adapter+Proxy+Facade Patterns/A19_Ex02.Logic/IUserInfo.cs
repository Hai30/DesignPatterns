using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A19_Ex02.Logic
{
	public interface IUserInfo
	{
		void insertUserInfoToLists();
		List<string> getNameList(List<object> lst);
		List<int> getCommentAmountList(List<object> lst);
		List<int> getPhotosAmountList(List<object> lst);

	}
}
