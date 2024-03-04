using System;

using Skyline.DataMiner.Scripting;
using Skyline.Protocol.Events;

/// <summary>
/// DataMiner QAction Class: Populate Event Data.
/// </summary>
public class QAction
{
	/// <summary>
	/// The QAction entry point.
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void Run(SLProtocol protocol)
	{
		try
		{
			Events events = new Events();
			protocol.FillArray(Parameter.Eventsoverview.tablePid, events.GetEvents(), NotifyProtocol.SaveOption.Full);
		}
		catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}
}