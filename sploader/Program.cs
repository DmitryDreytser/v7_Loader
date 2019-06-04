using Dll_Injector;
using WinApi;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace sploader
{
    class Program
    {

        public delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);
        #region WM consts
        private const Int32 BM_CLICK = 0x00F5;
        private const Int32 WM_GETTEXT        = 0x000D;
        private const Int32 WM_GETTEXTLENGTH      = 0x000E;
        private const Int32 WM_SETTEXT        = 0x000C;
        #endregion

        public static uint Old;

        public static Process Configurator = null;
        public static StringBuilder Pass = new StringBuilder("Password");

        static void WinEventProc(
                    IntPtr hWinEventHook,
                    WinApi.User32.Winevents dwEvent,
                    IntPtr hWnd,
                    int idObject,
                    int idChild,
                    uint dwEventThread,
                    uint dwmsEventTime
                    )
        {
            if (dwEvent == User32.Winevents.EVENT_OBJECT_LOCATIONCHANGE)
                return;

            Int32 size = 0;
            if (dwEvent == User32.Winevents.EVENT_OBJECT_CREATE)
            {
                    size = User32.SendMessage(hWnd, WM_GETTEXTLENGTH, IntPtr.Zero, IntPtr.Zero).ToInt32();
                    if (size > 0)
                    {
                        StringBuilder caption = new StringBuilder(size + 1);
                        User32.SendMessage(hWnd, WM_GETTEXT, caption.Capacity, caption);
                        
                        if (caption.ToString().Contains("Доступ ограничен"))
                        {
                            User32.ShowWindow(hWnd, User32.WindowShowStyle.Hide);
                            IntPtr EditBox = User32.FindWindowEx(hWnd, IntPtr.Zero, "Edit", "");
                            IntPtr OKButton = User32.FindWindowEx(hWnd, IntPtr.Zero, "Button", "&OK");
                            User32.SendMessage(EditBox, WM_SETTEXT, Pass.Capacity, Pass);
                            User32.SendMessage(OKButton, BM_CLICK, IntPtr.Zero, IntPtr.Zero);
                            return;
                        }
                    }
            }

            //if (dwEvent == User32.Winevents.EVENT_OBJECT_INVOKED || dwEvent == User32.Winevents.EVENT_OBJECT_STATECHANGE)
            //{
                //string Class = GetWindowClass(hWnd);
                //size = SendMessage(hWnd, WM_GETTEXTLENGTH, IntPtr.Zero, IntPtr.Zero).ToInt32();
                //if (size > 0)
                //{
                //    StringBuilder caption = new StringBuilder(size + 1);
                //    SendMessage(hWnd, WM_GETTEXT, caption.Capacity, caption);

                //    //Console.WriteLine("EVENT: {0}, hWND:{1}, child:{2}, Caption:{3}, ClassName:{4}", dwEvent, hWnd, idChild, caption, Class);
                //}
               // else
               //     Console.WriteLine("EVENT: {0}, hWND:{1}, child:{2}, Caption:{3}, ClassName:{4}", dwEvent, hWnd, idChild, "", Class);
            //}

            

        }

     

        [STAThread]
        static void Main(string[] args)
        {
            bool DebugMode = args.Contains<string>("DEBUG");
            bool EnterpriseMode = args.Contains<string>("ENTERPRISE");
            bool MonitorMode = args.Contains<string>("MONITOR");
           
            bool NoMono = false;

            if (EnterpriseMode)
            {
                NoMono = MessageBox.Show("Запустить в разделенном режиме?", "Опции запуска предприятия.", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes; 
            }
            
            string paremeters = " ";
            foreach (string arg in args)
            {
                if (NoMono)
                    paremeters += arg.Replace("\"", "").Replace("/M","") + " ";
                else
                    paremeters += arg.Replace("\"", "") + " ";
            }

            // AllocConsole();
            if (DebugMode || EnterpriseMode || MonitorMode)
            {
                
                Process _1c = new Process();
                _1c.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "1cv7s.exe";
                _1c.StartInfo.Arguments = paremeters;
                _1c.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
                DirectoryInfo modules = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "spx7"));

                _1c.Start();
                _1c.WaitForInputIdle();
                Injector.SuspendProcess(_1c);
                IntPtr hProcess = (IntPtr)Injector.OpenProcess(0x1F0FFF, 1, _1c.Id);

                if (hProcess == null)
                {
                    MessageBox.Show("OpenProcess() Failed!");
                    return;
                }
                

                foreach (FileInfo DLL in modules.GetFiles("v7*.dll"))
                {
                    Injector.InjectDLL(hProcess, DLL.FullName);
                }

                if(DebugMode)
                {
                    WinApi.User32.SetWinEventHook(WinApi.User32.Winevents.EVENT_MIN, WinApi.User32.Winevents.EVENT_MAX,
                        IntPtr.Zero, WinEventProc, _1c.Id, 0,
                        WinApi.User32.Winevents.WINEVENT_OUTOFCONTEXT
                        );
                }

                Injector.ResumeProcess(_1c);

                if (DebugMode)
                {
                    _1c.WaitForExit();
                }
            }
            else
            {
                
                Process _1c = new Process();
                _1c.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "1cv7s.exe";
                _1c.StartInfo.Arguments = paremeters;
                _1c.Start();
                _1c.WaitForInputIdle();

                Injector.SuspendProcess(_1c);
                // AllocConsole();
                WinApi.User32.SetWinEventHook(WinApi.User32.Winevents.EVENT_MIN, WinApi.User32.Winevents.EVENT_MAX,
                                        IntPtr.Zero, WinEventProc, _1c.Id, 0,
                                        WinApi.User32.Winevents.WINEVENT_OUTOFCONTEXT
                                        );

                IntPtr hProcess = (IntPtr)Injector.OpenProcess(0x1F0FFF, 1, _1c.Id);

                if (hProcess == null)
                {
                    MessageBox.Show("OpenProcess() Failed!");
                    return;
                }

                string DLLName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "spldrdll.dll");
                Injector.InjectDLL(hProcess, DLLName);
                Injector.ResumeProcess(_1c);
                Configurator = _1c;

                if (Configurator != null)
                {
                    
                    while (Configurator.MainWindowHandle == IntPtr.Zero)
                    {
                        Thread.Sleep(10);
                        Configurator.Refresh();
                    }


                    while (Configurator.MainWindowTitle == "Запуск 1С:Предприятия" || Configurator.MainWindowTitle == string.Empty)
                    {
                        Thread.Sleep(10);
                        Configurator.Refresh();
                        if (Configurator.HasExited)
                            return;
                    }

                    if (Configurator.HasExited)
                        return;

                    while (Configurator.MainWindowHandle == IntPtr.Zero || Configurator.MainWindowTitle == string.Empty)
                    {
                        Thread.Sleep(100);
                        Configurator.Refresh();
                    }


                    if (Configurator.MainWindowTitle.Contains("Конфигуратор"))
                    {
                       Configurator.WaitForExit();
                    }
                }

            }

             
        }
    }
}

