using Newtonsoft.Json;
using System;

namespace Pipedrive
{
	public class DateOnlyConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
	{
		public DateOnlyConverter()
		{
			base.DateTimeFormat = "yyyy-MM-dd";
		}

		
	}
}
