using System;
using System.Runtime.InteropServices;


namespace ApplicationSwitch
{
    public static class User32
    {
        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr handle, int nCmdShow);
        [DllImport("User32.dll")]
        private static extern bool IsIconic(IntPtr handle);

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        const int SwRestore = 9;
        public static void BringToFront(string title)
        {
            
            IntPtr handle = FindWindow(null, title);

            if (handle == IntPtr.Zero)
            {
                return;
            }
            if (IsIconic(handle))
            {
                ShowWindow(handle, SwRestore);
            }

            SetForegroundWindow(handle);
        }
    }
}
