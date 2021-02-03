namespace DotNet.Extensions.Tests
{
    class PagedTestCases
    {
        internal static int[] DataSource = { 1, 2, 3, 4, 5, 6, 7, 8};

        internal static object[] Paged =
        {
            new object[] { DataSource, 1, 10, DataSource },
            new object[] { DataSource, 1, 3, new int[] { 1, 2, 3 } },
            new object[] { DataSource, 2, 3, new int[] { 4, 5, 6 } },
            new object[] { DataSource, 3, 3, new int[] { 7, 8 } },
            new object[] { DataSource, 4, 3, System.Array.Empty<int>() },
        };
    }
}