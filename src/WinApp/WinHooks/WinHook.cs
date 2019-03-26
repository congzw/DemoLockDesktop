using System.IO;
using System.Runtime.InteropServices;
using WinApp.Properties;

namespace WinApp.WinHooks
{
    internal class WinHook
    {
        private const string WinLockDllPath = "WinLockDll.dll";
        
        [DllImport(WinLockDllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int Desktop_Show_Hide(bool bEnableDisable);

        [DllImport(WinLockDllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int CtrlAltDel_Enable_Disable(bool bEnableDisable);

        [DllImport(WinLockDllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int AltTab1_Enable_Disable(bool bEnableDisable);

        [DllImport(WinLockDllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int StartButton_Show_Hide(bool bShowHide);

        [DllImport(WinLockDllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int Taskbar_Show_Hide(bool bShowHide);

        [DllImport(WinLockDllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int Clock_Show_Hide(bool bShowHide);

        [DllImport(WinLockDllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int TaskSwitching_Enable_Disable(bool bEnableDisable);

        [DllImport(WinLockDllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int TaskManager_Enable_Disable(bool bEnableDisable);

        [DllImport(WinLockDllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int Keys_Enable_Disable(bool bEnableDisable);

        [DllImport("user32.dll")]
        internal static extern void BlockInput(bool block);

        static WinHook()
        {
            var copyPath = "WinLockDll.dll";
            if (!File.Exists(copyPath))
            {
                File.WriteAllBytes(copyPath, Resources.WinLockDll);
            }
        }
    }
}
