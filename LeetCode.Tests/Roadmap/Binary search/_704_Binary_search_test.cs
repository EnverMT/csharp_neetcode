using Leetcode.Roadmap.Binary_Search._704_Binary_search;

namespace Leetcode.Tests.Roadmap.Binary_search
{
    public class _704_Binary_search_test
    {
        [Fact]
        public void _704_Binary_search_testSearch()
        {
            Solution solution = new Solution();

            Assert.Equal(4, solution.Search([-1, 0, 3, 5, 9, 12], 9));
            Assert.Equal(-1, solution.Search([-1, 0, 3, 5, 9, 12], 2));
        }
    }
}
