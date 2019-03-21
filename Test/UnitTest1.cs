using MM.Engine;
using Serilog;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Test
{
    /// <summary>
    /// ��Ԫ����
    /// </summary>
    public class UnitTest1
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="output">���</param>
        public UnitTest1(ITestOutputHelper output)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.TestOutput(output, Serilog.Events.LogEventLevel.Verbose)
                .CreateLogger();
        }

        [Fact]
        public void Test1()
        {
            var Indexer = new Indexer();
            var py = Indexer.PY();
            var ret = py.RunFile(Cache.runPath + "test.py", "fun", "param1", "param2", "param3");
            if (ret != null)
            {
                Log.Debug(ret.ToString());
            }
            else
            {
                Log.Debug($"û�л�ȡ������");
            }
            Assert.False(false);
        }
    }
}
