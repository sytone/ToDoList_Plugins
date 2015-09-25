using System;
using TDLPluginHelpers;

namespace SampleTaskListStorage
{
    public class SampleTaskListStorageCore
    {
        public bool Export(TDLTaskList srcTasks, string sDestFilePath, bool bSilent, TDLPreferences prefs, string sKey)
        {
            int nVal = prefs.GetProfileInt("bob", "dave", 20);
            int nVal2 = prefs.GetProfileInt("bob", "phil", 20);

            // add some dummy values to prefs
            prefs.WriteProfileInt("bob", "dave", 10);

            TDLTask task = srcTasks.GetFirstTask();

            String sTitle = task.GetTitle();


            return true;
        }
    }
}
