namespace Skyline.Protocol.Events
{
	using System;
	using System.Collections.Generic;

	using Skyline.DataMiner.Scripting;

	public class Events
	{
		private readonly Random rd;

		public Events()
		{
			rd = new Random();
		}

		public List<object[]> GetEvents()
		{
			List<object[]> allRows = new List<object[]>
			{
				CreateEventRow("1", "News").ToObjectArray(),
				CreateEventRow("2", "Sports").ToObjectArray(),
				CreateEventRow("3", "Movie Time").ToObjectArray(),
				CreateEventRow("4", "Skyline Late Night").ToObjectArray(),
			};

			return allRows;
		}

		private EventsoverviewQActionRow CreateEventRow(string primaryKey, string eventName)
		{
			EventsoverviewQActionRow row = new EventsoverviewQActionRow
			{
				Eventsoverviewinstance_101 = primaryKey,
				Eventsoverviewname_102 = eventName,
				Eventsoverviewstatus_103 = GetRandomEventState(),
			};

			return row;
		}

		private int GetRandomEventState()
		{
			return rd.Next(0, 4);
		}
	}
}