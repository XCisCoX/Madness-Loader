using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madness_Loader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress,
            uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess,
            IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
        static bool is64BitProcess = (IntPtr.Size == 8);
        static bool is64BitOperatingSystem = is64BitProcess || CheckIsWow64();

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process(
            [In] IntPtr hProcess,
            [Out] out bool wow64Process
        );

        public static bool CheckIsWow64()
        {
            if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) ||
                Environment.OSVersion.Version.Major >= 6)
            {
                using (Process p = Process.GetCurrentProcess())
                {
                    bool retVal;
                    if (!IsWow64Process(p.Handle, out retVal))
                    {
                        return false;
                    }
                    return retVal;
                }
            }
            else
            {
                return false;
            }
        }
        const int PROCESS_CREATE_THREAD = 0x0002;
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_READ = 0x0010;
        const uint MEM_COMMIT = 0x00001000;
        const uint MEM_RESERVE = 0x00002000;
        const uint PAGE_READWRITE = 4;

        delegate void SetTextCallback(string text);
        private void logadd(string text)
        {
            if (txtLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(logadd);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                txtLog.Text += DateTime.Now.ToShortTimeString() + ":" + text + "\r\n";
            }

        }

        private static string GetHexString(byte[] bt)
        {
            string text = string.Empty;
            for (int i = 0; i < bt.Length; i++)
            {
                byte expr_10 = bt[i];
                int num = (int)(expr_10 & 15);
                int num2 = expr_10 >> 4 & 15;
                if (num2 > 9)
                {
                    text += ((char)(num2 - 10 + 65)).ToString();
                }
                else
                {
                    text += num2.ToString();
                }
                if (num > 9)
                {
                    text += ((char)(num - 10 + 65)).ToString();
                }
                else
                {
                    text += num.ToString();
                }
                if (i + 1 != bt.Length && (i + 1) % 2 == 0)
                {
                    // text += "-";
                }
            }
            return text;
        }

        private static string GetHash(byte[] s)
        {
            HashAlgorithm arg_12_0 = new MD5CryptoServiceProvider();
            byte[] bytes = s;
            return GetHexString(arg_12_0.ComputeHash(bytes));
        }

        void injection()
        {
            bool IsInjected = false;
            logadd("[+]Initalizing...");
            Process hl = new Process();
            hl.StartInfo.Arguments = "-game cstrike";
            hl.StartInfo.FileName = txtPath.Text;
            Process[] hl2 = Process.GetProcessesByName("hl");
            if (hl2.Length != 0)
            {
                logadd("[+]Counter Strike Already Opened!");
                return;
            }
            if(!File.Exists(txtPath.Text))
            {
                logadd("[+]Problem To Open Counter Strike[Check Counter Path]");
                return;
            }
            hl.Start();
            logadd("[+]Creating Process");

            IntPtr procHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, hl.Id);

            logadd("[+]Detecting Handle");
            IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            logadd("[+]Getting Load dll");
            string[] dllName ={ "ABS.dll" ,"fix.dll"};
            if (!File.Exists(dllName[0])&& !File.Exists(dllName[1]))
            {

                logadd("[+]Dll Not Found!");
                hl.Kill();
                return;
            }
            IntPtr allocMemAddress = VirtualAllocEx(procHandle, IntPtr.Zero, (uint)((dllName[0].Length + 1) * Marshal.SizeOf(typeof(char))), MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);
            IntPtr allocMemAddress2 = VirtualAllocEx(procHandle, IntPtr.Zero, (uint)((dllName[1].Length + 1) * Marshal.SizeOf(typeof(char))), MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

            logadd("[+]Virtualing Memory Address");
            // writing the name of the dll there
            UIntPtr bytesWritten;
            WriteProcessMemory(procHandle, allocMemAddress, Encoding.Default.GetBytes(dllName[0]), (uint)((dllName[0].Length + 1) * Marshal.SizeOf(typeof(char))), out bytesWritten);
            WriteProcessMemory(procHandle, allocMemAddress, Encoding.Default.GetBytes(dllName[1]), (uint)((dllName[1].Length + 1) * Marshal.SizeOf(typeof(char))), out bytesWritten);

            logadd("[+]Writing Into Process");
            // creating a thread that will call LoadLibraryA with allocMemAddress as argument
            CreateRemoteThread(procHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);
            CreateRemoteThread(procHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress2, 0, IntPtr.Zero);
            Thread.Sleep(1000);
            logadd("[+]Creating Remote...");
            Thread.Sleep(1000);
            try
            {
                for (int i = 0; i < hl.Modules.Count; i++)
                {
                    if (hl.Modules[i].FileName.ToLower().Contains(@"ABS.dll")|| hl.Modules[i].FileName.ToLower().Contains(@"fix.dll"))
                    {
                        logadd(string.Format("[++]INFO DLL:\r\n_________________________________________\r\n[+]Module:")
                            + hl.Modules[i].ModuleName +
                     "\r\n[+]Address:" + hl.Modules[i].BaseAddress + "\r\n[+]MemorySize:" +
                      hl.Modules[i].ModuleMemorySize + "\r\n[+]Full Path:" + hl.Modules[i].FileVersionInfo.FileName
                      + "\r\n[+]HashCode:" + GetHash(File.ReadAllBytes(hl.Modules[i].FileName.ToString())) + "\r\n_________________________________________");

                        IsInjected = true;

                    }
                }
            }
            catch
            {
                logadd("[+]Problem To Injection Memory!");
                return;
            }
            if (IsInjected == false)
            {
                logadd("[+]Problem To Injection Memory!");
                return;
            }
            logadd("[+]Handles:" + hl.HandleCount);
            Thread.Sleep(1000);
            logadd("[+]Affinty:" + hl.ProcessorAffinity.ToString());
            Thread.Sleep(1000);
            logadd("[+]Threads:" + hl.Threads.Count.ToString());

            Process[] hl3 = Process.GetProcessesByName("hl");

            hl.PriorityBoostEnabled = true;
            hl.PriorityClass = ProcessPriorityClass.High;
            logadd("[+]VM Size:" + (CheckIsWow64() ? hl.VirtualMemorySize64 : hl.VirtualMemorySize));

            logadd("[+]Main Counter Info: "+hl.MainModule.FileVersionInfo.CompanyName) ;
            logadd("[+]Title:" + hl3[0].MainWindowTitle);

            logadd("[+]Injected Seccussfully!");
           
            return;
        }
        bool IsPath(string path)
        {
            bool existsAndIsDirectory = (Directory.Exists(path) && File.Exists(path)) ? false : true;
            return existsAndIsDirectory;
        }


        private void lblBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.FileName = "hl.exe";
            op.Filter = "Counter Strike |hl.exe";
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = op.FileName;
                File.WriteAllText("hl.ini", op.FileName);
            }
        }

        private void btnInject_Click(object sender, EventArgs e)
        {     
                txtLog.Clear();
                string curPath = Path.GetFullPath("Madness.dll");
                Thread tr = new Thread(new ThreadStart(injection));
                tr.Start();               
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists("hl.ini"))
            {
                if (IsPath(File.ReadAllText("hl.ini")))
                {
                    txtPath.Text = File.ReadAllText("hl.ini");
                    timer1.Enabled = false;
                }
            }
        }

        private void nyX_Button1_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.ScrollToCaret();
        }
    }
}
