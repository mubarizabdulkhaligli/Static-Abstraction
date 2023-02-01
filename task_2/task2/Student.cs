using System;
namespace task2
{
	internal class Student
	{
		public int No;
		public string Name;
		private string _groupNo;

        private static int _totalCount;

        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }

		public string GroupNo {
			set
			{
				if (CheckGroupNo(value))
					_groupNo = value;
			}
			get => _groupNo;
			}



        static public bool CheckGroupNo(string groupno)
		{
			if (string.IsNullOrWhiteSpace(groupno) || groupno.Length != 4 || !char.IsUpper(groupno[0]))
				return false;

			for (int i = 1; i < groupno.Length; i++)
			{
				if (!char.IsDigit(groupno[i]))
					return false;
			}
			return true;
		}
	}
}