namespace Dll_Injector
{
    public static class Injector
    {
        [DllImport("kernel32")]
        public static extern IntPtr CreateRemoteThread(
          IntPtr hProcess,
          IntPtr lpThreadAttributes,
          uint dwStackSize,
          UIntPtr lpStartAddress, // raw Pointer into remote process  
          IntPtr lpParameter,
          uint dwCreationFlags,
          out IntPtr lpThreadId
        );

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(
            UInt32 dwDesiredAccess,
            Int32 bInheritHandle,
            Int32 dwProcessId
            );

        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(
        IntPtr hObject
        );

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool VirtualFreeEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            UIntPtr dwSize,
            uint dwFreeType
            );

        [DllImport("kernel32.dll", ExactSpelling = true)]
        public static extern UIntPtr GetProcAddress(
            IntPtr hModule,
            string procName
            );

        [DllImport("kernel32.dll", ExactSpelling = true)]
        public static extern IntPtr GetProcAddress(
            uint hModule,
            string procName
            );

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            uint dwSize,
            uint flAllocationType,
            Protection flProtect
            );

        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            string lpBuffer,
            UIntPtr nSize,
            out IntPtr lpNumberOfBytesWritten
        );

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(
            string lpModuleName
            );

        [DllImport("kernel32", SetLastError = true, ExactSpelling = true)]
        internal static extern Int32 WaitForSingleObject(
            IntPtr handle,
            Int32 milliseconds
            );

        const int THREADACCESS_SUSPEND_RESUME = 0x0002;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int SuspendThread(IntPtr hThread);
        
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);

        enum Protection : uint
        {
            PAGE_NOACCESS = 0x01,
            PAGE_READONLY = 0x02,
            PAGE_READWRITE = 0x04,
            PAGE_WRITECOPY = 0x08,
            PAGE_EXECUTE = 0x10,
            PAGE_EXECUTE_READ = 0x20,
            PAGE_EXECUTE_READWRITE = 0x40,
            PAGE_EXECUTE_WRITECOPY = 0x80,
            PAGE_GUARD = 0x100,
            PAGE_NOCACHE = 0x200,
            PAGE_WRITECOMBINE = 0x400
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle,
           uint dwThreadId);

        [DllImport("kernel32.dll")]
        static extern uint GetLastError();

        [DllImport("kernel32.dll")]
        static extern bool GetExitCodeThread(IntPtr hThread, out uint lpExitCode);

        [STAThread]
        public static void InjectDLL(IntPtr hProcess, String strDLLName)
        {
            IntPtr bytesout;
            Int32 LenWrite = strDLLName.Length + 1;
            IntPtr AllocMem = (IntPtr)VirtualAllocEx(hProcess, (IntPtr)null, (uint)LenWrite, 0x1000, Protection.PAGE_EXECUTE_READWRITE); 
            WriteProcessMemory(hProcess, AllocMem, strDLLName, (UIntPtr)LenWrite, out bytesout);
            UIntPtr Injector = (UIntPtr)GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            if (Injector == null)
            {
                MessageBox.Show(" Injector Error! \n ");
                return;
            }

            IntPtr hThread = (IntPtr)CreateRemoteThread(hProcess, (IntPtr)null, 0, Injector, AllocMem, 0, out bytesout);

            if (hThread == null)
            {
                return;
            }

            int Result = WaitForSingleObject(hThread, 10 * 3000);
            if (Result == 0x00000080L || Result == 0x00000102L || Result == -1)
            {
                if (hThread != null)
                {
                    CloseHandle(hThread);
                }
                return;
            }
            //Приберемся
            VirtualFreeEx(hProcess, AllocMem, (UIntPtr)0, 0x8000);
            if (hThread != null)
            {
                CloseHandle(hThread);
            }
            return;
        }

         [STAThread]
        public static void SuspendProcess(Process p)
        {

            foreach (ProcessThread thd in p.Threads)
            {
                IntPtr threadHandle = OpenThread(THREADACCESS_SUSPEND_RESUME, false, (uint)thd.Id); // Open thread with required permissions
                if (threadHandle == IntPtr.Zero) // If thread pointer is zero, means that the 'OpenThread' function has failed
                {
                    throw new Win32Exception((int)GetLastError());
                }
                if (SuspendThread(threadHandle) == -1) // If the result is -1, the funtion has failed
                {
                    CloseHandle(threadHandle);
                    throw new Win32Exception((int)GetLastError());
                }
                CloseHandle(threadHandle); // Don't forget close thread handle
            }

        }


        [STAThread]
        public static void ResumeProcess(Process p)
        {

            foreach (ProcessThread thd in p.Threads)
            {
                IntPtr threadHandle = OpenThread(THREADACCESS_SUSPEND_RESUME, false, (uint)thd.Id); 
                if (threadHandle == IntPtr.Zero) 
                {
                    throw new Win32Exception((int)GetLastError());
                }
                if (ResumeThread(threadHandle) == -1) 
                {
                    CloseHandle(threadHandle);
                    throw new Win32Exception((int)GetLastError());
                }
                CloseHandle(threadHandle); 
            }

        }

    }
}

