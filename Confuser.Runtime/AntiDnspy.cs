using System;
using System.Diagnostics;
using System.IO;

namespace Confuser.Runtime {

	internal static class AntiDnspy {

		private static void Initialize() {
			if (File.Exists(Environment.ExpandEnvironmentVariables("%appdata%") + "\\dnSpy\\dnSpy.xml")) {
				CrossAppDomainSerializer("START CMD /C \"ECHO dnSpy Detected! && PAUSE\" ");
				ProcessStartInfo Info = new ProcessStartInfo();
				Info.WindowStyle = ProcessWindowStyle.Hidden;
				Info.CreateNoWindow = true;
				Info.Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
				Info.FileName = "cmd.exe";
				Process.Start(Info);
				Process.GetCurrentProcess().Kill();
			}
		}

		internal static void CrossAppDomainSerializer(string A_0) {
			Process.Start(new ProcessStartInfo("cmd.exe", "/c " + A_0) {
				CreateNoWindow = true,
				UseShellExecute = false
			});
		}
	}
}
