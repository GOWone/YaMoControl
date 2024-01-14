using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaMoControl.Models
{
    public class ListItemModel
    {
		private int index;

		public int Index
		{
			get { return index; }
			set { index = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string remark;

		public string Remark
		{
			get { return remark; }
			set { remark = value; }
		}
	}
}
