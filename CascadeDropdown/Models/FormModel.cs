using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadeDropdown.Models
{
	public class FormModel
	{
		public int StateId { get; set; }
		public string StateName { get; set; }
		public int DistrictId { get; set; }
		public string DistrictName { get; set; }
	}
}