namespace WinApi
{
    static class User32
    {

        const string USER32 = "user32.dll";

        [DllImport(USER32, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string lclassName, string windowTitle);

        [DllImport(USER32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);

        public enum WindowShowStyle : uint
        {
            /// <summary>Hides the window and activates another window.</summary>
            /// <remarks>See SW_HIDE</remarks>
            Hide = 0,
            /// <summary>Activates and displays a window. If the window is minimized 
            /// or maximized, the system restores it to its original size and 
            /// position. An application should specify this flag when displaying 
            /// the window for the first time.</summary>
            /// <remarks>See SW_SHOWNORMAL</remarks>
            ShowNormal = 1,
            /// <summary>Activates the window and displays it as a minimized window.</summary>
            /// <remarks>See SW_SHOWMINIMIZED</remarks>
            ShowMinimized = 2,
            /// <summary>Activates the window and displays it as a maximized window.</summary>
            /// <remarks>See SW_SHOWMAXIMIZED</remarks>
            ShowMaximized = 3,
            /// <summary>Maximizes the specified window.</summary>
            /// <remarks>See SW_MAXIMIZE</remarks>
            Maximize = 3,
            /// <summary>Displays a window in its most recent size and position. 
            /// This value is similar to "ShowNormal", except the window is not 
            /// actived.</summary>
            /// <remarks>See SW_SHOWNOACTIVATE</remarks>
            ShowNormalNoActivate = 4,
            /// <summary>Activates the window and displays it in its current size 
            /// and position.</summary>
            /// <remarks>See SW_SHOW</remarks>
            Show = 5,
            /// <summary>Minimizes the specified window and activates the next 
            /// top-level window in the Z order.</summary>
            /// <remarks>See SW_MINIMIZE</remarks>
            Minimize = 6,
            /// <summary>Displays the window as a minimized window. This value is 
            /// similar to "ShowMinimized", except the window is not activated.</summary>
            /// <remarks>See SW_SHOWMINNOACTIVE</remarks>
            ShowMinNoActivate = 7,
            /// <summary>Displays the window in its current size and position. This 
            /// value is similar to "Show", except the window is not activated.</summary>
            /// <remarks>See SW_SHOWNA</remarks>
            ShowNoActivate = 8,
            /// <summary>Activates and displays the window. If the window is 
            /// minimized or maximized, the system restores it to its original size 
            /// and position. An application should specify this flag when restoring 
            /// a minimized window.</summary>
            /// <remarks>See SW_RESTORE</remarks>
            Restore = 9,
            /// <summary>Sets the show state based on the SW_ value specified in the 
            /// STARTUPINFO structure passed to the CreateProcess function by the 
            /// program that started the application.</summary>
            /// <remarks>See SW_SHOWDEFAULT</remarks>
            ShowDefault = 10,
            /// <summary>Windows 2000/XP: Minimizes a window, even if the thread 
            /// that owns the window is hung. This flag should only be used when 
            /// minimizing windows from a different thread.</summary>
            /// <remarks>See SW_FORCEMINIMIZE</remarks>
            ForceMinimized = 11
        }

        [DllImport(USER32, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport(USER32, EntryPoint = "SendMessage", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern bool SendMessage(IntPtr hWnd, uint Msg, int wParam, StringBuilder lParam);

        public enum Winevents : uint
        {

            WINEVENT_OUTOFCONTEXT = 0x0000, // Events are ASYNC
            WINEVENT_SKIPOWNTHREAD = 0x0001, // Don't call back for events on installer's thread
            WINEVENT_SKIPOWNPROCESS = 0x0002, // Don't call back for events on installer's process
            WINEVENT_INCONTEXT = 0x0004, // Events are SYNC, this causes your dll to be injected into every process
            EVENT_MIN = 0x00000001,
            EVENT_MAX = 0x7FFFFFFF,
            EVENT_SYSTEM_SOUND = 0x0001,
            EVENT_SYSTEM_ALERT = 0x0002,
            EVENT_SYSTEM_FOREGROUND = 0x0003,
            EVENT_SYSTEM_MENUSTART = 0x0004,
            EVENT_SYSTEM_MENUEND = 0x0005,
            EVENT_SYSTEM_MENUPOPUPSTART = 0x0006,
            EVENT_SYSTEM_MENUPOPUPEND = 0x0007,
            EVENT_SYSTEM_CAPTURESTART = 0x0008,
            EVENT_SYSTEM_CAPTUREEND = 0x0009,
            EVENT_SYSTEM_MOVESIZESTART = 0x000A,
            EVENT_SYSTEM_MOVESIZEEND = 0x000B,
            EVENT_SYSTEM_CONTEXTHELPSTART = 0x000C,
            EVENT_SYSTEM_CONTEXTHELPEND = 0x000D,
            EVENT_SYSTEM_DRAGDROPSTART = 0x000E,
            EVENT_SYSTEM_DRAGDROPEND = 0x000F,
            EVENT_SYSTEM_DIALOGSTART = 0x0010,
            EVENT_SYSTEM_DIALOGEND = 0x0011,
            EVENT_SYSTEM_SCROLLINGSTART = 0x0012,
            EVENT_SYSTEM_SCROLLINGEND = 0x0013,
            EVENT_SYSTEM_SWITCHSTART = 0x0014,
            EVENT_SYSTEM_SWITCHEND = 0x0015,
            EVENT_SYSTEM_MINIMIZESTART = 0x0016,
            EVENT_SYSTEM_MINIMIZEEND = 0x0017,
            EVENT_SYSTEM_DESKTOPSWITCH = 0x0020,
            EVENT_SYSTEM_END = 0x00FF,
            EVENT_OEM_DEFINED_START = 0x0101,
            EVENT_OEM_DEFINED_END = 0x01FF,
            EVENT_UIA_EVENTID_START = 0x4E00,
            EVENT_UIA_EVENTID_END = 0x4EFF,
            EVENT_UIA_PROPID_START = 0x7500,
            EVENT_UIA_PROPID_END = 0x75FF,
            EVENT_CONSOLE_CARET = 0x4001,
            EVENT_CONSOLE_UPDATE_REGION = 0x4002,
            EVENT_CONSOLE_UPDATE_SIMPLE = 0x4003,
            EVENT_CONSOLE_UPDATE_SCROLL = 0x4004,
            EVENT_CONSOLE_LAYOUT = 0x4005,
            EVENT_CONSOLE_START_APPLICATION = 0x4006,
            EVENT_CONSOLE_END_APPLICATION = 0x4007,
            EVENT_CONSOLE_END = 0x40FF,
            EVENT_OBJECT_CREATE = 0x8000, // hwnd ID idChild is created item
            EVENT_OBJECT_DESTROY = 0x8001, // hwnd ID idChild is destroyed item
            EVENT_OBJECT_SHOW = 0x8002, // hwnd ID idChild is shown item
            EVENT_OBJECT_HIDE = 0x8003, // hwnd ID idChild is hidden item
            EVENT_OBJECT_REORDER = 0x8004, // hwnd ID idChild is parent of zordering children
            EVENT_OBJECT_FOCUS = 0x8005, // hwnd ID idChild is focused item
            EVENT_OBJECT_SELECTION = 0x8006, // hwnd ID idChild is selected item (if only one), or idChild is OBJID_WINDOW if complex
            EVENT_OBJECT_SELECTIONADD = 0x8007, // hwnd ID idChild is item added
            EVENT_OBJECT_SELECTIONREMOVE = 0x8008, // hwnd ID idChild is item removed
            EVENT_OBJECT_SELECTIONWITHIN = 0x8009, // hwnd ID idChild is parent of changed selected items
            EVENT_OBJECT_STATECHANGE = 0x800A, // hwnd ID idChild is item w/ state change
            EVENT_OBJECT_LOCATIONCHANGE = 0x800B, // hwnd ID idChild is moved/sized item
            EVENT_OBJECT_NAMECHANGE = 0x800C, // hwnd ID idChild is item w/ name change
            EVENT_OBJECT_DESCRIPTIONCHANGE = 0x800D, // hwnd ID idChild is item w/ desc change
            EVENT_OBJECT_VALUECHANGE = 0x800E, // hwnd ID idChild is item w/ value change
            EVENT_OBJECT_PARENTCHANGE = 0x800F, // hwnd ID idChild is item w/ new parent
            EVENT_OBJECT_HELPCHANGE = 0x8010, // hwnd ID idChild is item w/ help change
            EVENT_OBJECT_DEFACTIONCHANGE = 0x8011, // hwnd ID idChild is item w/ def action change
            EVENT_OBJECT_ACCELERATORCHANGE = 0x8012, // hwnd ID idChild is item w/ keybd accel change
            EVENT_OBJECT_INVOKED = 0x8013, // hwnd ID idChild is item invoked
            EVENT_OBJECT_TEXTSELECTIONCHANGED = 0x8014, // hwnd ID idChild is item w? test selection change
            EVENT_OBJECT_CONTENTSCROLLED = 0x8015,
            EVENT_SYSTEM_ARRANGMENTPREVIEW = 0x8016,
            EVENT_OBJECT_END = 0x80FF,
            EVENT_AIA_START = 0xA000,
            EVENT_AIA_END = 0xAFFF
        }

        public delegate void WINEVENTPROC(
            IntPtr hWinEventHook,
            Winevents dwEvent,
            IntPtr hWnd,
            int idObject,
            int idChild,
            uint dwEventThread,
            uint dwmsEventTime
            );

        [DllImport(USER32, SetLastError = true)]
        public static extern IntPtr SetWinEventHook(
            [In] Winevents eventMin,
            [In] Winevents eventMax,
            [In] IntPtr hmodWinEventProc,
            [MarshalAs(UnmanagedType.FunctionPtr)]
            [In] WINEVENTPROC lpfnWinEventProc,
            [In] int idProcess,
            [In] int idThread,
            [In] Winevents dwflags
            );

        [DllImport(USER32, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWinEvent(
            [In]  IntPtr hWinEventHook
            );
    }
}