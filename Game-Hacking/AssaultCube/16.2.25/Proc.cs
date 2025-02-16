using System.Diagnostics;

public class Proc{
	private string _processName = "AC.exe"; // Process Name 
	public void GetProcess() {
		GetProcessID(_processName); // Not Needed yet
	}

	public void GetProcessID(string processName){
		Console.WriteLine("Getting the Process name " + processName);
		var processListSnapshot = Process.GetProcesses(); // Get All Local Running Processes if needed
		var processSnapshot = Process.GetProcessesByName(processName); // Get All Currently Running Processes for the Game Specifically


		if (!processSnapshot){
			Console.WriteLine("Could not find the target's Process Name / Process ID");
			return; 
		}

	}
}
