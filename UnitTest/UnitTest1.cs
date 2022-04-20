using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Library;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetName()
        {
            string exp = "1";
            TaskList taskList = new TaskList(exp);

            string act = taskList.GetName();
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void GetTask()
        {
            List<Task> exp = null;
            TaskList taskList = new TaskList("1");

            List<Task> act = taskList.GetTasks();
            Assert.AreEqual(exp, act);
        }
    }
}
