using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SendKeysTo
{
    public partial class SendKeysForm : Form
    {
        // mapping from combobox text to actual process
        protected Dictionary<String, Process> processList = new Dictionary<string, Process>();

        public SendKeysForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshProcessList(null, null);
            sendKeysBtn.Click += SendKeysBtnHandler;
            WordWrapOpt.Checked = textArea.WordWrap;
        }

        protected void RefreshProcessList(object sender, EventArgs args)
        {
            Process[] processes = Process.GetProcesses();
            processList.Clear();
            processBox.SelectedIndex = -1;  // clear selection
            processBox.Items.Clear();       // clear items

            foreach (var i in processes)
            {
                try
                {
                    // If the process does not have a window then skip it
                    if (i.MainWindowHandle == IntPtr.Zero)
                    {
                        continue;
                    }
                } 
                catch (Exception)
                {
                    // if window can not be queried for whatever reason skip it
                    Console.WriteLine("WARNING: Could not query MainWindowHandle for process: " + i.ProcessName);
                    continue;
                }

                // The displayed string in the combobox and the key for the dictionary. Hopefully unique enough.
                String key = i.ProcessName + ": " + i.MainWindowTitle;
                processList.Add(key, i);
                processBox.Items.Add(key);
            }
        }

        protected void SendKeysBtnHandler(object sender, EventArgs e)
        {
            if(processBox.SelectedItem == null)
            {
                MessageBox.Show("Select a process from the list.");
            } 
            else
            {
                String selectedItem = (String)processBox.SelectedItem;
                if (!processList.ContainsKey(selectedItem))
                {
                    MessageBox.Show("Cannot find the following in dictionary: " + selectedItem + ", please refresh the list of processes and select it again!");
                }

                Process p = processList[selectedItem];
                // refresh the handle for the top window in selected process
                p.Refresh();
                
                // if it has a window
                if(p.MainWindowHandle != IntPtr.Zero)
                {
                    // Need to set window to be in the foreground to receive keypresses
                    SetForegroundWindow(p.MainWindowHandle);

                    // send text from textArea line by line
                    String[] lines = textArea.Lines;
                    for(int i=0;i<lines.Length;i++)
                    {
                        SendKeys.SendWait(lines[i]);
                        // for every line except the last send a line break
                        // by pressing the enter key
                        if(i < lines.Length-1)
                        {
                            SendKeys.Send("{ENTER}");
                        }
                    }

                    // Restore focus back to this application
                    IntPtr thisWindow = Process.GetCurrentProcess().MainWindowHandle;
                    if(thisWindow != IntPtr.Zero)
                    {
                        SetForegroundWindow(thisWindow);
                    }
                }
            }
        }

        [DllImport("User32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        protected void RefreshProcListOpt_Click(object sender, EventArgs e)
        {
            RefreshProcessList(null, null);
        }

        private void WordWrapOpt_Click(object sender, EventArgs e)
        {
            bool ww = textArea.WordWrap;
            textArea.WordWrap = !ww;
            WordWrapOpt.Checked = !ww;
        }
    }
}
