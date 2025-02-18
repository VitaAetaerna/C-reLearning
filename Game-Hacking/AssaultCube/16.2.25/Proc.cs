using System.Diagnostics;

public class Proc{
	private string _processName = "Spotify"; // Process Name 
	public void GetProcessInfo() {
		var mainProc = GetMainProcess(_processName);
		var procId = mainProc.Id;
		var baseHandle = getBaseHandle(mainProc);
	}

	public  GetMainProcess(string processName){
		Console.WriteLine("Getting the Process name " + processName);
		var processListSnapshot = Process.GetProcesses(); // Get All Local Running Processes if needed
		var processSnapshot = Process.GetProcessesByName(processName); // Get All Currently Running Processes for the Game Specifically

		// If no process of Game was found -> Exit
		if (processSnapshot == null){
			Console.WriteLine("Could not find the target's Process Name / Process ID");
			return; 
		}
		// Extract the Main Process that i want to edit and read memory from
		var mainProcess = processSnapshot[0];

		// Output all the found Processes with the name and its PID -> Also output the main Process + its PID and Output the Main Process and its Base Handle
		foreach (var item in processSnapshot){
			Console.WriteLine("PID to " + item + " is " + item.Id);
		}
		Console.WriteLine("Parent Process is " + mainProcess + " ID: " + mainProcess.Id);
		return mainProcess;
	}

	public int getBaseHandle(Process mainProcess){
		// Get the baseHandle to interact with the Process
		var baseHandle = mainProcess != null ? mainProcess.Handle : null;
		if (baseHandle == null){
			Console.WriteLine("Base Handle of Process " + mainProcess + mainProcess.Id + " could not be fetched");
		} 
		Console.WriteLine("Parent Process is " + mainProcess + " Base Handle: " + baseHandle);
		return baseHandle;
	}
}
