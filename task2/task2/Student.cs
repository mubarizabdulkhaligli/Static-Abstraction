using System;
namespace task2
{
	internal class Student
	{
		public int No;
		public string FullName;
		public int Point;


		private static int _totalCount;

		public Student()
		{
			_totalCount++;
			No = _totalCount;
		}


	}
}

