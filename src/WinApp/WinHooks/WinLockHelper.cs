namespace WinApp.WinHooks
{
    internal class WinLockHelper
    {
        internal static void SetEnable(bool enable)
        {
            WinHook.Desktop_Show_Hide(enable);
            WinHook.CtrlAltDel_Enable_Disable(enable);
            WinHook.AltTab1_Enable_Disable(enable);
            WinHook.StartButton_Show_Hide(enable);
            WinHook.Taskbar_Show_Hide(enable);
            WinHook.TaskSwitching_Enable_Disable(enable);
            WinHook.TaskManager_Enable_Disable(enable);
        }
    }
}